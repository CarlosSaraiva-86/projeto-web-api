using System;
using System.Collections.Generic;
using System.Text;
using Web.Api.Core;

namespace Web.Api.Domain
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
    }
}
