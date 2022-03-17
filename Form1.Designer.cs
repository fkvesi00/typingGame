
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Correct = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 42;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(854, 123);
            this.listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Correct,
            this.missedStatusLabel,
            this.totalStatusLabel,
            this.accuracyStatusLabel,
            this.difficultyStatusLabel,
            this.difficultyProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 97);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Correct
            // 
            this.Correct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(72, 20);
            this.Correct.Text = "Correct: 0";
            // 
            // missedStatusLabel
            // 
            this.missedStatusLabel.Name = "missedStatusLabel";
            this.missedStatusLabel.Size = new System.Drawing.Size(70, 20);
            this.missedStatusLabel.Text = "Missed: 0";
            // 
            // totalStatusLabel
            // 
            this.totalStatusLabel.Name = "totalStatusLabel";
            this.totalStatusLabel.Size = new System.Drawing.Size(57, 20);
            this.totalStatusLabel.Text = "Total: 0";
            // 
            // accuracyStatusLabel
            // 
            this.accuracyStatusLabel.Name = "accuracyStatusLabel";
            this.accuracyStatusLabel.Size = new System.Drawing.Size(95, 20);
            this.accuracyStatusLabel.Text = "Accuracy: 0%";
            // 
            // difficultyStatusLabel
            // 
            this.difficultyStatusLabel.Name = "difficultyStatusLabel";
            this.difficultyStatusLabel.Size = new System.Drawing.Size(443, 20);
            this.difficultyStatusLabel.Spring = true;
            this.difficultyStatusLabel.Text = "Difficulty";
            this.difficultyStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.Maximum = 701;
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            this.difficultyProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 123);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Correct;
        private System.Windows.Forms.ToolStripStatusLabel missedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel accuracyStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel difficultyStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
    }
}

