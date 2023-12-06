using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Practice_02
{
    internal class Auto
    {
        private string patente;
        private string marca;
        public int modelo;


        public Auto(string patente, string marca, int modelo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Patente: {patente}");
            sb.AppendLine($"Marca: {marca}");
            sb.AppendLine($"Modelo: {modelo}");

            return sb.ToString();
        }
    }
}
