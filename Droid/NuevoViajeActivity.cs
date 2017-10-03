
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
using Travelio.Models;
using Travelio.Helpers;
using System.IO;

namespace Travelio.Droid
{
    [Activity(Label = "NuevoViajeActivity")]
    public class NuevoViajeActivity : Activity
    {
        EditText ciudad;
        DatePicker salida, regreso;
        Button btnGuardar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NuevoViaje);

            ciudad = FindViewById<EditText>(Resource.Id.etLugar);
            salida = FindViewById<DatePicker>(Resource.Id.dpIda);
            regreso = FindViewById<DatePicker>(Resource.Id.dpRegreso);
            btnGuardar = FindViewById<Button>(Resource.Id.btnGuardar);

            btnGuardar.Click += BtnGuardar_Click;
        }

        void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ciudad.Text))
            {

                string nombreArchivo = "viajes_db.sqlite";
                string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string ruta = Path.Combine(rutaCarpeta, nombreArchivo);

                var viaje = new Viaje()
                {
                    Nombre = ciudad.Text,
                    FechaInicio = salida.DateTime,
                    FechaRegreso = regreso.DateTime
                };

                if (DatabaseHelper.Insert(ref viaje, ruta))
                    Toast.MakeText(this, $"Se agrego la ciudad {ciudad.Text}", ToastLength.Short);
                else
                    Toast.MakeText(this, $"Error al agregar la ciudad", ToastLength.Short);

            }
            else
                Toast.MakeText(this, "Favor de introducir una ciudad", ToastLength.Short);

        }
    }
}
