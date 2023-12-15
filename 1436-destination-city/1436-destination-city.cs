public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> unique = new HashSet<string>();
        
        foreach (var path in paths){
            unique.Add(path[0]);
        }
        foreach (var path in paths){
            if(!unique.Contains(path[1])){
                return path[1];
            }
        }
        
        return unique.Last();
    }
}