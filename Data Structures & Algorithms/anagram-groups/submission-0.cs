public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string, List<string>> dict = new Dictionary<string, List<string>>();
        //char[] characters = input.ToCharArray();

        foreach(string s in strs)
        {
            char[] characters = s.ToCharArray();
            Array.Sort(characters);
            string sortedKey = new string(characters);   
            if (!dict.ContainsKey(sortedKey)) {
                dict[sortedKey] = new List<string>();
            }
            
            dict[sortedKey].Add(s);
        }
        List<List<string>> res = new List<List<string>>();
        foreach (var pair in dict) {
            res.Add(pair.Value);
        }
        return res;
    }
    
}
