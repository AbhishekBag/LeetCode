public class Solution {
    int[][] arr;
    public int MaximumScore(int[] nums, int[] multipliers) {
        arr = new int[multipliers.Length][];
        for(int i = 0; i < multipliers.Length; i++) {
            arr[i] = Enumerable.Repeat(Int32.MaxValue, nums.Length).ToArray();
        }

        return GetScore(nums, 0, nums.Length - 1, multipliers, 0);
    }

    private int GetScore(int[] nums, int start, int end, int[] multipliers, int opIndex) {
        if(opIndex >= multipliers.Length) {
            return 0;
        }

        if(arr[start][multipliers.Length - (nums.Length - end)] != Int32.MaxValue) {
            return arr[start][multipliers.Length - (nums.Length - end)];
        }

        int pickedStart = multipliers[opIndex] * nums[start] + GetScore(nums, start + 1, end, multipliers, opIndex + 1);
        int pickedEnd = multipliers[opIndex] * nums[end] + GetScore(nums, start, end - 1, multipliers, opIndex + 1);

        arr[start][multipliers.Length - (nums.Length - end)] = Math.Max(pickedStart, pickedEnd);

        return arr[start][multipliers.Length - (nums.Length - end)];
    }
}

/*
nums  multiplies
 fun(nums, start, end, multiplies, opIndex)

 opIndex == multiplies.Length
 return 0

 choice: pick start => fun(nums, start + 1, end, multiplies, opIndex + 1)  score = pickedItem * multiplies[opI]
         pick end   => fun(nums, start, end - 1, multiplies, opIndex + 1)

         return max(pick Start, pick end)
*/