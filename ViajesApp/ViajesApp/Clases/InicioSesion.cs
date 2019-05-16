using System;
namespace ViajesApp.Clases
{
    public class InicioSesion
    {
        public InicioSesion()
        {

        }

        public static bool IniciarSesion(string usuario, string password)
        {
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
