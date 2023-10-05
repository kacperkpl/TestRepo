namespace TestRepo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("And another line!!");
            Console.WriteLine("And the third one!!!");
            Console.WriteLine("And the final fourth!!!!");

            TestRepoClass2 trc2 = new TestRepoClass2();
            Console.WriteLine(trc2.MinusOne(12));
        }
    }
}