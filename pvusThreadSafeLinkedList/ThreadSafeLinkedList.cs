using System.Text;

namespace pvusThreadSafeLinkedList
{
    /// <summary>
    /// Beispielimplementation einer thread-sicheren einfach verketteten Liste
    /// </summary>
    public class ThreadSafeLinkedList
    {
        // Der Anker für alle unsere Elemente
        Element anker = null;

        /// <summary>
        /// Hinzufügen eines neuen Elements
        /// </summary>
        /// <param name="neuesElement">neues Element</param>
        public void Hinzufuegen(Element neuesElement)
        {
            // Liste ist leer, also erstes Element hinzufügen
            if(anker == null)
            {
                // Anker auf das neue Element zeigen lassen
                this.anker = neuesElement;
            }
            else
            {
                // auf erstes Element zeigen
                Element aktuell = anker;

                // So lange nach dem aktuellen Element noch ein weiteres kommt
                while(aktuell.Naechstes != null)
                {
                    // auf das nächste Element verschieben
                    aktuell = aktuell.Naechstes;
                }

                // aktuell ist nun das letzte Element
                // das neue Element anhängen
                aktuell.Naechstes = neuesElement;

                // sicherheitshalber das neue Element ins Nichts zeigen lassen
                neuesElement.Naechstes = null;
            }
        }

        /// <summary>
        /// Entfernen des ersten Elementes mit den gleichen Daten
        /// </summary>
        /// <param name="daten">Vergleichsdaten</param>
        /// <returns>Wahr wenn das Element entfernt werden konnte; 
        /// andernfalls Falsch.</returns>
        public bool Entfernen(string daten)
        {
            // Gibt es überhaupt Elemente in der Liste?
            if(this.anker == null)
            {
                // Wo nichts ist, konnte nichts gelöscht werden.
                return false;
            }

            // Gibt es nur ein Element?
            if (this.anker.Naechstes == null)
            {
                // Ist das erste Element zu entfernen?
                if (this.anker.Daten == daten)
                {
                    // Verweis auf das erste Element entfernen
                    this.anker = null;

                    // erfolgreiches Löschen bestätigen
                    return true;
                }
                else 
                { 
                    // Das erste und einzige Element entsprach nicht den Kriterien
                    return false; 
                }
            }

            // Es gibt mindestens zwei Elemente!

            // Verweise aufbauen
            Element vorgaenger = this.anker;
            Element aktuell = vorgaenger.Naechstes;
            Element nachfolger = aktuell.Naechstes;

            // Wiederholen so lange es noch ein weiteres Element gibt
            do
            {
                // Ist aktuelle Element zu entfernen?
                if (aktuell.Daten == daten)
                {
                    // Vorgänger auf den Nachfolger zeigen lassen
                    vorgaenger.Naechstes = nachfolger;

                    // Löschen bestätigen
                    return true;
                }
                else
                {
                    // Verweise um eine Stelle verschieben
                    vorgaenger = aktuell;
                    aktuell = nachfolger;
                    nachfolger = aktuell.Naechstes;
                }
            }
            while (nachfolger != null);

            // Es konnte kein entsprechendes Element gefunden werden.
            return false;
        }

        /// <summary>
        /// Ermittelt die Anzahl der Elemente in der Liste
        /// </summary>
        /// <returns>Anzahl der Elemente</returns>
        public int AnzahlElemente()
        {
            // Diese Zeile muss ersetzt werden!
            throw new NotImplementedException();
        }

        /// <summary>
        /// Daten der einzelnen Elemente als Text zurückgeben (iterativ)
        /// </summary>
        /// <returns>Text mit den Daten der Elemente</returns>
        public string Ausgeben()
        {
            // Sammelobjekt für alle Textdaten
            StringBuilder sb = new StringBuilder();

            // Anfangspunkt festsetzen
            Element aktuell = this.anker;

            // Wiederholen so lange es einen Nachfolger gibt
            while(aktuell != null)
            {
                // Daten des Elementes als Text anfügen
                sb.Append($"'{aktuell.Daten}' ");

                // Verweis um eine Stelle verschieben
                aktuell = aktuell.Naechstes;
            }

            if(sb.Length == 0)
            {
                sb.Append("(leere Liste)");
            }

            // Textdaten aus Sammelobjekt zusammenfügen und zurückgeben
            return sb.ToString();
        }

        /// <summary>
        /// Alle Elemente der Liste entfernen.
        /// </summary>
        public void Leeren()
        {
            // Anker ins Nichts zeigen lassen
            // Alle Elemente gelten damit als verwaist und werden vom
            // Garbage Collector entfernt
            this.anker = null;
        }
    }
}
