public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = 0, fast = 0;

        do {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while(slow != fast);

        // Console.WriteLine($"slow: {slow}; fast: {fast}");

        int next = 0;
        while(next != slow) {
            next = nums[next];
            slow = nums[slow];
        }

        return next;
    }
}