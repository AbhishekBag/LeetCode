public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0, j = numbers.Length - 1;

        while(i < j) {
            // while(i < numbers.Length && numbers[i] + numbers[j] < target) {
            //     i++;
            // }

            // while(j >= 0 && numbers[i] + numbers[j] > target) {
            //     j--;
            // }

            var sum = numbers[i] + numbers[j];
            if(sum < target) {
                i++;
            } else if(sum >target) {
                j--;
            } else break;
        }

        return new int[2] {i+1, j+1};
    }
}