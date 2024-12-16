using AutoMapper;
using DrsDemo.Domain.Countries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Commands.Countries.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountry, UpdateCountryResponse>
    {
        private readonly ICountryWriteRepository _countryWriteRepository;
        private readonly IMapper _mapper;

        public UpdateCountryCommandHandler(ICountryWriteRepository countryWriteRepository)
        {
            _countryWriteRepository = countryWriteRepository;
        }

        Task<UpdateCountryResponse> IRequestHandler<UpdateCountry, UpdateCountryResponse>.Handle(UpdateCountry request, CancellationToken cancellationToken)
        {
            _countryWriteRepository.UpdateAsync(_mapper.Map<UpdateCountry,Country>(request));

            return Task.FromResult(new UpdateCountryResponse
            {
                Code = (int)HttpStatusCode.OK,
                Description = "Başarılı"
            });
        }
    }
}
