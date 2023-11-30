public class Solution {
    public IList<IList<int>> HighestRankedKItems(int[][] grid, int[] pricing, int[] start, int k) {
        List<Cell> map = new List<Cell>();

        List<IList<int>> res = new List<IList<int>>();

        BFS(grid, pricing, start[0], start[1], map);

        map.Sort((a, b) => {
            if(a.distance != b.distance) {
                return a.distance.CompareTo(b.distance);
            }
            if(a.price != b.price) {
                return a.price.CompareTo(b.price);
            }
            if(a.row != b.row) {
                return a.row.CompareTo(b.row);
            }
            if(a.col != b.col) {
                return a.col.CompareTo(b.col);
            }

            return 0;
        });

        for(int i = 0; i < k && i < map.Count(); i++) {
            var t = new List<int>();
            t.Add(map[i].row);
            t.Add(map[i].col);

            res.Add(t);
        }

        return res;
    }

    private void BFS(int[][] grid, int[] pricing, int r, int c, List<Cell> res) {
        int[] row = new int[] {0, 1, 0, -1};
        int[] col = new int[] {1, 0, -1, 0};
        Queue<Cell> q = new Queue<Cell>();
        HashSet<string> visited = new HashSet<string>();

        q.Enqueue(new Cell(r, c, grid[r][c], 0));
        while(q.Count() > 0) {
            var poped = q.Dequeue();

            if(!visited.Contains($"{poped.row}_{poped.col}")) {
                if(pricing[0] <= poped.price  && poped.price <= pricing[1] && poped.price != 1) {
                    res.Add(poped);
                }
                for(int i = 0; i < 4; i++) {
                    int nR = poped.row + row[i];
                    int nC = poped.col + col[i];

                    if(IsValidCell(grid, nR, nC)) {
                        q.Enqueue(new Cell(nR, nC, grid[nR][nC], poped.distance + 1));                        
                    }
                }
                
                visited.Add($"{poped.row}_{poped.col}");
            }
        }
    }

    private bool IsValidCell(int[][] grid, int r, int c) {
        int R = grid.Length;
        int C = grid[0].Length;

        if(r < 0 || r >= R || c < 0 || c >= C || grid[r][c] == 0) {
            return false;
        }

        return true;
    }
}

public class Cell {
    public int row;
    public int col;
    public int price;
    public int distance;

    public Cell(int r, int c, int p, int d) {
        row = r;
        col = c;
        price = p;
        distance = d;
    }
}