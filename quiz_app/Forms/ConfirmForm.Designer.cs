namespace quiz_app.Forms
{
    partial class ConfirmForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.subtitleMsg = new System.Windows.Forms.Label();
            this.titleMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.studentName);
            this.panel1.Controls.Add(this.subtitleMsg);
            this.panel1.Controls.Add(this.titleMsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 345);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 66);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quiz App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(27, 278);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(563, 37);
            this.startBtn.TabIndex = 30;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 15.75F);
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hello!";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.studentName.Location = new System.Drawing.Point(98, 106);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(202, 25);
            this.studentName.TabIndex = 29;
            this.studentName.Text = "Donn Jayson Quinto";
            // 
            // subtitleMsg
            // 
            this.subtitleMsg.AutoSize = true;
            this.subtitleMsg.Font = new System.Drawing.Font("Roboto Light", 14.25F);
            this.subtitleMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.subtitleMsg.Location = new System.Drawing.Point(23, 205);
            this.subtitleMsg.Name = "subtitleMsg";
            this.subtitleMsg.Size = new System.Drawing.Size(307, 23);
            this.subtitleMsg.TabIndex = 25;
            this.subtitleMsg.Text = "To start just click START. Good luck!";
            // 
            // titleMsg
            // 
            this.titleMsg.AutoSize = true;
            this.titleMsg.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.titleMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.titleMsg.Location = new System.Drawing.Point(21, 153);
            this.titleMsg.Name = "titleMsg";
            this.titleMsg.Size = new System.Drawing.Size(334, 33);
            this.titleMsg.TabIndex = 26;
            this.titleMsg.Text = "Are you ready for the quiz?";
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(617, 345);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.ConfirmForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label subtitleMsg;
        private System.Windows.Forms.Label titleMsg;
    }
}