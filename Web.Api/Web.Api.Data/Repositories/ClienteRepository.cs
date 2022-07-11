using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Data;
using Web.Api.Core.Data.Interfaces;
using Web.Api.Domain;
using Web.Api.Domain.Interfaces;

namespace Web.Api.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
