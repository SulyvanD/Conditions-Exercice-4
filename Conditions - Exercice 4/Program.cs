using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions___Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string password = "admin";
            string user_login, user_password;

            Console.WriteLine("Entrez votre identifiant");
            user_login = Console.ReadLine();
            Console.WriteLine("Entrez votre mot de passe");
            user_password = Console.ReadLine();

            if (user_login == login)
            {
                if (user_password == password)
                {
                    Console.WriteLine("Bienvenue à la Manu le Havre.");
                }
                else
                {
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                }
            }
            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
            }
        }
    }
}
