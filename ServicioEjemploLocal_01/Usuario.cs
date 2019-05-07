using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioEjemploLocal_01
{
    [DataContract]
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string contrasena;


        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        [DataMember]
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        [DataMember]
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public Usuario(int id, string nombre, string apellido, string contrasena)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contrasena = contrasena;

        }

        public Usuario() { }
    }
}