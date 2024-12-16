using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Commands.Countries.CreateCountry
{
    public class CreateCountry : IRequest<CreateCountryResponse>
    {
        public string Name { get; set; }
    }
}
