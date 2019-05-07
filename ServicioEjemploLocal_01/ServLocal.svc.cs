using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioEjemploLocal_01
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServLocal : IServLocal
    {
        Usuario u1 = new Usuario(1, "Felipe", "Parra", "203nA2jd");
        Usuario u2 = new Usuario(2, "Valentina", "Sume", "ns94bw9AA");
        Usuario u3 = new Usuario(3, "Martin", "Bianchi", "hw1qbUTC1");

        List<Usuario> listUsuarios = new List<Usuario>();

        public List<Usuario> ObtenerTodosUsuarios()
        {
            listUsuarios.Add(u1);
            listUsuarios.Add(u2);
            listUsuarios.Add(u3);

            return listUsuarios;

        }

        public Usuario ObtenerUsuario(string usuario, string contrasenia)
        {

            listUsuarios.Add(u1);
            listUsuarios.Add(u2);
            listUsuarios.Add(u3);


            Usuario uObtenido = new Usuario();

            foreach (Usuario item in listUsuarios)
            {

                if (item.Nombre == usuario  && item.Contrasena == contrasenia)
                {
                    uObtenido = item;

                    break;
                }

                else
                {
                    uObtenido = null;
                }
            }

            return uObtenido;

        }
    }
}
