namespace quiz_app
{
    partial class QuizForm
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
            this.titleMsg = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleMsg
            // 
            this.titleMsg.AutoSize = true;
            this.titleMsg.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.titleMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.titleMsg.Location = new System.Drawing.Point(22, 24);
            this.titleMsg.Name = "titleMsg";
            this.titleMsg.Size = new System.Drawing.Size(69, 33);
            this.titleMsg.TabIndex = 12;
            this.titleMsg.Text = "Quiz";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.questionLabel.Location = new System.Drawing.Point(23, 99);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(85, 23);
            this.questionLabel.TabIndex = 12;
            this.questionLabel.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time left:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(137, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(65, 25);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "10:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(714, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 67);
            this.panel1.TabIndex = 14;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.Location = new System.Drawing.Point(749, 553);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(177, 37);
            this.NextBtn.TabIndex = 18;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.BackColor = System.Drawing.Color.Transparent;
            this.PrevBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.PrevBtn.FlatAppearance.BorderSize = 2;
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBtn.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.PrevBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.PrevBtn.Location = new System.Drawing.Point(27, 553);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(177, 37);
            this.PrevBtn.TabIndex = 18;
            this.PrevBtn.Text = "Previous";
            this.PrevBtn.UseVisualStyleBackColor = false;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.option1.Location = new System.Drawing.Point(135, 345);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(95, 29);
            this.option1.TabIndex = 19;
            this.option1.TabStop = true;
            this.option1.Text = "Choice";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.option2.Location = new System.Drawing.Point(667, 345);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(95, 29);
            this.option2.TabIndex = 19;
            this.option2.TabStop = true;
            this.option2.Text = "Choice";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.option3.Location = new System.Drawing.Point(135, 408);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(95, 29);
            this.option3.TabIndex = 19;
            this.option3.TabStop = true;
            this.option3.Text = "Choice";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Click += new System.EventHandler(this.option3_CheckedChanged);
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.option4.Location = new System.Drawing.Point(667, 408);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(95, 29);
            this.option4.TabIndex = 19;
            this.option4.TabStop = true;
            this.option4.Text = "Choice";
            this.option4.UseVisualStyleBackColor = true;
            this.option4.Click += new System.EventHandler(this.option4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quiz_app.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(926, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.questionBox.Location = new System.Drawing.Point(28, 137);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(897, 146);
            this.questionBox.TabIndex = 21;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(953, 617);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.titleMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizForm";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label titleMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton option4;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox questionBox;
    }
}

