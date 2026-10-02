public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        if(s.Length %2 !=0)
            return false;

        for(int i =0 ;i<s.Length;i++)
        {
            if(s[i] == '(' || s[i] == '[' ||s[i] == '{')
            {
                st.Push(s[i]);
            }
            else{
                if (st.Count == 0) return false;
                char a = st.Pop();
                if((a != '(' & s[i] == ')')
                    ||(a != '[' & s[i] == ']')
                    ||(a != '{' & s[i] == '}'))
                    return false;

            }
        }
        return st.Count == 0;
    }
}
