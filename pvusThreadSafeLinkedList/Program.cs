namespace pvusThreadSafeLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pvusThreadSafeLinkedList");

            ThreadSafeLinkedList list = new ThreadSafeLinkedList();

            Console.WriteLine("\nDer Liste die Elemente 'A', 'B' und 'C' hinzufügen.");
            list.Hinzufuegen(new Element("A"));
            list.Hinzufuegen(new Element("B"));
            list.Hinzufuegen(new Element("C"));
            Console.WriteLine($"Inhalt der Liste: {list.Ausgeben()}");

            Console.WriteLine("\nElement 'B' entfernen.");
            list.Entfernen("B");
            Console.WriteLine($"Inhalt der Liste: {list.Ausgeben()}");

            Console.WriteLine("\nElement 'C' entfernen.");
            list.Entfernen("C");
            Console.WriteLine($"Inhalt der Liste: {list.Ausgeben()}");

            Console.WriteLine("\nElement 'A' entfernen.");
            list.Entfernen("A");
            Console.WriteLine($"Inhalt der Liste: {list.Ausgeben()}");

            Console.WriteLine("\nElement aus leerer Liste entfernen.");
            list.Entfernen("A");
            Console.WriteLine($"Inhalt der Liste: {list.Ausgeben()}");

            Console.WriteLine("\nDer Liste die Elemente 'A', 'B' und 'C' hinzufügen.");
            list.Hinzufuegen(new Element("A"));
            list.Hinzufuegen(new Element("B"));
            list.Hinzufuegen(new Element("C"));
            Console.WriteLine($"Inhalt der Liste: {list.Ausgeben()}");

            Console.WriteLine("\nAlle Elemente aus Liste entfernen.");
            list.Leeren();
            Console.WriteLine($"Inhalt der Liste: {list.Ausgeben()}");
        }
    }
}