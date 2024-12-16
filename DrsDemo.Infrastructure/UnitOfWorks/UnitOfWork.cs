using DrsDemo.Domain.Countries;
using DrsDemo.Domain.Draws;
using DrsDemo.Domain.Groups;
using DrsDemo.Domain.Teams;
using DrsDemo.Domain.UnitOfWorks;
using DrsDemo.Infrastructure.Context;
using DrsDemo.Infrastructure.Repositories.Countries;
using DrsDemo.Infrastructure.Repositories.Draws;
using DrsDemo.Infrastructure.Repositories.Groups;
using DrsDemo.Infrastructure.Repositories.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DrsDemoWriteDbContext _writeDbContext;

        public UnitOfWork(DrsDemoWriteDbContext writeDbContext)
        {
            _writeDbContext = writeDbContext;
        }

        public void Commit()
        {
            _writeDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _writeDbContext.SaveChangesAsync();
        }
    }
}
