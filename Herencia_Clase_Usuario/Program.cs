namespace Herencia_Clase_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n--------------------------");
            Usuario usuario = new Usuario();
            usuario.Nombre_Usu1 = "Aldo";
            usuario.Edad1 = 3;
            usuario.E_Mail1 = "alditosege@hotmail.com";
            Console.WriteLine("Usuario: Usuario \nNombre de Usuario: " + usuario.Nombre_Usu1 + "\nEdad: " + usuario.Edad1 + "\nE-Mail: " + usuario.E_Mail1);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n--------------------------");
            Administrador adm = new Administrador();
            adm.Nombre_Usu1 = "Joakim";
            adm.Edad1 = 13;
            adm.E_Mail1 = "joak9am@hotmail.com";
            adm.Id_Administrador = "05JC785423";
            Console.WriteLine("Usuario: Administrador \nNombre de Usuario: " + adm.Nombre_Usu1 + "\nEdad: " + adm.Edad1 + "\nE-Mail: " + adm.E_Mail1 + "\nId de Administrador: " + adm.Id_Administrador);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n--------------------------");
            Invitado invitado = new Invitado();
            invitado.Nombre_Usu1 = "David";
            invitado.Edad1 = 28;
            invitado.E_Mail1 = "Daviddm@hotmail.com";
            invitado.Id_invitado = "ACL78852369";
            Console.WriteLine("Usuario: Invitado \nNombre de Usuario: " + invitado.Nombre_Usu1 + "\nEdad: " + invitado.Edad1 + "\nE-Mail: " + invitado.E_Mail1 + "\nId de Invitado: " + invitado.Id_invitado);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n--------------------------");
            Console.ReadKey(true);
        }
    }
}