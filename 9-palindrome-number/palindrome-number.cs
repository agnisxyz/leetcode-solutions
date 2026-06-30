public class Solution {
    public bool IsPalindrome(int x) {

        int number = x;
        int reversedNumber = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;
            reversedNumber = (reversedNumber * 10) + lastDigit;
            number = number / 10;
        }
        return reversedNumber == x;     
    }
}