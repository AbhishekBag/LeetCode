public class Solution {
    public int LongestStrChain(string[] words) {
        Array.Sort(words, (a, b) => {
            return a.Length.CompareTo(b.Length);
        });

        Dictionary<string, int> wordChainLength = new Dictionary<string, int>();
        int longestChainLength = 1;

        foreach(var word in words) {
            wordChainLength[word] = 1;
            int wordLength = word.Length;
            for(int i = 0; i < wordLength; i++) {
                // Console.WriteLine($"word: {word}; i: {i}; pred: {pred.ToString()}");
                StringBuilder pred = new StringBuilder(word);
                pred.Remove(i, 1);
                string predecessor = pred.ToString();

                if(wordChainLength.ContainsKey(predecessor)) {
                    // wordChainLength[word]++;
                    wordChainLength[word] = Math.Max(wordChainLength[word], wordChainLength[predecessor] + 1);
                    longestChainLength = Math.Max(longestChainLength, wordChainLength[word]);
                }
            }
        }

        return longestChainLength;
    }
}
/*
["xbc","pcxbcf","xb","cxbc","pcxbc"]

1. sort words by length => "xb", "xbc", "cxbc", "pcxbc", "pcxbcf"
2. create dictionary for each word to hold letter count
3. for each word in array,
3.1. current = words[i], Add current to the result list (List<List<string>>) at ith index
    if current.Length != words[j].Length - 1, break loop
    else, IsPredecessor(words[i], words[j]) => add words[j] at ith index and set map[i, j] = true

IsPredecessor(str1 => i, str2 => j)
set counter = 1
loop
if(coounter <= 0) => return false
if(str1[i] == str[j]) => i++ and j++
if(str[i + 1] == str[j]), i++, counter--
if(str[i]) == str[j + 1], j++, counter--

end loop
return true;
*/