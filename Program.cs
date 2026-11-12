using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {

      //Luodaan lista tuotteille ja niiden hinnoille
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

    Console.WriteLine("Tervetuloa ostoskoriin! Tässä on tuotteet ja niiden hinnat: ");
    Console.WriteLine("Tuote & hinta:");
    Console.WriteLine("maito/1.50, leipä/2.00, voi/3.00, juusto/4.00");

    //luodaan ostoskori, johon käyttäjä voi lisätä tuotteita
    List<string> ostoskori = new List<string>();

  
    while (true)
    {
      Console.WriteLine("Lisää tuotteet ostoskoriin tai kirjoita 'kassalle' mennäksesi kassalle:");
      string tuote = Console.ReadLine();
      if (tuote == "kassalle")
      {break;}

    ostoskori.Add (tuote);
    }

    //käydään läpi ostoskori ja tulostetaan tuotteet
    Console.WriteLine ("Ostoskorisi sisältää seuraavat tuotteet: ");

    foreach (string tuote in ostoskori)
    Console.WriteLine (tuote);

    Console.WriteLine ("Ostoskorin summa yhteensä");
    }
  }