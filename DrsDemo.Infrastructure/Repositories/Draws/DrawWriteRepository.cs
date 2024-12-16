using DrsDemo.Domain.Draws;
using DrsDemo.Domain.UnitOfWorks;
using DrsDemo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories.Draws
{
    public class DrawWriteRepository : WriteBaseRepository<Draw, Guid>, IDrawWriteRepository
    {
        public DrawWriteRepository(DrsDemoWriteDbContext writeDbContext, IUnitOfWork uOw) : base(writeDbContext, uOw)
        {
        }
    }
}
