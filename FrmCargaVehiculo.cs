namespace pryEmilianoFernandezEtapa2
{
    public partial class FrmCargaVehiculo : Form
    {
        clsVehiculo objetoVehiculo;
        private System.Windows.Forms.Timer timerColision = new System.Windows.Forms.Timer();

        public FrmCargaVehiculo()
        {
            InitializeComponent();
            objetoVehiculo = new clsVehiculo();

            timerColision.Interval = 200; // intervalo milesima * seg
            timerColision.Tick += timerColision_Tick;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Int32 CantidadVehiculos = Convert.ToInt32(txtCantidadVehiculo.Text);
            Int32 Contador = 0;

            while (CantidadVehiculos > Contador)
            {
                objetoVehiculo.crearVehiculo(PctVehiculo);
                Contador++;
            }

            txtCantidadVehiculo.Clear();
        }

        private void timerColision_Tick(object sender, EventArgs e)
        {

            int count = objetoVehiculo.listaVehiculo.Count;

            for (int i = 0; i < count; i++)
            {
                var vehiculo1 = objetoVehiculo.listaVehiculo[i];

                for (int j = i + 1; j < count; j++)
                {
                    var vehiculo2 = objetoVehiculo.listaVehiculo[j];

                    if (vehiculo1.Bounds.IntersectsWith(vehiculo2.Bounds))
                    {
                        vehiculo1.Visible = false;
                        vehiculo2.Visible = false;

                        objetoVehiculo.listaVehiculo.Remove(vehiculo1);
                        objetoVehiculo.listaVehiculo.Remove(vehiculo2);

                        count -= 2; // contador para la cantidad cambiante de vehículos
                        i--; // índice para la próxima iteración
                        break; // Sale del bucle interior ya que hemos encontrado una colisión
                    }
                }
            }

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            objetoVehiculo.timerMovimientoSuculento.Interval = 50; // intervalo milesima * seg
            objetoVehiculo.timerMovimientoSuculento.Tick += objetoVehiculo.timerMovimientoSuculento_Tick;
            timerColision.Start();
            objetoVehiculo.moverVehiculo(PctVehiculo);

            //BtnCargar.Enabled = false;
            //btnMover.Enabled = false;
        }

        private void PctVehiculo_Click(object sender, EventArgs e)
        {

        }
    }
}
