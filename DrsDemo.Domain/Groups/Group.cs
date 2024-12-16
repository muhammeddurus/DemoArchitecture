using DrsDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Domain.Groups
{
    public class Group : EntityBase<Guid>
    {
        public string Name { get; set; }
    }
}
