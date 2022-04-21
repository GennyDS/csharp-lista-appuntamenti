using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamenti
    {
        private DateTime DataOra;
        private string NomeAppuntamento;
        private string LocalitaAppuntamento; 



        public Appuntamenti(DateTime DataOra, string NomeAppuntamento, string LocaltaAppuntamento)
        {

            this.DataOra = DataOra = DateTime.Now;
            this.NomeAppuntamento = NomeAppuntamento;
            this.LocalitaAppuntamento = LocaltaAppuntamento;
            try
            {
                
            }
            catch (Exception ex)
            {

            }
        }


        public void CambioDataOra(DateTime NuovaDataOra)
        {
            do
            {
                Console.WriteLine("inserisci una nuova data");
                NuovaDataOra = DateTime.Parse(Console.ReadLine());


                if (NuovaDataOra < DataOra)
                {
                    throw new Exception("La data NON è VALIDA");
                }

            } while (NuovaDataOra > DataOra);
        }


        public string GetNomeAppuntamento()
        {
            return NomeAppuntamento;
        }


        public string GetLocalitaAppuntamento()
        {
            return LocalitaAppuntamento;
        }

        public string ModificaNome(string nuovoNomeAppuntamento)
        {
            Console.WriteLine("inserisci un nuovo nome appuntamento");
            nuovoNomeAppuntamento = Console.ReadLine();
            return nuovoNomeAppuntamento;
        }

        public string ModificaLocalita(string nuovaLocalitaAppuntamento)
        {
            Console.WriteLine("inserisci una nuova località");
            nuovaLocalitaAppuntamento = Console.ReadLine();
            return nuovaLocalitaAppuntamento;



        }


        public  string ToString()
        {
            string rappresentazioneInStringa = "";

            rappresentazioneInStringa += "---- Appuntamento ---- \n";
            rappresentazioneInStringa += "Nome: " + this.NomeAppuntamento + "\n";
            rappresentazioneInStringa += "Descrizione: " + this.LocalitaAppuntamento + "\n";
            rappresentazioneInStringa += "Prezzo: " + this.DataOra + "\n";

            return rappresentazioneInStringa;
        }






    }
    }
