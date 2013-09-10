using System;
using System.Collections;

namespace colecciones
{
	public class ejemploArrayList
	{
		public ejemploArrayList ()
		{
		}
		
		public void mostrar(){
			ArrayList myArrayList = new ArrayList();
	      	myArrayList.Add("Hola");
	      	myArrayList.Add("Mundo");
	      	myArrayList.Add("!");
			
			myArrayList.Remove("!");
	
	      	Console.WriteLine( "Ejemplo de ArrayList" );
	      	Console.WriteLine( "    Count:    {0}", myArrayList.Count );
	      	Console.WriteLine( "    Capacity: {0}", myArrayList.Capacity );
	      	Console.Write( "    Values:" );
	      	PrintValues( myArrayList );
			Console.WriteLine();

			Persona juan = new Persona();
			juan.nombre = "Juan";
			
			Persona mariana = new Persona();
			mariana.nombre = "Mariana";
		
			ArrayList personas = new ArrayList();
			personas.Add(juan);
			personas.Add(mariana);
			personas.Add("Mensaje");
			personas.Add(102);
			PrintValues(personas);
			
			Persona desconocido = new Persona();
			desconocido.nombre = "Desconocido";
			
			personas.Insert(2,desconocido);
			PrintValues(personas);
			
			
			try{				 //Persona	//Objeto
				Persona persona = (Persona) personas[2];
				Console.WriteLine("Persona es " + persona.nombre);
			}catch(Exception e){
				Console.WriteLine("Ocurrio un error");
			}
		}
		
		private static void PrintValues( IEnumerable myList )  {
      		foreach ( Object obj in myList ){
         		Console.Write( "    {0}", obj );
			}
      		Console.WriteLine();
   		}
	}
}

