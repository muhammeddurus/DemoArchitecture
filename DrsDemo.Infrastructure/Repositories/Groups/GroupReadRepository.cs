using DrsDemo.Domain.Groups;
using DrsDemo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories.Groups
{
    public class GroupReadRepository : ReadBaseRepository<Group, Guid>, IGroupReadRepository
    {
        public GroupReadRepository(DrsDemoReadDbContext readDbContext) : base(readDbContext)
        {
        }
    }
}
