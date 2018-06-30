namespace World_Skils
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Random = new System.Windows.Forms.ToolStripMenuItem();
            this.jerebievka = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3_Kol_zaezd = new System.Windows.Forms.TextBox();
            this.textBox2_Kol_polei = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_Time = new System.Windows.Forms.TextBox();
            this.textBox4_teams = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Random});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Random
            // 
            this.Random.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jerebievka});
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(86, 20);
            this.Random.Text = "Жеребьевка";
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // jerebievka
            // 
            this.jerebievka.Name = "jerebievka";
            this.jerebievka.Size = new System.Drawing.Size(197, 22);
            this.jerebievka.Text = "Провести Жеребьевку";
            this.jerebievka.Click += new System.EventHandler(this.jerebievka_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(541, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количство заездов";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество полей";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Время";
            // 
            // textBox3_Kol_zaezd
            // 
            this.textBox3_Kol_zaezd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3_Kol_zaezd.Location = new System.Drawing.Point(397, 156);
            this.textBox3_Kol_zaezd.Name = "textBox3_Kol_zaezd";
            this.textBox3_Kol_zaezd.Size = new System.Drawing.Size(162, 20);
            this.textBox3_Kol_zaezd.TabIndex = 10;
            this.textBox3_Kol_zaezd.Text = "1";
            this.textBox3_Kol_zaezd.TextChanged += new System.EventHandler(this.textBox3_Kol_zaezd_TextChanged);
            // 
            // textBox2_Kol_polei
            // 
            this.textBox2_Kol_polei.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2_Kol_polei.Location = new System.Drawing.Point(397, 105);
            this.textBox2_Kol_polei.Name = "textBox2_Kol_polei";
            this.textBox2_Kol_polei.Size = new System.Drawing.Size(162, 20);
            this.textBox2_Kol_polei.TabIndex = 9;
            this.textBox2_Kol_polei.Text = "1";
            this.textBox2_Kol_polei.TextChanged += new System.EventHandler(this.textBox2_Kol_polei_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(584, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 145);
            this.label1.TabIndex = 8;
            this.label1.Text = "мин.";
            // 
            // textBox1_Time
            // 
            this.textBox1_Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_Time.Location = new System.Drawing.Point(397, 53);
            this.textBox1_Time.Name = "textBox1_Time";
            this.textBox1_Time.Size = new System.Drawing.Size(162, 20);
            this.textBox1_Time.TabIndex = 7;
            this.textBox1_Time.Text = "2";
            this.textBox1_Time.TextChanged += new System.EventHandler(this.textBox1_Time_TextChanged);
            // 
            // textBox4_teams
            // 
            this.textBox4_teams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4_teams.Location = new System.Drawing.Point(397, 205);
            this.textBox4_teams.Name = "textBox4_teams";
            this.textBox4_teams.Size = new System.Drawing.Size(162, 20);
            this.textBox4_teams.TabIndex = 14;
            this.textBox4_teams.Text = "2";
            this.textBox4_teams.TextChanged += new System.EventHandler(this.textBox4_teams_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Количество команд";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(569, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 20);
            this.button2.TabIndex = 16;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(13, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 475);
            this.panel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4_teams);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3_Kol_zaezd);
            this.Controls.Add(this.textBox2_Kol_polei);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_Time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Timer (World Skills)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3_Kol_zaezd;
        private System.Windows.Forms.TextBox textBox2_Kol_polei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_Time;
        private System.Windows.Forms.ToolStripMenuItem Random;
        private System.Windows.Forms.TextBox textBox4_teams;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem jerebievka;
    }
}

