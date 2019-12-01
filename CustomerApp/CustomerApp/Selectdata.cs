using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    class Selectdata
    {
        
        public static List<string> GetData()
        {
            List<string> entries = new List<string>();
            //string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "SqlCus.db");
            using (SqliteConnection db = new SqliteConnection($"Filename=SqlCus"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand
                    ("SELECT uid, first_Name, lirst_Name, email from Customers", db);
                SqliteDataReader query = selectcommand.ExecuteReader();
               

                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                    entries.Add(query.GetString(1));
                    entries.Add(query.GetString(2));
                    entries.Add(query.GetString(3));
                }

                db.Close();
            }

            return entries;

        }
    }
}
