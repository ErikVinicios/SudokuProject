using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProject
{
    internal class Hard : Game
    {
        private int[,] HardGame = { { 2, 0, 0, 5, 0, 7, 4, 0, 6},
                                { 0, 0, 0, 0, 3, 1, 0, 0, 0},
                                { 0, 0, 0, 0, 0, 0, 2, 3, 0},
                                { 0, 0, 0, 0, 2, 0, 0, 0, 0},
                                { 8, 6, 0, 3, 1, 0, 0, 0, 0},
                                { 0, 4, 5, 0, 0, 0, 0, 0, 0},
                                { 0, 0, 9, 0, 0, 0, 7, 0, 0},
                                { 0, 0, 6, 9, 5, 0, 0, 0, 2},
                                { 0, 0, 1, 0, 0, 6, 0, 0, 8}};

        public Hard(Form1 form1) : base(form1)
        {
        }

        public override int[,] Feedback { get => HardGame; set => HardGame = value; }
    }
}
