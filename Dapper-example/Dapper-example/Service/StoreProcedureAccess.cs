using Dapper;
using Dapper_example.Repository;
using Dapper_example.Repository.Helper;
using Microsoft.Data.SqlClient;
using System.Collections;

namespace Dapper_example.Service
{
    public class StoreProcedureAccess : IStoreProcedureAccess
    {
      
        private static string ConnectionString = "";

        public StoreProcedureAccess(IConfiguration db)
        {
            ConnectionString = db.GetConnectionString("DefaultConnection");
            
        }
        public IEnumerable<T>? DataListMax20<T>(SPParameters parm)
        {
            try
            {
                ErrorTracking.ClearErrors();
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {

                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Comp1", parm._Comcod ?? "");
                    param.Add("@CallType", parm.Calltype);
                    param.Add("@Dxml01", (parm.Dxml01 == null) ? null : parm.Dxml01.GetXml());
                    param.Add("@Dxml02", (parm.Dxml02 == null) ? null : parm.Dxml02.GetXml());
                    param.Add("@Desc1", parm.Desc01 ?? "");
                    param.Add("@Desc2", parm.Desc02 ?? "");
                    param.Add("@Desc3", parm.Desc03 ?? "");
                    param.Add("@Desc4", parm.Desc04 ?? "");
                    param.Add("@Desc5", parm.Desc05 ?? "");
                    param.Add("@Desc6", parm.Desc06 ?? "");
                    param.Add("@Desc7", parm.Desc07 ?? "");
                    param.Add("@Desc8", parm.Desc08 ?? "");
                    param.Add("@Desc9", parm.Desc09 ?? "");
                    param.Add("@Desc10", parm.Desc10 ?? "");
                    param.Add("@Desc11", parm.Desc11 ?? "");
                    param.Add("@Desc12", parm.Desc12 ?? "");
                    param.Add("@Desc13", parm.Desc13 ?? "");
                    param.Add("@Desc14", parm.Desc14 ?? "");
                    param.Add("@Desc15", parm.Desc15 ?? "");
                    param.Add("@Desc16", parm.Desc16 ?? "");
                    param.Add("@Desc17", parm.Desc17 ?? "");
                    param.Add("@Desc18", parm.Desc18 ?? "");
                    param.Add("@Desc19", parm.Desc19 ?? "");
                    param.Add("@Desc20", parm.Desc20 ?? "");
                    param.Add("@UserID", parm.UserID ?? "");
                    sqlCon.Open();
                    return sqlCon.Query<T>(parm.StoredProcedure, param, commandType: System.Data.CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                ErrorTracking.SetError(ex);
                return null;
            }
        }

        public IEnumerable<T> DataListMax30<T>(SPParameters parm)
        {
            try
            {
                ErrorTracking.ClearErrors();
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {

                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Comp1", parm._Comcod ?? "");
                    param.Add("@CallType", parm.Calltype);
                    param.Add("@Dxml01", (parm.Dxml01 == null) ? null : parm.Dxml01.GetXml());
                    param.Add("@Dxml02", (parm.Dxml02 == null) ? null : parm.Dxml02.GetXml());
                    param.Add("@Desc1", parm.Desc01 ?? "");
                    param.Add("@Desc2", parm.Desc02 ?? "");
                    param.Add("@Desc3", parm.Desc03 ?? "");
                    param.Add("@Desc4", parm.Desc04 ?? "");
                    param.Add("@Desc5", parm.Desc05 ?? "");
                    param.Add("@Desc6", parm.Desc06 ?? "");
                    param.Add("@Desc7", parm.Desc07 ?? "");
                    param.Add("@Desc8", parm.Desc08 ?? "");
                    param.Add("@Desc9", parm.Desc09 ?? "");
                    param.Add("@Desc10", parm.Desc10 ?? "");
                    param.Add("@Desc11", parm.Desc11 ?? "");
                    param.Add("@Desc12", parm.Desc12 ?? "");
                    param.Add("@Desc13", parm.Desc13 ?? "");
                    param.Add("@Desc14", parm.Desc14 ?? "");
                    param.Add("@Desc15", parm.Desc15 ?? "");
                    param.Add("@Desc16", parm.Desc16 ?? "");
                    param.Add("@Desc17", parm.Desc17 ?? "");
                    param.Add("@Desc18", parm.Desc18 ?? "");
                    param.Add("@Desc19", parm.Desc19 ?? "");
                    param.Add("@Desc20", parm.Desc20 ?? "");
                    param.Add("@Desc21", parm.Desc21 ?? "");
                    param.Add("@Desc22", parm.Desc22 ?? "");
                    param.Add("@Desc23", parm.Desc23 ?? "");
                    param.Add("@Desc24", parm.Desc24 ?? "");
                    param.Add("@Desc25", parm.Desc25 ?? "");
                    param.Add("@Desc26", parm.Desc26 ?? "");
                    param.Add("@Desc27", parm.Desc27 ?? "");
                    param.Add("@Desc28", parm.Desc28 ?? "");
                    param.Add("@Desc29", parm.Desc29 ?? "");
                    param.Add("@Desc30", parm.Desc30 ?? "");
                    param.Add("@Desc31", parm.Desc31 ?? "");
                    param.Add("@Desc32", parm.Desc32 ?? "");
                    param.Add("@Desc33", parm.Desc33 ?? "");
                    param.Add("@Desc34", parm.Desc34 ?? "");
                    param.Add("@Desc35", parm.Desc35 ?? "");
                    param.Add("@Desc36", parm.Desc36 ?? "");
                    param.Add("@Desc37", parm.Desc37 ?? "");
                    param.Add("@Desc38", parm.Desc38 ?? "");
                    param.Add("@Desc39", parm.Desc39 ?? "");
                    param.Add("@Desc40", parm.Desc40 ?? "");
                    param.Add("@UserID", parm.UserID ?? "");
                    sqlCon.Open();
                    return sqlCon.Query<T>(parm.StoredProcedure, param, commandType: System.Data.CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                ErrorTracking.SetError(ex);
                return null;
            }
        }

        public bool ExecuteMax20(SPParameters parm)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                try
                {
                    ErrorTracking.ClearErrors();
                    sqlCon.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Comp1", parm._Comcod);
                    param.Add("@CallType", parm.Calltype);
                    param.Add("@Dxml01", (parm.Dxml01 == null) ? null : parm.Dxml01.GetXml());
                    param.Add("@Dxml02", (parm.Dxml02 == null) ? null : parm.Dxml02.GetXml());
                    param.Add("@Desc1", parm.Desc01 ?? "");
                    param.Add("@Desc2", parm.Desc02 ?? "");
                    param.Add("@Desc3", parm.Desc03 ?? "");
                    param.Add("@Desc4", parm.Desc04 ?? "");
                    param.Add("@Desc5", parm.Desc05 ?? "");
                    param.Add("@Desc6", parm.Desc06 ?? "");
                    param.Add("@Desc7", parm.Desc07 ?? "");
                    param.Add("@Desc8", parm.Desc08 ?? "");
                    param.Add("@Desc9", parm.Desc09 ?? "");
                    param.Add("@Desc10", parm.Desc10 ?? "");
                    param.Add("@Desc11", parm.Desc11 ?? "");
                    param.Add("@Desc12", parm.Desc12 ?? "");
                    param.Add("@Desc13", parm.Desc13 ?? "");
                    param.Add("@Desc14", parm.Desc14 ?? "");
                    param.Add("@Desc15", parm.Desc15 ?? "");
                    param.Add("@Desc16", parm.Desc16 ?? "");
                    param.Add("@Desc17", parm.Desc17 ?? "");
                    param.Add("@Desc18", parm.Desc18 ?? "");
                    param.Add("@Desc19", parm.Desc19 ?? "");
                    param.Add("@Desc20", parm.Desc20 ?? "");                  
                    param.Add("@UserID", parm.UserID ?? "");
                    sqlCon.Execute(parm.StoredProcedure, param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 240);
                    return true;
                }
                catch (Exception ex)
                {
                    ErrorTracking.SetError(ex);
                    return false;
                }

            }
        }

        public bool ExecuteMax30(SPParameters parm)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                try
                {
                    ErrorTracking.ClearErrors();
                    sqlCon.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Comp1", parm._Comcod);
                    param.Add("@CallType", parm.Calltype);
                    param.Add("@Dxml01", (parm.Dxml01 == null) ? null : parm.Dxml01.GetXml());
                    param.Add("@Dxml02", (parm.Dxml02 == null) ? null : parm.Dxml02.GetXml());
                    param.Add("@Desc1", parm.Desc01 ?? "");
                    param.Add("@Desc2", parm.Desc02 ?? "");
                    param.Add("@Desc3", parm.Desc03 ?? "");
                    param.Add("@Desc4", parm.Desc04 ?? "");
                    param.Add("@Desc5", parm.Desc05 ?? "");
                    param.Add("@Desc6", parm.Desc06 ?? "");
                    param.Add("@Desc7", parm.Desc07 ?? "");
                    param.Add("@Desc8", parm.Desc08 ?? "");
                    param.Add("@Desc9", parm.Desc09 ?? "");
                    param.Add("@Desc10", parm.Desc10 ?? "");
                    param.Add("@Desc11", parm.Desc11 ?? "");
                    param.Add("@Desc12", parm.Desc12 ?? "");
                    param.Add("@Desc13", parm.Desc13 ?? "");
                    param.Add("@Desc14", parm.Desc14 ?? "");
                    param.Add("@Desc15", parm.Desc15 ?? "");
                    param.Add("@Desc16", parm.Desc16 ?? "");
                    param.Add("@Desc17", parm.Desc17 ?? "");
                    param.Add("@Desc18", parm.Desc18 ?? "");
                    param.Add("@Desc19", parm.Desc19 ?? "");
                    param.Add("@Desc20", parm.Desc20 ?? "");
                    param.Add("@Desc21", parm.Desc21 ?? "");
                    param.Add("@Desc22", parm.Desc22 ?? "");
                    param.Add("@Desc23", parm.Desc23 ?? "");
                    param.Add("@Desc24", parm.Desc24 ?? "");
                    param.Add("@Desc25", parm.Desc25 ?? "");
                    param.Add("@Desc26", parm.Desc26 ?? "");
                    param.Add("@Desc27", parm.Desc27 ?? "");
                    param.Add("@Desc28", parm.Desc28 ?? "");
                    param.Add("@Desc29", parm.Desc29 ?? "");
                    param.Add("@Desc30", parm.Desc30 ?? "");
                    param.Add("@UserID", parm.UserID ?? "");
                    sqlCon.Execute(parm.StoredProcedure, param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 240);
                    return true;
                }
                catch (Exception ex)
                {
                    ErrorTracking.SetError(ex);
                    return false;
                }

            }
        }

        public bool ExecuteMax40(SPParameters parm)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                try
                {
                    ErrorTracking.ClearErrors();
                    sqlCon.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Comp1", parm._Comcod);
                    param.Add("@CallType", parm.Calltype);
                    param.Add("@Dxml01", (parm.Dxml01 == null) ? null : parm.Dxml01.GetXml());
                    param.Add("@Dxml02", (parm.Dxml02 == null) ? null : parm.Dxml02.GetXml());
                    param.Add("@Desc1", parm.Desc01 ?? "");
                    param.Add("@Desc2", parm.Desc02 ?? "");
                    param.Add("@Desc3", parm.Desc03 ?? "");
                    param.Add("@Desc4", parm.Desc04 ?? "");
                    param.Add("@Desc5", parm.Desc05 ?? "");
                    param.Add("@Desc6", parm.Desc06 ?? "");
                    param.Add("@Desc7", parm.Desc07 ?? "");
                    param.Add("@Desc8", parm.Desc08 ?? "");
                    param.Add("@Desc9", parm.Desc09 ?? "");
                    param.Add("@Desc10", parm.Desc10 ?? "");
                    param.Add("@Desc11", parm.Desc11 ?? "");
                    param.Add("@Desc12", parm.Desc12 ?? "");
                    param.Add("@Desc13", parm.Desc13 ?? "");
                    param.Add("@Desc14", parm.Desc14 ?? "");
                    param.Add("@Desc15", parm.Desc15 ?? "");
                    param.Add("@Desc16", parm.Desc16 ?? "");
                    param.Add("@Desc17", parm.Desc17 ?? "");
                    param.Add("@Desc18", parm.Desc18 ?? "");
                    param.Add("@Desc19", parm.Desc19 ?? "");
                    param.Add("@Desc20", parm.Desc20 ?? "");
                    param.Add("@Desc21", parm.Desc21 ?? "");
                    param.Add("@Desc22", parm.Desc22 ?? "");
                    param.Add("@Desc23", parm.Desc23 ?? "");
                    param.Add("@Desc24", parm.Desc24 ?? "");
                    param.Add("@Desc25", parm.Desc25 ?? "");
                    param.Add("@Desc26", parm.Desc26 ?? "");
                    param.Add("@Desc27", parm.Desc27 ?? "");
                    param.Add("@Desc28", parm.Desc28 ?? "");
                    param.Add("@Desc29", parm.Desc29 ?? "");
                    param.Add("@Desc30", parm.Desc30 ?? "");
                    param.Add("@Desc31", parm.Desc31 ?? "");
                    param.Add("@Desc32", parm.Desc32 ?? "");
                    param.Add("@Desc33", parm.Desc33 ?? "");
                    param.Add("@Desc34", parm.Desc34 ?? "");
                    param.Add("@Desc35", parm.Desc35 ?? "");
                    param.Add("@Desc36", parm.Desc36 ?? "");
                    param.Add("@Desc37", parm.Desc37 ?? "");
                    param.Add("@Desc38", parm.Desc38 ?? "");
                    param.Add("@Desc39", parm.Desc39 ?? "");
                    param.Add("@Desc40", parm.Desc40 ?? "");
                    param.Add("@UserID", parm.UserID ?? "");
                    sqlCon.Execute(parm.StoredProcedure, param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 240);
                    return true;
                }
                catch (Exception ex)
                {
                    ErrorTracking.SetError(ex);
                    return false;
                }

            }
        }
    }
}
