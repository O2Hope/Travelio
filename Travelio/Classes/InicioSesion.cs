using System;
namespace Travelio.Classes
{
    public class InicioSesion
    {
        public InicioSesion()
        {
        }

        public static bool IniciarSesion(string usuario, string password)
        {
            if (String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(password))
            {
                return false;
            }

            return true;

        }
    }
}
