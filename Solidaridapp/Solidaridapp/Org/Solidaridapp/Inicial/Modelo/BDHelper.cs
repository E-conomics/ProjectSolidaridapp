using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    public class BDHelper
    {
        SQLiteConnection dbConn;
        public bool CheckFileExists()
        {
            var local = Windows.Storage.ApplicationData.Current.LocalSettings;
            if (local.Values.ContainsKey("existe"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool onCreate()
        {
            try
            {
                if (!CheckFileExists())
                {
   
                    using (dbConn = new SQLiteConnection(App.DB_PATH))
                    {
                        string createTableQuery = @"CREATE TABLE IF NOT EXISTS Personas (
                          idPersona INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          Nombre NVARCHAR(100)  NULL,
                          pApellido VARCHAR(50)  NULL,
                          sApellido VARCHAR(50) NULL,
                          fNacimiento VARCHAR(50) NULL,
                          idUsuario INTEGER NOT NULL
                          )";
                        using (var dbConn = new SQLiteConnection(App.DB_PATH))
                        {
                            var miPersona = dbConn.Execute(createTableQuery, null);
                        }
                        var local = Windows.Storage.ApplicationData.Current.LocalSettings;
                        local.Values["existe"] = "ok";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
    }
}
