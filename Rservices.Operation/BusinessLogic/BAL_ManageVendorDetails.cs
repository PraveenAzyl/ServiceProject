using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rservices.Operation.DalaLayer;
namespace Rservices.Operation.BusinessLogic
{

    public interface IManage_VendorDetail : IDisposable
    {
        void SaveVendor();
    }
    internal class BAL_ManageVendorDetails:IManage_VendorDetail
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void SaveVendor()
        {
            using (var objsave = new DAL_ManageVendorDetails())
            {

            }
        }
    }
}
