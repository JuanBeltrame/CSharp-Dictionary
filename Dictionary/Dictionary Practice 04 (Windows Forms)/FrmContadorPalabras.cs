using System.Text;

namespace Dictionary_Practice_04__Windows_Forms_
{
    public partial class FrmContadorPalabras : Form
    {
        public FrmContadorPalabras()
        {
            InitializeComponent();
        }

        // 4 hola
        // 3 chau
        // 2 que
        // 1 programacion segundo adios
        // hola hola hola hola chau que que programacion segundio adios chau chau

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> podio = ObtenerPodio(contadorPalabras);
            MostrarPodio(podio);
        }

        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);

            return podio;
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (podio.Count == 0)
            {
                stringBuilder.AppendLine("No se ingresaron palabras...");
            }
            else
            {
                for (int i = 0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }


                //foreach (KeyValuePair<string, int> par in podio)
                //{
                //    stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                //}
            }

            MessageBox.Show(stringBuilder.ToString(), "Podio");
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }

        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = rtxtContadorPalabras.Text;
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
