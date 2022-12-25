
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
            this.textcarnumber = new System.Windows.Forms.TextBox();
            this.textcarname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.carname = new System.Windows.Forms.Label();
            this.toll = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // textcarnumber
            // 
            this.textcarnumber.Location = new System.Drawing.Point(514, 152);
            this.textcarnumber.Name = "textcarnumber";
            this.textcarnumber.Size = new System.Drawing.Size(100, 20);
            this.textcarnumber.TabIndex = 11;
            // 
            // textcarname
            // 
            this.textcarname.Location = new System.Drawing.Point(514, 90);
            this.textcarname.Name = "textcarname";
            this.textcarname.Size = new System.Drawing.Size(100, 20);
            this.textcarname.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bus Number";
            // 
            // carname
            // 
            this.carname.AutoSize = true;
            this.carname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carname.Location = new System.Drawing.Point(187, 90);
            this.carname.Name = "carname";
            this.carname.Size = new System.Drawing.Size(106, 24);
            this.carname.TabIndex = 7;
            this.carname.Text = "Bus Name";
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
            // BusInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toll);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.textcarnumber);
            this.Controls.Add(this.textcarname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carname);
            this.Name = "BusInfo";
            this.Text = "BusInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox textcarnumber;
        private System.Windows.Forms.TextBox textcarname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carname;
        private System.Windows.Forms.Label toll;
        private System.Windows.Forms.Button button1;
    }
}