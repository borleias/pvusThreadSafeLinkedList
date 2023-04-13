namespace pvusThreadSafeLinkedList
{
    /// <summary>
    /// Beispielimplementation für ein Element einer einfach verketteten Liste
    /// </summary>
    public class Element
    {
        /// <summary>
        /// Verweis auf das nächste Element
        /// </summary>
        public Element Naechstes { get; set; }

        /// <summary>
        /// Daten des Elements
        /// </summary>
        public string Daten { get; set; }

        /// <summary>
        /// Konstruktor für ein Element
        /// </summary>
        /// <param name="daten">Textdaten des Elements</param>
        public Element(string daten)
        {
            this.Daten = daten;
        }
    }
}
