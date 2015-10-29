using eHandel2015.Repository.DTO.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel2015.Repository.Abstract.Demo
{
    public interface IDemo : IModel
    {
        IEnumerable<Repository.Demo> DemoAction();
    }
}
