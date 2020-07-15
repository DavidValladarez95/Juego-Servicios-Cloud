using System;
using System.Collections.Generic;
using System.Text;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.ComponentModel.Design;

namespace Juego.BL
{
    class RegistrationLogicFirebase
    {

        public RegistrationLogicFirebase()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "LIXXDJh0Z6D3mP8ZaGNIQuax2SiRZOGxKgrl00Vv",
            BasePath = "https://juego-servicios-cloud-usuarios.firebaseio.com/"
        };

        IFirebaseClient client;

        private void InitializeComponent()
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

            }
            catch
            {
                Console.WriteLine("Existe un error de conexion - Contacte con el administrador XD ");
            }
        }
    }
}
