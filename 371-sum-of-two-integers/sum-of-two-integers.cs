public class Solution {
    public int GetSum(int a, int b) {
        int carry = b;
        while(b != 0) {
            carry = (a & b) << 1;
            a = a ^ b;
            b  = carry;
        }

        return a;
    }
}