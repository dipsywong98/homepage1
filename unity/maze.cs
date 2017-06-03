using System;

public class Maze
{
    private Random rnd = new Random();
    public Maze(int _w, int _h)
    {
        this._w = _w; this._h = _h;
        map = new bool[_w, _h];
        for (int i = 0; i < _w; i++)
        {
            for (int j = 0; j < _h; j++)
            {
                map[i, j] = true;
            }
        }
        dfs(1, 1);
        for (int i = 0; i < _w; i++)
        {
            for (int j = 0; j < _h; j++)
            {
                Console.Write(map[i, j] ? 1 : 0);
            }
            Console.Write("\n");
        }
    }

    private void dfs(int x, int y)
    {
        map[x, y] = false;
        int[] neighbour = new int[4];
        int sum = 0;
        for (int i = 0; i < 4; i++)
        {
            if (((x + 2 * dx[i]) < 0) || ((x + 2 * dx[i]) >= _w) || ((y + 2 * dy[i]) < 0) || ((y + 2 * dy[i]) >= _h))
            {
                continue;
            }
            if (map[x + 2 * dx[i], y + 2 * dy[i]] == true)
            {
                neighbour[sum++] = i;
            }
        }
        if (sum == 0) return;
        int d = neighbour[rnd.Next(0, sum)];
        map[x + 1 * dx[d], y + 1 * dy[d]] = false;
        dfs(x + 2 * dx[d], y + 2 * dy[d]);
        dfs(x, y);
        return;
    }

    public int _w, _h;
    public bool[,] map;
    private int[] dx = { -1, 0, 1, 0 }, dy = { 0, 1, 0, -1 };
}
