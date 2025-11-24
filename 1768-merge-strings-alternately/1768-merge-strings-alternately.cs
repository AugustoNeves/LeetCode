public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int maxLength = word1.Length >= word2.Length ? word1.Length : word2.Length;
        
        Console.WriteLine($"Max Length: {maxLength}");
        string merged = null;
        for(int i = 0; i < maxLength; i++){
            if (word1.Length > i)
                merged += word1[i];
            if (word2.Length > i)            
                merged += word2[i];
            Console.WriteLine($"Merged: {merged}");

        }

        return merged;
    }
}