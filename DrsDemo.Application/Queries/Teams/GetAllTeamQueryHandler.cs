using AutoMapper;
using DrsDemo.Domain.Teams;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Queries.Teams
{
    public class GetAllTeamQueryHandler : IRequestHandler<GetAllTeamQuery, List<TeamDto>>
    {
        private readonly ITeamReadRepository _teamReadRepository;
        private readonly IMapper _mapper;

        public GetAllTeamQueryHandler(ITeamReadRepository teamReadRepository, IMapper mapper)
        {
            _teamReadRepository = teamReadRepository;
            _mapper = mapper;
        }

        public async Task<List<TeamDto>> Handle(GetAllTeamQuery request, CancellationToken cancellationToken)
        {
            var result = await _teamReadRepository.GetAllAsync();
            return _mapper.Map<List<Team>, List<TeamDto>>(result);
        }
    }
}
