/// <summary>
/// Implement an algorithm to determine if a string has all unique characters.
/// </summary>

string str = "#117";
Console.WriteLine(IsUnique(str));

bool IsUnique(string str)
{
	Dictionary<char, bool> dict = new();
	foreach (char ch in str)
	{
		if (dict.ContainsKey(ch))
		{
			return false;
		}
		dict[ch] = true;
	}
	return true;
}

/// <summary>
///  What if you cannot use additional data structures?
/// </summary>
bool IsUnique2(string str)
{
	var checker = 0;
	foreach (var ch in str)
	{
		var val = ch - 'a';
		if ((checker & (1 << val)) > 0)
		{
			return false;
		}
		checker |= (1 << val);
	}
	return true; 
}
