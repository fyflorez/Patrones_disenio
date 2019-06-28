using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseño.Patrones
{
    /// <summary>
    /// Singleton, Delimitacion a una sola instancia;
    /// </summary>
    public class Conexion
    {
        private static Conexion Instancia;

        private Conexion()
        {

        }

        public static Conexion getInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Conexion();
            }

            return Instancia;

        }

        public void Conectar()
        {

        }

        public void DesConectar()
        {
        }

    }
}
