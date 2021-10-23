using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion
{
    class Jeu
    {
        int tour;
        int winP1;
        int winP2;
        Plateau plateau;
        public Jeu()
        {
            tour = 0;
            winP1 = 0;
            winP2 = 0;
            plateau = new Plateau(3, 3);
        }

        public void LancerJeu()
        {
            while (true)
            {
                Rendu.Rendre(plateau.GetTab());
                Console.Write("Quel est l'action du joueur " + (tour + 1) + " (1 => Jouer, 2 => Quitter) ? ");
                String choice = Console.ReadLine();
                if (choice == "2")
                {
                    break;
                } else if (choice == "1")
                {
                    Console.Write("Ligne (1 à " + plateau.GetTailleX() + ") ? ");
                    String choiceX = Console.ReadLine();
                    if (int.TryParse(choiceX, out int x))
                    {
                        if (x <= plateau.GetTailleX() && x > 0)
                        {
                            Console.Write("Colonne (1 à " + plateau.GetTailleY() + ") ? ");
                            String choiceY = Console.ReadLine();
                            if (int.TryParse(choiceY, out int y))
                            {
                                if (y <= plateau.GetTailleY() && y > 0)
                                {
                                    if(!plateau.SetValueInTab(x-1, y-1, tour+1))
                                    {
                                        Console.WriteLine("Il y a déjà un jeton à cet endroit");
                                        continue;
                                    }
                                    if (tour == 0)
                                    {
                                        if (plateau.VerifyIfP1Won())
                                        {
                                            Rendu.Rendre(plateau.GetTab());
                                            winP1++;
                                            Console.WriteLine("Le joueur 1 a gagné !");
                                            Console.WriteLine(winP1 + " - " + winP2);
                                            Console.WriteLine("Voulez-vous rejouer ? (Oui / Non)");
                                            String regame = Console.ReadLine();
                                            if(regame == "Oui")
                                            {
                                                plateau.Reset();
                                                tour = 0;
                                                continue;
                                            }
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (plateau.VerifyIfP2Won())
                                        {
                                            Rendu.Rendre(plateau.GetTab());
                                            winP2++;
                                            Console.WriteLine("Le joueur 2 a gagné !");
                                            Console.WriteLine(winP1 + " - " + winP2);
                                            Console.WriteLine("Voulez-vous rejouer ? (Oui / Non)");
                                            String regame = Console.ReadLine();
                                            if (regame == "Oui")
                                            {
                                                plateau.Reset();
                                                tour = 0;
                                                continue;
                                            }
                                            break;
                                        }
                                    }
                                    if (plateau.VerifyIfDraw())
                                    {
                                        Rendu.Rendre(plateau.GetTab());
                                        Console.WriteLine("Egalité !");
                                        Console.WriteLine(winP1 + " - " + winP2);
                                        Console.WriteLine("Voulez-vous rejouer ? (Oui / Non)");
                                        String regame = Console.ReadLine();
                                        if (regame == "Oui")
                                        {
                                            plateau.Reset();
                                            tour = 0;
                                            continue;
                                        }
                                        break;
                                    }
                                    tour = (tour + 1) % 2;
                                }
                                else
                                {
                                    Console.WriteLine("Ce n'est pas un chiffre valide");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ce n'est pas un chiffre valide");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ce n'est pas une commande valide");
                        }
                    }
                }
            }
        }
    }
}
