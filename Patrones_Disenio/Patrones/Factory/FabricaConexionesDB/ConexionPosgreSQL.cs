using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseño.Patrones.Factory
{
    public class ConexionPosgreSQL : IConexion
    {
        public void Conectar() { }
        public void Desconectar() { }
    }
}
