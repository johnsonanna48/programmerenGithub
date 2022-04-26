using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Documents.Users.annat.Documents.GitHubprogrammeren
{
    public class StudentMonkeySeeMonkeyDoo

    {
                public static uint studententeller;
                private static List<StudentMonkeySeeMonkeyDoo> Allestudenten = new List<StudentMonkeySeeMonkeyDoo>();
                public static immutableList<StudentMonkeySeeMonkeyDoo> Allestudenten {
                    get{
                        return Allestudenten.ToimmutableList();
                    }
                }        
                public string naam;
                public DateTime Geboortedatum;
                public uint Studentennummer;
                private vakinschrijving[] vakinschrijvingen = new vakinschrijving[5];

                public StudentMonkeySeeMonkeyDoo( string Naam, DateTime Geboortedatum){
                    Naam = naam;
                    Geboortedatum = Geboortedatum;
                    Allestudenten.Add(this);
                }
                public byte BepaalWerkbelastingmonkeyseemonkeydoo(){
                    byte werkbelasting = 0;
                    for (int i = 0; i < vakinschrijvingen.Length; i++)
                    {
                        if (vakinschrijvingen is not null)
                        {
                            werkbelasting +=10;                            
                        }                       
                    } return werkbelasting;
            }
                public double GemiddeldeMonkeySeeMonkeyDoo(){
                        int aantalCursussen = 0;
                        double som = 0.0;
                        for (int i = 0; i < vakinschrijvingen.Length;i++)
                       {
                            if (vakinschrijvingen[i] is not null)
                            {

                              if ( vakinschrijvingen[i].Resultaat is not null)
                                 { som += (byte)vakinschrijvingen[i].Resultaat;
                                 aantalCursussen++;
                                }
                            }
                        } return som /aantalCursussen;       
                }
                        public string GenereerNaamkaarjeMonkeySeeMonkeyDoo(){
                            return $"{Naam} (STUDENT)";
                        }
public void kwoteerMonkeyseeMonkeyDoo( byte cursusIndex, byte behaaldResulaat){
    if (cursusindex < 0|| cursusIndex >= Vakinschrijvingen.Length || Vakinschrijvingen[cursusIndex] is null || behaaldResultaat > 20 )
    {
        Console.WriteLine("Ongelding Cijfeer je bent een gekke aap! ");
    }
    else 
    {
        vakinschrijvingen[cursusIndex].Resultaat = behaaldResulaat;
    }
}



    
    
    
    }       




}