using System;

namespace CreationCompte
{
    class Program
    {
        static void Main(string[] args)
        {
           CréerCompte();
        }

        static void CréerCompte()
        {
            Console.WriteLine("Veuillez saisir votre login et votre Mot de Passe");
            string login = Console.ReadLine();
            string password = Console.ReadLine();

            try
            {
                checkLogin(login);
                checkPassword(password);
                Console.WriteLine("Votre compte a bien été créé. Un message vient de vous être envoyé");
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }

            static void checkLogin(string login)
            {
                if (login.Length < 5)
                {
                    throw new FormatException("Le login doit contenir au moins 5 caractères");
                }
            }

            static void checkPassword(string password)
            {

                bool hasLetter = false, hasNumber = false; //on met false car on veut qu'il le vérifie

                if (password.Length < 6)
                {
                    throw new FormatException("Le mot de passe doit contenir au moins 6 caractères");
                }

                foreach (char c in password)
                {
                    if (c >=48 & c <= 57)
                    {
                        hasNumber = true;
                    }

                    if ((c >= 65 & c <= 90) || (c >= 97 & c <= 122))
                    {
                        hasLetter = true;
                    }
                }

                if (!hasLetter || !hasNumber)
                    {
                    throw new FormatException("Votre mot de passe doit contenir au moins une lettre et un chiffre.");
                    }

            }
        }



    }
}
