using System;
using UIKit;
using System.Collections.Generic;
using Foundation;

namespace CeldasPersonalizadasPeliculas
{
	public class TableSourcePelicula:UITableViewSource
	{
		List<Pelicula> ListaPeliculas;
		NSString celdaId = new NSString ("TableCell");

		public TableSourcePelicula (List<Pelicula> peliculas)
		{
			ListaPeliculas = peliculas;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return ListaPeliculas.Count;
		}



		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView (ListaPeliculas [indexPath.Row].Titulo,
				ListaPeliculas [indexPath.Row].Sinopsis, null, "OK", null).Show ();

			tableView.DeselectRow (indexPath, true);
		}


		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			PeliculaCelda cell = tableView.DequeueReusableCell (celdaId) as PeliculaCelda;


			if (cell == null) {
				cell = new PeliculaCelda (celdaId);
			}

			cell.UpdateCell (ListaPeliculas [indexPath.Row]);

			return cell;
		}


		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 104f;
		}
	}
}

