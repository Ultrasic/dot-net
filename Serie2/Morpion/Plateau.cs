using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion
{
    class Plateau : ITerminable
    {
        int[,] tab;
        int tailleX;
        int tailleY;
        public Plateau(int x, int y)
        {
            tailleX = x;
            tailleY = y;
            tab = new int[tailleX, tailleY];
        }

        public int[,] GetTab()
        {
            return tab;
        }

        public int GetTailleX()
        {
            return tailleX;
        }

        public int GetTailleY()
        {
            return tailleY;
        }

        public bool SetValueInTab(int x, int y, int value)
        {
            if (this[x, y] == 0)
            {
                this[x, y] = value;
                return true;
            }
            return false;
        }

        public bool VerifyIfP1Won()
        {
            bool won = false;
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                won = true;
                for(int j = 0; j < tab.GetLength(1); j++)
                {
                    if(tab[i,j] != 1)
                    {
                        won = false;
                        break;
                    }
                }
                if(won == true)
                {
                    return won;
                }
            }

            for (int i = 0; i < tab.GetLength(1); i++)
            {
                won = true;
                for (int j = 0; j < tab.GetLength(0); j++)
                {
                    if (tab[j, i] != 1)
                    {
                        won = false;
                        break;
                    }
                }
                if (won == true)
                {
                    return won;
                }
            }

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                won = true;
                if (tab[i, i] != 1)
                {
                    won = false;
                    break;
                }
            }

            if (won == true)
            {
                return won;
            }

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                won = true;
                if (tab[i, tab.GetLength(0)- 1 - i] != 1)
                {
                    won = false;
                    break;
                }
            }

            return won;
        }

        public bool VerifyIfP2Won()
        {
            bool won = false;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                won = true;
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] != 2)
                    {
                        won = false;
                        break;
                    }
                }
                if (won == true)
                {
                    return won;
                }
            }

            for (int i = 0; i < tab.GetLength(1); i++)
            {
                won = true;
                for (int j = 0; j < tab.GetLength(0); j++)
                {
                    if (tab[j, i] != 2)
                    {
                        won = false;
                        break;
                    }
                }
                if (won == true)
                {
                    return won;
                }
            }

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                won = true;
                if (tab[i, i] != 2)
                {
                    won = false;
                    break;
                }
            }

            if (won == true)
            {
                return won;
            }

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                won = true;
                if (tab[i, tab.GetLength(0) - 1 - i] != 2)
                {
                    won = false;
                    break;
                }
            }

            return won;
        }

        public bool VerifyIfDraw()
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void Reset()
        {
            tab = new int[tailleX, tailleY];
        }

        public int this[int x, int y] // indexeur
        {
            get { return tab[x, y]; }
            //Je n'utilise pas le set car pas moyen de retourner une valeur (int ou bool)
            //Et donc pas de façon de vérifier si la valeur a pu s'ajouter et ne pas override
            //Celle d'un autre joueur
            set { if (tab[x, y] == 0) { tab[x, y] = value; } } // peut être omis
        }
    }
}
