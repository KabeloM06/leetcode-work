public class Solution {
    public bool IsPalindrome(int x) {
        long revert = 0;             
            int number = x;             
            while (number > 0)
            {
                revert = revert*10 + number%10;
                number /= 10;
            }

            return revert == x;
    }
}