using System;
namespace Travelio.NewFolder
{
    public class DatabaseHelper
    {
        public DatabaseHelper()
        {
        }

        public static bool Insert<T>(ref T item, string rutaDB)
        {
            using (var conexion = new SQLite.SQLiteConnection(rutaDB))
            {
                conexion.CreateTable<T>();

                if (conexion.Insert(item) > 0)
                    return true;
            }
            return false;
        }

        public static bool Update<T>(ref T item, string rutaDB)
        {
            using (var conexion = new SQLite.SQLiteConnection(rutaDB))
            {
                if (conexion.Update(item) > 0)
                    return true;
            }
            return false;
        }

        public static bool Delete<T>(ref T item, string rutaDB)
        {
            using(var conexion = new SQLite.SQLiteConnection(rutaDB))
            {
                if (conexion.Delete(item) > 0)
                    return true;
            }
            return false;
        }
    }
}
