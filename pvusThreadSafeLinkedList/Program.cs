namespace pvusThreadSafeLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pvusThreadSafeLinkedList");

            ThreadSafeLinkedList list = new ThreadSafeLinkedList();

            list.Hinzufuegen(new Element("A"));
            list.Hinzufuegen(new Element("B"));
            list.Hinzufuegen(new Element("C"));

            Console.WriteLine($"\nInhalt der Liste: {list.Ausgeben()}"); 
         
            list.Entfernen("B");
            
            Console.WriteLine($"\nInhalt der Liste: {list.Ausgeben()}");

            list.Entfernen("C");

            Console.WriteLine($"\nInhalt der Liste: {list.Ausgeben()}");

            list.Entfernen("A");

            Console.WriteLine($"\nInhalt der Liste: {list.Ausgeben()}");

            list.Entfernen("A");

            Console.WriteLine($"\nInhalt der Liste: {list.Ausgeben()}");

            list.Hinzufuegen(new Element("A"));
            list.Hinzufuegen(new Element("B"));
            list.Hinzufuegen(new Element("C"));

            Console.WriteLine($"\nInhalt der Liste: {list.Ausgeben()}");

            list.Leeren();

            Console.WriteLine($"\nInhalt der Liste: {list.Ausgeben()}");
        }
    }
}