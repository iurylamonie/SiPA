using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiPA.Modelo
{
    public class ItemCompra
    {
        public static void Incluir(SiPA.ItemCompra itemCompra)
        {
            BancoDataContext dc = new BancoDataContext();
            dc.ItemCompras.InsertOnSubmit(itemCompra);
            dc.SubmitChanges();
        }

        public static List<SiPA.ItemCompra> Listar(int id)
        {
            BancoDataContext dc = new BancoDataContext();
            List<SiPA.ItemCompra> ic = (from it in dc.ItemCompras
                                        where it.compra_id == id
                                        select it).ToList();
            return ic;
        }

        public static void Excluir(int id)
        {
            try
            {
                BancoDataContext dc = new BancoDataContext();
                List<SiPA.ItemCompra> ic = (from i in dc.ItemCompras where i.compra_id == id select i).ToList();
                dc.ItemCompras.DeleteAllOnSubmit(ic);
                dc.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static void Remover(int id)
        {
            BancoDataContext dc = new BancoDataContext();
            SiPA.ItemCompra ic = (from i in dc.ItemCompras where i.id == id select i).Single();
            dc.ItemCompras.DeleteOnSubmit(ic);
            dc.SubmitChanges();
        }
    }
}