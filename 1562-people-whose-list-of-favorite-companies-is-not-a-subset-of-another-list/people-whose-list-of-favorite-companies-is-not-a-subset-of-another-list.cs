public class Solution {
    public IList<int> PeopleIndexes(IList<IList<string>> favoriteCompanies) {
        List<int> res = new List<int>();
        List<HashSet<string>> companies = favoriteCompanies.Select(lst => lst.ToHashSet<string>()).ToList();

        for(int i = 0; i < companies.Count(); i++) {
            bool isSubset = false;
            for(int j = 0; j < companies.Count(); j++) {
                if(i == j) {
                    continue;
                }

                Console.WriteLine($"i: {i}, j: {j}");

                if(companies[i].IsSubsetOf(companies[j])) {
                    isSubset = true;
                    break;
                }
            }

            if(!isSubset) {
                res.Add(i);
            }
        }

        return res;
    }
}