class AsciiTable
{
	private int xPosition;
	private string[] headers;
	private int[] headersWidths;
	private int totalWidth;

	public AsciiTable(string[] headings, int[] weights, int xPosition, int width)
	{
		// TODO: Don't use `this`
		totalWidth = width;
		this.xPosition = xPosition;

		headers = headings;
		headersWidths = CalculateHeaderWidths(weights, totalWidth);

		DrawHeaders();
	}

	// TODO: Make constructor to make a centre table

	private int[] CalculateHeaderWidths(int[] headerWeights, int totalWidth)
	{
		int[] headerWidths = new int[headerWeights.Length];
		float totalWeight = headerWeights.Sum();

		// Loop through every weight that we need
		// to calculate
		for (int i = 0; i < headerWeights.Length; i++)
		{
			// Get a 0.x to determine how much space
			// the width of this header should take up
			float percentage = headerWeights[i] / totalWeight;

			// Turn the percentage into a width
			int currentWidth = (int)(percentage * totalWidth);
			headerWidths[i] = currentWidth;
		}

		// Give back the list of widths
		// TODO: Check for if this exceeds totalWidth (idk if it might)
		return headerWidths;
	}


	// TODO: Maybe make this public and don't run in constructor
	private void DrawHeaders()
	{
		DrawSlice('┌', '─', '┐', '┬');
		DrawSlice('│', ' ', '│', '│');
		PopulateAboveSlice(headers);
		DrawSlice('╞', '═', '╡', '╪');
	}

	public void AddRow(params string[] data)
	{
		// Draw the initial background line
		DrawSlice('│', ' ', '│', '│');

		// Populate the table with the data
		PopulateAboveSlice(data);
	}

	public void End()
	{
		DrawSlice('└', '─', '┘', '┴');
	}

	private void DrawSlice(char left, char filler, char right, char? separator = null)
	{
		// Check for if we have supplied a separator or not
		if (separator == null) separator = filler;

		// Make the initial "empty" line and also make
		// sure the width has enough characters removed
		// so that we can insert the column characters in
		//? -2 is for the corners
		int width = (totalWidth - 2) - headersWidths.Length;
		string line = left + new string(filler, width) + right;

		// Add in all of the header sections (columns)
		int x = 0;
		for (int i = 1; i < headersWidths.Length; i++)
		{
			// TODO: Get rid of the weird as casting to string rubbish
			// Insert the separator characters
			line = line.Insert(x + headersWidths[i], ((char)separator).ToString());
			x += headersWidths[i];
		}

		// Set the cursor to the correct position
		// then draw the current line
		Console.CursorLeft = xPosition;
		Console.WriteLine(line);
	}

	private void PopulateAboveSlice(string[] data)
	{
		// Move back up to the slice that we wanna edit
		Console.CursorTop--;

		// Loop through every bit of data and chuck
		// it into the correct header thingy
		//? 2 because 1 for the border of the table, and 1 for the padding
		int x = xPosition + 2;
		for (int i = 0; i < headersWidths.Length; i++)
		{
			// Move to the correct X position
			Console.CursorLeft = x;
			
			// Draw the bit of data
			// TODO: If the data is longer than the allowed stuff then make it end with ...
			Console.Write(data[i]);

			// Increase the X for the next bit of data
			x += headersWidths[i];
		}

		// Move the cursor back down to get to the original position
		Console.CursorTop++;
	}
}