using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {




            Random aleatoire = new Random();
            int intelligence = 0;
            int trouGalactique = aleatoire.Next(1, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            bool finPartie1 = false;
            int choix = 0;

            while (finPartie1 == false)
            {

                Console.WriteLine("Entrainement Maitrise One For All"); //Niveau 0
                Console.WriteLine("Niveau 0");
                Console.WriteLine("Vous voyez 2 robots facilement eliminables a votre gauche, mais une fille est en peril a votre droite");
                Console.WriteLine("Que faites-vous : 1 -Detruire les 2 robots 2 -Sauver la fille   3- Detruire les 2 robots et sauver la fille");
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 5)
                {
                    Console.WriteLine("Mission Réussi mais risque trop grand");
                    Console.WriteLine("Vous ne pouvez plus continuer l'epreuve dans cet état");
                    Console.WriteLine("Reprendre");

                }

                else if (choix == 1)// Detruire les deux robots
                {
                    Console.WriteLine("Choix tres Froid pour un futur Hero!!");
                    Console.WriteLine("Echec de l'epreuve");

                }
                else if (choix == 2)// Sauver la fille          
                {
                    Console.WriteLine("Bien Réflechi!! Battre rapidement les deux robots");
                    Console.WriteLine("Niveau 1");// Niveau 1     
                    finPartie1 = true;
                }
                else if (choix == 3)// Detruire les 2 robots et sauver la fille
                {
                    Console.WriteLine("Plus Ultra; Mission accomplie Passez au niveau 1");
                    Console.WriteLine("Niveau 1");// Niveau 1              
                    finPartie1 = true;

                    {


                    }
                }
            }


            Console.WriteLine("A la suite de votre niveau, vous voyez 4 autres robots eliminables, a votre gauche vous en avez deux petits facilements eleminables, et a droite 2 autres Plus grands et coriaces");
            Console.WriteLine("Que faites-vous : 1 -Allez vous a droite?! 2 -Allez vous a gauche?!");
            choix = int.Parse(Console.ReadLine());
            if (choix == 1)
            {
                Console.WriteLine("Plus Ultra, Vous avez pris le bon chemin et Il vous reste juste 1 robots a abattre");
                Console.WriteLine("Niveau 2");// Niveau 2  

            }

            if (choix == 4)
            {

                Console.WriteLine("Vous avez pris le risque, mais vous avez reussi a sauver la fille tout en faisant attention");
                Console.WriteLine("Plus Ultra: Passer au Niveau 2");
                Console.WriteLine("Niveau 2");
            }
            if (choix == 2)
            {
                Console.WriteLine("Vous avez eliminez les deux robots a gauche mais egarer votre chemin");
                Console.WriteLine("Niveau 2-1"); // Niveau 2-1
                Console.WriteLine("HA La vous etes dans une embuscade, et pour pouvoir retrouver votre chemin vous devez décuplez votre intelligence et pour cela vous devez choiosir l'une des deux options");
                Console.WriteLine("1- Intelligence a 100  2- Intelligence a 50");
                intelligence = int.Parse(Console.ReadLine());


            }

            if (intelligence == 50)

            {
                Console.WriteLine("Vous avez choisi une intelligence a la moyenne, recommandé pour un débutant et avez pu retrouvé votre chemin, Epreuve Reussi");
                Console.WriteLine("Niveau 2-2");
                Console.WriteLine("Le Dernier Robot detient en captivité sur sa main droite une autre fille, vous devez la sauvé sans qu'elle ne soit blessé");
                Console.WriteLine("Pour cela vous pouvez soit 1- Couper la main du robot et proteger la fille 2- Eliminer le robot en utilisant le smash(risque de blessé la fille)");
                choix = int.Parse(Console.ReadLine());

            }
            if (intelligence == 100)

            {
                Console.WriteLine("Vous avez choisi une intelligence Max a 100, mais pour terminer l'epreuve, il se pose un dernier robot assez Coriace devant vous et vous devez l'éliminer pour la réussir");
                Console.WriteLine("Vous avez la possibilité d'utliser le Détroit Smash pour vaincre le robot rapidement mais avec 100& de chance de perdre votre bras ou combattre le robot sans pouvoir l'eliminer");
                Console.WriteLine("Que faites vous: 5- Utiliser le Détroit Smash 6-Combattre le robot sans attaque spéeciale");
                choix = int.Parse(Console.ReadLine());
            }

            if (choix == 6)
            {
                Console.WriteLine("Vous avez combattu le puissant robot de tout vos efforts et n'avez finalement pas pu l'éeliminer et l'épreuve est terminée ");
                Console.WriteLine("Épreuve Reussi: Vous avez fait le bon choix, car il faut parfois se retirer qund l'enemie est plus que nous quit a perdre la Vie au combat pour rien");
            }

            Console.WriteLine("Le Dernier Robot detient en captivité sur sa main droite une autre fille, vous devez la sauvé sans qu'elle ne soit blessé");//Niveau 2-3
            Console.WriteLine("Niveau 2-3");
            Console.WriteLine("Pour cela vous pouvez soit 1- Couper la main du robot et proteger la fille 2- Eliminer le robot en utilisant le smash(risque de blessé la fille)");

            if (choix == 1)
                choix = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("Vous avez sauvez la fille intelligement digne d'un heros ");
                Console.WriteLine("Plus Ultra: Passer au Niveau Suivant");// Niveau 3
                Console.WriteLine("Niveau 3");
            }

            if (choix == 2)
                choix = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine("Vous avez pris le risque,et la fille a été sérieusement blessé");
                Console.WriteLine("Reprendre le Niveau");

            }

            Console.WriteLine("A la Derniere epreuve se dresse ALL MIGHT devant vous et vous devez etre capable de le toucher pour acquerir votre maitre du One For All");
            Console.WriteLine("Vous avez acqueris des connaissances et augmenter votre niveau le long de votre entrainement et la se dresse l'ultime impasse devant vous qu'allez vous faire pour detenir la force ultime");
            Console.WriteLine("Dans cette ultime épreuve vous avez la possibilité de faire équipe avec Todoroki, maitrisant le feu et la glace!!");
            Console.WriteLine("Voici les séries de choix que s'offrent a vous pour reussir a toucher All Might");
            Console.WriteLine("1- Combattre All Might tout seul  2- Combattre All Might avec Todoroki");
            choix = int.Parse(Console.ReadLine());

            if (choix == 1)
            {
                Console.WriteLine("Pour combattre All Might Seul vous devez definir une capacité de force necessaire pour etre capable de le toucher");
                Console.WriteLine("Niveau 4");//Niveau 4
                Console.WriteLine("Niveau de force: 3- Force: 365.7 4- Force: 450.8");
                choix = int.Parse(Console.ReadLine());

            }
            if (choix == 3)
            {
                Console.WriteLine("Niveau de Force Insuffisante pour toucher All Might");
                Console.WriteLine("Reprendre!!");
            }

            if (choix == 4)
            {
                Console.WriteLine("Capacité Max atteinte, Votre corps n'est pas assez entrainé pour recevoir cette force");
                Console.WriteLine("Reprendre");
            }

            if (choix == 2)
            {
                Console.WriteLine("Combattre All Might avec Todoroki");
                Console.WriteLine("Niveau 5"); // Niveau 5
                Console.WriteLine("Pour cela il vous faut combler a deux une capacité de force necessaire");
                Console.WriteLine("Niveau de force: 5- Force: 450.8");
                choix = int.Parse(Console.ReadLine());

            }
            if (choix == 5)
            {
                Console.WriteLine("Niveau de Force acquis mais pas suffisante a toucher All Might");
                Console.WriteLine("Possibilté d'utiliser les deux éelements de Todoroki");
                Console.WriteLine("7- Feu  8- Glace   9- Feu et Glace");
                choix = int.Parse(Console.ReadLine());

            }
            if (choix == 7)
            {
                Console.WriteLine("Utlisation de Feu");
                Console.WriteLine("Pas suffisant Pour All Might, Assez Puissant qu'il est");
                Console.WriteLine("Reprendre avec une autre astuce");

            }
            if (choix == 8)
            {
                Console.WriteLine("Utilisation de la Glace");
                Console.WriteLine("Encore plus d'effort Pas suffisant Pour All Might, Assez Puissant qu'il est, C'est le Symbole de la Paix quand meme");
            }
            if (choix == 9)
            {
                Console.WriteLine("Utilisation Feu et Glace");//Niveau 6
                Console.WriteLine("PLus Ultra: Niveau Acquis, Vous avez reussi a toucher All Might!!!");
                Console.WriteLine("One For All Maitriser");
                Console.WriteLine("Niveau Terminé");

            }


            Console.ReadKey();
















        }
    }
}
