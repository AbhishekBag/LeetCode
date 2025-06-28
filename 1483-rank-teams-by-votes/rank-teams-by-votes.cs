public class Solution {
    public string RankTeams(string[] votes) {
        int n = votes[0].Length;
        Dictionary<char, int[]> rankMap = new Dictionary<char, int[]>();

        foreach(char c in votes[0]) {
            rankMap[c] = new int[n];
        }

        foreach(string vote in votes) {
            for(int i = 0; i < n; i++) {
                rankMap[vote[i]][i]++;
            }
        }

        List<char> rank = rankMap.Keys.ToList();

        rank.Sort((a, b) => {
            for(int i = 0; i < n; i++) {
                if(rankMap[a][i] != rankMap[b][i]) {
                    return rankMap[b][i].CompareTo(rankMap[a][i]);
                }
            }

            return a.CompareTo(b);
        });

        return new string(rank.ToArray());
    }
}