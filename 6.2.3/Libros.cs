using System;

class Libro
{
	string autor;
	string titulo;
	string ubicacion;

	public string GetAutor ()
	{
		return autor;
	}

	public void SetAutor (string nuevoAutor)
	{
		autor = nuevoAutor;
	}

	public string GetTitulo ()
	{
		return titulo;
	}

	public void SetTitulo (string nuevoTitulo)
	{
		titulo = nuevoTitulo;
	}

	public string GetUbicacion ()
	{
		return ubicacion;
	}

	public void SetUbicacion (string nuevaUbicacion)
	{
		ubicacion = nuevaUbicacion;
	}

	public static void Main ()
	{
		Libro book = new Libro ();
		book.SetAutor ("George Michael");
		book.SetTitulo ("Las lágrimas de un chorizo en la boca de un gitano.");
		book.SetUbicacion ("Galería de arriba a la izquierda.");

		Console.WriteLine ("Autor: {0}", book.autor);
		Console.WriteLine ("Título: {0}", book.titulo);
		Console.WriteLine ("Ubicado en: {0}", book.ubicacion);
	}
}

ggggggggggggggggggg
