using eHandel2015.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel2015.Repository.Concrete
{
   public class Model : IModel
    {
       private HandelDBContext _context;
       public HandelDBContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new HandelDBContext();
                }
                return _context;
            }
        }


        public HandelElektronicznyDBEntities Entities 
        {
            get { return Context.GetShopEntities(); }
        }
    }
}
