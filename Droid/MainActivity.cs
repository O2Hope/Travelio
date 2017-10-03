using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Travelio.Droid
{
    [Activity(Label = "Travelio", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText etUsuario, etPassword;
        Button btnIniciar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            etUsuario = FindViewById<EditText>(Resource.Id.etUsuario);
            etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            btnIniciar = FindViewById<Button>(Resource.Id.btnEntrar);

            btnIniciar.Click += BtnIniciar_Click;
        }

        void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(etUsuario.Text) || String.IsNullOrEmpty(etPassword.Text))
            {
                //TODO: Alerta a usuario por falta de datos
            }
            else
            {
                //TODO: Navegacion a pagina principal
            }
        }

    }
}

