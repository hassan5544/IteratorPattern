using IteratorPattern;

class Program
{
    public static void Main()
    {


        Invoices invoices = new Invoices();
        Item item = new Item();
        item.Name = "item";
        invoices.items.Add(item);
        Item item2 = new Item();
        item2.Name = "item2";
        invoices.items.Add(item2);

        Item item3 = new Item();
        item3.Name = "item3";
        invoices.items.Add(item3);

        Iterate(invoices);

        void Iterate(IIteratorCollection iteratorCollection)
        {
            IIterator iterator = iteratorCollection.CreateItemsIterator(); ;
            for(iterator.First(); iterator.HasNext();iterator.Next() )
            {
                Console.WriteLine(iterator.Current().Name);

            }

            Console.WriteLine("Reverse");

            IIterator Reverseiterator = iteratorCollection.CreateReverseItemsIterator(); ;
            for (Reverseiterator.First(); Reverseiterator.HasNext(); Reverseiterator.Next())
            {
                Console.WriteLine(Reverseiterator.Current().Name);

            }
        }
    }
}