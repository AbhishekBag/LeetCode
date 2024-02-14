public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {        
        List<int> res = new List<int>();
        Dictionary<int,int> frequencyMap = new Dictionary<int, int>();
        foreach(var num in nums) {
            if(!frequencyMap.ContainsKey(num)) {
                frequencyMap[num] = 0;
            }

            frequencyMap[num]++;
        }

        // Comparer<int>.Create((x, y) => y.CompareTo(x))
        PriorityQueue<int, int> map = new PriorityQueue<int, int>();
        foreach(var item in frequencyMap) {
            map.Enqueue(item.Key, item.Value);
            if(map.Count > k) {
                map.Dequeue();
            }
        }

        for(int i = 0; i < k; i++) {
            var poped = map.Dequeue();
            res.Add(poped);
        }

        // var freqList = frequencyMap.Select(x => (x.Key, x.Value)).ToList();
        // freqList.Sort((a, b) => b.Item2.CompareTo(a.Item2));
        // for(int i = 0; i < k; i++) {
        //     res.Add(freqList[i].Item1);
        // }

        return res.ToArray();
    }
}