/* 5-2-13 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> array = new Dictionary<int, string>();
        Dictionary<string, int> scores = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
            scores.Add("wins", 0);
            scores.Add("loss", 0);
            ScoreLabel.Text = "Score: 0 Wins, 0 Losses";
            label1.Text = "You are [x] and I am [o].";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "x";
            Button1.Enabled = false;
            addToArray(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button2.Text = "x";
            Button2.Enabled = false;
            addToArray(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button3.Text = "x";
            Button3.Enabled = false;
            addToArray(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button4.Text = "x";
            Button4.Enabled = false;
            addToArray(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button5.Text = "x";
            Button5.Enabled = false;
            addToArray(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Button6.Text = "x";
            Button6.Enabled = false;
            addToArray(6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Button7.Text = "x";
            Button7.Enabled = false;
            addToArray(7);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button8.Text = "x";
            Button8.Enabled = false;
            addToArray(8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Button9.Text = "x";
            Button9.Enabled = false;
            addToArray(9);
        }

        public void addToArray(int c)
        {
            /*label1.Text = Convert.ToString(c);*/
            array[c] = "x";
            if (checkBoard("x"))
            {
                label1.Text = "Congratulations, you have won!";
                scores["wins"]++;
                endGame();
                return;
            }
            selectRandom();
        }

        public void selectRandom()
        {
            /*label1.Text = Convert.ToString(array.Count());*/
            if (array.Count() > 7)
            {
                label1.Text = "No more moves could be made, game has ended.";
                endGame();
                return;
            }
            while (true)
            {
                int index = new Random().Next(1, 10);
               /* label1.Text = Convert.ToString(index);*/
                if (array.ContainsKey(index)) continue;
                (Controls["Button" + Convert.ToString(index)] as Button).Text = "o";
                (Controls["Button" + Convert.ToString(index)] as Button).Enabled = false;
                array.Add(index, "o");
                if (checkBoard("o")) {
                    label1.Text = "You have lost!";
                    scores["loss"]++;
                    endGame();
                    return;
                }
                break;
            }
        }

        public bool checkBoard(string c)
        {
            string value = "";
            if (array.TryGetValue(1, out value) && array.TryGetValue(2, out value) && array.TryGetValue(3, out value) && array[1] == c && array[2] == c && array[3] == c)
            {
                return true;
            }
            else if (array.TryGetValue(4, out value) && array.TryGetValue(5, out value) && array.TryGetValue(6, out value) && array[4] == c && array[5] == c && array[6] == c)
            {
                return true;
            }
            else if (array.TryGetValue(7, out value) && array.TryGetValue(8, out value) && array.TryGetValue(9, out value) && array[7] == c && array[8] == c && array[9] == c)
            {
                return true;
            }
            else if (array.TryGetValue(1, out value) && array.TryGetValue(4, out value) && array.TryGetValue(7, out value) && array[1] == c && array[4] == c && array[7] == c)
            {
                return true;
            }
            else if (array.TryGetValue(2, out value) && array.TryGetValue(5, out value) && array.TryGetValue(8, out value) && array[2] == c && array[5] == c && array[8] == c)
            {
                return true;
            }
            else if (array.TryGetValue(3, out value) && array.TryGetValue(6, out value) && array.TryGetValue(9, out value) && array[3] == c && array[6] == c && array[9] == c)
            {
                return true;
            }
            else if (array.TryGetValue(1, out value) && array.TryGetValue(5, out value) && array.TryGetValue(9, out value) && array[1] == c && array[5] == c && array[9] == c)
            {
                return true;
            }
            else if (array.TryGetValue(3, out value) && array.TryGetValue(5, out value) && array.TryGetValue(7, out value) && array[3] == c && array[5] == c && array[7] == c)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                array[i] = "";
                (Controls["Button" + Convert.ToString(i)] as Button).Text = "";
                (Controls["Button" + Convert.ToString(i)] as Button).Enabled = true;
            }
            RetryButton.Visible = false;
            array.Clear();
            label1.Text = "";
            //Dictionary<int, string> array = new Dictionary<int, string>();
        }
        public void endGame()
        {
            for (int i = 1; i < 10; i++)
            {
                //(Controls["Button" + Convert.ToString(i)] as Button).Text = "";
                (Controls["Button" + Convert.ToString(i)] as Button).Enabled = false;
            }
            RetryButton.Visible = true;
            ScoreLabel.Text = "Score: " + Convert.ToString(scores["wins"]) + " win" + ((scores["wins"] == 1) ? "" : "s") + ", " + Convert.ToString(scores["loss"]) + " loss" + ((scores["loss"] == 1) ? "" : "es");
        }
    }
}
