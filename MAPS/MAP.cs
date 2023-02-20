using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Caster
{
    public class Map
    {
        public char[,] map = new char[,] { };

        public Map(string str)
        {
            string[] lines = File.ReadAllLines(str);
            int xL = int.Parse(lines[0]);
            //int y = int.Parse(lines[1]);

            map = new char[25, 25];

            for (int y = 2; y < lines.Length; y++)
            {
                string res = lines[y].Replace(",", "");
                char[] l = res.ToCharArray();
                for (int x = 0; x < l.Length; x++)
                {                    
                    map[x, y-2] = l[x];
                }
            }
        }

        public Map(char[,] map)
        {
            this.map = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    this.map[x, y] = '0';
                }
            }
        }

        public void Save()
        {
            StringBuilder str;

            str = new StringBuilder();
            str.Append(map.GetLength(0) + "\r\n");
            str.Append(map.GetLength(1) + "\r\n");

            for (int y = 0; y < map.GetLength(1); y++)
            {
                str.Append(map[0, y]);
                for (int x = 1; x < map.GetLength(0); x++)
                {
                    str.Append("," + map[x, y]);
                }
                str.Append("\r\n");
            }

            File.WriteAllText("mtx.mx", str.ToString());
        }
    }
}
