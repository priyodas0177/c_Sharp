
namespace Gui
{
    partial class VehicleInfo
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCar = new System.Windows.Forms.Button();
            this.BtnBike = new System.Windows.Forms.Button();
            this.BtnTruck = new System.Windows.Forms.Button();
            this.BtnBus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCar
            // 
            this.BtnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCar.Location = new System.Drawing.Point(150, 82);
            this.BtnCar.Name = "BtnCar";
            this.BtnCar.Size = new System.Drawing.Size(118, 48);
            this.BtnCar.TabIndex = 0;
            this.BtnCar.Text = "Car";
            this.BtnCar.UseVisualStyleBackColor = true;
            this.BtnCar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnBike
            // 
            this.BtnBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBike.Location = new System.Drawing.Point(380, 82);
            this.BtnBike.Name = "BtnBike";
            this.BtnBike.Size = new System.Drawing.Size(104, 48);
            this.BtnBike.TabIndex = 4;
            this.BtnBike.Text = "Bike";
            this.BtnBike.UseVisualStyleBackColor = true;
            this.BtnBike.Click += new System.EventHandler(this.bike_Click);
            // 
            // BtnTruck
            // 
            this.BtnTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTruck.Location = new System.Drawing.Point(150, 217);
            this.BtnTruck.Name = "BtnTruck";
            this.BtnTruck.Size = new System.Drawing.Size(118, 48);
            this.BtnTruck.TabIndex = 5;
            this.BtnTruck.Text = "Truck";
            this.BtnTruck.UseVisualStyleBackColor = true;
            this.BtnTruck.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnBus
            // 
            this.BtnBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBus.Location = new System.Drawing.Point(380, 217);
            this.BtnBus.Name = "BtnBus";
            this.BtnBus.Size = new System.Drawing.Size(104, 48);
            this.BtnBus.TabIndex = 6;
            this.BtnBus.Text = "Bus";
            this.BtnBus.UseVisualStyleBackColor = true;
            this.BtnBus.Click += new System.EventHandler(this.bus_Click);
            // 
            // VehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(653, 387);
            this.Controls.Add(this.BtnBus);
            this.Controls.Add(this.BtnTruck);
            this.Controls.Add(this.BtnBike);
            this.Controls.Add(this.BtnCar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "VehicleInfo";
            this.Text = "VehicleInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnCar;
        private System.Windows.Forms.Button BtnBike;
        private System.Windows.Forms.Button BtnTruck;
        private System.Windows.Forms.Button BtnBus;
    }
}