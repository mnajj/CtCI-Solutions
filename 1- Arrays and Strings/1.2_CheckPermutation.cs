/// <summary>
/// Given two strings, write a method to decide if one is a permutation of the other.
/// </summary>

// Solution 1 [Sorting]
string sort(string str)
{
	char[] chars = str.ToCharArray();
	Array.Sort(chars);
	return new string(chars);
}

bool IsPermutation(string str1, string str2)
{
	if (str1.Length != str2.Length)
	{
		return false;
	}

	return sort(str1).Equals(sort(str2));
}

// Solution 2 [Count Lookup]
bool IsPermutation2(string str1, string str2)
{
	if (str1.Length != str2.Length)
	{
		return false;
	}

	var letterCount = new Dictionary<char, int>();
	foreach (char ch in str1)
	{
		if (letterCount.ContainsKey(ch))
		{
			letterCount[ch]++;
		}
		else
		{
			letterCount[ch] = 1;
		}
	}

	foreach (char ch in str2)
	{
		if (letterCount.ContainsKey(ch))
		{
			letterCount[ch]--;
			if (letterCount[ch] < 0)
			{
				return false;
			}
		}
		else
		{
			return false;
		}
	}

	return true;
}