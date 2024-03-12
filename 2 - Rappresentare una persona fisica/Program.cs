using System;

class Persona
{
    private string _nome;
    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }
    private string _cognome;
    public string Cognome
    {
        get => _cognome;
        set => _cognome = value;
    }
    private string _codicefiscale;
    public string Codicefiscale
    {
        get => _codicefiscale;
        set => _codicefiscale = value;
    }
    private bool _registrato;
    public bool Registrato
    {
        get => _registrato;
        set => _registrato = value;
    }
    public void Registra()
    {
        Registrato = true;
        Console.WriteLine("\nLa persona è stata registra.");
    }
    public void Mostra()
    {
        Console.WriteLine($"{Nome} {Cognome} ha il seguente codice fiscale: {Codicefiscale}.");
    }
}
class Program
{
    static void Main()
    {
        Persona persona1 = new Persona();
        string answer;

        Console.WriteLine("Vuoi registrare una persona?");
        answer = Console.ReadLine();

        if (answer.ToUpper() == "SI")
        {
            Console.Write("Inserire il nome della persona: ");
            persona1.Nome = Console.ReadLine();

            Console.Write("Inserire il cognome della persona: ");
            persona1.Cognome = Console.ReadLine();

            Console.Write("Inserire il codice fiscale: ");
            persona1.Codicefiscale = Console.ReadLine();

            persona1.Registra();
            persona1.Mostra();
            Console.ReadKey();
        }
        else
        {
            Environment.Exit(0);
        }
    }
}