func mergeAlternately(word1 string, word2 string) string {
     n1, n2 := len(word1), len(word2)
    result := []byte{}
    
    for i := 0; i < n1 || i < n2; i++ {
        if i < n1 {
            result = append(result, word1[i])
        }
        if i < n2 {
            result = append(result, word2[i])
        }
    }
    return string(result)
}