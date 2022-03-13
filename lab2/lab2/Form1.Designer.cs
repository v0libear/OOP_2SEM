namespace lab2
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
            this.Nomer_scheta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tipvklada = new System.Windows.Forms.ComboBox();
            this.Podklycheniebankinga = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.TextBox();
            this.MastercardRadioBtn = new System.Windows.Forms.RadioButton();
            this.VisaRadioBtn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.otchestvo = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.TypeOfCardPanel = new System.Windows.Forms.Panel();
            this.NoRadioBtn = new System.Windows.Forms.RadioButton();
            this.YesRadioBtn = new System.Windows.Forms.RadioButton();
            this.cmc = new System.Windows.Forms.Panel();
            this.DisplayArea = new System.Windows.Forms.TextBox();
            this.TypeOfCardPanel.SuspendLayout();
            this.cmc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nomer_scheta
            // 
            this.Nomer_scheta.BackColor = System.Drawing.Color.White;
            this.Nomer_scheta.Location = new System.Drawing.Point(12, 32);
            this.Nomer_scheta.Name = "Nomer_scheta";
            this.Nomer_scheta.Size = new System.Drawing.Size(136, 23);
            this.Nomer_scheta.TabIndex = 0;
            this.Nomer_scheta.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.Nomer_scheta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер счёта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подключение смс:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Тип вклада:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tipvklada
            // 
            this.Tipvklada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipvklada.FormattingEnabled = true;
            this.Tipvklada.Location = new System.Drawing.Point(12, 150);
            this.Tipvklada.Name = "Tipvklada";
            this.Tipvklada.Size = new System.Drawing.Size(136, 23);
            this.Tipvklada.TabIndex = 2;
            // 
            // Podklycheniebankinga
            // 
            this.Podklycheniebankinga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Podklycheniebankinga.FormattingEnabled = true;
            this.Podklycheniebankinga.Location = new System.Drawing.Point(12, 212);
            this.Podklycheniebankinga.Name = "Podklycheniebankinga";
            this.Podklycheniebankinga.Size = new System.Drawing.Size(136, 23);
            this.Podklycheniebankinga.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Подключение интернет банкинга:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Вид Карты:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Баланс:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // Balance
            // 
            this.Balance.BackColor = System.Drawing.Color.White;
            this.Balance.Location = new System.Drawing.Point(12, 349);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(136, 23);
            this.Balance.TabIndex = 0;
            this.Balance.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.Balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly_KeyPress);
            // 
            // MastercardRadioBtn
            // 
            this.MastercardRadioBtn.AutoSize = true;
            this.MastercardRadioBtn.Location = new System.Drawing.Point(5, 15);
            this.MastercardRadioBtn.Name = "MastercardRadioBtn";
            this.MastercardRadioBtn.Size = new System.Drawing.Size(84, 19);
            this.MastercardRadioBtn.TabIndex = 3;
            this.MastercardRadioBtn.TabStop = true;
            this.MastercardRadioBtn.Text = "Mastercard";
            this.MastercardRadioBtn.UseVisualStyleBackColor = true;
            // 
            // VisaRadioBtn
            // 
            this.VisaRadioBtn.AutoSize = true;
            this.VisaRadioBtn.Location = new System.Drawing.Point(95, 15);
            this.VisaRadioBtn.Name = "VisaRadioBtn";
            this.VisaRadioBtn.Size = new System.Drawing.Size(46, 19);
            this.VisaRadioBtn.TabIndex = 3;
            this.VisaRadioBtn.TabStop = true;
            this.VisaRadioBtn.Text = "Visa";
            this.VisaRadioBtn.UseVisualStyleBackColor = true;
            this.VisaRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Владелец:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Фамилия:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Имя:";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // Firstname
            // 
            this.Firstname.BackColor = System.Drawing.Color.White;
            this.Firstname.Location = new System.Drawing.Point(85, 420);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(136, 23);
            this.Firstname.TabIndex = 0;
            this.Firstname.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.Firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            // 
            // Lastname
            // 
            this.Lastname.BackColor = System.Drawing.Color.White;
            this.Lastname.Location = new System.Drawing.Point(85, 451);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(136, 23);
            this.Lastname.TabIndex = 0;
            this.Lastname.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.Lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Отчество";
            this.label11.Click += new System.EventHandler(this.label9_Click);
            // 
            // otchestvo
            // 
            this.otchestvo.BackColor = System.Drawing.Color.White;
            this.otchestvo.Location = new System.Drawing.Point(85, 484);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(136, 23);
            this.otchestvo.TabIndex = 0;
            this.otchestvo.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.otchestvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(288, 19);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(457, 46);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Сохранить данные в формате XML";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(288, 76);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(457, 46);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Загрузить данные из формата XML";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TypeOfCardPanel
            // 
            this.TypeOfCardPanel.Controls.Add(this.VisaRadioBtn);
            this.TypeOfCardPanel.Controls.Add(this.MastercardRadioBtn);
            this.TypeOfCardPanel.Location = new System.Drawing.Point(13, 271);
            this.TypeOfCardPanel.Name = "TypeOfCardPanel";
            this.TypeOfCardPanel.Size = new System.Drawing.Size(176, 46);
            this.TypeOfCardPanel.TabIndex = 6;
            // 
            // NoRadioBtn
            // 
            this.NoRadioBtn.AutoSize = true;
            this.NoRadioBtn.Location = new System.Drawing.Point(92, 6);
            this.NoRadioBtn.Name = "NoRadioBtn";
            this.NoRadioBtn.Size = new System.Drawing.Size(45, 19);
            this.NoRadioBtn.TabIndex = 3;
            this.NoRadioBtn.TabStop = true;
            this.NoRadioBtn.Text = "Нет";
            this.NoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // YesRadioBtn
            // 
            this.YesRadioBtn.AutoSize = true;
            this.YesRadioBtn.Location = new System.Drawing.Point(1, 6);
            this.YesRadioBtn.Name = "YesRadioBtn";
            this.YesRadioBtn.Size = new System.Drawing.Size(39, 19);
            this.YesRadioBtn.TabIndex = 3;
            this.YesRadioBtn.TabStop = true;
            this.YesRadioBtn.Text = "Да";
            this.YesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // cmc
            // 
            this.cmc.Controls.Add(this.NoRadioBtn);
            this.cmc.Controls.Add(this.YesRadioBtn);
            this.cmc.Location = new System.Drawing.Point(13, 87);
            this.cmc.Name = "cmc";
            this.cmc.Size = new System.Drawing.Size(187, 36);
            this.cmc.TabIndex = 6;
            // 
            // DisplayArea
            // 
            this.DisplayArea.BackColor = System.Drawing.Color.White;
            this.DisplayArea.Location = new System.Drawing.Point(288, 150);
            this.DisplayArea.Multiline = true;
            this.DisplayArea.Name = "DisplayArea";
            this.DisplayArea.ReadOnly = true;
            this.DisplayArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayArea.Size = new System.Drawing.Size(457, 414);
            this.DisplayArea.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 575);
            this.Controls.Add(this.DisplayArea);
            this.Controls.Add(this.cmc);
            this.Controls.Add(this.TypeOfCardPanel);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Podklycheniebankinga);
            this.Controls.Add(this.Tipvklada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nomer_scheta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Банк";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TypeOfCardPanel.ResumeLayout(false);
            this.TypeOfCardPanel.PerformLayout();
            this.cmc.ResumeLayout(false);
            this.cmc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nomer_scheta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Tipvklada;
        private System.Windows.Forms.ComboBox Podklycheniebankinga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.RadioButton MastercardRadioBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox otchestvo;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Panel TypeOfCardPanel;
        private System.Windows.Forms.RadioButton NoRadioBtn;
        private System.Windows.Forms.RadioButton YesRadioBtn;
        private System.Windows.Forms.Panel cmc;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.RadioButton VisaRadioBtn;
        private System.Windows.Forms.TextBox DisplayArea;
    }
}

