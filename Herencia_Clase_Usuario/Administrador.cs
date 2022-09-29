using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Clase_Usuario
{
    internal class Administrador : Usuario
    {
        private string id_Administrador;
        public string Id_Administrador { get => id_Administrador; set => id_Administrador = value; }
    }
}
