public class Solution {
    public bool IsHappy(int n) {
        if( n == 1)
            return true;
        HashSet<int> hS = new HashSet<int>();
        int dS = digitSqSum(n);
        while(hS.Add(dS)){
            if( dS == 1)
                return true;
            else{
                dS = digitSqSum(dS);
            }
        }
        return false;
    }
    public int digitSqSum(int n)
    {
        int sum = 0;
        while(n>0)
        {
            sum += sq(n%10);
            n /=10;
        }
        return sum;
    }

    public int sq (int n)
    {
        return n*n;
    }
}
