using Api.DTOs;
using Business.Models;

namespace Api
{
    public static class EnderecoExtension
    { 
        public static Endereco ToEntity(this EnderecoDTO endereco)
        { 
            return new Endereco 
            {
                Id = endereco.Id,
                FornecedorId = endereco.FornecedorId,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Complemento = endereco.Complemento,
                Cep = endereco.Cep,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Estado = endereco.Estado

            };
        }

        public static EnderecoDTO ToDTO(this Endereco endereco)
        {
            if(endereco == null)
            { 
                return null;
            }

            return new EnderecoDTO
            {
                Id = endereco.Id,
                FornecedorId = endereco.FornecedorId,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Complemento = endereco.Complemento,
                Cep = endereco.Cep,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Estado = endereco.Estado

            };
        } 
    }
}
