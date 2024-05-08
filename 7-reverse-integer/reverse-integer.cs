public class Solution {
    public int Reverse(int x) {
        bool isNegetive = x < 0 ? true : false;
        int res = 0;
        int tmp = 0;

        // Handle edge case for minimum value of integer
        if (x == int.MinValue) {
            return 0;
        }

        x = Math.Abs(x);

        while(x != 0) {
            int rem = x%10;
            tmp = res * 10 + rem;
            x = x/10;

            if((tmp - rem)/10 != res) {
                return 0;
            }

            res = tmp;

            // Console.WriteLine($"x: {x}, res: {res}");
        }

        if(res < 0 && isNegetive) {
            return 0;
        }

        return isNegetive ? -1 * res : res;
    }
}