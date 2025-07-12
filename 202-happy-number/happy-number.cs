public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> collection = new HashSet<int>();
        while(!collection.Contains(n)) {

            // Console.WriteLine($"{n} -> ");

            int sum = 0;
            collection.Add(n);
            if(n == 1) {
                return true;
            }

            while(n > 0) {
                var d = n % 10;
                sum += d * d;
                n = n / 10;
            }

            n = sum;
        }

        return false;
    }
}