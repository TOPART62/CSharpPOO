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
        T[] _elements;
        int _nbElements;

        public T[] Elements { get; set; }
        public int NbElements { get; set; }

        // Constructeurs
        public Pile()
        {
            NbElements = 0;
        }
        public Pile(T[] elements, int nbElements)
        {
            Elements = elements ?? throw new ArgumentNullException(nameof(elements));
            NbElements = nbElements;
        }

        //Methodes
        public void Empiler(T element)
        {
            Elements[NbElements] = element;
            NbElements++;
        }
        public T Depiler()
        {
            if (NbElements > 0)
            {
                NbElements--;
                return Elements[NbElements];
            }
            else
                Console.WriteLine("Depilage impossible ! La pile est vide !!");
            return default(T) ?? throw new ArgumentNullException(nameof(Elements));

        }

        public void AfficherPile()
        {
            foreach (T element in this.Elements)
                Console.WriteLine($"{element}");
        }
    }
}
