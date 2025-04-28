using Dapper;
using Dapper_example.Repository.Helper;
using Microsoft.Data.SqlClient;

namespace Dapper_example.Repository
{
    public interface IStoreProcedureAccess
    {
        bool ExecuteMax20(SPParameters parm);
        bool ExecuteMax30(SPParameters parm);
        bool ExecuteMax40(SPParameters parm);
        IEnumerable<T> DataListMax20<T>(SPParameters parm);
        IEnumerable<T> DataListMax30<T>(SPParameters parm);




    }
}
