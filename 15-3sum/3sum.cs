public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        HashSet<(int, int, int)> hashMap = new HashSet<(int, int, int)>();

        for(int i = 0; i < nums.Length; i++) {
            var triplets = GetTriplets(nums, i, -nums[i]);
            foreach(var item in triplets) {
                hashMap.Add(item);
            }
        }

        foreach(var item in hashMap) {
            result.Add(new List<int>() { item.Item1, item.Item2, item.Item3});
        }

        return result;
    }

    private HashSet<(int, int, int)> GetTriplets(int[] nums, int index, int target) {
        Dictionary<int , int> map = new Dictionary<int, int>();
        HashSet<(int, int, int)> res = new HashSet<(int, int, int)>();

        for(int i = index + 1; i < nums.Length; i++) {
            int comp = target - nums[i];

            if(map.ContainsKey(comp)) {
                List<int> lst = new List<int>();
                lst.Add(nums[index]);
                lst.Add(nums[i]);
                lst.Add(nums[map[comp]]);

                lst.Sort();
                res.Add((lst[0], lst[1], lst[2]));
            } else if(!map.ContainsKey(nums[i])) {
                map.Add(nums[i], i);
            }
        }

        return res;
    }

    /*
    public IList<IList<int>> ThreeSum(int[] nums) {
        HashSet<IList<int>> result = new HashSet<IList<int>>(new ListComparer());
        for(int i = 0; i < nums.Length; i++) {
            // result.AddRange(GetElements(nums, nums[i], i));

            foreach(var item in GetElements(nums, nums[i], i)) {
                result.Add(item);
            }
        }

        return result.ToList();
    }

    private HashSet<List<int>> GetElements(int[] nums, int sum, int index) {
        HashSet<List<int>> res = new HashSet<List<int>>(new ListComparer());
        for(int i = 0; i < nums.Length; i++) {
            if(i == index) {
                continue;
            }

            int target = sum - nums[i];
            for(int j = 0; j < nums.Length; j++) {
                if(j == i || j == index) {
                    continue;
                }

                if(sum + nums[i] + nums[j] == 0) {
                    Console.WriteLine($"Sum: {sum}, i: {nums[i]}, j: {nums[j]}; total: {sum + nums[i] + nums[j]}");
                    List<int> lst = new List<int>();
                    lst.Add(sum);
                    lst.Add(nums[i]);
                    lst.Add(nums[j]);
                    lst.Sort();

                    res.Add(lst);
                }
            }
        }

        return res;
    }

    class ListComparer : IEqualityComparer<IList<int>>
    {
        public bool Equals(IList<int> x, IList<int> y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(IList<int> obj)
        {
            return obj.Sum();
        }
    }
    */
}