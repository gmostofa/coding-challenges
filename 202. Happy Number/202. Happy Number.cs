namespace DefaultNamespace;

public class Solution 
{
    public bool IsHappy(int n) 
    {
        HashSet<int> seen = new HashSet<int>();
        while (n != 1 && !seen.Contains(n)) 
        {
            seen.Add(n);
            n = GetNext(n);
        }
        return n == 1;
    }
    private int GetNext(int n) 
    {
        int totalSum = 0;
        while (n > 0) 
        {
            int digit = n % 10;
            totalSum += digit * digit;
            n /= 10;
        }
        return totalSum;
    }
}