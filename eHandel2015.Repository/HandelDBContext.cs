using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel2015.Repository
{
    public class HandelDBContext: IDisposable
    {
        private HandelElektronicznyDBEntities _ShopEntities;

        public HandelDBContext()
        {
            _ShopEntities = new HandelElektronicznyDBEntities();
        }


        public HandelElektronicznyDBEntities GetShopEntities()
        {
            return _ShopEntities;
        }


        public void Dispose()
        {
            if (_ShopEntities == null) return;
            _ShopEntities.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
