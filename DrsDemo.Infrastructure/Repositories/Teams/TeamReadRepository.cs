using DrsDemo.Domain.Common;
using DrsDemo.Domain.Teams;
using DrsDemo.Infrastructure.Context;
using DrsDemo.Infrastructure.Helper.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories.Teams
{
    public class TeamReadRepository : ReadBaseRepository<Team, Guid>, ITeamReadRepository
    {
        public TeamReadRepository(DrsDemoReadDbContext readDbContext) : base(readDbContext)
        {
        }
    }
}
