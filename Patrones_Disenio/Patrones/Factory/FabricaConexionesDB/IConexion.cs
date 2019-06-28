using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseño.Patrones.Factory
{
    public interface IConexion
    {
        void Conectar();
        void Desconectar();
    }
}
