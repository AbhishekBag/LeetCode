public class Solution {
    public int HIndex(int[] citations) {
        int max = 0;
        for(int i = 0; i < citations.Length; i++) {
            max = Math.Max(max, citations[i]);
        }

        int[] arr = new int[max + 1];
        foreach(var citation in citations) {
            for(int i = 0; i <= citation; i++) {
                arr[i]++;
            }
        }

        int cMax = -1, cIndex = -1;
        for(int i = 0; i < max + 1; i++) {
            if(i <= arr[i]) {
                cMax = i;
            }
        }
        return cMax;

        foreach(var citation in citations) {
            if(citation == 0) {
                continue;
            }
            if(cMax < arr[citation]) {
                cMax = arr[citation];
                cIndex = citation;
            }
        }

        // return cMax;


        for(int i = 0; i < max + 1; i++) {
            Console.WriteLine($"i: {i} => {arr[i]}");
            if(cMax < arr[i]) {
                cMax = arr[i];
                // cIndex = i;
            }
        }

        //return cIndex;

        /*
        Array.Sort(citations);
        for(int i = citations.Length - 1; i >= 0; i--) {
            if(IsHIndex(i, citations)) {
                return i;
            }
        }

        return -1;
        */
    }

    private bool IsHIndex(int i, int[] citations) {
        int count = 0;
        Console.WriteLine($"Checking for i: {i}");
        for(int j = citations.Length - 1; j >= 0; j--) {
            Console.WriteLine($"citations[j]: {citations[j]}");
            if(i > citations[j]) {
                break;
            }

            count++;
        }
        
        Console.WriteLine($"i >= count: {i} >= {count} = {i >= count}");
        return i >= count;
        Console.WriteLine();
    }
}

/*
3,0,6,1,5
0,1,3,5,6
0,4,3,2,1
*/