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

            this.DataOra = DataOra;
            this.NomeAppuntamento = NomeAppuntamento;
            this.LocalitaAppuntamento = LocaltaAppuntamento;

            if (DataOra < DateTime.Now)
            {
                throw new Exception("La data è  troppo vecchia");
            }
        }


        public void CambioDataOra(DateTime NuovaDataOra)
        {
          

                if (NuovaDataOra < DateTime.Now)
                {
                    throw new InvalidDataException("La data NON è VALIDA");
                }
                else
                {
                     this.DataOra= NuovaDataOra;
                }
          
        }


        public string GetNomeAppuntamento()
        {
            return NomeAppuntamento;
        }


        public string GetLocalitaAppuntamento()
        {
            return LocalitaAppuntamento;
        }

        public void ModificaNome(string nuovoNomeAppuntamento)
        {
           
        this.NomeAppuntamento= nuovoNomeAppuntamento;
        }

        public void ModificaLocalita(string nuovaLocalitaAppuntamento)
        {
            
           this.LocalitaAppuntamento= nuovaLocalitaAppuntamento;



        }


        public  override string ToString()
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
