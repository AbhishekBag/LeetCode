public class Solution {
    private int[] arr;
    public int Rob(int[] nums) {
        arr = Enumerable.Repeat(-1, nums.Length).ToArray();
        return RobHouse(nums, 0);
    }

    private int RobHouse(int[] nums, int i) {
        if(i >= nums.Length) {
            return 0;
        }

        if(arr[i] != -1) {
            return arr[i];
        }

        int take = nums[i] + RobHouse(nums, i + 2);
        int dontTake = RobHouse(nums, i + 1);

        arr[i] = Math.Max(take, dontTake);

        return arr[i];
    }
}

/*
1,2,3,1 (i)

if(i > length)
    return 0

take money at i:
sum + val
f(i + 2)

dont take at i:
sum
f(i + 1)
*/