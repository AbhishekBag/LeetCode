public class TopVotedCandidate {
    // Dictionary<person, Candidate>
    public Dictionary<int, int> timeLeadMap = new Dictionary<int, int>();
    public int[] times;
    // Dictionary<time, List<Candidate>>
    // public Dictionary<int, List<Candidate>> leading = new Dictionary<int, List<Candidate>>();
    public TopVotedCandidate(int[] persons, int[] times) {
        this.times = times;
        int lead = -1;
        Dictionary<int, int> voteMap = new Dictionary<int, int>();

        for(int i = 0; i < times.Length; i++) {
            int p = persons[i];
            int t = times[i];

            if(voteMap.ContainsKey(p)) {
                voteMap[p]++;
            } else {
                voteMap[p] = 1;
            }

            if(lead == -1 || voteMap[p] >= voteMap[lead]) {
                lead = p;
            }

            timeLeadMap[t] = lead;
        }
    }

    public int Q(int t) {
        int timeIndex = BinarySearch(times, t);
        return timeLeadMap[times[timeIndex]];
    }

    private int BinarySearch(int[] times, int time) {
        int i = 0;
        int j = times.Length - 1;

        while(i <= j) {
            int mid = i + (j - i) / 2;
            if(times[mid] == time) {
                return mid;
            } else if(time > times[mid]) {
                i = mid + 1;
            } else {
                j = mid - 1;
            }
        }

        return i - 1;
    }
    
    /*
    // Dictionary<time, SortedList<(person, voteCount, time)>>
    // private Dictionary<int, SortedList<Candidate>> map;

    // Dictionary<time, Dictionary<person, Candidate>>
    private Dictionary<int, Dictionary<int, Candidate>> map;
    public TopVotedCandidate(int[] persons, int[] times) {
        map = new Dictionary<int, Dictionary<int, Candidate>>();

        for(int i = 0; i < persons.Length; i++) {
            int p = persons[i];
            int t = times[i];
            if(map.ContainsKey(t)) {
                if(map[t].ContainsKey(p)) {
                    map[t][p].voteCount++;
                    map[t][p].time = t;
                } else {
                    map[t][p] = new Candidate(p, t, 1);
                }
            } else {
                map[t] = new Dictionary<int, Candidate>(){
                    {p, new Candidate(p, t, 1)}
                };
            }
        }

        foreach(var item in map) {
            Console.WriteLine($"time: {item.Key}:");
            foreach(var p in item.Value) {
                Console.Write($"person: {p.Value.person}; votes: {p.Value.voteCount}; time: {p.Value.time}.");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
    
    public int Q(int t) {
        if(map.ContainsKey(t)) {
            var candidates = map[t].Select(x => x.Value).ToList();
            candidates.Sort((x, y) => {
                if(x.voteCount > y.voteCount) {
                    return 1;
                } else if(x.voteCount < y.voteCount) {
                    return -1;
                } else {
                    if(x.time >= y.time) {
                        return 1;
                    } else {
                        return -1;
                    }
                }
            });

            return candidates.FirstOrDefault().person;
        }

        return -1;
    }
    }
    */
}

public class Candidate {
    public int person { get; set; }
    public int voteCount { get; set; }
    public int time { get; set; }
    
    public Candidate(int p, int v, int t) {
        person = p;
        time = t;
        voteCount = v;
    }
}

/**
 * Your TopVotedCandidate object will be instantiated and called as such:
 * TopVotedCandidate obj = new TopVotedCandidate(persons, times);
 * int param_1 = obj.Q(t);
 */