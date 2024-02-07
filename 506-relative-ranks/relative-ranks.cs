public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        PriorityQueue<int, int> q = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        for(int i = 0; i < score.Length; i++) {
            q.Enqueue(i, score[i]);
        }

        string[] res = new string[score.Length];
        int rank = 1;
        while(q.Count > 0) {
            var dQ = q.Dequeue();

            switch(rank) {
                case 1:
                    res[dQ] = "Gold Medal";
                    break;
                case 2:
                    res[dQ] = "Silver Medal";
                    break;
                case 3:
                    res[dQ] = "Bronze Medal";
                    break;
                default:
                    res[dQ] = rank.ToString();
                    break;
            }

            rank++;
        }

        return res;
    }
}