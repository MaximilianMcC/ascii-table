class AsciiTableOptions
{
	
}

struct AsciiTableStyle
{
	// Corners
	public char TopLeft;
	public char TopRight;
	public char BottomLeft;
	public char BottomRight;

	// Straights
	public char Horizontal;
	public char Vertical;

	// Header stuff and joiners
	public char LeftHeaderJoiner;
	public char RightHeaderJoiner;
	public char MiddleHeaderJoinerTop;
	public char MiddleHeaderJoinerBottom;
	public char MiddleHeaderHorizontal;



	// Prebuilt styles
	public static AsciiTableStyle PureAscii => new AsciiTableStyle()
	{
		TopLeft = '#',
		TopRight = '#',
		BottomLeft = '+',
		BottomRight = '+',

		Horizontal = '-',
		Vertical = '|',

		LeftHeaderJoiner = '+',
		RightHeaderJoiner = '+',
		MiddleHeaderJoinerBottom = '+',
		MiddleHeaderJoinerTop = '+',
		MiddleHeaderHorizontal = '-'
	};

	// Prebuilt styles
	public static AsciiTableStyle Single => new AsciiTableStyle()
	{
		TopLeft = '┌',
		TopRight = '┐',
		BottomLeft = '└',
		BottomRight = '┘',

		Horizontal = '─',
		Vertical = '│',

		LeftHeaderJoiner = '╞',
		RightHeaderJoiner = '╡',
		MiddleHeaderJoinerTop = '┬',
		MiddleHeaderJoinerBottom = '╪',
		MiddleHeaderHorizontal = '═'
	};

	// Prebuilt styles
	public static AsciiTableStyle Double => new AsciiTableStyle()
	{
		TopLeft = '╔',
		TopRight = '╗',
		BottomLeft = '╚',
		BottomRight = '╝',

		Horizontal = '═',
		Vertical = '║',

		LeftHeaderJoiner = '╠',
		RightHeaderJoiner = '╣',
		MiddleHeaderJoinerTop = '╦',
		MiddleHeaderJoinerBottom = '╬',
		MiddleHeaderHorizontal = '═'
	};
}