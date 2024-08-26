class Program
{
	public static void Main(string[] args)
	{
		AsciiTable table = new AsciiTable(
			new string[] { "test", "lorem ipsum", "kia ora" },
			new int[] { 1, 2, 1 },
			10, 95
		);
		table.AddRow("I think this text should be overflowing rn", "I think this text should be overflowing rn", "I think this text should be overflowing rn");
		table.AddRow("I think this text should be overflowing rn", "I think this text should be overflowing rn", "I think this text should be overflowing rn");
		table.AddRow("I think this text should be overflowing rn", "I think this text should be overflowing rn", "I think this text should be overflowing rn");
		table.End();

		Console.ReadKey();
	}
}