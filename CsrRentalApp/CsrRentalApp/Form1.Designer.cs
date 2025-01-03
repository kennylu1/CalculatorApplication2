namespace CsrRentalApp
{
    partial class Form1
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
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRented = new System.Windows.Forms.DateTimePicker();
            this.dtReturned = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "car Rental System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(16, 224);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(313, 29);
            this.tbCustomerName.TabIndex = 1;
            this.tbCustomerName.TextChanged += new System.EventHandler(this.tbCustomerName_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtRented
            // 
            this.dtRented.Location = new System.Drawing.Point(12, 343);
            this.dtRented.Name = "dtRented";
            this.dtRented.Size = new System.Drawing.Size(302, 29);
            this.dtRented.TabIndex = 2;
            // 
            // dtReturned
            // 
            this.dtReturned.Location = new System.Drawing.Point(476, 265);
            this.dtReturned.Name = "dtReturned";
            this.dtReturned.Size = new System.Drawing.Size(302, 29);
            this.dtReturned.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(472, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Returned";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Returned";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(163, 577);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "確認";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Items.AddRange(new object[] {
            "Honda",
            "toyota",
            "bmw",
            "benz"});
            this.cbTypeOfCar.Location = new System.Drawing.Point(16, 454);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(301, 26);
            this.cbTypeOfCar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(21, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type Of Car";
            // 
            // lab1
            // 
            this.lab1.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lab1.Location = new System.Drawing.Point(488, 360);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(229, 91);
            this.lab1.TabIndex = 9;
            this.lab1.Text = "Submit";
            this.lab1.UseVisualStyleBackColor = true;
            this.lab1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 641);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtReturned);
            this.Controls.Add(this.dtRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRented;
        private System.Windows.Forms.DateTimePicker dtReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button lab1;
    }
}

