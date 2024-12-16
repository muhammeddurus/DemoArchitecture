using DrsDemo.Domain.Groups;
using DrsDemo.Domain.UnitOfWorks;
using DrsDemo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories.Groups
{
    public class GroupWriteRepository : WriteBaseRepository<Group, Guid>, IGroupWriteRepository
    {
        public GroupWriteRepository(DrsDemoWriteDbContext writeDbContext, IUnitOfWork uOw) : base(writeDbContext, uOw)
        {
        }
    }
}
