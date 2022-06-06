Console.WriteLine(IsPalindrome3("taco cat"));

bool IsPalindrome(string str)
{
	var trimmed = string.Concat(str.Where(c => !char.IsWhiteSpace(c)));
	var chars = trimmed.ToCharArray();
	Array.Reverse(chars);
	var revStr = new string(chars);
	if (trimmed.Equals(revStr)) return true;
	return false;
}

bool IsPalindrome2(string str)
{
	var dict = new Dictionary<char, int>();
	foreach (char ch in str)
	{
		if (!char.IsWhiteSpace(ch))
		{
			if (!dict.ContainsKey(ch))
			{
				dict[ch] = 1;
			}
			else
			{
				dict[ch]++;
			}
		}
	}

	int isOdd = 0;
	foreach (KeyValuePair<char, int> pair in dict)
	{
		if (pair.Value % 2 != 0)
		{
			isOdd++;
		}
	}
	return isOdd == 1;
}

bool IsPalindrome3(string str)
{
	var dict = new Dictionary<char, int>();
	int odds = 0;
	foreach (char ch in str)
	{
		if (!char.IsWhiteSpace(ch))
		{
			if (!dict.ContainsKey(ch))
			{
				dict[ch] = 1;
			}
			else
			{
				dict[ch]++;
			}

			if (dict[ch] % 2 == 1)
			{
				odds++;
			}
			else
			{
				odds--;
			}
		}
	}
	return odds <= 1;
}