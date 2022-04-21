using ListaAppuntamenti;





 List<Appuntamenti> ListaAppuntamenti = new List<Appuntamenti>();

Console.WriteLine("quanti appuntamenti vuoi inserire?");
int nAppuntamenti=int.Parse(Console.ReadLine());
for(int i = 0; i < nAppuntamenti; i++)
{
    
        Console.WriteLine("inserisci il nome dell'appuntamento");
    string NomeAppuntamentoUtente = Console.ReadLine();


    Console.WriteLine("inserisci la Località dell'appuntamento");
    string LocalitaAppuntamentoUtente = Console.ReadLine();
    
    try
    {
        Console.WriteLine("inserisci La data dell'appuntamento");
        DateTime DataOraUtente = DateTime.Parse(Console.ReadLine());
        Appuntamenti mioAppuntamento = new Appuntamenti(DataOraUtente, NomeAppuntamentoUtente, LocalitaAppuntamentoUtente);
        ListaAppuntamenti.Add(mioAppuntamento);
    }
     
    catch (Exception ex)
    {
       
        Console.WriteLine(ex.Message);
    }

}

ListaAppuntamenti.ToString();


