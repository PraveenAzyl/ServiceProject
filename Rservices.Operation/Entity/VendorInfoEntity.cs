using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rservices.Operation.Entity
{
   public class VendorInfoEntity
    {
        public string VendorName { get; set; }
        public string VendorContactNo { get; set; }
        public string VendorEmailID { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string PermanentAddress { get; set; }
        public string LocalAddress { get; set; }
        public string LocationIDPKFK { get; set; }
	    public string AdhaarNo { get; set; }
        public string PanCardNo { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string IsActive { get; set; }
        public string IsDisabled { get; set; }
        public string VendorId { get; set; }
    }
}
