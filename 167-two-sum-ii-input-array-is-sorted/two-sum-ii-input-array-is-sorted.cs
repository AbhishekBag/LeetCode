public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        for(int i = 0; i < numbers.Length - 1; i++) {
            int k = BinarySearch(numbers, i + 1, target - numbers[i]);

            // Console.WriteLine($"i: {i}; target: {target}; searchTarget: {target - numbers[i]}; returnedIndex: {k}");

            if(k != -1) {
                res[0] = i + 1;
                res[1] = k + 1;

                break;
            }
        }

        return res;
    }

    private int BinarySearch(int[] nums, int s, int target) {
        int n = nums.Length - 1;
        int mid = 0;
        while(s <= n) {
            mid = (s + n) / 2;
            // Console.WriteLine($"s: {s}; mid: {mid}; n: {n}");
            if(nums[mid] == target) {
                return mid;
            }

            if(nums[mid] > target) {
                n = mid - 1;
            } else {
                s = mid + 1;
            }
        }

        return -1;
    }
}