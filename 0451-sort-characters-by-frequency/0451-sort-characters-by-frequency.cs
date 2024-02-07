public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char,string> dict = new Dictionary<char,string>();
        for(int i = 0; i < s.Length; i++){
            if(!dict.ContainsKey(s[i])){
                dict.Add(s[i],"");
            }
            dict[s[i]] += s[i];
        }

        string result ="";
        foreach (var x in dict.OrderBy(x=> -x.Value.Length)){
            result += x.Value;
        }
        return result;
    }
}