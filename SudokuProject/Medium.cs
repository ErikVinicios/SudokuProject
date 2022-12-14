using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProject
{
    public class Medium : Game
    {
        private int[,] MediumGame = { { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                { 0, 0, 8, 3, 0, 0, 6, 0, 0},
                                { 2, 3, 0, 0, 6, 8, 1, 5, 0},
                                { 1, 9, 0, 0, 0, 0, 7, 0, 0},
                                { 0, 0, 0, 0, 0, 0, 2, 0, 0},
                                { 3, 4, 2, 5, 0, 0, 0, 6, 0},
                                { 0, 0, 0, 1, 0, 0, 0, 2, 0},
                                { 6, 0, 0, 7, 0, 3, 8, 0, 0},
                                { 0, 1, 0, 6, 0, 4, 3, 0, 0}};

        public Medium(Form1 form1) : base(form1)
        {
        }

        public override int[,] Feedback { get => MediumGame; set => MediumGame = value; }
    }
}
