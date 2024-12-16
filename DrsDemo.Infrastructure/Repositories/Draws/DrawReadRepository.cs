using DrsDemo.Domain.Draws;
using DrsDemo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories.Draws
{
    public class DrawReadRepository : ReadBaseRepository<Draw, Guid>, IDrawReadRepository
    {
        public DrawReadRepository(DrsDemoReadDbContext readDbContext) : base(readDbContext)
        {
        }
    }
}
