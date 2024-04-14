using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rows = new HashSet<char>[9];
            var cols = new HashSet<char>[9];
            var box = new HashSet<char>[9];

            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<char>();
                cols[i] = new HashSet<char>();
                box[i] = new HashSet<char>();
            }

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    var item = board[row][col];
                    if (item == '.') continue;
                    if (!rows[row].Contains(item)) rows[row].Add(item);
                    else return false;

                    if (!cols[col].Contains(item)) cols[col].Add(item);
                    else return false;

                    var idx = (row / 3 * 3) + (col / 3);
                    if (!box[idx].Contains(item)) box[idx].Add(item);
                    else return false;
                }
            }
            return true;
        }
    }
}
