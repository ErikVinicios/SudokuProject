﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProject
{
    public class Easy : Game
    {
        public int[,] EasyGame = { { 7, 0, 0, 1, 8, 0, 6, 0, 0},
                                { 1, 0, 0, 6, 0, 0, 8, 2, 5},
                                { 4, 8, 6, 5, 9, 0, 3, 0, 0},
                                { 0, 2, 0, 4, 6, 8, 0, 1, 0},
                                { 6, 3, 9, 0, 0, 0, 4, 5, 8},
                                { 0, 1, 0, 3, 5, 9, 0, 6, 0},
                                { 0, 0, 8, 0, 2, 5, 1, 3, 6},
                                { 3, 6, 5, 0, 0, 4, 0, 0, 7},
                                { 0, 0, 1, 0, 3, 6, 0, 0, 9}};

        public Easy(Form1 form1) : base(form1)
        {
        }

        public override int[,] Feedback { get => EasyGame; set => EasyGame = value; }
    }
}
