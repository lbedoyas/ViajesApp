using System;
namespace ViajesApp.Clases
{
    public class DatabaseHelper
    {
        public DatabaseHelper()
        {
        }

        public static bool Insertar<T>(ref T item, string ruta_db)
        {
            using(SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(ruta_db))
            {
                conexion.CreateTable<T>();

                if(conexion.Insert(item)>0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
