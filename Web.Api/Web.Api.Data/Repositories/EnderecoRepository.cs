using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Api.Core.Data;
using Web.Api.Domain;

namespace Web.Api.Data.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>
    {
        public EnderecoRepository(ApplicationContext context) : base(context)
        {
        }

        
    }
}
