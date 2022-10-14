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
            int[,] feedback = { { 7, 0, 0, 1, 8, 0, 6, 0, 0},
                                { 1, 0, 0, 6, 0, 0, 8, 2, 5},
                                { 4, 8, 6, 5, 9, 0, 3, 0, 0},
                                { 0, 2, 0, 4, 6, 8, 0, 1, 0},
                                { 6, 3, 9, 0, 0, 0, 4, 5, 8},
                                { 0, 1, 0, 3, 5, 9, 0, 6, 0},
                                { 0, 0, 8, 0, 2, 5, 1, 3, 6},
                                { 3, 6, 5, 0, 0, 4, 0, 0, 7},
                                { 0, 0, 1, 0, 3, 6, 0, 0, 9}};

            for (int i=0;i<9;i++)
            {
                for (int j=0;j<9;j++)
                {
                    if (feedback[i, j] != 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = feedback[i, j];
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = null;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                        dataGridView1.Rows[i].Cells[j].ReadOnly = false;
                    }
                }
            }
        }

        private void btMedium_Click(object sender, EventArgs e)
        {
            int[,] feedback = { { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                { 0, 0, 8, 3, 0, 0, 6, 0, 0},
                                { 2, 3, 0, 0, 6, 8, 1, 5, 0},
                                { 1, 9, 0, 0, 0, 0, 7, 0, 0},
                                { 0, 0, 0, 0, 0, 0, 2, 0, 0},
                                { 3, 4, 2, 5, 0, 0, 0, 6, 0},
                                { 0, 0, 0, 1, 0, 0, 0, 2, 0},
                                { 6, 0, 0, 7, 0, 3, 8, 0, 0},
                                { 0, 1, 0, 6, 0, 4, 3, 0, 0}};

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (feedback[i, j] != 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = feedback[i, j];
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = null;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                        dataGridView1.Rows[i].Cells[j].ReadOnly = false;
                    }
                }
            }
        }

        private void btHard_Click(object sender, EventArgs e)
        {
            int[,] feedback = { { 2, 0, 0, 5, 0, 7, 4, 0, 6},
                                { 0, 0, 0, 0, 3, 1, 0, 0, 0},
                                { 0, 0, 0, 0, 0, 0, 2, 3, 0},
                                { 0, 0, 0, 0, 2, 0, 0, 0, 0},
                                { 8, 6, 0, 3, 1, 0, 0, 0, 0},
                                { 0, 4, 5, 0, 0, 0, 0, 0, 0},
                                { 0, 0, 9, 0, 0, 0, 7, 0, 0},
                                { 0, 0, 6, 9, 5, 0, 0, 0, 2},
                                { 0, 0, 1, 0, 0, 6, 0, 0, 8}};

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (feedback[i, j] != 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = feedback[i, j];
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = null;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                        dataGridView1.Rows[i].Cells[j].ReadOnly = false;
                    }
                }
            }
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
