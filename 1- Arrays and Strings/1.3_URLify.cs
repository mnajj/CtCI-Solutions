using System.Text;

string ReplaceSpace(string str)
{
	StringBuilder repStr = new StringBuilder();
	foreach (char c in str)
	{
		if (c == ' ')
		{
			repStr.Append("20%");
		}
		else
		{
			repStr.Append(c);
		}
	}
	return repStr.ToString();
}