
namespace Gui
{
    partial class CarInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toll = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textCarNum = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMoneyRec = new System.Windows.Forms.TextBox();
            this.textMoneyBack = new System.Windows.Forms.TextBox();
            this.btn_moneyBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Number";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(319, 207);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 26, 0, 0, 0, 0);
            // 
            // toll
            // 
            this.toll.AutoSize = true;
            this.toll.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toll.Location = new System.Drawing.Point(228, 41);
            this.toll.Name = "toll";
            this.toll.Size = new System.Drawing.Size(143, 25);
            this.toll.TabIndex = 3;
            this.toll.Text = "Toll =500 Tk";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(355, 371);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(101, 36);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Print";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(97, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCarNum
            // 
            this.textCarNum.Location = new System.Drawing.Point(319, 105);
            this.textCarNum.Multiline = true;
            this.textCarNum.Name = "textCarNum";
            this.textCarNum.Size = new System.Drawing.Size(226, 27);
            this.textCarNum.TabIndex = 8;
            this.textCarNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Time
            // 
            this.Time.CustomFormat = "HH:mm";
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time.Location = new System.Drawing.Point(355, 259);
            this.Time.Name = "Time";
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(86, 20);
            this.Time.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Money Received";
            // 
            // textMoneyRec
            // 
            this.textMoneyRec.Location = new System.Drawing.Point(319, 155);
            this.textMoneyRec.Name = "textMoneyRec";
            this.textMoneyRec.Size = new System.Drawing.Size(226, 20);
            this.textMoneyRec.TabIndex = 14;
            this.textMoneyRec.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textMoneyBack
            // 
            this.textMoneyBack.Location = new System.Drawing.Point(319, 316);
            this.textMoneyBack.Multiline = true;
            this.textMoneyBack.Name = "textMoneyBack";
            this.textMoneyBack.Size = new System.Drawing.Size(226, 20);
            this.textMoneyBack.TabIndex = 15;
            this.textMoneyBack.TextChanged += new System.EventHandler(this.textMoneyBack_TextChanged);
            // 
            // btn_moneyBack
            // 
            this.btn_moneyBack.Location = new System.Drawing.Point(97, 312);
            this.btn_moneyBack.Name = "btn_moneyBack";
            this.btn_moneyBack.Size = new System.Drawing.Size(75, 23);
            this.btn_moneyBack.TabIndex = 16;
            this.btn_moneyBack.Text = "Money Back";
            this.btn_moneyBack.UseVisualStyleBackColor = true;
            this.btn_moneyBack.Click += new System.EventHandler(this.btn_moneyBack_Click);
            // 
            // CarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(617, 438);
            this.Controls.Add(this.btn_moneyBack);
            this.Controls.Add(this.textMoneyBack);
            this.Controls.Add(this.textMoneyRec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.textCarNum);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.toll);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "CarInfo";
            this.Text = "CarInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label toll;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textCarNum;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMoneyRec;
        private System.Windows.Forms.TextBox textMoneyBack;
        private System.Windows.Forms.Button btn_moneyBack;
    }
}