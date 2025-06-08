public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0, j = numbers.Length - 1;

        while(i <= j) {
            while(i < numbers.Length && numbers[i] + numbers[j] < target) {
                i++;
            }

            while(j >= 0 && numbers[i] + numbers[j] > target) {
                j--;
            }

            if(numbers[i] + numbers[j] == target) {
                return new int[2] { i + 1, j + 1 };
            }
        }

        return new int[2];
    }
}