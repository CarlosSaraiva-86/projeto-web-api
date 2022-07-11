using System;
using System.Collections.Generic;
using System.Text;
using Web.Api.Core;

namespace Web.Api.Domain
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public Guid EnderecoId { get; set; }
    }
}
