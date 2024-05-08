public class Solution {
    public int Reverse(int x) {
        int res = 0;
        int tmp = 0;

        // Handle edge case for minimum value of integer
        if (x == int.MinValue) {
            return 0;
        }

        while(x != 0) {
            int rem = x%10;
            tmp = res * 10 + rem;
            x = x/10;

            if((tmp - rem)/10 != res) {
                return 0;
            }

            res = tmp;

            //Console.WriteLine($"x: {x}, res: {res}");
        }

        return res;
    }
}