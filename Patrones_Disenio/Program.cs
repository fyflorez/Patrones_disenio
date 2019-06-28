using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrones_Diseño.Patrones.Factory;

namespace Patrones_Diseño
{
    class Program
    {
        static void Main(string[] args)
        {
            //singleton
            Patrones.Conexion conn =  Patrones.Conexion.getInstancia();
            conn.Conectar();
            conn.DesConectar();

            bool b = conn is Patrones.Conexion;



            //factoria
            FactoryConexion fabrica = new FactoryConexion();

                      
            IConexion fac_1 = fabrica.GetConexion(FactoryConexion.Motores.MySQL);
            fac_1.Conectar();
            fac_1.Desconectar();


            IConexion fac_2 = fabrica.GetConexion(FactoryConexion.Motores.Oracle);
            fac_2.Conectar();
            fac_2.Desconectar();

        }
    }
}
