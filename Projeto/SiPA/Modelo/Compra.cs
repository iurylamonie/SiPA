using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SiPA.Modelo
{
    public class Compra
    {
        public static void Incluir(SiPA.Compra compra)
        {
            BancoDataContext dc = new BancoDataContext();
            dc.Compras.InsertOnSubmit(compra);
            dc.SubmitChanges();
        }

        public static void Alterar(SiPA.Compra compra)
        {
            BancoDataContext dc = new BancoDataContext();
            SiPA.Compra r = (from c in dc.Compras
                             where c.id == compra.id
                             select c).Single();
            r = compra;
            dc.SubmitChanges();
        }

        public static void Excluir(int id)
        {
            BancoDataContext dc = new BancoDataContext();
            SiPA.Compra compra = (from c in dc.Compras where c.id == id select c).Single();
            dc.Compras.DeleteOnSubmit(compra);
            dc.SubmitChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<SiPA.Compra> Listar()
        {
            BancoDataContext dc = new BancoDataContext();
            List<SiPA.Compra> compras = (from com in dc.Compras select com).ToList();
            return compras;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<SiPA.Compra> Filtro(string fornecedor, DateTime periodo)
        {
            BancoDataContext dc = new BancoDataContext();
            List<SiPA.Compra> compras = (from com in dc.Compras
                                         where com.Fornecedor.nome == fornecedor && com.dataCompra == periodo
                                         select com).ToList();
            return compras;
        }
    }
}