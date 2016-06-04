using SQLite;
using System;
using System.Collections.Generic;
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
                        dbConn.CreateTable<Persona>();
                        var local = Windows.Storage.ApplicationData.Current.LocalSettings;
                        local.Values["existe"] = "ok";
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
