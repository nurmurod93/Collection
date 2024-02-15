namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inson[] talabaMassivi = new Inson[5]
            {
                new Inson("Ali", "Valiyev"),
                new Inson("Vali", "Aliyev"),
                new Inson("Soli", "Soliyev"),
                new Inson("Falonchi", "Falonchiyev"),
                new Inson("Pistonchi", "Pistonchiyev")
            };

            Talabalar talabalar = new Talabalar(talabaMassivi);
            foreach (Inson inson in talabalar)
                Console.WriteLine(inson.Ism + " " + inson.Familiya);
        }
    }

    //public class MyCollection : IEnumerable
    //{
    //    public IEnumerator GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public static class MyCollectionExist
    //{
    //    public static void Add(this MyCollection collection, object item)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class Example
    //{
    //    public void TestCollection()
    //    {
    //        MyCollection mc = new MyCollection() { true, "salom!", 0x123F };
    //        mc.Add(new object());

    //    }
    //}
}
