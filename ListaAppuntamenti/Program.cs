using ListaAppuntamenti;

 List<Appuntamenti> ListaAppuntamenti = new List<Appuntamenti>();

Console.WriteLine("quanti appuntamenti vuoi inserire?");
int nAppuntamenti=int.Parse(Console.ReadLine());
for (int i = 0; i < nAppuntamenti; i++)
{

    Console.WriteLine("inserisci il nome dell'appuntamento");
    string NomeAppuntamentoUtente = Console.ReadLine();


    Console.WriteLine("inserisci la Località dell'appuntamento");
    string LocalitaAppuntamentoUtente = Console.ReadLine();
    bool datacoretta = false;
    while (!datacoretta)
    { 
        try
        {
            Console.WriteLine("inserisci La data dell'appuntamento");
            DateTime DataOraUtente = DateTime.Parse(Console.ReadLine());
            Appuntamenti mioAppuntamento = new Appuntamenti(DataOraUtente, NomeAppuntamentoUtente, LocalitaAppuntamentoUtente);
            ListaAppuntamenti.Add(mioAppuntamento);
        }

        catch (InvalidDataException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}
foreach(Appuntamenti appuntamenti in ListaAppuntamenti)
{
    Console.WriteLine(appuntamenti.ToString());
}

Console.WriteLine("Vuoi cambiare Data? (si/no)");
string Scelta=Console.ReadLine();
Scelta=Scelta.ToLower();

switch(Scelta)
{
    case "si":
        Console.WriteLine("Quale appuntamento vuoi modificare? (inserisci il nome )");
        string NomeAppuntamentoDaModificare=Console.ReadLine();
        bool NomeTrovato = false;
        for(int i=0;i<ListaAppuntamenti.Count;i++)
        {

        }
}



