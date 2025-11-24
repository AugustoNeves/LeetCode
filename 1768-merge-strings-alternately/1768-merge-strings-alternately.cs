public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder sb = new StringBuilder();
        int n1 = word1.Length, n2 = word2.Length;
        
        for(int i = 0; i < Math.Max(n1, n2); i++) {
            if(i < n1) sb.Append(word1[i]);
            if(i < n2) sb.Append(word2[i]);
        }
        return sb.ToString();
    }
}