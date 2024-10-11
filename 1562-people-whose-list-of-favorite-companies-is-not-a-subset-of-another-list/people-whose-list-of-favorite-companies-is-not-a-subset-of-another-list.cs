public class Solution {
    public IList<int> PeopleIndexes(IList<IList<string>> favoriteCompanies) {
        List<HashSet<string>> companies = favoriteCompanies.Select(lst => lst.ToHashSet<string>()).ToList();
        List<int> res = new List<int>();

        for(int i = 0; i < companies.Count(); i++) {
            bool flg = false;
            for(int j = 0; j < companies.Count(); j++) {
                if(i == j) {
                    continue;
                }

                if(companies[i].IsSubsetOf(companies[j])) {
                    flg = true;
                    break;
                }
            }

            if(!flg) {
                res.Add(i);
            }
        }

        return res;
    }
}