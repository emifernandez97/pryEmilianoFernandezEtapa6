using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEmilianoFernandezEtapa2
{
    internal class clsVehiculo
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Image Imagen { get; set; }

        public List <PictureBox> listaVehiculo = new List <PictureBox> ();

        public System.Windows.Forms.Timer timerMovimientoSuculento = new System.Windows.Forms.Timer();

        public PictureBox pctVehiculo = new PictureBox ();
        //Metodos

        public void crearVehiculo(PictureBox Vehiculo) //pct del formulario
        {
            PictureBox ImagenVehiculo = new PictureBox(); //instancio en memora imagen

            Random rnd = new Random(); //creo random

            // Generar una posición aleatoria dentro del PictureBox contenedor
            int posX = rnd.Next(0, Vehiculo.Width - 50);
            int posY = rnd.Next(0, Vehiculo.Height - 100);

            switch (rnd.Next(1,4))  //para cada caso un random
            {
                case 1:
                    Imagen = pryEmilianoFernandezEtapa6.Properties.Resources.Rayo_Mckuin;
                    break;
                case 2:
                    Imagen = pryEmilianoFernandezEtapa6.Properties.Resources.CAPTAIN_removebg_preview;
                    break;
                case 3:
                    Imagen = pryEmilianoFernandezEtapa6.Properties.Resources.jay_jay_removebg_preview;
                    break;
            }

            ImagenVehiculo.Image = Imagen;
            ImagenVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenVehiculo.Location = new Point (posX,posY);
            ImagenVehiculo.Size = new Size(60 , 60);
            ImagenVehiculo.BackColor = Color.White;
            Vehiculo.Controls.Add(ImagenVehiculo);

            listaVehiculo.Add(ImagenVehiculo);

            ImagenVehiculo.BringToFront();          
        }

        /*public void moverVehiculo()
        {
            Random random = new Random(); // Necesario para generar números aleatorios
            timerMovimientoSuculento.Start();

            foreach (var vehiculo in listaVehiculo)
            {
                // Generar un número aleatorio entre 0 y 3 para seleccionar una dirección
                int direccion = random.Next(4);

                // Mover el vehículo en la dirección correspondiente
                switch (direccion)
                {
                    case 0: // Arriba
                        vehiculo.Top -= 10; // Puedes ajustar el valor de acuerdo a la velocidad deseada
                        break;
                    case 1: // Abajo
                        vehiculo.Top += 10; // Puedes ajustar el valor de acuerdo a la velocidad deseada
                        break;
                    case 2: // Izquierda
                        vehiculo.Left -= 10; // Puedes ajustar el valor de acuerdo a la velocidad deseada
                        break;
                    case 3: // Derecha
                        vehiculo.Left += 10; // Puedes ajustar el valor de acuerdo a la velocidad deseada
                        break;
                }
            }
        }*/

        private Random random = new Random();
        public void moverVehiculo(PictureBox pctMovilidad)
        {
            timerMovimientoSuculento.Start();
            pctVehiculo = pctMovilidad;

            foreach (var vehiculo in listaVehiculo)
            {
                // Generar un número aleatorio entre 0 y 3 para seleccionar una dirección
                int direccion = random.Next(4);

                // Variables para almacenar las nuevas coordenadas del vehículo
                int nuevoTop = vehiculo.Top;
                int nuevoLeft = vehiculo.Left;

                // Mover el vehículo en la dirección correspondiente
                switch (direccion)
                {
                    case 0: // Arriba
                        nuevoTop -= 10; // Puedes ajustar el valor de acuerdo a la velocidad deseada
                        break;
                    case 1: // Abajo
                        nuevoTop += 10; // Puedes ajustar el valor de acuerdo a la velocidad deseada
                        break;
                    case 2: // Izquierda
                        nuevoLeft -= 10; // Puedes ajustar el valor de acuerdo a la velocidad deseada
                        break;
                    case 3: // Derecha
                        nuevoLeft += 10; // Puedes ajustar el valor de acuerdo a la velocidad deseada
                        break;
                }

                // Verificar si el movimiento mantendrá al vehículo dentro de los límites del PictureBox
                if (nuevoTop >= 0 && nuevoTop + vehiculo.Height <= pctVehiculo.Height &&
                    nuevoLeft >= 0 && nuevoLeft + vehiculo.Width <= pctVehiculo.Width)
                {
                    // Aplicar los nuevos valores de posición si el movimiento es válido
                    vehiculo.Top = nuevoTop;
                    vehiculo.Left = nuevoLeft;
                }
            }
        }

        public void timerMovimientoSuculento_Tick(object sender, EventArgs e) 
        {
            moverVehiculo(pctVehiculo);
        }

    }
}
