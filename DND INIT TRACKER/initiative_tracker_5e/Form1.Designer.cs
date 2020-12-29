namespace initiative_tracker_5e
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_ini_bonus = new System.Windows.Forms.ComboBox();
            this.button_add_player = new System.Windows.Forms.Button();
            this.button_roll_ini = new System.Windows.Forms.Button();
            this.listBox_players = new System.Windows.Forms.ListBox();
            this.button_remove_player = new System.Windows.Forms.Button();
            this.panel_AC = new System.Windows.Forms.Panel();
            this.button_remove1_damage = new System.Windows.Forms.Button();
            this.button_add10_damage = new System.Windows.Forms.Button();
            this.button_add5_damage = new System.Windows.Forms.Button();
            this.button_add_damage = new System.Windows.Forms.Button();
            this.label_damage = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.comboBox_ac = new System.Windows.Forms.ComboBox();
            this.listBox_ini = new System.Windows.Forms.ListBox();
            this.listBox_playerAC = new System.Windows.Forms.ListBox();
            this.listBox_damage_taken = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_monsters = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_add_fromML = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_AC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(14, 27);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(408, 44);
            this.textBox_name.TabIndex = 0;
            // 
            // comboBox_ini_bonus
            // 
            this.comboBox_ini_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ini_bonus.FormattingEnabled = true;
            this.comboBox_ini_bonus.Location = new System.Drawing.Point(497, 26);
            this.comboBox_ini_bonus.Name = "comboBox_ini_bonus";
            this.comboBox_ini_bonus.Size = new System.Drawing.Size(63, 45);
            this.comboBox_ini_bonus.TabIndex = 1;
            // 
            // button_add_player
            // 
            this.button_add_player.AutoSize = true;
            this.button_add_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_player.Location = new System.Drawing.Point(566, 27);
            this.button_add_player.Name = "button_add_player";
            this.button_add_player.Size = new System.Drawing.Size(396, 47);
            this.button_add_player.TabIndex = 2;
            this.button_add_player.Text = "Add Custom to Encounter";
            this.button_add_player.UseVisualStyleBackColor = true;
            this.button_add_player.Click += new System.EventHandler(this.Button_add_player_Click);
            // 
            // button_roll_ini
            // 
            this.button_roll_ini.AutoSize = true;
            this.button_roll_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_roll_ini.Location = new System.Drawing.Point(8, 119);
            this.button_roll_ini.Name = "button_roll_ini";
            this.button_roll_ini.Size = new System.Drawing.Size(385, 47);
            this.button_roll_ini.TabIndex = 3;
            this.button_roll_ini.Text = "ROLL INITIATIVE";
            this.button_roll_ini.UseVisualStyleBackColor = true;
            this.button_roll_ini.Click += new System.EventHandler(this.Button_roll_ini_Click);
            // 
            // listBox_players
            // 
            this.listBox_players.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_players.FormattingEnabled = true;
            this.listBox_players.ItemHeight = 42;
            this.listBox_players.Location = new System.Drawing.Point(103, 21);
            this.listBox_players.Name = "listBox_players";
            this.listBox_players.Size = new System.Drawing.Size(357, 592);
            this.listBox_players.TabIndex = 4;
            // 
            // button_remove_player
            // 
            this.button_remove_player.AutoSize = true;
            this.button_remove_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove_player.Location = new System.Drawing.Point(8, 172);
            this.button_remove_player.Name = "button_remove_player";
            this.button_remove_player.Size = new System.Drawing.Size(385, 47);
            this.button_remove_player.TabIndex = 5;
            this.button_remove_player.Text = "REMOVE";
            this.button_remove_player.UseVisualStyleBackColor = true;
            this.button_remove_player.Click += new System.EventHandler(this.Button_remove_player_Click);
            // 
            // panel_AC
            // 
            this.panel_AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AC.Controls.Add(this.button_remove1_damage);
            this.panel_AC.Controls.Add(this.button_add10_damage);
            this.panel_AC.Controls.Add(this.button_add5_damage);
            this.panel_AC.Controls.Add(this.button_add_damage);
            this.panel_AC.Controls.Add(this.label_damage);
            this.panel_AC.Location = new System.Drawing.Point(664, 92);
            this.panel_AC.Name = "panel_AC";
            this.panel_AC.Size = new System.Drawing.Size(402, 459);
            this.panel_AC.TabIndex = 1;
            // 
            // button_remove1_damage
            // 
            this.button_remove1_damage.AutoSize = true;
            this.button_remove1_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove1_damage.Location = new System.Drawing.Point(16, 364);
            this.button_remove1_damage.Name = "button_remove1_damage";
            this.button_remove1_damage.Size = new System.Drawing.Size(370, 82);
            this.button_remove1_damage.TabIndex = 13;
            this.button_remove1_damage.Text = "-1";
            this.button_remove1_damage.UseVisualStyleBackColor = true;
            this.button_remove1_damage.Click += new System.EventHandler(this.Button_remove1_damage_Click);
            // 
            // button_add10_damage
            // 
            this.button_add10_damage.AutoSize = true;
            this.button_add10_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add10_damage.Location = new System.Drawing.Point(16, 276);
            this.button_add10_damage.Name = "button_add10_damage";
            this.button_add10_damage.Size = new System.Drawing.Size(370, 82);
            this.button_add10_damage.TabIndex = 12;
            this.button_add10_damage.Text = "+10";
            this.button_add10_damage.UseVisualStyleBackColor = true;
            this.button_add10_damage.Click += new System.EventHandler(this.Button_add10_damage_Click);
            // 
            // button_add5_damage
            // 
            this.button_add5_damage.AutoSize = true;
            this.button_add5_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add5_damage.Location = new System.Drawing.Point(16, 188);
            this.button_add5_damage.Name = "button_add5_damage";
            this.button_add5_damage.Size = new System.Drawing.Size(370, 82);
            this.button_add5_damage.TabIndex = 11;
            this.button_add5_damage.Text = "+5";
            this.button_add5_damage.UseVisualStyleBackColor = true;
            this.button_add5_damage.Click += new System.EventHandler(this.Button_add5_damage_Click);
            // 
            // button_add_damage
            // 
            this.button_add_damage.AutoSize = true;
            this.button_add_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_damage.Location = new System.Drawing.Point(16, 100);
            this.button_add_damage.Name = "button_add_damage";
            this.button_add_damage.Size = new System.Drawing.Size(370, 82);
            this.button_add_damage.TabIndex = 10;
            this.button_add_damage.Text = "+1";
            this.button_add_damage.UseVisualStyleBackColor = true;
            this.button_add_damage.Click += new System.EventHandler(this.Button_add1_damage_Click);
            // 
            // label_damage
            // 
            this.label_damage.AutoSize = true;
            this.label_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_damage.Location = new System.Drawing.Point(3, 13);
            this.label_damage.Name = "label_damage";
            this.label_damage.Size = new System.Drawing.Size(407, 73);
            this.label_damage.TabIndex = 2;
            this.label_damage.Text = "Add Damage";
            // 
            // button_next
            // 
            this.button_next.AutoSize = true;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.Location = new System.Drawing.Point(8, 14);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(385, 99);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "ADVANCE INITIATIVE";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.Button_next_Click);
            // 
            // comboBox_ac
            // 
            this.comboBox_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ac.FormattingEnabled = true;
            this.comboBox_ac.Location = new System.Drawing.Point(428, 26);
            this.comboBox_ac.Name = "comboBox_ac";
            this.comboBox_ac.Size = new System.Drawing.Size(63, 45);
            this.comboBox_ac.TabIndex = 8;
            // 
            // listBox_ini
            // 
            this.listBox_ini.Enabled = false;
            this.listBox_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_ini.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_ini.FormattingEnabled = true;
            this.listBox_ini.ItemHeight = 42;
            this.listBox_ini.Location = new System.Drawing.Point(16, 21);
            this.listBox_ini.Name = "listBox_ini";
            this.listBox_ini.Size = new System.Drawing.Size(81, 592);
            this.listBox_ini.TabIndex = 9;
            // 
            // listBox_playerAC
            // 
            this.listBox_playerAC.Enabled = false;
            this.listBox_playerAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_playerAC.FormattingEnabled = true;
            this.listBox_playerAC.ItemHeight = 42;
            this.listBox_playerAC.Location = new System.Drawing.Point(466, 21);
            this.listBox_playerAC.Name = "listBox_playerAC";
            this.listBox_playerAC.Size = new System.Drawing.Size(81, 592);
            this.listBox_playerAC.TabIndex = 10;
            // 
            // listBox_damage_taken
            // 
            this.listBox_damage_taken.Enabled = false;
            this.listBox_damage_taken.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_damage_taken.FormattingEnabled = true;
            this.listBox_damage_taken.ItemHeight = 42;
            this.listBox_damage_taken.Location = new System.Drawing.Point(553, 21);
            this.listBox_damage_taken.Name = "listBox_damage_taken";
            this.listBox_damage_taken.Size = new System.Drawing.Size(81, 592);
            this.listBox_damage_taken.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Initiative Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "AC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Damage Taken";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.button_add_player);
            this.panel1.Controls.Add(this.comboBox_ac);
            this.panel1.Controls.Add(this.comboBox_ini_bonus);
            this.panel1.Location = new System.Drawing.Point(12, 797);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 102);
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Initiative Bonus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "AC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // comboBox_monsters
            // 
            this.comboBox_monsters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_monsters.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_monsters.FormattingEnabled = true;
            this.comboBox_monsters.Location = new System.Drawing.Point(13, 13);
            this.comboBox_monsters.Name = "comboBox_monsters";
            this.comboBox_monsters.Size = new System.Drawing.Size(517, 47);
            this.comboBox_monsters.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_add_fromML);
            this.panel2.Controls.Add(this.comboBox_monsters);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 74);
            this.panel2.TabIndex = 18;
            // 
            // button_add_fromML
            // 
            this.button_add_fromML.AutoSize = true;
            this.button_add_fromML.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_fromML.Location = new System.Drawing.Point(554, 14);
            this.button_add_fromML.Name = "button_add_fromML";
            this.button_add_fromML.Size = new System.Drawing.Size(302, 47);
            this.button_add_fromML.TabIndex = 18;
            this.button_add_fromML.Text = "Add to Encounter";
            this.button_add_fromML.UseVisualStyleBackColor = true;
            this.button_add_fromML.Click += new System.EventHandler(this.Button_add_fromML_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.listBox_players);
            this.panel3.Controls.Add(this.listBox_ini);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.listBox_playerAC);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.listBox_damage_taken);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 628);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_next);
            this.panel4.Controls.Add(this.button_roll_ini);
            this.panel4.Controls.Add(this.button_remove_player);
            this.panel4.Location = new System.Drawing.Point(664, 557);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 234);
            this.panel4.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 915);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_AC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_AC.ResumeLayout(false);
            this.panel_AC.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_ini_bonus;
        private System.Windows.Forms.Button button_add_player;
        private System.Windows.Forms.Button button_roll_ini;
        private System.Windows.Forms.ListBox listBox_players;
        private System.Windows.Forms.Button button_remove_player;
        private System.Windows.Forms.Panel panel_AC;
        private System.Windows.Forms.Label label_damage;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.ComboBox comboBox_ac;
        private System.Windows.Forms.ListBox listBox_ini;
        private System.Windows.Forms.Button button_add_damage;
        private System.Windows.Forms.ListBox listBox_playerAC;
        private System.Windows.Forms.ListBox listBox_damage_taken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_add5_damage;
        private System.Windows.Forms.Button button_add10_damage;
        private System.Windows.Forms.Button button_remove1_damage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_monsters;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_add_fromML;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

