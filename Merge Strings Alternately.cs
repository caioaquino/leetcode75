public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int len = Math.Max(word1.Length,word2.Length);
        string result = "";

        for(int i=0; i< len; i++){
            if(i< word1.Length){
                result +=  word1.Substring(i,1);
            }
            if(i< word2.Length){
                result +=  word2.Substring(i,1);
            }
        }
        return result;
    }
}
