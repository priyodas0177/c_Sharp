
namespace Gui
{
    partial class TruckTollCollection
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
            this.button1 = new System.Windows.Forms.Button();
            this.texttruckmoneyback = new System.Windows.Forms.TextBox();
            this.texttruckmoneyreceived = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.moneyreceived = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(497, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // texttruckmoneyback
            // 
            this.texttruckmoneyback.Location = new System.Drawing.Point(487, 193);
            this.texttruckmoneyback.Name = "texttruckmoneyback";
            this.texttruckmoneyback.Size = new System.Drawing.Size(100, 20);
            this.texttruckmoneyback.TabIndex = 8;
            // 
            // texttruckmoneyreceived
            // 
            this.texttruckmoneyreceived.Location = new System.Drawing.Point(487, 120);
            this.texttruckmoneyreceived.Name = "texttruckmoneyreceived";
            this.texttruckmoneyreceived.Size = new System.Drawing.Size(100, 20);
            this.texttruckmoneyreceived.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Money Back";
            // 
            // moneyreceived
            // 
            this.moneyreceived.AutoSize = true;
            this.moneyreceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyreceived.Location = new System.Drawing.Point(214, 116);
            this.moneyreceived.Name = "moneyreceived";
            this.moneyreceived.Size = new System.Drawing.Size(187, 25);
            this.moneyreceived.TabIndex = 5;
            this.moneyreceived.Text = "Money Received";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TruckTollCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texttruckmoneyback);
            this.Controls.Add(this.texttruckmoneyreceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyreceived);
            this.Name = "TruckTollCollection";
            this.Text = "TruckTollCollection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texttruckmoneyback;
        private System.Windows.Forms.TextBox texttruckmoneyreceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moneyreceived;
        private System.Windows.Forms.Button button2;
    }
}