using SqlViewer.Models;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SqlViewer.Dal
{
    interface IRepository
    {
        void LogIn(string server, string username, string password);

        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType table);
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        DataSet CreateDataSet(string query);
        int ExecuteQuery(string query);
    }
}