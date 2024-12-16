using DrsDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Domain.Countries
{
    public interface ICountryWriteRepository : IWriteBaseRepository<Country,Guid>
    {
    }
}
