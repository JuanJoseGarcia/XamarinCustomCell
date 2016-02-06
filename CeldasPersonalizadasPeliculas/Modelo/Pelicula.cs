using System;

namespace CeldasPersonalizadasPeliculas
{
	public class Pelicula
	{
		public Pelicula (int id, string titulo, string director, int puntuacion, string duracion, 
		                  string imagen, string sinopsis)
		{

			this.Id = id;
			this.Titulo = titulo;
			this.Director = director;
			this.Puntuacion = puntuacion;
			this.Sinopsis = sinopsis;
			this.Duracion = duracion;
			this.Imagen = imagen;
		}

		public int Id { get; set; }

		public string Titulo { get; set; }

		public string Director { get; set; }

		public int Puntuacion { get; set; }

		public string Sinopsis { get; set; }

		public string Duracion { get; set; }

		public string Imagen { get; set; }
	}
}

