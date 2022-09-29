using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Clase_Usuario
{
    internal class Invitado : Usuario
    {
        private string id_invitado;
        public string Id_invitado { get => id_invitado; set => id_invitado = value; }
    }
}
