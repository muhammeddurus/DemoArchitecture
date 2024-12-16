using DrsDemo.Application.Queries.Countries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DrsDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public CountryController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public Task<List<CountryDto>> GetAllAsync()
        {
            return _mediatr.Send(new CountryAllQuery());
        }
    }
}
