public class Solution {
    public int HeightChecker(int[] heights) {
        int[] temp = new int[heights.Length];
        for(int j=0; j<heights.Length; j++){
            temp[j] = heights[j];
        }
        Array.Sort(temp);
        int count = 0;
        for(int i=0; i<heights.Length; i++){
            if(temp[i] != heights[i]){
                count++;
            }
            else{
                //loop again
            }
        }
        return count;
    }
}