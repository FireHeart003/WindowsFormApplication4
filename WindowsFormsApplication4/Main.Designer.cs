namespace WindowsFormsApplication4
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lastSaved = new System.Windows.Forms.Label();
            this.lastSavedDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 318);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(733, 400);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(55, 16);
            this.Time.TabIndex = 3;
            this.Time.Text = "00:00:00";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(711, 425);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(77, 16);
            this.Date.TabIndex = 4;
            this.Date.Text = "Jan 01 2022";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Main_Load);
            // 
            // lastSaved
            // 
            this.lastSaved.AutoSize = true;
            this.lastSaved.Location = new System.Drawing.Point(9, 9);
            this.lastSaved.Name = "lastSaved";
            this.lastSaved.Size = new System.Drawing.Size(81, 16);
            this.lastSaved.TabIndex = 5;
            this.lastSaved.Text = "Last Saved: ";
            // 
            // lastSavedDate
            // 
            this.lastSavedDate.AutoSize = true;
            this.lastSavedDate.Location = new System.Drawing.Point(96, 9);
            this.lastSavedDate.Name = "lastSavedDate";
            this.lastSavedDate.Size = new System.Drawing.Size(77, 16);
            this.lastSavedDate.TabIndex = 6;
            this.lastSavedDate.Text = "Jan 01 2022";
            this.lastSavedDate.Click += new System.EventHandler(this.lastSavedDate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastSavedDate);
            this.Controls.Add(this.lastSaved);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lastSaved;
        private System.Windows.Forms.Label lastSavedDate;
    }
}