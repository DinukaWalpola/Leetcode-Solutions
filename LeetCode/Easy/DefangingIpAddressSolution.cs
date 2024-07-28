namespace LeetCode.Easy;

public class DefangingIpAddressSolution
{
    public static string DefangIPaddr(string address)
    {
        return string.Join("[.]", address.Split('.'));
    }
}