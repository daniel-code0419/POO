/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 24/09/2019
 * Hora: 6H30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejemplo1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Demo POO");
			
			Persona per= new Persona();
			
			
			
			Estudiantes est= new Estudiantes();
			Console.WriteLine("Ingresar el documentos: ");
			est.documento = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingresar los nombres");
			est.nombres=Console.ReadLine();
			Console.WriteLine("ingrese los apellidos");
			est.apellidos=Console.ReadLine();
			//Console.WriteLine("Ingrese la nacionalidad");
			//est.nacionalidad=Console.ReadLine();
			Console.WriteLine("ingrese la carrera");
			est.carrera=Console.ReadLine();
			Console.WriteLine("Ingrese el semestre");
			est.semestre= int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el promedio");
			est.promedio= double.Parse(Console.ReadLine());
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}