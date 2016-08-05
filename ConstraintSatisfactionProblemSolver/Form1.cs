using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csp;


//Author Sami :D 

namespace ConstraintSatisfactionProblemSolver
{
    public partial class Form1 : Form
    {
        Label[,] lbl;
        int[,] table = new int[3, 3];
        ISolver<string, int> solver = new RecursiveBacktrackSolver<string, int>();
        int rowSum = 0;
        int colSum = 0;
        int diagSum = 0;
        int total = 0000;
        public Form1()
        {
            InitializeComponent();
            lbl = new Label[3, 3];
            Font font = null;
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    Label lb = new Label();
                    if (font == null)
                        font = new Font("Arial", 25 ,FontStyle.Regular);
                    lb.Font = font;
                    lb.BackColor = Color.Transparent;
                    lb.ForeColor = Color.Green;
                    lb.Location = new Point(x * 100 + 30, y * 70 + 20);
                    lb.Size = new Size(60, 40);
                    tablePanel.Controls.Add(lb);
                    lbl[y, x] = lb;
                    lbl[y, x].Text = "0";
                }
            tbSol.AppendText("--- Output Log ---");
            tbSol.AppendText(Environment.NewLine);
        }
        private void btnGiveValues_Click(object sender, EventArgs e)
        {

            #region Selecting Row & COl of enter to given value
            int r =-1;
            int c=-1;
            if (rb11.Checked)
            {
                r = 0;
                c = 0;
            }
            if (rb12.Checked)
            {
                r = 0;
                c = 1;
            }
            if (rb13.Checked)
            {
                r = 0;
                c = 2;
            }
            if (rb21.Checked)
            {
                r = 1;
                c = 0;
            }
            if (rb22.Checked)
            {
                r = 1;
                c = 1;
            }
            if (rb23.Checked)
            {
                r = 1;
                c = 2;
            }
            if (rb31.Checked)
            {
                r = 2;
                c = 0;
            }
            if (rb32.Checked)
            {
                r = 2;
                c = 1;
            }
            if (rb33.Checked)
            {
                r = 2;
                c = 2;
            }
            #endregion

            #region Checking correctness of Input.
            bool flagCorr = false;
            for (int i = 1; i<10; i++)
            {
                if (i == Int32.Parse(txtValue.Text))
                {
                    flagCorr = true;
                }
            }
            #endregion
            #region Checking for dupicate values.
            bool flagDup = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (table[i, j].ToString() == txtValue.Text)
                        flagDup = true;
            #endregion

            if (flagCorr && !flagDup)
            {
                string val = txtValue.Text;
                lbl[r, c].Text = val;
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        table[i, j] = Int32.Parse(lbl[i, j].Text);

                CalculateSum();
            }
            else
            {
                    MessageBox.Show("Invalid input. ( Input range: 1 - 9 ) & No duplicate values allowed.");
            }
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = Int32.Parse(lbl[i, j].Text);
            Solve();
        }
        public void Solve()
        {
            int l = 0, k = 0;
            // Check whether All Sum are Equal --- If equal then it is Solved
            if (isSumEqual())
            {
                Display();
                CalculateSum();
                return;
            }
            else
            {
                #region Check for empty Spots...
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (table[i, j] == 0)
                        {
                            k = i;
                            l = j;
                            break;
                        }
                #endregion
                // Calling method to get array that contains all possible entries for that particular empty spot...
                int[] possibilities = possibleEntries(k, l);
                #region Recursive Logic --- In order to go back again and again, if no possible entries are found
                for (int s = 0; s < possibilities.Length; s++)
                {
                    if (possibilities[s] != 0)
                    {
                        table[k, l] = possibilities[s];
                        Solve();
                    }
                }
                table[k, l] = 0;
                #endregion
            }
        }
        public void CalculateSum()
        {
            diagSum = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                rowSum = 0;
                colSum = 0;
                diagSum += table[i, i];
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    rowSum += table[i, j];
                    colSum += table[j, i];
                }
                #region To display sum of 1st Row & Col
                if (i == 0)
                {
                    lbr1.Text = rowSum.ToString();
                    lbc1.Text = colSum.ToString();
                }
                #endregion
                #region To display sum of 2nd Row & Col
                if (i == 1)
                {
                    lbr2.Text = rowSum.ToString();
                    lbc2.Text = colSum.ToString();
                }
                #endregion
                #region To display sum of 3rd Row & Col
                if (i == 2)
                {
                    lbr3.Text = rowSum.ToString();
                    lbc3.Text = colSum.ToString();
                }
                #endregion
            }
            lb_diag.Text = diagSum.ToString();
            
        }
        public void Display()
        {
            total++;
            lblTotal.Text = total.ToString();
            MessageBox.Show("yes!");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    lbl[i, j].Text = table[i, j].ToString();
                    tbSol.AppendText(table[i, j].ToString() + " ");
                }
                tbSol.AppendText(Environment.NewLine);
            }
            tbSol.AppendText("---------------");
            tbSol.AppendText(Environment.NewLine);
        }
        public int[] possibleEntries(int i, int j)
        {
                #region All possible Entries

                int[] ps = new int[9];
                for (int s = 0; s < ps.Length; s++)
                    ps[s] = s + 1;
                #endregion

                #region Check for all possible Entries.

                for (int n = 0; n < 3; n++)
                    for(int m = 0; m < 3; m++)
                        if (table[n, m] != 0)
                            for (int s = 0; s < ps.Length; s++)
                                if (ps[s] == table[n, m])
                                    ps[s] = 0;
                #endregion
                             
                #region Listing the possible entries which are Left for given CELL

                int[] possiblities = new int[9];
                int p = 0;
                for (int s = 0; s < ps.Length; s++)
                    if (ps[s] != 0)
                    {
                        possiblities[p] = ps[s];
                        p++;
                    }
                #endregion

                //possiblities is an array that contains list of all possible entries for the given CELL.
                return possiblities;
        }
        public bool isSumEqual()
        {
            diagSum = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                rowSum = 0;
                colSum = 0;
                diagSum += table[i, i];
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    rowSum += table[i, j];
                    colSum += table[j, i];
                }
                #region To display sum of all Row & Col
                if (rowSum != 15 || colSum != 15)
                        return false;
                #endregion
            }
            if (diagSum != 15)
                return false;
            return true;
        }
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = 0;
                    lbl[i, j].Text = "0";
                }
            total = 0000;
            lbc1.Text = "0";
            lbc2.Text = "0";
            lbc3.Text = "0";
            lbr1.Text = "0";
            lbr2.Text = "0";
            lbr3.Text = "0";
            lb_diag.Text = "0";
            lblTotal.Text = "0";
            tbSol.Text = "---- Ready ----";
            tbSol.AppendText(Environment.NewLine);
        }
        private void allChkBox(object sender, EventArgs e)
        {
            txtValue.Select();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
