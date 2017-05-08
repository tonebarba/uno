using System;


public class Persona
{
	string nombre;

	public void SetNombre (string nuevoNombre)
	{
		nombre = nuevoNombre;
	}

	public void Saludar () 
	{
		Console.Write ("Hola, soy {0}", nombre);
	}
		
}

