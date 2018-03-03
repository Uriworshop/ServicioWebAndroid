using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Data;
using Android.Views.Animations;
using System.Threading.Tasks;
using Android.Content;
using System;

namespace Practica4ParcialUYS
{
	[Activity(Label = "Practica4ParcialUYS", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		string Titu, Clasi, Gene, Dura, Dire, Acto, Sino, Fe;
		Animation fade_in, fade_put;
		ViewFlipper Imagen;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			ImageButton Boton1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
			ImageButton Boton2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
			ImageButton Boton3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
			ImageButton Boton4 = FindViewById<ImageButton>(Resource.Id.imageButton4);
			ImageButton Boton5 = FindViewById<ImageButton>(Resource.Id.imageButton5);
			ImageButton Boton6 = FindViewById<ImageButton>(Resource.Id.imageButton6);
			ImageButton Boton7 = FindViewById<ImageButton>(Resource.Id.imageButton7);
			ImageButton Boton8 = FindViewById<ImageButton>(Resource.Id.imageButton8);
			ImageButton Boton9 = FindViewById<ImageButton>(Resource.Id.imageButton9);
			ImageButton Boton10 = FindViewById<ImageButton>(Resource.Id.imageButton10);
			ImageButton Boton11 = FindViewById<ImageButton>(Resource.Id.imageButton11);
			Imagen = FindViewById<ViewFlipper>(Resource.Id.ImagenesCar);

			fade_in = AnimationUtils.LoadAnimation(this, Resource.Animation.Fade_in);
			fade_put = AnimationUtils.LoadAnimation(this, Resource.Animation.Fade_put);

			Imagen.SetInAnimation(ApplicationContext, Resource.Animation.Fade_in);
			Imagen.SetOutAnimation(ApplicationContext, Resource.Animation.Fade_put);
			Imagen.SetFlipInterval(5000);
			Imagen.StartFlipping();

			Boton1.Click += delegate{
				try
				{   
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("Donnie Darko");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("Donnie Darko");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}

				}
			};

			Boton2.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("El efecto mariposa");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("El efecto mariposa");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton3.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("El exorcista");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("El exorcista");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton4.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("El increible castillo vagabundo");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("El increible castillo vagabundo");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton5.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("Intouchables");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("Intouchables");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton6.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("La naranja mecanica");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("La naranja mecanica");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton7.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("Las ventajas de ser invisible");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("Las ventajas de ser invisible");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton8.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("Requiem por un sueno");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("Requiem por un sueno");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton9.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("Straight Outta Compton");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("Straight outta compton");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton10.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("Wolverine inmortal");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					try
					{
						Practica4ParcialUYS.ServiCineSql.Service Ser = new Practica4ParcialUYS.ServiCineSql.Service();
						DataSet Con = new DataSet();
						Con = Ser.Consultar("Wolverine Inmortal");
						DataRow Renglon;
						Renglon = Con.Tables["Informacion"].Rows[0];
						Titu = Renglon["Nombre"].ToString();
						Gene = Renglon["Genero"].ToString();
						Clasi = Renglon["Clasificacion"].ToString();
						Dura = Renglon["Duracion"].ToString();
						Dire = Renglon["Director"].ToString();
						Acto = Renglon["Actores"].ToString();
						Sino = Renglon["Sinopsis"].ToString();
						Fe = Renglon["Fecha_Estreno"].ToString();
						Cargar();

					}
					catch (Exception)
					{
						Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
					}
				}
			};
			Boton11.Click += delegate
			{
				try
				{
					Practica4ParcialUYS.SitioCine.ServiCine Ser = new Practica4ParcialUYS.SitioCine.ServiCine();
					DataSet Con = new DataSet();
					Con = Ser.BuscarPeli("Comunidad");
					DataRow Renglon;
					Renglon = Con.Tables["Informacion"].Rows[0];
					Titu = Renglon["Nombre"].ToString();
					Gene = Renglon["Genero"].ToString();
					Clasi = Renglon["Clasificacion"].ToString();
					Dura = Renglon["Duracion"].ToString();
					Dire = Renglon["Director"].ToString();
					Acto = Renglon["Actores"].ToString();
					Sino = Renglon["Sinopsis"].ToString();
					Fe = Renglon["Fecha"].ToString();
					Cargar();
				}
				catch (System.Exception)
				{
					Toast.MakeText(this, "Erro Al Busca La Peli", ToastLength.Long).Show();
				}
			};
		}

		void Ser_BuscarPeliCompleted(object sender, SitioCine.BuscarPeliCompletedEventArgs e)
		{
			
		}

		public void Cargar()
		{
			Intent Datos = new Intent(this, typeof(Datos));
			Datos.PutExtra("Titu", Titu);
			Datos.PutExtra("Gene", Gene);
			Datos.PutExtra("Clasi", Clasi);
			Datos.PutExtra("Dura", Dura);
			Datos.PutExtra("Dire", Dire);
			Datos.PutExtra("Acto", Acto);
			Datos.PutExtra("Sino", Sino);
			Datos.PutExtra("Fe", Fe);
			StartActivity(Datos);
		}
	}
}

