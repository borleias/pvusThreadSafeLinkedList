namespace pvusThreadSafeLinkedList
{
    public class Element
    {
        public Element Naechstes { get; set; }
        public string Daten { get; set; }

        public Element(string data)
        {
            this.Daten = data;
        }
    }
}
