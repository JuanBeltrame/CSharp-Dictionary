namespace Dictionary_Practice_04__Windows_Forms_
{
    public partial class FrmContadorPalabras : Form
    {
        public FrmContadorPalabras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = rtxtContadorPalabras.Text;
            string[] palabras = texto.Split(' ');
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
        }
    }
}
