using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace ViajesApp.Droid
{
    [Activity(Label = "ViajesApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText nombreusuarioEditText, passwordEditText;
        Button inicioSessionButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            nombreusuarioEditText = FindViewById<EditText>(Resource.Id.usuarioEditText);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);
            inicioSessionButton = FindViewById<Button>(Resource.Id.inicioSesionButton);

            inicioSessionButton.Click += InicioSessionButton_Clicked;
        }

        private void InicioSessionButton_Clicked (object sender, EventArgs argumentos)
        {
            if(string.IsNullOrEmpty(nombreusuarioEditText.Text) || string.IsNullOrEmpty(passwordEditText.Text))
            {

            }
            else
            {
                //hacer: navegar a la pagina principal
            }
        }
    }
}

