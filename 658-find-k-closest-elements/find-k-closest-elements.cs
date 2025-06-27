public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        List<int> res = new ();
        int mid = FindClosest(arr, x);

        // Console.WriteLine($"mid: {mid}");

        if(mid == 0) {
            for(int i = 0; i < k; i++) {
                res.Add(arr[i]);
            }
        } else if(mid == arr.Length - 1) {
            for(int i = arr.Length - 1; i > arr.Length - 1 - k; i--) {
                res.Insert(0, arr[i]);
            }
        } else {
            res.Add(arr[mid]);
            k--;
            int l = mid - 1;
            int r = mid + 1;

            while(l >= 0 && r < arr.Length && k > 0) {
                if(Math.Abs(arr[l] - x) <= Math.Abs(arr[r] - x)) {
                    res.Insert(0, arr[l]);
                    l--;
                } else {
                    res.Add(arr[r]);
                    r++;
                }

                k--;
            }

            // Console.WriteLine($"k: {k}, res: {string.Join(", ", res)}");

            while(k > 0) {
                if(l >= 0) {
                    res.Insert(0, arr[l--]);
                }

                if(r < arr.Length) {
                    res.Add(arr[r++]);
                }

                k--;
            }
        }

        return res;
    }

    private int FindClosest(int[] arr, int x) {
        int n = arr.Length;
        int left = 0, right = n - 1;

        while(left < right) {
            int mid = (left + right) / 2;
            if(arr[mid] == x) {
                return mid;
            } else if(arr[mid] < x) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }

        if(left == 0) {
            return 0;
        }
        
        // Console.WriteLine($"left: {left}, right: {right}, x: {x}, left - x: {Math.Abs(arr[left - 1] - x)}, right - x: {Math.Abs(arr[right] - x)}");

        return Math.Abs(arr[left - 1] - x) <= Math.Abs(arr[right] - x) ? left - 1 : right;
    }
}