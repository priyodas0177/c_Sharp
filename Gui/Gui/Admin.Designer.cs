
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnmonth = new System.Windows.Forms.Button();
            this.btnyear = new System.Windows.Forms.Button();
            this.DTP_day = new System.Windows.Forms.DateTimePicker();
            this.DTPmonth = new System.Windows.Forms.DateTimePicker();
            this.DTPyear = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
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
            this.btnTCD.Click += new System.EventHandler(this.btnTCD_Click);
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(493, 246);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(369, 218);
            this.dgvAdmin.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 334);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(666, 104);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(75, 23);
            this.btnDay.TabIndex = 15;
            this.btnDay.Text = "Show";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmonth
            // 
            this.btnmonth.Location = new System.Drawing.Point(666, 155);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.Size = new System.Drawing.Size(75, 23);
            this.btnmonth.TabIndex = 16;
            this.btnmonth.Text = "Show";
            this.btnmonth.UseVisualStyleBackColor = true;
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click);
            // 
            // btnyear
            // 
            this.btnyear.Location = new System.Drawing.Point(666, 217);
            this.btnyear.Name = "btnyear";
            this.btnyear.Size = new System.Drawing.Size(75, 23);
            this.btnyear.TabIndex = 17;
            this.btnyear.Text = "Show";
            this.btnyear.UseVisualStyleBackColor = true;
            this.btnyear.Click += new System.EventHandler(this.btnyear_Click);
            // 
            // DTP_day
            // 
            this.DTP_day.CustomFormat = "dd";
            this.DTP_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_day.Location = new System.Drawing.Point(397, 104);
            this.DTP_day.Name = "DTP_day";
            this.DTP_day.Size = new System.Drawing.Size(134, 20);
            this.DTP_day.TabIndex = 18;
            // 
            // DTPmonth
            // 
            this.DTPmonth.CustomFormat = "MMMM";
            this.DTPmonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPmonth.Location = new System.Drawing.Point(397, 158);
            this.DTPmonth.Name = "DTPmonth";
            this.DTPmonth.Size = new System.Drawing.Size(127, 20);
            this.DTPmonth.TabIndex = 19;
            // 
            // DTPyear
            // 
            this.DTPyear.CustomFormat = "yyyy";
            this.DTPyear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPyear.Location = new System.Drawing.Point(397, 217);
            this.DTPyear.Name = "DTPyear";
            this.DTPyear.Size = new System.Drawing.Size(127, 20);
            this.DTPyear.TabIndex = 20;
            // 
            // AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 550);
            this.Controls.Add(this.DTPyear);
            this.Controls.Add(this.DTPmonth);
            this.Controls.Add(this.DTP_day);
            this.Controls.Add(this.btnyear);
            this.Controls.Add(this.btnmonth);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvAdmin);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnmonth;
        private System.Windows.Forms.Button btnyear;
        private System.Windows.Forms.DateTimePicker DTP_day;
        private System.Windows.Forms.DateTimePicker DTPmonth;
        private System.Windows.Forms.DateTimePicker DTPyear;
    }
}