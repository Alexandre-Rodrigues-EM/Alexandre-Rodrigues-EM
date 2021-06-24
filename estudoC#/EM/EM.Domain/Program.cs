using System;
using System.Data.Common;
using FirebirdSql.Data.FirebirdClient;

namespace EM.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new FbConnection("database=localhosto:EM2.5.fdb;user=sysdba;password=masterkey"))
            {
                connection.Open();
                var metadataCollections = connection.GetSchema();
                var dataTypes = connection.GetSchema(DbMetaDataCollectionNames.DataTypes);
                var dataSourceInformation = connection.GetSchema(DbMetaDataCollectionNames.DataSourceInformation);
                var reservedWords = connection.GetSchema(DbMetaDataCollectionNames.ReservedWords);
                var userTables = connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
                var systemTables = connection.GetSchema("Tables", new string[] { null, null, null, "SYSTEM TABLE" });
                var tableColumns = connection.GetSchema("Columns", new string[] { null, null, "TableName" });
            }
        }
    }
}
