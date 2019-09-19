namespace Timer
{
    partial class Form1
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
            this.btn_startpause = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_at = new System.Windows.Forms.RadioButton();
            this.rb_in = new System.Windows.Forms.RadioButton();
            this.tb_h = new System.Windows.Forms.TextBox();
            this.tb_m = new System.Windows.Forms.TextBox();
            this.tb_s = new System.Windows.Forms.TextBox();
            this.tb_at = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_remainingTime = new System.Windows.Forms.Label();
            this.timer_100ms = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_startpause
            // 
            this.btn_startpause.Location = new System.Drawing.Point(179, 23);
            this.btn_startpause.Name = "btn_startpause";
            this.btn_startpause.Size = new System.Drawing.Size(75, 23);
            this.btn_startpause.TabIndex = 0;
            this.btn_startpause.Text = "Start";
            this.btn_startpause.UseVisualStyleBackColor = true;
            this.btn_startpause.Click += new System.EventHandler(this.Btn_startpause_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(179, 50);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "S";
            // 
            // rb_at
            // 
            this.rb_at.AutoSize = true;
            this.rb_at.Location = new System.Drawing.Point(12, 53);
            this.rb_at.Name = "rb_at";
            this.rb_at.Size = new System.Drawing.Size(35, 17);
            this.rb_at.TabIndex = 5;
            this.rb_at.Text = "At";
            this.rb_at.UseVisualStyleBackColor = true;
            // 
            // rb_in
            // 
            this.rb_in.AutoSize = true;
            this.rb_in.Checked = true;
            this.rb_in.Location = new System.Drawing.Point(12, 26);
            this.rb_in.Name = "rb_in";
            this.rb_in.Size = new System.Drawing.Size(34, 17);
            this.rb_in.TabIndex = 6;
            this.rb_in.TabStop = true;
            this.rb_in.Text = "In";
            this.rb_in.UseVisualStyleBackColor = true;
            // 
            // tb_h
            // 
            this.tb_h.Location = new System.Drawing.Point(65, 25);
            this.tb_h.Name = "tb_h";
            this.tb_h.Size = new System.Drawing.Size(32, 20);
            this.tb_h.TabIndex = 7;
            this.tb_h.Text = "0";
            this.tb_h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_in_KeyPress);
            // 
            // tb_m
            // 
            this.tb_m.Location = new System.Drawing.Point(103, 26);
            this.tb_m.Name = "tb_m";
            this.tb_m.Size = new System.Drawing.Size(32, 20);
            this.tb_m.TabIndex = 8;
            this.tb_m.Text = "0";
            this.tb_m.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_in_KeyPress);
            // 
            // tb_s
            // 
            this.tb_s.Location = new System.Drawing.Point(141, 25);
            this.tb_s.Name = "tb_s";
            this.tb_s.Size = new System.Drawing.Size(32, 20);
            this.tb_s.TabIndex = 9;
            this.tb_s.Text = "0";
            this.tb_s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_in_KeyPress);
            // 
            // tb_at
            // 
            this.tb_at.Location = new System.Drawing.Point(65, 52);
            this.tb_at.Name = "tb_at";
            this.tb_at.Size = new System.Drawing.Size(108, 20);
            this.tb_at.TabIndex = 10;
            this.tb_at.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_at_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Remaining";
            // 
            // lbl_remainingTime
            // 
            this.lbl_remainingTime.AutoSize = true;
            this.lbl_remainingTime.Location = new System.Drawing.Point(74, 86);
            this.lbl_remainingTime.Name = "lbl_remainingTime";
            this.lbl_remainingTime.Size = new System.Drawing.Size(49, 13);
            this.lbl_remainingTime.TabIndex = 12;
            this.lbl_remainingTime.Text = "00:00:00";
            // 
            // timer_100ms
            // 
            this.timer_100ms.Enabled = true;
            this.timer_100ms.Tick += new System.EventHandler(this.Timer_100ms_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 112);
            this.Controls.Add(this.lbl_remainingTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_at);
            this.Controls.Add(this.tb_s);
            this.Controls.Add(this.tb_m);
            this.Controls.Add(this.tb_h);
            this.Controls.Add(this.rb_in);
            this.Controls.Add(this.rb_at);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_startpause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startpause;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_at;
        private System.Windows.Forms.RadioButton rb_in;
        private System.Windows.Forms.TextBox tb_h;
        private System.Windows.Forms.TextBox tb_m;
        private System.Windows.Forms.TextBox tb_s;
        private System.Windows.Forms.TextBox tb_at;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_remainingTime;
        private System.Windows.Forms.Timer timer_100ms;
    }
}

