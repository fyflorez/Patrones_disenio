using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseño.Patrones.Factory.FabricaConexionesRest
{
    public interface IConexionRest
    {
        void leerURL(string url);
    }
}
