using DrsDemo.Domain.Countries;
using DrsDemo.Domain.Draws;
using DrsDemo.Domain.Groups;
using DrsDemo.Domain.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Domain.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
