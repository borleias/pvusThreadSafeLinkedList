using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvusThreadSafeLinkedList
{
    public class ThreadSafeLinkedList
    {
        Element anker = null;

        // Hinzufügen
        public void Hinzufuegen(Element neuesElement)
        {
            // erstes Element hinzufügen
            if(anker == null)
            {
                this.anker = neuesElement;
            }
            else
            {
                Element aktuell = anker;
                while(aktuell.Naechstes != null)
                {
                    aktuell = aktuell.Naechstes;
                }
                aktuell.Naechstes = neuesElement;
                neuesElement.Naechstes = null;
            }
        }

        // Entfernen
        public bool Entfernen(string daten)
        {
            // Gibt es überhaupt Elemente in der Liste?
            if(this.anker == null)
            {
                return false;
            }

            // Gibt es nur ein Element?
            if (this.anker.Naechstes == null)
            {
                // Ist dieses Element zu entfernen?
                if (this.anker.Daten == daten)
                {
                    this.anker = null;
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }

            // Es gibt mindestens zwei Elemente!
            Element vorgaenger = this.anker;
            Element aktuell = vorgaenger.Naechstes;
            Element naechstes = aktuell.Naechstes;

            // So lange es noch ein weiteres Element gibt
            do
            {
                // Ist dieses Element zu entfernen?
                if (aktuell.Daten == daten)
                {
                    vorgaenger.Naechstes = aktuell.Naechstes;
                    return true;
                }
                else
                {
                    vorgaenger = aktuell;
                    aktuell = naechstes;
                    naechstes = aktuell.Naechstes;
                }
            }
            while (naechstes != null);

            return false;
        }

        // Elemente zählen

        // Elemente ausgeben (rekursiv)

        // Elemente ausgeben (iterativ)
        public string Ausgeben()
        {
            StringBuilder sb = new StringBuilder();

            Element aktuell = this.anker;

            while(aktuell != null)
            {
                sb.Append($"'{aktuell.Daten}' ");
                aktuell = aktuell.Naechstes;
            }

            return sb.ToString();
        }

        // Leeren
        public void Leeren()
        {
            this.anker = null;
        }
    }
}
