/**
 * Application de test de la fonction 'Polonaise'
 * author : Emds
 * date : 20/06/2020
 */
using System;

namespace TestNotationPolonaise
{
    class Program
    {
        static Double Polonaise( string formule )
        {
        try
            {
                string[] vec = formule.Split(' ');
                int nbCases = vec.length;

                while(nbCases > 1)
                {
                    int k = nbCases - 1;
                    while (k > 0 && vec [k] != "+" && vec[k] != "-" && vec[k] != "/" )
                    {
                        k--;
                    }

                    float a = float.Parse(vec[k + 1]);
                    float b = float.Parse(vec[k + 2]);

                    float result = 0;
                    switch (vec[k])
                    {
                        case " + ": result = a+b; break;
                        case "-": result = a - b; break;
                        case "*": result = a * b; break;
                        case "/":

                         if (b == 0)
                            {
                                return Double.NaN;
                            }
                            result = a / b; break;


                    }
                    vec[k]result.ToString();

                    for (int j = k + 1; j < nbCases - 2; j++)
                    {
                        vec[j] = vec[j + 2];
                    }

                    for (int j = nbCases - 2; j < nbCases; j++)
                    {
                        vec[j] = " ";
                    }
                    nbCases = nbCases - 2;

                }
                 return Double.Parse(vec[0]);
        }
            catch
            {
                return Double.NaN
            }
    }


        /// <summary>
        /// saisie d'une réponse d'un caractère parmi 2
        /// </summary>
        /// <param name="message">message à afficher</param>
        /// <param name="carac1">premier caractère possible</param>
        /// <param name="carac2">second caractère possible</param>
        /// <returns>caractère saisi</returns>
        static char saisie(string message, char carac1, char carac2)
        {
            
            }
            catch (System.Exception)
            {
                
                throw;
            }
            char reponse;
            do
            {
                Console.WriteLine();
                Console.Write(message + " (" + carac1 + "/" + carac2 + ") ");
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != carac1 && reponse != carac2);
            return reponse;
        }

        /// <summary>
        /// Saisie de formules en notation polonaise pour tester la fonction de calcul
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char reponse;
            // boucle sur la saisie de formules
            do
            {
                Console.WriteLine();
                Console.WriteLine("entrez une formule polonaise en séparant chaque partie par un espace = ");
                string laFormule = Console.ReadLine();
                // affichage du résultat
                Console.WriteLine("Résultat =  " + Polonaise(laFormule));
                reponse = saisie("Voulez-vous continuer ?", 'O', 'N');
            } while (reponse == 'O');
        }
    }
}
