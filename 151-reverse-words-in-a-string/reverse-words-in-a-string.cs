public class Solution {
    public string ReverseWords(string s) {
        string[] arr = s.Split(" ");

        arr = arr.Where(x => x.Length > 0).ToArray();

        Array.Reverse(arr);

        return String.Join(" ", arr);
    }
}