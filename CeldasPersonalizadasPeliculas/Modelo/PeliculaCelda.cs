using System;
using UIKit;
using System.Drawing;
using Foundation;

namespace CeldasPersonalizadasPeliculas
{
	public class PeliculaCelda:UITableViewCell
	{
		UIImageView Imagen;
		UILabel Titulo, Director, Duracion;
		UIProgressView Puntuacion;

		public PeliculaCelda (NSString cellid) : base (UITableViewCellStyle.Default, cellid)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Default;
			ContentView.BackgroundColor = UIColor.White;

			Imagen = new UIImageView ();


			Titulo = new UILabel () {
				Font = UIFont.FromName ("Helvetica-Bold", 12f),
				BackgroundColor = UIColor.Clear
			};


			Director = new UILabel () {
				Font = UIFont.FromName ("Helvetica", 10f),
				BackgroundColor = UIColor.Clear
			};

			Duracion = new UILabel () { 
				Font = UIFont.FromName ("Helvetica", 8f),
				TextColor = UIColor.Gray,
				BackgroundColor = UIColor.Clear
			};


			Puntuacion = new UIProgressView () { 
				ProgressTintColor = UIColor.Yellow
			};

			ContentView.AddSubviews (new UIView[]{ Titulo, Director, Imagen, Duracion, Puntuacion });
		}


		public void UpdateCell (Pelicula p)
		{
			Imagen.Image = UIImage.FromFile ("Imagenes/" + p.Imagen);
			Titulo.Text = p.Titulo;
			Director.Text = p.Director;
			Duracion.Text = p.Duracion;

			Puntuacion.Progress = (float)p.Puntuacion / 10;
		}

		public override void LayoutSubviews ()
		{
					
			base.LayoutSubviews ();

			Imagen.Frame = new RectangleF (5, 7, 60, 90);
			Titulo.Frame = new RectangleF (75, 8, (float)ContentView.Bounds.Width, 25);
			Director.Frame = new RectangleF (75, 30, (float)ContentView.Bounds.Width, 20);
			Puntuacion.Frame = new RectangleF (75, 60, (float)ContentView.Bounds.Width - 90, 80);
			Duracion.Frame = new RectangleF (75, 65, (float)ContentView.Bounds.Width, 25);
				
		}
	}
}

