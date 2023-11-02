// See https://aka.ms/new-console-template for more information
using NullCheck;

namespace NullCheck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetData();
        }
                
        public static void GetData()
        {
            StudentRepository repository = new StudentRepository();
            var alumno = repository.GetById(19);

            //Validación 'clásica'
            //if (alumno != null)
            //    Console.WriteLine($"El nombre del alumno es {alumno.Name}");
            //else
            //    Console.WriteLine("Alumno NO existe");
            

            //Validación adecuada
            if (alumno is not null)
                Console.WriteLine($"El nombre del alumno es {alumno.Name}");
            else
                Console.WriteLine("Alumno NO existe");
        }

    }
}