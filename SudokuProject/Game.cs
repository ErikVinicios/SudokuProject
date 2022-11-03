using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProject
{
    public class Game
    {
        Form1 form;

        public Game(Form1 form1)
        {
            form = form1;
            CreateGame();
        }

        public virtual int[,] Feedback { get; set; }
        public void CreateGame()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Feedback[i, j] != 0)
                    {
                        form.dataGridView1.Rows[i].Cells[j].Value = Feedback[i, j];
                        form.dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        form.dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                    }
                    else
                    {
                        form.dataGridView1.Rows[i].Cells[j].Value = null;
                        form.dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                        form.dataGridView1.Rows[i].Cells[j].ReadOnly = false;
                    }
                }
            }
        }
    }
}
