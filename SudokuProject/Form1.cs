using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuProject
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 9;

            for (int i=0;i<9;i++)
            {
                for (int j=0;j<9;j++)
                {
                    if ((i < 3 || i >= 6) && (j < 3 || j >= 6))
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.DarkOrange;
                    if ((i >= 3 && i < 6) && (j >= 3 && j < 6))
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.DarkOrange;
                }
            }
        }

        private void btEasy_Click(object sender, EventArgs e)
        {
            game = new Easy(this);
        }

        private void btMedium_Click(object sender, EventArgs e)
        {
            game = new Medium(this);
        }

        private void btHard_Click(object sender, EventArgs e)
        {
            game = new Hard(this);
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            int[,] sudoku = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        sudoku[i, j] = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    else
                        sudoku[i, j] = 0;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                int soma = 0;
                for (int j = 0; j < 9; j++)
                {
                    soma += sudoku[i, j];
                }
                if (soma != 45)
                {
                    MessageBox.Show($"Error on the line {(i + 1).ToString()}", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }

            int lin, col;
            int[] linha = { 0, 3, 6, 0, 3, 6, 0, 3, 6 };
            int[] coluna = { 0, 0, 0, 3, 3, 3, 6, 6, 6 };
            int[] possivel = new int[10];

            for (int qua=0; qua<9; qua++)
            {
                lin = linha[qua];
                col = coluna[qua];

                int soma = 0;

                for (int i=lin;i<lin+3;i++)
                {
                    for (int j=col;j<col+3;j++)
                    {
                        soma += sudoku[i, j];
                    }
                }

                if (soma != 45)
                {
                    MessageBox.Show($"Error in the square {(qua + 1).ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Game completed successfully! ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to go out? ", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
