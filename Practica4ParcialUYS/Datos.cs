using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Practica4ParcialUYS
{
	[Activity(Label = "Datos")]
	public class Datos : Activity
	{
		string peli1 = "Donnie";
		protected override void OnCreate(Bundle savedInstanceState)
		{
			
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Rese);
			TextView Titulo = FindViewById<TextView>(Resource.Id.txtTitulo);
			TextView Clasificacion = FindViewById<TextView>(Resource.Id.txtClasifica);
			TextView Genero = FindViewById<TextView>(Resource.Id.txtGenero);
			TextView Duracion = FindViewById<TextView>(Resource.Id.txtDuracion);
			TextView Director = FindViewById<TextView>(Resource.Id.txtDirector);
			TextView Actores = FindViewById<TextView>(Resource.Id.txtActores);
			TextView Sinopsis = FindViewById<TextView>(Resource.Id.txtRese);
			TextView Fecha = FindViewById<TextView>(Resource.Id.txtFecha);
			ImageView LaImagen = FindViewById<ImageView>(Resource.Id.ImgBase);

			TextView Gen = FindViewById<TextView>(Resource.Id.txtGenero);
			Gen.MovementMethod = new Android.Text.Method.ScrollingMovementMethod();
			TextView Res = FindViewById<TextView>(Resource.Id.txtRese);
			Res.MovementMethod = new Android.Text.Method.ScrollingMovementMethod();
			TextView Act = FindViewById<TextView>(Resource.Id.txtActores);
			Act.MovementMethod = new Android.Text.Method.ScrollingMovementMethod();


			try
			{
				Titulo.Text = Intent.GetStringExtra("Titu");
				Clasificacion.Text = Intent.GetStringExtra("Clasi");
				Genero.Text = Intent.GetStringExtra("Gene");
				Duracion.Text = Intent.GetStringExtra("Dura");
				Director.Text = Intent.GetStringExtra("Dire");
				Actores.Text = Intent.GetStringExtra("Acto");
				Sinopsis.Text = Intent.GetStringExtra("Sino");
				Fecha.Text = Intent.GetStringExtra("Fe");
				if (Titulo.Text == "Donnie Darko")
					LaImagen.SetImageResource(Resource.Drawable.Donnie);
				if (Titulo.Text == "El efecto mariposa")
					LaImagen.SetImageResource(Resource.Drawable.Mariposa);
				if (Titulo.Text == "El exorcista")
					LaImagen.SetImageResource(Resource.Drawable.Diablo);
				if (Titulo.Text == "El increible castillo vagabundo")
					LaImagen.SetImageResource(Resource.Drawable.Castillo);
				if (Titulo.Text == "Intouchables")
					LaImagen.SetImageResource(Resource.Drawable.Intocables);
				if (Titulo.Text == "La naranja mecanica")
					LaImagen.SetImageResource(Resource.Drawable.Naranja);
				if (Titulo.Text == "Las ventajas de ser invisible")
					LaImagen.SetImageResource(Resource.Drawable.Ventajas);
				if (Titulo.Text == "Requiem por un sueno")
					LaImagen.SetImageResource(Resource.Drawable.Requim);
				if (Titulo.Text == "Straight Outta Compton" || Titulo.Text == "Straight outta compton ")
					LaImagen.SetImageResource(Resource.Drawable.Outta);
				if (Titulo.Text == "Wolverine inmortal" || Titulo.Text == "Wolverine Inmortal")
					LaImagen.SetImageResource(Resource.Drawable.Wolver);
			}
			catch (Exception)
			{
				Toast.MakeText(this, "Error Al Cargar Datos", ToastLength.Long).Show();
			}

		}
	}
}
