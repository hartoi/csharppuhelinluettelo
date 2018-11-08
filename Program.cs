// Tehtävä muokkaa koodista puhelinluettelo, jossa käyttäjä voi syöttää nimen
// ja ohjelma tarkistaa onko numero puhelinluettelossa, jos se ei ole, ohjelma kertoo sen
// jos se on, niin numero tulostetaan 
// Lisähaaste: Lisää sanakirjaan sukunimi-sarake ja muokkaa ohjelmaa, niin että voidaan
// hakea joko sukunimen tai etunimen mukaan
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Kokeile alla olevaa ja koita saada hakutoiminto toimimaan
        // sen avulla, niin että for-silmukassa hyödynnetään contains-funktioita
        // Luodaan sanakirja-muuttujarakenne
        Dictionary<string, string> puhelin_luettelo = new Dictionary<string, string>();
        
        // Lisätään siihen tietoa
        puhelin_luettelo.Add("Pekka Heikera", "040234345");
        puhelin_luettelo.Add("Jorma", "050123345");
        puhelin_luettelo.Add("Jorma Kariluoto", "050123345");
        puhelin_luettelo.Add("Kalle", "050666666");
        // Esimerkki
        Console.WriteLine("Esim Jorma:"+puhelin_luettelo["Jorma"]);
        // Tehtävä 1: Lisää puhelinluetteloon yksi nimi
        // ja tulosta se nimi

        // Tehtävä 2: Tulosta koko puhelinluettelon sisältö
        // Hyödynnä tätä
        // List<string> nimet = new List<string>(puhelin_luettelo.Keys);

        // Luetaan avaimet ( Pekka Heikera, Jorma, Jorma Kariluoto, Kalle )
        // ne nimet listaan
        // tämän jälkeen esim nimet[0] == "Pekka Heikera"
        List<string> nimet = new List<string>(puhelin_luettelo.Keys);

        // Kysytään käyttäjältä hakuehto
        Console.WriteLine("Syötä hakuehto:");
        string haettava_nimi = Console.ReadLine();

        // Luupataan kaikki nimeto läpi, eli 
        // nimi muuttuja saa arvot ( Pekka Heikera, Jorma, Jorma Kariluoto, Kalle )
        for (int i = 0; i < nimet.Count; i++)
        {
            string nimi = nimet[i];
            // Jos nimi-muuttuja sisältää hakuehdon, niin silloin
            // sanotaan true tai false
            Console.WriteLine("Etsitään avaimesta " + nimi + " hakusana " + haettava_nimi);
            if (nimi.Contains(haettava_nimi) == true)
            {
                Console.WriteLine("Löytyi");
                //  Halutaan tulostaa myös puhelinnumero
            }
            else
            {
                Console.WriteLine("Ei löytynyt");
            }
            /*
            if (){
               Console.WriteLine(nimi + " " + puhelin_luettelo[nimi]);
            }*/
        } // for
        // Lopetetaan ohjelma
        System.Environment.Exit(1);
    } // main


} // class