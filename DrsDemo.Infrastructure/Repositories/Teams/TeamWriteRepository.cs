using DrsDemo.Domain.Teams;
using DrsDemo.Domain.UnitOfWorks;
using DrsDemo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories.Teams
{
    public class TeamWriteRepository : WriteBaseRepository<Team, Guid>, ITeamWriteRepository
    {
        public TeamWriteRepository(DrsDemoWriteDbContext writeDbContext, IUnitOfWork uOw) : base(writeDbContext, uOw)
        {
        }
    }
}
