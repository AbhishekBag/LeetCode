public class Solution {
    public string RankTeams(string[] votes) {
        if (votes.Length == 1) {
            return votes[0];
        }

        int n = votes[0].Length;
        Dictionary<char, int[]> weightedVotes = new Dictionary<char, int[]>();

        foreach (string vote in votes) {
            for (int i = 0; i < n; i++) {
                char c = vote[i];
                if (!weightedVotes.ContainsKey(c)) {
                    weightedVotes[c] = new int[n];
                }
                weightedVotes[c][i]++;
            }
        }

        List<char> teams = weightedVotes.Keys.ToList();
        teams.Sort((a, b) => {
            for (int i = 0; i < n; i++) {
                if (weightedVotes[a][i] != weightedVotes[b][i]) {
                    return weightedVotes[b][i].CompareTo(weightedVotes[a][i]);
                }
            }
            return a.CompareTo(b); // Compare alphabetically if votes are the same
        });

        return new string(teams.ToArray());
    }

    private void DisplayWeightedVotesMap(List<(int, char)> map) {
        for(int i = 0; i < map.Count(); i++) {
            Console.Write($"({map[i].Item1} => {map[i].Item2}), ");
        }

        Console.WriteLine();
    }

    private void DisplayWeightedVotes(int[] arr) {
        for(int i = 0; i < arr.Length; i++) {
            Console.Write($"{arr[i]}, ");
        }

        Console.WriteLine();
    }
}