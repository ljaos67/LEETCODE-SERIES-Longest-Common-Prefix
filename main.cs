public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        Array.Sort(strs);
        string prefix = "";
        string first = strs[0];
        string last = strs[strs.Length -1];
        for(int i = 0; i < (first.Length < last.Length ? first.Length :last.Length); i++)
        {
            if(first[i] != last[i])
            {
                return prefix;
            }
            prefix += first[i];
        }
        return prefix;
    }
}
