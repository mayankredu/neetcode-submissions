public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] c1 = s.ToCharArray();
        Array.Sort(c1);
        s = new string(c1);

        char[] c2 = t.ToCharArray();
        Array.Sort(c2);
        t = new string(c2);

        return s == t;
    }
}
