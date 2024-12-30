public class Solution {
    public bool RotateString(string s, string goal) {
        if(s.Length == goal.Length && (s + s).Contains(goal)){
            return true;
        }
        else{
            return false;
        }
    }
}