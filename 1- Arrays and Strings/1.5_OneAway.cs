Console.WriteLine(OneEditAway("apple", "aple"));

bool OneEditAway(string s, string t)
{
	if (s.Length == t.Length)
	{
		return EditReplace(s, t);
	}

	if (s.Length + 1 == t.Length)
	{
		return EditInsert(s, t);
	}

	if (s.Length - 1 == t.Length)
	{
		return EditInsert(t, s);
	}

	return false;
}

bool EditReplace(string s, string t)
{
	bool foundDiff = false;
	for (int i = 0; i < s.Length; i++)
	{
		if (s[i] != t[i])
		{
			if (foundDiff)
			{
				return false;
			}

			foundDiff = true;
		}
	}

	return true;
}

bool EditInsert(string s1, string s2)
{
	int index1 = 0;
	int index2 = 0;
	while (index2 < s2.Length && index1 < s1.Length)
	{
		if (s1[index1] != s2[index2])
		{
			if (index1 != index2)
			{
				return false;
			}

			index2++;
		}
		else
		{
			index1++;
			index2++;
		}
	}

	return true;
}

bool OneEditAway2(string first, string second)
{
	if (first.Length - second.Length > 1) return false;
	string shorter = first.Length < second.Length ? first : second;
	string longer = first.Length < second.Length ? second : first;
	bool foundDiff = false;
	int idx1 = 0, idx2 = 0;
	while (idx1 < shorter.Length && idx2 < longer.Length)
	{
		if (shorter[idx1] != longer[idx2])
		{
			if (foundDiff) return false;
			foundDiff = true;
			if (shorter.Length == longer.Length) idx1++;
		}
		else
		{
			idx1++;
		}

		idx2++;
	}

	return true;
}