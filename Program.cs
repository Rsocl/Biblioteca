using System;

// Clase que representa un libro
public class Libro
{
    // Atributos de la clase Libro
    public string Nombre { get; set; }
    public string Autor { get; set; }
    public int AnioPublicacion { get; set; }

    // Constructor
    public Libro(string nombre, string autor, int anioPublicacion)
    {
        this.Nombre = nombre;
        this.Autor = autor;
        this.AnioPublicacion = anioPublicacion;
    }

    // Propiedades para acceder a los atributos
    public string nombre
    {
        get => Nombre;
        set => Nombre = value;
    }

    public string autor
    {
        get => Autor;
        set => Autor = value;
    }

    public int anioPublicacion
    {
        get => AnioPublicacion;
        set
        {
            if (value > 0)
            {
                AnioPublicacion = value;
            }
            else
            {
                throw new ArgumentException("El año de publicación debe ser mayor a 0");
            }
        }
    }

    // Método para obtener la antigüedad del libro
    public int ObtenerAntiguedad()
    {
        return DateTime.Now.Year - AnioPublicacion;
    }

    // Método para comparar la antigüedad
    public bool EsMenorAnios(int anios)
    {
        return ObtenerAntiguedad() < anios;
    }

    // Método para mostrar información del libro
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Autor: {Autor}, Año de publicación: {AnioPublicacion}");
    }
}

// Clase principal para ejecutar el programa
class Program
{
    static void Main(string[] args)
    {
        // Datos predeterminados del libro
        string nombre = "Cien Años de Soledad";
        string autor = "Gabriel García Márquez";
        int anio = 1967;

        var libro = new Libro(nombre, autor, anio);
        libro.MostrarInformacion();

        Console.Write("Ingrese los años para comparar antigüedad: ");
        int aniosComparar = int.Parse(Console.ReadLine());

        if (libro.EsMenorAnios(aniosComparar))
        {
            Console.WriteLine($"El libro \"{libro.Nombre}\" es más nuevo que {aniosComparar} años.");
        }
        else
        {
            Console.WriteLine($"El libro \"{libro.Nombre}\" tiene {libro.ObtenerAntiguedad()} años o más.");
        }
    }
}
