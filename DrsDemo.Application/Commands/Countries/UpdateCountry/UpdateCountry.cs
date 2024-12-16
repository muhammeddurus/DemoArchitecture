using MediatR;

namespace DrsDemo.Application.Commands.Countries.UpdateCountry
{
    internal class UpdateCountry : IRequest<UpdateCountryResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
