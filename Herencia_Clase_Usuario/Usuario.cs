using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Clase_Usuario
{
    internal class Usuario
    {
        private string Nombre_Usu;
        private int Edad;
        private string E_Mail;

        public string Nombre_Usu1 { get => Nombre_Usu; set => Nombre_Usu = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public string E_Mail1 { get => E_Mail; set => E_Mail = value; }

        public void CrearUsuario(string _Nombre_Usu, int _Edad, string _E_Mail)
        {
            Nombre_Usu = _Nombre_Usu;
            Edad = _Edad;
            E_Mail = _E_Mail;
        }
    }
}
