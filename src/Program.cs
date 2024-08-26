class Program
{
	public static void Main(string[] args)
	{
		AsciiTable table = new AsciiTable(
			new string[] { "test", "lorem ipsum", "kia ora", "hello, world!" },
			new int[] { 1, 2, 1, 1 },
			10, 95
		);
		// table.AddRow("test", "test", "test", "test");
		// table.AddRow("test", "test", "test", "test");
		// table.AddRow("test", "test", "test", "test");
		// table.AddRow("test", "test", "test", "test");
		// table.End();

		Console.ReadKey();
	}
}