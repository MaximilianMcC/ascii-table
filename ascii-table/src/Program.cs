class Program
{
    public static void Main(string[] args)
    {
        AsciiTable table = new AsciiTable(
            new string[] { "test", "lorem ipsum", "kia ora", "hello, world!" },
            new int[] { 1, 1, 2, 1 },
            0, Console.WindowWidth
        );
        table.AddRow("test", "test", "test", "test");
        table.AddRow("test", "test", "test", "test");
        table.AddRow("test", "test", "test", "test");
        table.AddRow("test", "test", "test", "test");

        Console.ReadKey();
    }
}