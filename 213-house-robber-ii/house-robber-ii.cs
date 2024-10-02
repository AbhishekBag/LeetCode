public class Solution {
    private int[] collection1;
    private int[] collectionN;
    public int Rob(int[] nums) {
        if(nums.Length == 1) {
            return nums[0];
        }
        
        collection1 = Enumerable.Repeat(-1, nums.Length).ToArray();
        collectionN = Enumerable.Repeat(-1, nums.Length).ToArray();
        return Math.Max(RobHouse(nums, 0, nums.Length - 2, collection1), RobHouse(nums, 1, nums.Length - 1, collectionN));
    }

    private int RobHouse(int[] nums, int houseNo, int end, int[] collection) {
        if(houseNo > end) {
            return 0;
        }

        if(collection[houseNo] != -1) {
            return collection[houseNo];
        }

        int picked = nums[houseNo] + RobHouse(nums, houseNo + 2, end, collection);
        int notPicked = RobHouse(nums, houseNo + 1, end, collection);

        // return Math.Max(picked, notPicked);

        collection[houseNo] = Math.Max(picked, notPicked);
        return collection[houseNo];
    }
}