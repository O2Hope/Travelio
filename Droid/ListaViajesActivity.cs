
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Travelio.Helpers;
using Travelio.Models;

namespace Travelio.Droid
{
    [Activity(Label = "ListaViajesActivity")]
    public class ListaViajesActivity : ListActivity
    {
        List<Viaje> viajes;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            CargarViajes();
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            CargarViajes();
     
        }

        void CargarViajes()
        {
            string nombreArchivo = "viajes_db.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string ruta = Path.Combine(rutaCarpeta, nombreArchivo);

            viajes = new List<Viaje>();
            viajes = DatabaseHelper.Viajes(ruta);

            if (viajes != null)
            {
                var arrayAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, viajes);
                ListAdapter = arrayAdapter;
            }
        }
    }
}
