namespace TaoOneHacker.DataStructure.Core._14_HashTables._01_Hash_Table_Basics;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var freq = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            var t = s[i] - 'a';
            
            freq[s[i] - 'a']++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (freq[s[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}