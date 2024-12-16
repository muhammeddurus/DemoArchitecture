using DrsDemo.Application.Common.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Commands.Countries.CreateCountry
{
    public class CreateCountryResponse : IStatuResponse
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
    }
}
