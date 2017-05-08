using System;

public class Juego
{
	public void Lanzar ()
	{
		Console.Write ("Bienvenido a Console Invaders. Pulse z para salir: ");
		char letra = Convert.ToChar (Console.ReadLine ());
		//if (letra == 'z') {
			
		//}
	}

	public static void Main ()
	{
		Juego space = new Juego ();
		space.Lanzar ();
	}
}


