public class Solution {
    public int RomanToInt(string s) {

    Dictionary<char, int> romanDic = new Dictionary<char, int>() {
        {'I', 1}, {'V', 5}, {'X', 10},
        {'L', 50}, {'C', 100},
        {'D', 500}, {'M', 1000}
    };
    

    int sum = 0;

    for (int i = 0; i < s.Length; i++){
        if (i + 1 < s.Length && romanDic[s[i]] < romanDic[s[i + 1]]){
            sum += romanDic[s[i + 1]] - romanDic[s[i]];
            i++;
        }
        else{
            sum += romanDic[s[i]];
        }
    }

    return sum;
}
}