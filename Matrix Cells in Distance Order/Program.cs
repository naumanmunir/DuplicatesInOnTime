using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Cells_in_Distance_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            AllCellsDistOrder(89, 90, 21, 65);
        }

        static int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            Queue<Cell> queue = new Queue<Cell>();
            HashSet<Cell> hs = new HashSet<Cell>();

            Cell cell = new Cell(r0, c0, true);
            queue.Enqueue(cell);
            hs.Add(cell);

            var totalCells = R * C;

            while (queue.Count > 0 && totalCells != hs.Count)
            {
                Cell c = queue.Dequeue();
                
                if(c.RowIndex+1 < R)
                {
                    Cell newC = new Cell(c.RowIndex + 1, c.ColIndex, true);

                    var res = hs.Where(x => x.RowIndex == newC.RowIndex && x.ColIndex == newC.ColIndex).FirstOrDefault();
                    if (res == null)
                    {
                        hs.Add(newC);
                        queue.Enqueue(newC);
                    }

                }
                if (c.RowIndex - 1 >= 0)
                {
                    Cell newC = new Cell(c.RowIndex - 1, c.ColIndex, true);

                    var res = hs.Where(x => x.RowIndex == newC.RowIndex && x.ColIndex == newC.ColIndex).FirstOrDefault();
                    if (res == null)
                    {
                        hs.Add(newC);
                        queue.Enqueue(newC);
                    }
                }
                if (c.ColIndex + 1 < C)
                {
                    Cell newC = new Cell(c.RowIndex, c.ColIndex + 1, true);

                    var res = hs.Where(x => x.RowIndex == newC.RowIndex && x.ColIndex == newC.ColIndex).FirstOrDefault();
                    if (res == null)
                    {
                        hs.Add(newC);
                        queue.Enqueue(newC);
                    }
                }
                if (c.ColIndex - 1 >= 0)
                {
                    Cell newC = new Cell(c.RowIndex, c.ColIndex - 1, true);

                    var res = hs.Where(x => x.RowIndex == newC.RowIndex && x.ColIndex == newC.ColIndex).FirstOrDefault();
                    if (res == null)
                    {
                        hs.Add(newC);
                        queue.Enqueue(newC);
                    }
                }
            }

            int[][] mat = new int[hs.Count][];

            int z = 0;
            foreach (var item in hs)
            {
                mat[z] = new int[2] { item.RowIndex, item.ColIndex };
                z++;
            }

            return mat;
        }
    }

    public class Cell
    {
        public int RowIndex { get; set; }
        public int ColIndex { get; set; }
        public bool Visited { get; set; }

        public Cell(int r, int c, bool v)
        {
            RowIndex = r;
            ColIndex = c;
            Visited = v;
        }
    }
}
