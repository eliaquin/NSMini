using System.Configuration;

namespace nsMini2
{
    internal class Cadena
    {
        public static string CadenaDeConexion => LeerCadena();
        private static string LeerCadena()
        {
            var connstr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            return connstr;
        }
    }
}
