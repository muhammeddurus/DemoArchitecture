using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Common.HelperModels
{
    public interface IStatuResponse
    {
        public int Code { get; set; }
        public string Description { get; set; }
    }
}
