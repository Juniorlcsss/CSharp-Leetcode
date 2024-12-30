public class Solution {
    public int RomanToInt(string s) {
        //replacing
        s=s.Replace("IV","IIII");
        s=s.Replace("IX","VIIII");
        s=s.Replace("XL","XXXX");
        s=s.Replace("XC","XXXXXXXXX");
        s=s.Replace("CD","CCCC");
        s=s.Replace("CM", "DCCCC");

        //loop
        int count = 0;
        for(int i=0; i<s.Length; i++){
            switch (s[i]){
                case 'I':
                    count++;
                    break;

                case 'V':
                    count+=5;
                    break;
                
                case 'X':
                    count+=10;
                    break;

                case 'L':
                    count+=50;
                    break;

                case 'C':
                    count+=100;
                    break;

                case 'D':
                    count+=500;
                    break;

                case 'M':
                    count+=1000;
                    break;
            }
        }
        return count;
    }
}