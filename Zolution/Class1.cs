namespace Zolution;
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = "";
        if(strs.Count()==1){
            return strs[0];
        }
        for (int no = 0; no < strs.Count()-1; no++)
        {
            var str1=strs[no].ToArray();
            var str2=strs[no+1].ToArray();
            if (no == 0)
            {
                result = NewMethod(result, str1, str2);
            }
            else
            {
                result = NewMethod("", result.ToArray(), str2);
            }
        }
        
        return result;
    }

    private static string NewMethod(string result, char[] str1, char[] str2)
    {
        for (int nos = 0; nos < str1.Count() && nos < str2.Count(); nos++)
        {
            if (str1[nos] == str2[nos])
            {
                result += str1[nos];
            }
            else
            {
                break;
            }
        }

        return result;
    }
}