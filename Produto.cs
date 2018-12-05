using System;

namespace Magrao.CanaWeb.Infra.Data.Controllers.Entitys
{
    public class Produto
    {
        public int ID;
        public string Nome;
        public string Descricao;
        public decimal Preco;
        public bool Ativo;
    
        public Produto(int iD, string nome, string descricao, decimal preco, bool ativo)
        {
            ID = iD;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Ativo = ativo;
        }
    }
}