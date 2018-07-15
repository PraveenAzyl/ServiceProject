using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rservices.Operation.Entity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace Rservices.Operation.DalaLayer
{
    public enum Enum_DAL_ManageVendorDetails
    {
        add, update, delete, getall
    }
    public interface IDAL_ManageVendorDetails : IDisposable
    {
        void SaveVendor();
    }

    internal class DAL_ManageVendorDetails : IDAL_ManageVendorDetails
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void SaveVendor()
        {


        }
        
        private void Manage_Admin_DAL_ManageVendorDetails(Enum_DAL_ManageVendorDetails dbAction, VendorInfoEntity entity)
        {
            try
            {

                object ActionBy = System.DBNull.Value;
                object Action = System.DBNull.Value;
                object StatusCode = System.DBNull.Value;
                object ErrorMsg = System.DBNull.Value;
                object Result = System.DBNull.Value;
                object ClinicName = System.DBNull.Value;
                object BrandName = System.DBNull.Value;
                object LocationName = System.DBNull.Value;
                object PinCode = System.DBNull.Value;
                object LabAddress = System.DBNull.Value;
                object OtherContactNo = System.DBNull.Value;
                object PrimaryEmailID = System.DBNull.Value;
                object RecordIDPK = System.DBNull.Value;

                switch (dbAction)
                {
                    case Enum_DAL_ManageVendorDetails.getall:
                        break;

                    //case Enum_DAL_ManageVendorDetails.add:
                    //    ClinicName = entity.ClinicName;
                    //    BrandName = entity.BrandName;
                    //    LocationName = entity.LocationName;
                    //    PinCode = entity.PinCode;
                    //    LabAddress = entity.LabAddress;
                    //    OtherContactNo = entity.OtherContactNo;
                    //    PrimaryEmailID = entity.PrimaryEmailID;
                    //    RecordIDPK = entity.RecordIDPK;
                    //    break;
                    //case EnumManage_ClinicReqForApproval.Delete:
                    //    RecordIDPK = entity.RecordIDPK;
                    //    break;

                    default:
                        break;

                }
                Action = dbAction.ToString();
                Database db = DatabaseFactory.CreateDatabase(CommonDBUtility.DBConnectionString);
                DbCommand dbCommand = db.GetStoredProcCommand(DatabaseSchemaService.MyProperty);
                db.AddInParameter(dbCommand, "@Action", DbType.String, Action);
                db.AddInParameter(dbCommand, "@ClinicName", DbType.String, ClinicName);
                db.AddInParameter(dbCommand, "@BrandName", DbType.String, BrandName);
                db.AddInParameter(dbCommand, "@LocationName", DbType.String, LocationName);
                db.AddInParameter(dbCommand, "@PinCode", DbType.String, PinCode);
                db.AddInParameter(dbCommand, "@LabAddress", DbType.String, LabAddress);
                db.AddInParameter(dbCommand, "@OtherContactNo", DbType.String, OtherContactNo);

            }
            catch (SqlException SqlEx)
            {
                throw new Exception(SqlEx.Message);
            }

            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }


        }


    }

}