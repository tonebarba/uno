using System;

public class PruebaPersona
{
	public static void Main ()
	{
		Persona p1 = new Persona ();
		Persona p2 = new Persona ();

		p1.SetNombre ("Juan");
		p2.SetNombre ("Pablo");

		p1.Saludar ();
		Console.WriteLine ();
		p2.Saludar ();
	}
}


