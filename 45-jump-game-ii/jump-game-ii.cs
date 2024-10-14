public class Solution {
    public int Jump(int[] nums) {
        Queue<Jump> q = new Queue<Jump>();
        HashSet<int> visited = new HashSet<int>();

        q.Enqueue(new Jump(0, 0));
        visited.Add(0);

        while(q.Count() > 0) {
            var dq = q.Dequeue();
            if(dq.index == nums.Length - 1) {
                return dq.jumpCount;
            }

            for(int i = 1; i < nums.Length && i <= nums[dq.index]; i++) {
                if(!visited.Contains(dq.index + i)) {
                    visited.Add(dq.index + i);
                    q.Enqueue(new Jump(dq.index + i, dq.jumpCount + 1));
                }                
            }
        }

        return -1;
    }
}

public class Jump {
    public int index;
    public int jumpCount;

    public Jump(int _i, int _j) {
        index = _i;
        jumpCount = _j;
    }
}