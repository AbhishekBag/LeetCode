public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int [] res = new int[2];
        for(int i = 0; i < numbers. Length; i++) {
            int k = BinarySearch(numbers, target - numbers[i], i + 1);

            if(k != -1) {
                res[0] = i + 1;
                res[1] = k + 1;

                return res;
            }
        }

        return res;
    }

    private int BinarySearch(int[] numbers, int target, int start) {
        int n = numbers.Length - 1;
        int mid = 0;
        while(start <= n) {
            mid = (start + n) / 2;
            if(numbers[mid] == target) {
                return mid;
            }
            if(numbers[mid] > target) {
                n = mid - 1;
            } else {
                start = mid + 1;
            }
        }

        return -1;
    }
}