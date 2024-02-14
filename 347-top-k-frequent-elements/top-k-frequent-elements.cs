public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequencyMap = new Dictionary<int, int>();
        foreach(var num in nums) {
            if(!frequencyMap.ContainsKey(num)) {
                frequencyMap[num] = 0;
            }

            frequencyMap[num]++;
        }

        var freqList = frequencyMap.Select(x => (x.Key, x.Value)).ToList();
        freqList.Sort((a, b) => b.Item2.CompareTo(a.Item2));
        List<int> res = new List<int>();
        for(int i = 0; i < k; i++) {
            res.Add(freqList[i].Item1);
        }

        return res.ToArray();
    }
}