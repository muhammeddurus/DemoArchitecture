using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Queries.Teams
{
    public class GetAllTeamQuery : IRequest<List<TeamDto>>
    {

    }
}
