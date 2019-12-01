using Microsoft.Data.Sqlite;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    class DataAccess
    {
        public async static void InitializeDatabase()
        {
            using (SqliteConnection db =
               new SqliteConnection($"Filename=SqlCus"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Customers (uid INTEGER PRIMARY KEY, " +
                    "first_Name VARCHAR(30) NULL, lirst_Name VARCHAR(40) NULL, email VARCHAR(200) NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }

        public static void AddData(string inputText)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SqlCus"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Customers VALUES (4, @firstName, @lastName, @email);";
                insertCommand.Parameters.AddWithValue("@firstName", inputText);
                insertCommand.Parameters.AddWithValue("@lastName", inputText);
                insertCommand.Parameters.AddWithValue("@email", inputText);

                insertCommand.ExecuteReader();
                db.Close();
            }
        }
    }
}
