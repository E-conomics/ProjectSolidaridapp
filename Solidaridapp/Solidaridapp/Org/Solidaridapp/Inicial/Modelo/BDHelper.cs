using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                        dbConn.CreateTable<BDAportaciones>();
                        dbConn.CreateTable<BdBenefactor>();
                        dbConn.CreateTable<BDBeneficiario>();
                        dbConn.CreateTable<BDEmpresa>();
                        dbConn.CreateTable<BDGiroBeneficiario>();
                        dbConn.CreateTable<BDPersona>();
                        dbConn.CreateTable<BDUsuario>();
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
        public bool DummyUser()
        {
            //using (var dbConn = new SQLiteConnection(App.DB_PATH))
            //{
            //    dbConn.DropTable<BDUsuario>();
            //    dbConn.CreateTable<BDUsuario>();
            //}
            //using (var dbConn = new SQLiteConnection(App.DB_PATH))
            //{
            //    dbConn.RunInTransaction(() =>
            //    {
            //        dbConn.Insert(new BDUsuario() { correo = "Juan", clave = "No" });
            //    });
            //}
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                List<BDUsuario> miLista = dbConn.Table<BDUsuario>().ToList<BDUsuario>();
                var miPersona = dbConn.Query<BDUsuario>("SELECT * FROM BDUsuario WHERE correo='" + "Juan" + "'").FirstOrDefault();
                string res= miPersona.ToString();
                
            }
            return true;
        }
    }
}
