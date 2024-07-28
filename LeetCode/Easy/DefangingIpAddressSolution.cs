using System.Text;

namespace LeetCode.Easy;

public class DefangingIpAddressSolution
{
    public static string DefangIPaddr(string address)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var c in address)
        {
            if (c != '.')
            {
                sb.Append(c);
            }
            else
            {
                sb.Append("[.]");
            }
        }

        return sb.ToString();
    }
}