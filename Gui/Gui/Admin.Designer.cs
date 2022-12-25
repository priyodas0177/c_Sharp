
namespace Gui
{
    partial class AdminInfo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTCD = new System.Windows.Forms.Button();
            this.btnTCM = new System.Windows.Forms.Button();
            this.btnTCY = new System.Windows.Forms.Button();
            this.textSearchByNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewNumber = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(206, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome to Padma Briddge";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTCD
            // 
            this.btnTCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCD.Location = new System.Drawing.Point(26, 97);
            this.btnTCD.Name = "btnTCD";
            this.btnTCD.Size = new System.Drawing.Size(330, 34);
            this.btnTCD.TabIndex = 3;
            this.btnTCD.Text = "Toll Colllection By Day";
            this.btnTCD.UseVisualStyleBackColor = true;
            // 
            // btnTCM
            // 
            this.btnTCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCM.Location = new System.Drawing.Point(26, 150);
            this.btnTCM.Name = "btnTCM";
            this.btnTCM.Size = new System.Drawing.Size(330, 34);
            this.btnTCM.TabIndex = 4;
            this.btnTCM.Text = " Toll Colllection By Month";
            this.btnTCM.UseVisualStyleBackColor = true;
            // 
            // btnTCY
            // 
            this.btnTCY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCY.Location = new System.Drawing.Point(26, 207);
            this.btnTCY.Name = "btnTCY";
            this.btnTCY.Size = new System.Drawing.Size(330, 34);
            this.btnTCY.TabIndex = 5;
            this.btnTCY.Text = "Toll Colllection By Year";
            this.btnTCY.UseVisualStyleBackColor = true;
            // 
            // textSearchByNumber
            // 
            this.textSearchByNumber.BackColor = System.Drawing.SystemColors.GrayText;
            this.textSearchByNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchByNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.textSearchByNumber.Location = new System.Drawing.Point(26, 288);
            this.textSearchByNumber.Name = "textSearchByNumber";
            this.textSearchByNumber.Size = new System.Drawing.Size(186, 29);
            this.textSearchByNumber.TabIndex = 7;
            this.textSearchByNumber.Text = "Search By Number";
            this.textSearchByNumber.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(26, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(206, 405);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 35);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(-5, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Admin Page";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(239, 289);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 28);
            this.txtSearch.TabIndex = 12;
            // 
            // dataGridViewNumber
            // 
            this.dataGridViewNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumber.Location = new System.Drawing.Point(516, 288);
            this.dataGridViewNumber.Name = "dataGridViewNumber";
            this.dataGridViewNumber.Size = new System.Drawing.Size(361, 194);
            this.dataGridViewNumber.TabIndex = 13;
            // 
            // AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 550);
            this.Controls.Add(this.dataGridViewNumber);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textSearchByNumber);
            this.Controls.Add(this.btnTCY);
            this.Controls.Add(this.btnTCM);
            this.Controls.Add(this.btnTCD);
            this.Controls.Add(this.textBox1);
            this.Name = "AdminInfo";
            this.Text = "AdminInfo";
            this.Load += new System.EventHandler(this.ManagerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTCD;
        private System.Windows.Forms.Button btnTCM;
        private System.Windows.Forms.Button btnTCY;
        private System.Windows.Forms.TextBox textSearchByNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewNumber;
    }
}