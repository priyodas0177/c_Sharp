
namespace Gui
{
    partial class TruckInfo
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
            this.txtTnum = new System.Windows.Forms.TextBox();
            this.txtTDat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTtim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTMonBac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTmonRec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(462, 325);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(101, 36);
            this.ok.TabIndex = 25;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // txtTnum
            // 
            this.txtTnum.Location = new System.Drawing.Point(473, 100);
            this.txtTnum.Name = "txtTnum";
            this.txtTnum.Size = new System.Drawing.Size(100, 20);
            this.txtTnum.TabIndex = 24;
            // 
            // txtTDat
            // 
            this.txtTDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDat.Location = new System.Drawing.Point(462, 178);
            this.txtTDat.Name = "txtTDat";
            this.txtTDat.Size = new System.Drawing.Size(226, 22);
            this.txtTDat.TabIndex = 22;
            this.txtTDat.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Truck Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Toll 900";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(196, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTtim
            // 
            this.txtTtim.CustomFormat = "HH:mm";
            this.txtTtim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTtim.Location = new System.Drawing.Point(462, 235);
            this.txtTtim.Name = "txtTtim";
            this.txtTtim.Size = new System.Drawing.Size(200, 20);
            this.txtTtim.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Money Back";
            // 
            // txtTMonBac
            // 
            this.txtTMonBac.Location = new System.Drawing.Point(463, 279);
            this.txtTMonBac.Name = "txtTMonBac";
            this.txtTMonBac.Size = new System.Drawing.Size(100, 20);
            this.txtTMonBac.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Money Received";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Date";
            // 
            // txtTmonRec
            // 
            this.txtTmonRec.Location = new System.Drawing.Point(473, 148);
            this.txtTmonRec.Name = "txtTmonRec";
            this.txtTmonRec.Size = new System.Drawing.Size(100, 20);
            this.txtTmonRec.TabIndex = 34;
            // 
            // TruckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTmonRec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTMonBac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTtim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.txtTnum);
            this.Controls.Add(this.txtTDat);
            this.Controls.Add(this.label1);
            this.Name = "TruckInfo";
            this.Text = "TruckInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox txtTnum;
        private System.Windows.Forms.DateTimePicker txtTDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtTtim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTMonBac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTmonRec;
    }
}