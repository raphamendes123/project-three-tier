using Api.DTOs;
using Business.Models;

namespace Api
{
    public static class FornecedorExtension
    {
        public static Fornecedor ToEntity(this FornecedorDTO fornecedor)
        {
            return new Fornecedor
            {
                Id = fornecedor.Id,
                Ativo = fornecedor.Ativo,
                Documento = fornecedor.Documento,
                Endereco = fornecedor.Endereco.ToEntity(),
                Nome = fornecedor.Nome,
                TipoFornecedor = (TipoFornecedor)fornecedor.TipoFornecedor,
                Produtos = fornecedor.Produtos.ToEntity()
            };
        }

        public static FornecedorDTO ToDTO(this Fornecedor fornecedor)
        {
            return new FornecedorDTO
            {
                Id = fornecedor.Id,
                Ativo = fornecedor.Ativo,
                Documento = fornecedor.Documento,
                Endereco = fornecedor.Endereco.ToDTO(),
                Nome = fornecedor.Nome,
                TipoFornecedor = (int)fornecedor.TipoFornecedor,
                Produtos = fornecedor.Produtos.ToDTO()
            };
        }

        public static IEnumerable<FornecedorDTO> ToDTO(this IEnumerable<Fornecedor> fornecedores)
        {
            List<FornecedorDTO> list = new List<FornecedorDTO>();

            foreach (var fornecedor in fornecedores)
            {
                list.Add(fornecedor.ToDTO());
            }
            return list;
        }
    }
}
