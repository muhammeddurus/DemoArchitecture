using DrsDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Domain.Countries
{
    public class Country : EntityBase<Guid>
    {
        public Country()
        {

        }
        public Country(string name)
        {
            Name = name;
        }
        public required string Name { get; set; }
    }
}
