public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        if(s.Length <= 1) {
            return s;
        }

        var arr = s.Split(" ")
                    .Where(x => x.Length >= 1)
                    .ToArray();
        Array.Reverse(arr);

        return string.Join(" ", arr);
    }
}