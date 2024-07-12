public class Solution {
    private int[] sides;
    private int sideLength;
    public bool Makesquare(int[] matchsticks) {
        sides = new int[4];
        int sum = matchsticks.Sum();
        sideLength = sum/4;
        if(sum % 4 != 0) {
            return false;
        }
        matchsticks = matchsticks.OrderByDescending(x => x).ToArray();

        return CanBuildSquare(matchsticks, 0);
    }

    private bool CanBuildSquare(int[] matchsticks, int index) {
        if(index == matchsticks.Length) {
            return true;
        }

        for(int s = 0; s < 4; s++) {
            if(sides[s] + matchsticks[index] <= sideLength) {
                sides[s] += matchsticks[index];
                if(CanBuildSquare(matchsticks, index + 1)) {
                    return true;
                }

                sides[s] -= matchsticks[index];
            }
        }

        return false;
    }
}