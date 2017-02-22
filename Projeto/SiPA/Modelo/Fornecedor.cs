using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SiPA.Modelo
{
    public class Fornecedor
    {
        public static void Incluir(SiPA.Fornecedor fornecedor)
        {
            BancoDataContext dataContext = new BancoDataContext();
            dataContext.Fornecedors.InsertOnSubmit(fornecedor);
            dataContext.SubmitChanges();
        }

        public static void Alterar(SiPA.Fornecedor fornecedor)
        {
            BancoDataContext dataContext = new BancoDataContext();
            var r = (from p in dataContext.Fornecedors
                     where p.id == fornecedor.id
                     select p).Single();

            r.nome = fornecedor.nome;
            r.telefone = fornecedor.telefone;
            r.cidade = fornecedor.cidade;
            r.estado = fornecedor.estado;
            r.endereco = fornecedor.endereco;
            r.cpf = fornecedor.cpf;
            r.cnpj = fornecedor.cnpj;
            r.opCPForCNPJ = fornecedor.opCPForCNPJ;
            r.email = fornecedor.email;


            dataContext.SubmitChanges();
        }

        public static void Excluir(int id)
        {
            BancoDataContext dataContext = new BancoDataContext();
            var r = (from p in dataContext.Fornecedors
                     where p.id == id
                     select p).Single();
            dataContext.Fornecedors.DeleteOnSubmit(r);
            dataContext.SubmitChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<SiPA.Fornecedor> Lista()
        {
            BancoDataContext dataContext = new BancoDataContext();
            var r = from p in dataContext.Fornecedors select p;
            return r.ToList();
        }

        public static SiPA.Fornecedor CosultarPorId(int id)
        {
            BancoDataContext dataContext = new BancoDataContext();
            var r = (from p in dataContext.Fornecedors where p.id == id select p).Single();
            return r;
        }
    }
}