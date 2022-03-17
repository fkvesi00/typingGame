using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Status status = new Status();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //add a random key to listBox
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // if the user pressed a key that is in the listBox, remove it
            // and then make the game a little faster
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;
                // THe user pressed a correct key, so update the stats object
                // by calling its Update() method with the argument true 
                status.update(true);

            }
            else
            {
                // The user pressed an incorrect key, so update the stats object
                // by calling its Update() method with the argument false 
                status.update(false);
            }

            // update the labels on the statusStrip
            Correct.Text = "Correct: " + status.correct;
            missedStatusLabel.Text = "Missed: " + status.missed;
            totalStatusLabel.Text = "Total: " + status.total;
            accuracyStatusLabel.Text = "Accuracy: " + status.accuracy + "%";
        }
    }
}
