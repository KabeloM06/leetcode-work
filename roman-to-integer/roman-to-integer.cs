public class Solution {
     Dictionary<char, int> dict3 = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},                
                {'M', 1000}
            };
        public int RomanToInt(string s)
        {
            var res = 0;
            var pre = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var cur = dict3[s[i]];
                res += pre > cur ? -cur : cur;
                pre = cur;
            }

            return res;
        }
};