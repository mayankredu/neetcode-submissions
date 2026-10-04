public class Solution {
      private const char split = '#';
    public string Encode(IList<string> strs) {
       if(strs.Count == 0 || strs == null)
        return "";
      StringBuilder sb = new StringBuilder();
        foreach (string str in strs)
        {
         sb.Append(str.Length).Append(split).Append(str);
        }
      return sb.ToString(); 
    }

    public List<string> Decode(string s) {
      List<string> result = new List<string>();
      if (string.IsNullOrEmpty(s)) return result;

      int i =0;
      while (i < s.Length)
      {
         int slash = s.IndexOf(split, i);
         
         int length = int.Parse(s.Substring(i, slash - i));

         i = slash + 1;

         result.Add(s.Substring(i, length));
            
         i += length;

      }
      return result;
   }
}
