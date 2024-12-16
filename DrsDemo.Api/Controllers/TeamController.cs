using DrsDemo.Application.Queries.Teams;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DrsDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public TeamController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public Task<List<TeamDto>> GetAllAsync()
        {
            return _mediatr.Send(new GetAllTeamQuery());
        }
    }
}
