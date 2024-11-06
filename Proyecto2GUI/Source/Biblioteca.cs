using Proyecto2.Proyecto2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Biblioteca
    {
        //declarar un usuario actual?
        public Usuario UsuarioActual = null;

        //Listas
        private List<Libro> librosBiblioteca = new List<Libro>();
        private List<Usuario> listaUsuarios = new List<Usuario>();//LinkedList
        private List<Prestamo> prestamos = new List<Prestamo>();//LinkedList
        private Queue<SolicitudEspera> listaEspera = new Queue<SolicitudEspera>();

        //Estados
        public bool LibrosOrdenados = false; //Libros ordenados
        private HistorialAcciones historialAcciones = new HistorialAcciones();

        //LOGIN
        public bool IniciarSesion(string nombre, string contrasena)
        {
            foreach (var usuario in listaUsuarios)
            {
                if (usuario.ID == nombre && usuario.Password == contrasena)
                {
                    if (usuario is Bibliotecario bibliotecario)
                    {
                        UsuarioActual = bibliotecario;
                    }
                    else if (usuario is Lector lector)
                    {
                        UsuarioActual = lector;
                    }
                    return true;
                }
            }
            return false;
        }
        public void CerrarSesion()
        {
            UsuarioActual = null;
            historialAcciones.LimpiarHistorial();
            Console.WriteLine("Sesión cerrada.");
        }

        //Modulo 1 Gestion de Libros
        //Agregar Libros
        public void AgregarLibro(Libro libroRecibidoGUI)
        {
            librosBiblioteca.Add(libroRecibidoGUI);
            LibrosOrdenados = false;
        }
        public List<Libro> MostrarLibros()
        {
            return librosBiblioteca;
        }
        public bool LibroExistente(string ISBN)
        {
            return librosBiblioteca.Any(libro => libro.ISBN == ISBN);
        }
        // ***** Busqueda de Libros ***** //
        //Metodo de introduccion de datos
        private string ParametroBuscar()
        {
            Console.Write("Ingrese el titulo o autor del libro: ");
            string parametro = Console.ReadLine();
            return parametro.ToLower();
        }
        public void MostrarLibroBuscado()
        {
            string parametro = ParametroBuscar();
            //agregar logica si ya estan ordenados
            Libro libroBuscado = BuscarLibroTitAut(librosBiblioteca, parametro);
            if (libroBuscado != null)
            {
                libroBuscado.MostrarLibro();
            }
            else
            {
                Console.WriteLine("Error. No hay coincidencias.");
            }
        }

        //Recursivo
        public Libro BuscarLibroTitAut(List<Libro> librosBiblioteca, string parametro, int indiceLista = 0)
        {
            if (string.IsNullOrEmpty(parametro) || librosBiblioteca == null || indiceLista >= librosBiblioteca.Count)
            {
                return null;
            }
            var libroActual = librosBiblioteca[indiceLista];
            if (libroActual.Titulo.ToLower() == parametro.ToLower() || libroActual.Autor.ToLower() == parametro.ToLower())
            {
                return libroActual;
            }
            return BuscarLibroTitAut(librosBiblioteca, parametro, indiceLista + 1);
        }

        //Busqueda de libro
        public List<Libro> BuscarLibrosPorTituloOAutor(string parametro)
        {
            List<Libro> librosEncontrados = new List<Libro>();
            if (string.IsNullOrWhiteSpace(parametro)) return librosEncontrados;
            parametro = parametro.ToLower();

            foreach (var libro in librosBiblioteca)
            {
                if (libro.Titulo.ToLower().Contains(parametro) || libro.Autor.ToLower().Contains(parametro))
                {
                    librosEncontrados.Add(libro);
                }
            }
            return librosEncontrados;
        }

        public Libro BuscarLibroISBN(string iSBN)
        {
            if (iSBN == null) return null;

            foreach (var libro in librosBiblioteca)
            {
                if (libro.ISBN.ToLower() == iSBN.ToLower())
                {
                    return libro;
                }
            }
            return null;
        }
        public List<Libro> ListaLibrosPorISBN(string iSBN)
        {
            List<Libro> librosEncontrados = new List<Libro>();

            if (string.IsNullOrWhiteSpace(iSBN)) return librosEncontrados;

            foreach (var libro in librosBiblioteca)
            {
                if (libro.ISBN.Equals(iSBN, StringComparison.OrdinalIgnoreCase))
                {
                    librosEncontrados.Add(libro);
                }
            }
            return librosEncontrados;
        }
        //BusquedaBinaria
        public Libro BuscarLibroBinario(string ISBN)
        {
            int izquierda = 0;
            int derecha = librosBiblioteca.Count - 1;

            while (izquierda <= derecha)
            {
                int mid = izquierda + (derecha - izquierda) / 2;
                int comparacion = librosBiblioteca[mid].ISBN.CompareTo(ISBN);

                if (comparacion == 0)
                {
                    return librosBiblioteca[mid];
                }
                else if (comparacion < 0)
                {
                    izquierda = mid + 1;
                }
                else
                {
                    derecha = mid - 1;
                }
            }
            return null;
        }
        //Eliminar Libro
        public bool EliminarLibro(Libro libroEliminar)
        {
            return librosBiblioteca.Remove(libroEliminar);
        }
        public void LibrosUsuariosPredeterminados()
        {
            listaUsuarios.Add(new Bibliotecario("Geovanny Alcon","Geovanny Alcon", "1407"));
            listaUsuarios.Add(new Bibliotecario("Geo", "Geo","1234"));
            librosBiblioteca.Add(new Libro("It", "Stephen King", "Horror", "666",true, 10));
            librosBiblioteca.Add(new Libro("It", "Stephen King", "Horror", "123", false, 20));
        }
        //Modulo 2 Gestion de Usuarios
        //Opc 1
        public void RegistrarUsuarioNuevo(string id, string nombre, string contraseña, int rol)
        {
            switch (rol)
            {
                case 1:
                    Bibliotecario nuevoBibliotecario = new Bibliotecario
                    {
                        ID = id,
                        Name = nombre,
                        Password = contraseña
                    };
                    listaUsuarios.Add(nuevoBibliotecario);
                    break;
                case 2:
                    Lector nuevoLector = new Lector
                    {
                        ID = id,
                        Name = nombre,
                        Password = contraseña
                    };
                    listaUsuarios.Add(nuevoLector);
                    break;
                default:
                    throw new ArgumentException("Rol no válido.");
            }

            MessageBox.Show("Usuario registrado con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool UsuarioExistente(string ID)
        {
            return listaUsuarios.Any(usuario => usuario.ID == ID);
        }

        //Opc 2
        public void EliminarEditarUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario");
            string nombreUsuario = Console.ReadLine();
            Usuario usuarioModificado = BuscarUsuario(nombreUsuario);
            if (usuarioModificado == null)
            {
                Console.WriteLine("Error. No se ha encontrado al usuario...");
                return;
            }

            Console.WriteLine("1. Editar");
            Console.WriteLine("2. Eliminar");
            Console.Write("Ingrese una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    EditarUsuario(usuarioModificado);
                    Console.WriteLine("Se ha agregado al nuevo usuario.");
                    break;
                case 2:
                    Console.WriteLine("Seguro desea eliminar al usuario? (S/N)");
                    EliminarUsuario(usuarioModificado);
                    Console.WriteLine("Se ha agregado al nuevo usuario.");
                break;
            }
        }

        public void EditarUsuario(Usuario usuarioBuscado)
        {
            Console.WriteLine("Ingrese los nuevos datos a editar...");
            Console.Write("ingrese el nuevo nombre: ");
            usuarioBuscado.ID = Console.ReadLine();
            Console.Write("Ingrese la nueva contraseña: ");
            usuarioBuscado.Password = Console.ReadLine();
            Console.WriteLine("Cambio realizado");
        }
        public bool EliminarUsuario(Usuario usuarioBuscado) 
        { 
            return listaUsuarios.Remove(usuarioBuscado);
        }

        public Usuario BuscarUsuario(string nombreUsuario) 
        {
            foreach(var usuario in listaUsuarios)
            {
                if (usuario.ID.ToLower() == nombreUsuario.ToLower())
                {
                    return usuario;
                }
            }
            return null;
        }
        public List<Usuario> MostrarListaUsuarios() 
        {
            return listaUsuarios;

        }
        //Modulo 3 Prestamos Lector
        //metodo temporal para solicitar prestamos
        public void GestionPrestamos() 
        {
            //Provisional hasta hacer login, se reemplazara con prop UsuarioActual ;3
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Usuario usuario = BuscarUsuario(nombre);
            if (usuario is Lector)
            {
                Lector lectorActual = (Lector)usuario;
                Console.WriteLine("1. Solicitar");
                Console.WriteLine("2. Devolver");
                Console.WriteLine("3. Deshacer");
                Console.Write("Ingrese una opcion: ");
                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc) 
                {
                    case 1:
                    SolicitarLibro(lectorActual);
                        break;
                    case 2:
                    DevolverLibro(lectorActual);
                    break;
                    case 3:
                        historialAcciones.DeshacerUltimaAccion();
                    break;
                }
            }
            else 
            {
                Console.WriteLine("El usuario ingresado no es un lector o no existe.");
                return;
            }


        }

        //Solicitar
        public void SolicitarLibro(Lector lector)
        {
            Console.Write("Ingrese el ISBN del libro que desea solicitar: ");
            string isbnBuscar = Console.ReadLine();
            Libro libroSolicitado = BuscarLibroISBN(isbnBuscar);

            if (libroSolicitado == null)
            {
                Console.WriteLine("Error. El libro no se encuentra en la biblioteca.");
                return;
            }

            if (!libroSolicitado.Disponible)
            {
                SolicitudEspera nuevaSolicitud = new SolicitudEspera(lector, libroSolicitado);
                listaEspera.Enqueue(nuevaSolicitud);
                Console.WriteLine("Error. El libro ya está prestado.");
                Console.WriteLine("Se le ha agregado a una lista de espera...");
                return;
            }

            Prestamo nuevoPrestamo = new Prestamo(libroSolicitado, lector);
            prestamos.Add(nuevoPrestamo);
            libroSolicitado.AumentarContadorPrestamo();
            Console.WriteLine($"El libro '{libroSolicitado.Titulo}' ha sido prestado a {lector.ID}.");

            // Registrar acción en el historial
            historialAcciones.RegistrarAccion(new AccionBiblioteca("Préstamo", libroSolicitado));
        }
        //Devolver
        public void DevolverLibro(Lector lector)
        {
            Console.Write("Ingrese el ISBN del libro que desea devolver: ");
            string isbn = Console.ReadLine();

            Prestamo prestamo = prestamos.Find(p => p.LibroPrestado.ISBN == isbn && p.LectorPrestamo.ID == lector.ID);

            if (prestamo == null)
            {
                Console.WriteLine("Error. No se encontró un préstamo correspondiente.");
                return;
            }

            prestamo.DevolverLibro();
            prestamos.Remove(prestamo);

            Console.WriteLine($"El libro '{prestamo.LibroPrestado.Titulo}' ha sido devuelto por {lector.ID}.");

            // Registrar acción en el historial
            historialAcciones.RegistrarAccion(new AccionBiblioteca("Devolución", prestamo.LibroPrestado));
        }

        //Mostrar prestamos activos
        public List<Prestamo> MostrarPrestamosActivos()
        {
            return prestamos;
        }
        public void MostrarLibrosMasSolicitados(int cantidad = 5)
        {
            if (cantidad > librosBiblioteca.Count)
            {
                cantidad = librosBiblioteca.Count;
            }

            Console.WriteLine($"Los {cantidad} libros más solicitados son:");

            List<Libro> librosOrdenados = new List<Libro>(librosBiblioteca);
            //Ordenamiento burbuja de libros mas solicitados
            for (int i = 0; i < librosOrdenados.Count; i++)
            {
                for (int j = i + 1; j < librosOrdenados.Count; j++)
                {
                    if (librosOrdenados[i].ContadorPrestamos < librosOrdenados[j].ContadorPrestamos)
                    {
                        var temp = librosOrdenados[i];
                        librosOrdenados[i] = librosOrdenados[j];
                        librosOrdenados[j] = temp;
                    }
                }
            }

            foreach (var libro in librosOrdenados)
            {
                Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Préstamos: {libro.ContadorPrestamos}");
            }
        }

        //Funcionalidades de ordenamiento
        public void OrdenarLibros() 
        {

            LibrosOrdenados = true;
        }


    }
}
