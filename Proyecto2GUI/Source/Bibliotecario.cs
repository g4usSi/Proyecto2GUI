using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Bibliotecario : Usuario
    {
        public Bibliotecario(string iD = null, string nombre = null ,string password = null) : base()
        {
            this.Rol = "Bibliotecario";
            if (iD == null)
            {
                Console.Write("Ingrese el nombre: ");
                ID = Console.ReadLine();
            }
            else
            {
                ID = iD;
            }

            if (nombre == null)
            {
                Console.Write("Ingrese el nombre: ");
                Name = Console.ReadLine();
            }
            else
            {
                Name = nombre;
            }

            if (password == null)
            {
                Console.Write("Ingrese la contraseña: ");
                Password = Console.ReadLine();
            }
            else
            {
                Password = password;
            }
        }
        public override void MostrarUsuario()
        {
            base.MostrarUsuario();
        }
    }
}
