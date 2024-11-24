using System.Text;
namespace ArtForAll.PerformancePB.Code;

public class StringWorker
{
    public string BuildStringBadly(string value)
    {
        for (var i = 0; i < 50; i++)
        {
            value += " " + "test";
        }

        return value;
    }

    public string BuildStringBetter(string value)
    {
        var sb = new StringBuilder(value);

        for (var i = 0; i < 50; i++)
        {
            sb.Append(' ');
            sb.Append("test");
        }

        return sb.ToString();
    }

    public (string lastName, string firstName) NaiveSplitName(string name)
    {
        var commaPos = name.IndexOf(',');
        var lastName = name.Substring(0, commaPos);
        var firstName = name.Substring(commaPos + 2);

        return (lastName, firstName);
    }

    public (string lastName, string firstName) SplitSplitName(string name)
    {
        var nameArray = name.Split(',');

        return (nameArray[0].Trim(), nameArray[1].Trim());
    }

    public (string lastName, string firstName) SpanSplitName(string name)
    {
        ReadOnlySpan<char> nameSpan = name.AsSpan();

        // Find the position of the comma once
        int commaPos = nameSpan.IndexOf(',');

        // Slice and convert to strings once
        var lastName = nameSpan.Slice(0, commaPos).ToString();
        var firstName = nameSpan.Slice(commaPos + 2).ToString();

        return (lastName, firstName);
    }

}
