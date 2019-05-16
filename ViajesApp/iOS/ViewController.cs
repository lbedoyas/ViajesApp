using System;

using UIKit;

namespace ViajesApp.iOS
{
    public partial class ViewController : UIViewController
    {


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Code to start the Xamarin Test Cloud Agent
                #if ENABLE_TEST_CLOUD
                			Xamarin.Calabash.Start ();
                #endif

            inicioSesionButton.TouchUpInside += InicioSesionButton_TouchUpInside;


        }

        void InicioSesionButton_TouchUpInside(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(usuarioTextField.Text) || string.IsNullOrEmpty(passwordTextField.Text))
            {

            }
            else
            {
                // hacer: agregar navegacion
            }
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
