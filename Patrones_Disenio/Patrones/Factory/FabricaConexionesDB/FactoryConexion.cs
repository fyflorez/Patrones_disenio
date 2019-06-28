using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseño.Patrones.Factory
{
    /// <summary>
    /// AE patron de diseño fabrica se basa en la creacion de una interface sus implementaciones y luego esta
    /// Implentacion se llaman por medio de una clase fabrica quien nos retorna a instancia solicitada
    /// </summary>
    public class FactoryConexion
    {
        public enum Motores
        {
            Oracle,
            MySQL,
            PosgreSQL,
            Otra
        }

        public IConexion GetConexion(Motores motor)
        {
            
            switch (motor.ToString())
            {
                case "Oracle":
                    return new ConexionOracle();
                case "MySQL":
                    return new ConexionMySQL();
                case "PosgreSQL":
                    return new ConexionPosgreSQL();
                default:
                    return new ConexionVacia();

            }
           

        }

    }
}
