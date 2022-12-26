
namespace Gui
{
    partial class CarTollCollection
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
            this.moneyreceived = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textmoneyreceived = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textMoneyBack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // moneyreceived
            // 
            this.moneyreceived.AutoSize = true;
            this.moneyreceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyreceived.Location = new System.Drawing.Point(79, 91);
            this.moneyreceived.Name = "moneyreceived";
            this.moneyreceived.Size = new System.Drawing.Size(187, 25);
            this.moneyreceived.TabIndex = 0;
            this.moneyreceived.Text = "Money Received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Money Back";
            // 
            // textmoneyreceived
            // 
            this.textmoneyreceived.Location = new System.Drawing.Point(342, 91);
            this.textmoneyreceived.Multiline = true;
            this.textmoneyreceived.Name = "textmoneyreceived";
            this.textmoneyreceived.Size = new System.Drawing.Size(144, 25);
            this.textmoneyreceived.TabIndex = 2;
            this.textmoneyreceived.TextChanged += new System.EventHandler(this.textmoneyreceived_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(342, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(145, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textMoneyBack
            // 
            this.textMoneyBack.Location = new System.Drawing.Point(342, 163);
            this.textMoneyBack.Multiline = true;
            this.textMoneyBack.Name = "textMoneyBack";
            this.textMoneyBack.Size = new System.Drawing.Size(144, 25);
            this.textMoneyBack.TabIndex = 6;
            // 
            // CarTollCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 404);
            this.Controls.Add(this.textMoneyBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textmoneyreceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyreceived);
            this.Name = "CarTollCollection";
            this.Text = "CarTollCollection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moneyreceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textmoneyreceived;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textMoneyBack;
    }
}