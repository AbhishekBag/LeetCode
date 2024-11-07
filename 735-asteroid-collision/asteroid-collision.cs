public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        if(asteroids.Length <= 1) {
            return asteroids;
        }

        Stack<int> collection = new Stack<int>();
        foreach(var asteroid in asteroids) {
            bool hasColided = false;
            while(collection.Count > 0 && IsItGoingToColide(collection.Peek(), asteroid)) {
                int peek = collection.Peek();
                if(Math.Abs(peek) == Math.Abs(asteroid)) {
                    collection.Pop();
                    hasColided = true;
                    break;
                }

                if(Math.Abs(peek) > Math.Abs(asteroid)) {
                    hasColided = true;
                    break;
                } else {
                    collection.Pop();
                }
            }

            if(!hasColided) {
                collection.Push(asteroid);
            }
        }

        var arr = collection.ToArray();
        Array.Reverse(arr);

        return arr;
    }

    private bool IsItGoingToColide(int peeked, int asteroid) {
        if(peeked > 0 && asteroid < 0) {
            return true;
        }

        return false;
    }
}