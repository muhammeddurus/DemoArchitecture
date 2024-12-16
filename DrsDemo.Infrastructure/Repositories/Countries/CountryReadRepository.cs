using DrsDemo.Domain.Countries;
using DrsDemo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories.Countries
{
    public class CountryReadRepository : ReadBaseRepository<Country, Guid>, ICountryReadRepository
    {
        public CountryReadRepository(DrsDemoReadDbContext readDbContext) : base(readDbContext)
        {
        }
    }
}
