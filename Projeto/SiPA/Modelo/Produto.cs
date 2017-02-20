using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SiPA.Modelo
{
    public class Produto
    {
        public static void Incluir(SiPA.Produto produto)
        {
            BancoDataContext dataContext = new BancoDataContext();
            dataContext.Produtos.InsertOnSubmit(produto);
            dataContext.SubmitChanges();
        }

        public static void Alterar(SiPA.Produto produto)
        {
            BancoDataContext dataContext = new BancoDataContext();
            var r = (from p in dataContext.Produtos
                     where p.id == produto.id
                     select p).Single();
            r.descricao = produto.descricao;
            dataContext.SubmitChanges();
        }

        public static void Excluir(int id)
        {
            BancoDataContext dataContext = new BancoDataContext();
            var r = (from p in dataContext.Produtos
                     where p.id == id
                     select p).Single();
            dataContext.Produtos.DeleteOnSubmit(r);
            dataContext.SubmitChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<SiPA.Produto> Lista()
        {
            BancoDataContext dataContext = new BancoDataContext();
            var r = from p in dataContext.Produtos select p;
            return r.ToList();
        }
    }
}