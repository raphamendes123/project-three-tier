using Api.DTOs;
using Business.Models;

namespace Api
{
    public static class ProdutoExtension
    {
        public static Produto ToEntity(this ProdutoDTO produto)
        {
            return new Produto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Ativo = produto.Ativo,
                DataCadastro = produto.DataCadastro,    
                Descricao = produto.Descricao,
                Valor = produto.Valor,
                FornecedorId = produto.FornecedorId,
            };
        }

        public static ProdutoDTO ToDTO(this Produto produto)
        {
            return new ProdutoDTO
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Ativo = produto.Ativo,
                DataCadastro = produto.DataCadastro,
                Descricao = produto.Descricao,
                Valor = produto.Valor,
                FornecedorId = produto.FornecedorId, 
            };
        }

        public static IEnumerable<ProdutoDTO> ToDTO(this IEnumerable<Produto> produtos)
        {
            if (produtos == null)
            {
               return null;
            }

            List<ProdutoDTO> list = new List<ProdutoDTO>();

            foreach (var produto in produtos)
            {
                list.Add(produto.ToDTO());
            }
            return list;
        }

        public static IEnumerable<Produto> ToEntity(this IEnumerable<ProdutoDTO> produtos)
        {
            List<Produto> list = new List<Produto>();

            foreach (var produto in produtos)
            {
                list.Add(produto.ToEntity());
            }
            return list;
        }
    }
}
