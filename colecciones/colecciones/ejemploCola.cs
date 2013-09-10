using System;
using System.Collections;

namespace colecciones
{
	public class ejemploCola
	{
		public ejemploCola ()
		{
		}
		
		public void mostrar(){
			Queue cola = new Queue();
       		cola.Enqueue("Hola");
       		cola.Enqueue("Mundo");
       		cola.Enqueue("!");
			
			Object objeto = cola.Dequeue();
			Console.WriteLine(objeto);
			
       		Console.WriteLine( "Ejemplo de Cola" );
       		Console.WriteLine( "\tCount:    {0}", cola.Count );
       		Console.Write( "\tValues:" );
       		PrintValues( cola );
			Console.WriteLine();
		}
		
		public static void PrintValues( IEnumerable myCollection )  {
			foreach ( Object obj in myCollection ){
				Console.Write( "    {0}", obj );
			}
       		Console.WriteLine();
    	}
	}
}

