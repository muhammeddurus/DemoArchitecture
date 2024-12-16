using AutoMapper;
using DrsDemo.Domain.Countries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Commands.Countries.CreateCountry
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountry, CreateCountryResponse>
    {
        private readonly ICountryWriteRepository _countryWriteRepository;
        private readonly IMapper _mapper;

        public CreateCountryCommandHandler(ICountryWriteRepository countryWriteRepository, IMapper mapper)
        {
            _countryWriteRepository = countryWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateCountryResponse> Handle(CreateCountry request, CancellationToken cancellationToken)
        {
            var res = await _countryWriteRepository.InsertAsync(_mapper.Map<CreateCountry, Country>(request));
            return new CreateCountryResponse
            {
                Id = res,
                Code = (int)HttpStatusCode.OK,
                Description = "Başarılı"
            };
        }
    }
}
