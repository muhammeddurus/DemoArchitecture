using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Queries.Countries
{
    public class CountryAllQueryHandler : IRequestHandler<CountryAllQuery, List<CountryDto>>
    {
        public async Task<List<CountryDto>> Handle(CountryAllQuery request, CancellationToken cancellationToken)
        {
            return new List<CountryDto>();
        }
    }
}
