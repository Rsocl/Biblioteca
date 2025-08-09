using System;

// Clase que representa un ejemplar de biblioteca
public class Ejemplar
{
    // Propiedades del ejemplar
    public string Titulo { get; set; }
    public string Escritor { get; set; }
    public int AnoPublicacion { get; set; }

    // Constructor de la clase Ejemplar
    public Ejemplar(string titulo, string escritor, int anoPublicacion)
    {
        this.Titulo = titulo;
        this.Escritor = escritor;
        this.AnoPublicacion = anoPublicacion;
    }

    // Propiedades alternativas para acceder a los atributos
    public string titulo
    {
        get => Titulo;
        set => Titulo = value;
    }

    public string escritor
    {
        get => Escritor;
        set => Escritor = value;
    }

    public int anoPublicacion
    {
        get => AnoPublicacion;
        set
        {
            if (value > 0)
            {
                AnoPublicacion = value;
            }
            else
            {
                throw new ArgumentException("El año de publicación debe ser mayor que cero.");
            }
        }
    }

    // Método para imprimir los detalles del ejemplar
    public void ImprimirDetalles()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Escritor}, Año de Publicación: {AnoPublicacion}");
    }

    // Método para verificar si el ejemplar es reciente
    public bool EsNuevo()
    {
        int anoActual = DateTime.Now.Year;
        return (anoActual - AnoPublicacion) < 1;
    }
}

// Programa principal para probar la clase Ejemplar
public class Program
{
    public static void Main(string[] args)
    {
        var ejemplar = new Ejemplar("Desarrollo Actual", "Rony", 2025);
        ejemplar.ImprimirDetalles();

        if (ejemplar.EsNuevo())
        {
            Console.WriteLine("El ejemplar es nuevo (menos de un año desde su publicación).");
        }
        else
        {
            Console.WriteLine("El ejemplar no es nuevo.");
        }

        // Cambiamos el año de publicación para probar
        //ejemplar.anoPublicacion = DateTime.Now.Year - 2;
        //ejemplar.ImprimirDetalles();

        if (ejemplar.EsNuevo())
        {
            Console.WriteLine("El ejemplar es nuevo.");
        }
        else
        {
            Console.WriteLine("El ejemplar no es nuevo.");
        }
    }
}