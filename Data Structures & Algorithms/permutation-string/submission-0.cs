public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        // C# way to sort a string
        char[] s1Arr = s1.ToCharArray();
        Array.Sort(s1Arr);
        string sortedS1 = new string(s1Arr);

        // Notice the <= condition to catch the last substring
        for (int i = 0; i <= s2.Length - s1.Length; i++) {
            // Extract a substring of length s1.Length
            string sub = s2.Substring(i, s1.Length);
            
            // Sort the substring
            char[] subArr = sub.ToCharArray();
            Array.Sort(subArr);
            string sortedSub = new string(subArr);

            // If the sorted characters match, a permutation exists
            if (sortedS1 == sortedSub) {
                return true;
            }
        }

        return false;
    }
}
