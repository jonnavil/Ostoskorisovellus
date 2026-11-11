using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
    List<string> tuotteet = new List<string>();

    tuotteet.Add("maito");
    tuotteet.Add("leipä");
    tuotteet.Add("voi");
    tuotteet.Add("juusto");

    List<double> hinnat = new List<double>();
    hinnat.Add(1.50);
    hinnat.Add(2.00);
    hinnat.Add(3.00);
    hinnat.Add(4.00);

    List<string> ostoskori = new List<string>();

    while (true)
    {
      Console.WriteLine("Lisää tuotteet ostoskoriin tai kirjoita 'kassalle' mennäksesi kassalle:");
      string tuote = Console.ReadLine();
      if (tuote == "kassalle")
      {break;}

    ostoskori.Add (tuote);
    }

    Console.WriteLine ("Ostoskorisi sisältää seuraavat tuotteet: ");
    foreach (string tuote in ostoskori)
    Console.WriteLine (tuote);

    Console.WriteLine ("Ostoskorin summa yhteensä");
    }
  }