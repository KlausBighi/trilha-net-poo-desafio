using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo;
        private string IMEI;
        private string Memoria;

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

            
        }

        //Método Adicional
        //---------------------------------------------------
        public void ExibirDados()
        {
            Console.WriteLine($"Smartphone: {Modelo}");
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}");
        }
        //---------------------------------------------------

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}