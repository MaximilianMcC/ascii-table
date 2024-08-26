class Program
{
	public static void Main(string[] args)
	{
		
		// Example of a table on the right of the screen
		AsciiTable table = new AsciiTable(
			new string[] { "Year level", "Average grade" },
			new int[] { 1, 2, },
			Console.WindowWidth / 2,
			45
		);
		table.AddRow("9", "Merit");
		table.AddRow("10", "Achieved");
		table.AddRow("11", "Excellence");
		table.AddRow("12", "Merit");
		table.AddRow("13", "Achieved");
		table.End();

		Console.ReadKey();
	}
}