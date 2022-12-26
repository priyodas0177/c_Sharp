
namespace Gui
{
    partial class BikeInfo
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
            this.toll = new System.Windows.Forms.Label();
            this.bok = new System.Windows.Forms.Button();
            this.bDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bNum = new System.Windows.Forms.TextBox();
            this.bTime = new System.Windows.Forms.DateTimePicker();
            this.m = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bmoneyReceived = new System.Windows.Forms.TextBox();
            this.bMoneyBack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toll
            // 
            this.toll.AutoSize = true;
            this.toll.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toll.Location = new System.Drawing.Point(183, 44);
            this.toll.Name = "toll";
            this.toll.Size = new System.Drawing.Size(143, 25);
            this.toll.TabIndex = 20;
            this.toll.Text = "Toll =200 Tk";
            // 
            // bok
            // 
            this.bok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bok.Location = new System.Drawing.Point(312, 322);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(101, 36);
            this.bok.TabIndex = 19;
            this.bok.Text = "Ok";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.ok_Click);
            // 
            // bDate
            // 
            this.bDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDate.Location = new System.Drawing.Point(291, 192);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(226, 22);
            this.bDate.TabIndex = 16;
            this.bDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bike Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bNum
            // 
            this.bNum.Location = new System.Drawing.Point(291, 102);
            this.bNum.Multiline = true;
            this.bNum.Name = "bNum";
            this.bNum.Size = new System.Drawing.Size(226, 26);
            this.bNum.TabIndex = 22;
            // 
            // bTime
            // 
            this.bTime.CustomFormat = "HH:mm";
            this.bTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bTime.Location = new System.Drawing.Point(291, 237);
            this.bTime.Name = "bTime";
            this.bTime.Size = new System.Drawing.Size(226, 20);
            this.bTime.TabIndex = 23;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(78, 157);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(88, 13);
            this.m.TabIndex = 24;
            this.m.Text = "Money Received";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(81, 275);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(67, 13);
            this.b.TabIndex = 25;
            this.b.Text = "Money Back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Time";
            // 
            // bmoneyReceived
            // 
            this.bmoneyReceived.Location = new System.Drawing.Point(291, 149);
            this.bmoneyReceived.Multiline = true;
            this.bmoneyReceived.Name = "bmoneyReceived";
            this.bmoneyReceived.Size = new System.Drawing.Size(226, 21);
            this.bmoneyReceived.TabIndex = 28;
            // 
            // bMoneyBack
            // 
            this.bMoneyBack.Location = new System.Drawing.Point(291, 285);
            this.bMoneyBack.Name = "bMoneyBack";
            this.bMoneyBack.Size = new System.Drawing.Size(226, 20);
            this.bMoneyBack.TabIndex = 29;
            // 
            // BikeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.bMoneyBack);
            this.Controls.Add(this.bmoneyReceived);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b);
            this.Controls.Add(this.m);
            this.Controls.Add(this.bTime);
            this.Controls.Add(this.bNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toll);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.bDate);
            this.Controls.Add(this.label1);
            this.Name = "BikeInfo";
            this.Text = "BikeInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toll;
        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.DateTimePicker bDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bNum;
        private System.Windows.Forms.DateTimePicker bTime;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bmoneyReceived;
        private System.Windows.Forms.TextBox bMoneyBack;
    }
}