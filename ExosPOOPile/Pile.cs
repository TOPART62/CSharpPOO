using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExosPOOPile
{
    internal class Pile<T>
    {
        // Attributs et Propriétés
        private T[] _elements = new T[0];
        private int _nbElements = 0;

        public T[] Elements 
        { 
            get => _elements; 
            set { _elements = value; } 
        }
        public int NbElements 
        { 
            get => _nbElements; 
            set { _nbElements = value; }    
        }


        const int NBElementsMax = 20;   

        // Constructeurs
        public Pile()
        {
            Elements = new T[0];
        }

        //Methodes
        public void Empiler(T element)
        {
            if (NbElements <= NBElementsMax)
            {
                NbElements++;
                Array.Resize(ref _elements, NbElements);
                _elements[NbElements - 1] = element;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tEmpilage impossible ! La pile est pleine !!\n");
                Console.ResetColor();
            }
        }
        
        public void Depiler()
        {
            if (NbElements > 0)
            {
                NbElements--;
                Array.Resize(ref _elements, NbElements);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tDépilage impossible ! La pile est vide !!\n");
                Console.ResetColor();
            }
        }

        public string Recuperer(int position)
        {
            string strTmp = "";
            if (position >= NbElements)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tLa position dans la pile n'existe pas  !!\n");
                Console.ResetColor();

            }
            else if (NbElements > 0)
            {
                for (int i = 0; i < this.NbElements; i++)
                {
                    if (this.Elements[i].ToString() == this.Elements[position].ToString())
                        strTmp = this.Elements[i].ToString();
                }
            }
            else
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tLa pile est vide !!\n");
                Console.ResetColor();
            }
            return strTmp;
        }

        public void AffichagePile()
        {
            if (this.NbElements > 0)
            {
                string strTmp = $"Affichage de la pile : ";
                for (int i = 0; i < this.NbElements; i++)
                    strTmp = strTmp + $"\n stringPile[{i}] : {this.Elements[i]} ";
                Console.WriteLine(strTmp);
            }
            else
                Console.WriteLine("La pile est vide !!!");    
        }
    }
}
