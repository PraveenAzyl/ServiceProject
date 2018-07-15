using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rservices.Operation.BusinessLogic
{
   
   public class RServiceFactory
    {
        public void Dispose()
        {
           // throw new NotImplementedException();
        }

        

        public IManage_VendorDetail VendorOperation()        
        {
            return new BAL_ManageVendorDetails();

        }
    }
}
