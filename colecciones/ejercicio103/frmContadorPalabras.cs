using System.Text;

namespace ejercicio103
{
    public partial class frmContadorPalabras : Form
    {
        public frmContadorPalabras()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();

            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);
            MostrarPodio(podio);
        }
        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder podioSB = new StringBuilder();

            if (podio.Count == 0)
            {
                podioSB.AppendLine("No se ingresaron palabras");
            }
            else
            {
                for (int i = 0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    podioSB.AppendLine($"Palabra {par.Key} - Cantidad {par.Value}");

                }
                //foreach (KeyValuePair<string, int> par in podio)
                //{
                //    podioSB.AppendLine($"Palabra {par.Key} - Cantidad {par.Value}");
                //}
            }
            MessageBox.Show(podioSB.ToString(), "Podio");
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            /*
            if(primerElemento.Value < segundoElemento.Value) 
            {
                return -1;
            }
            if (primerElemento.Value > segundoElemento.Value)
            {
                return 1;
            }

            return 0;
            */
            //como son numeros podemos hacerlo asi y nos ahorramos los if
            return segundoElemento.Value - primerElemento.Value;

        }
        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = txtPalabras.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }

            }
            return contadorPalabras;
        }

       
    }
}