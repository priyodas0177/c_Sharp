
namespace Gui
{
    partial class BusInfo
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
            this.ok = new System.Windows.Forms.Button();
            this.busNum = new System.Windows.Forms.TextBox();
            this.Busd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toll = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.busMonRec = new System.Windows.Forms.TextBox();
            this.busMonBac = new System.Windows.Forms.TextBox();
            this.BusT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(513, 327);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(101, 36);
            this.ok.TabIndex = 12;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // busNum
            // 
            this.busNum.Location = new System.Drawing.Point(471, 84);
            this.busNum.Name = "busNum";
            this.busNum.Size = new System.Drawing.Size(100, 20);
            this.busNum.TabIndex = 11;
            this.busNum.TextChanged += new System.EventHandler(this.textcarnumber_TextChanged);
            // 
            // Busd
            // 
            this.Busd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busd.Location = new System.Drawing.Point(471, 184);
            this.Busd.Name = "Busd";
            this.Busd.Size = new System.Drawing.Size(226, 22);
            this.Busd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bus Number";
            // 
            // toll
            // 
            this.toll.AutoSize = true;
            this.toll.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toll.Location = new System.Drawing.Point(283, 32);
            this.toll.Name = "toll";
            this.toll.Size = new System.Drawing.Size(143, 25);
            this.toll.TabIndex = 13;
            this.toll.Text = "Toll =600 Tk";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Money Received";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Money Back";
            // 
            // busMonRec
            // 
            this.busMonRec.Location = new System.Drawing.Point(471, 135);
            this.busMonRec.Name = "busMonRec";
            this.busMonRec.Size = new System.Drawing.Size(100, 20);
            this.busMonRec.TabIndex = 17;
            // 
            // busMonBac
            // 
            this.busMonBac.Location = new System.Drawing.Point(471, 271);
            this.busMonBac.Name = "busMonBac";
            this.busMonBac.Size = new System.Drawing.Size(100, 20);
            this.busMonBac.TabIndex = 18;
            this.busMonBac.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BusT
            // 
            this.BusT.CustomFormat = "HH:mm";
            this.BusT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BusT.Location = new System.Drawing.Point(471, 229);
            this.BusT.Name = "BusT";
            this.BusT.Size = new System.Drawing.Size(200, 20);
            this.BusT.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Time";
            // 
            // BusInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BusT);
            this.Controls.Add(this.busMonBac);
            this.Controls.Add(this.busMonRec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toll);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.busNum);
            this.Controls.Add(this.Busd);
            this.Controls.Add(this.label1);
            this.Name = "BusInfo";
            this.Text = "BusInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox busNum;
        private System.Windows.Forms.DateTimePicker Busd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox busMonRec;
        private System.Windows.Forms.TextBox busMonBac;
        private System.Windows.Forms.DateTimePicker BusT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}