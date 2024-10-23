public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        if(tasks.Length <= 1) {
            return tasks.Length;
        }

        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        Queue<(int remainingTaskCount, int availableTime)> q = new Queue<(int, int)>();
        int[] arr = new int[26];

        foreach(char c in tasks) {
            arr[c - 'A']++;
        }

        foreach(var item in arr) {
            if(item > 0) {
                heap.Enqueue(item, -item);
            }
        }

        int time = 0;
        while(heap.Count > 0 || q.Count > 0) {
            time++;

            if(heap.Count > 0) {
                var dq = heap.Dequeue();
                dq--;

                if(dq > 0) {
                    q.Enqueue((dq, time + n));
                }
            }

            if(q.Count > 0) {
                var peek = q.Peek();
                if(peek.availableTime == time) {
                    var d = q.Dequeue();
                    heap.Enqueue(d.remainingTaskCount, -d.remainingTaskCount);
                }
            }
        }

        return time;
    }
}