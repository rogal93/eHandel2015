using eHandel2015.Repository.Abstract.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHandel2015.Repository.DTO.Demo;

namespace eHandel2015.Repository.Concrete.Demo
{
    public  class Demo : Model,IDemo
    {

        public IEnumerable<Repository.Demo> DemoAction()
        {
            var model = Entities.Demo;
            
            return model;
        }
    }
}
