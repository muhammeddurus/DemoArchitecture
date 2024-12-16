using DrsDemo.Domain.Common;
using DrsDemo.Domain.Countries;
using DrsDemo.Domain.UnitOfWorks;
using DrsDemo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories.Countries
{
    public class CountryWriteRepository : WriteBaseRepository<Country, Guid>, ICountryWriteRepository
    {
        public CountryWriteRepository(DrsDemoWriteDbContext writeDbContext, IUnitOfWork uOw) : base(writeDbContext, uOw)
        {
        }
    }
}
