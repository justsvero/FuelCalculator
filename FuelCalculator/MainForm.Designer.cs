namespace FuelCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFuelAmount = new System.Windows.Forms.TextBox();
            this.tbTankCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFuelWeightKg = new System.Windows.Forms.TextBox();
            this.tbFuelWeightKgPerTank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFuelWeightLbPerTank = new System.Windows.Forms.TextBox();
            this.tbFuelWeightLb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFuelAmountLtrPerTank = new System.Windows.Forms.TextBox();
            this.tbFuelAmountLtr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFuelAmount
            // 
            this.tbFuelAmount.Location = new System.Drawing.Point(117, 12);
            this.tbFuelAmount.Name = "tbFuelAmount";
            this.tbFuelAmount.Size = new System.Drawing.Size(48, 20);
            this.tbFuelAmount.TabIndex = 0;
            // 
            // tbTankCount
            // 
            this.tbTankCount.Location = new System.Drawing.Point(117, 38);
            this.tbTankCount.Name = "tbTankCount";
            this.tbTankCount.Size = new System.Drawing.Size(26, 20);
            this.tbTankCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fuel Amount [gal]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fuel Tank Count";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 69);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fuel Weight [kg]";
            // 
            // tbFuelWeightKg
            // 
            this.tbFuelWeightKg.Location = new System.Drawing.Point(118, 103);
            this.tbFuelWeightKg.Name = "tbFuelWeightKg";
            this.tbFuelWeightKg.ReadOnly = true;
            this.tbFuelWeightKg.Size = new System.Drawing.Size(48, 20);
            this.tbFuelWeightKg.TabIndex = 6;
            // 
            // tbFuelWeightKgPerTank
            // 
            this.tbFuelWeightKgPerTank.Location = new System.Drawing.Point(241, 103);
            this.tbFuelWeightKgPerTank.Name = "tbFuelWeightKgPerTank";
            this.tbFuelWeightKgPerTank.ReadOnly = true;
            this.tbFuelWeightKgPerTank.Size = new System.Drawing.Size(48, 20);
            this.tbFuelWeightKgPerTank.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Per Tank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Per Tank";
            // 
            // tbFuelWeightLbPerTank
            // 
            this.tbFuelWeightLbPerTank.Location = new System.Drawing.Point(241, 129);
            this.tbFuelWeightLbPerTank.Name = "tbFuelWeightLbPerTank";
            this.tbFuelWeightLbPerTank.ReadOnly = true;
            this.tbFuelWeightLbPerTank.Size = new System.Drawing.Size(48, 20);
            this.tbFuelWeightLbPerTank.TabIndex = 11;
            // 
            // tbFuelWeightLb
            // 
            this.tbFuelWeightLb.Location = new System.Drawing.Point(118, 129);
            this.tbFuelWeightLb.Name = "tbFuelWeightLb";
            this.tbFuelWeightLb.ReadOnly = true;
            this.tbFuelWeightLb.Size = new System.Drawing.Size(48, 20);
            this.tbFuelWeightLb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fuel Weight [lb]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Per Tank";
            // 
            // tbFuelAmountLtrPerTank
            // 
            this.tbFuelAmountLtrPerTank.Location = new System.Drawing.Point(241, 155);
            this.tbFuelAmountLtrPerTank.Name = "tbFuelAmountLtrPerTank";
            this.tbFuelAmountLtrPerTank.ReadOnly = true;
            this.tbFuelAmountLtrPerTank.Size = new System.Drawing.Size(48, 20);
            this.tbFuelAmountLtrPerTank.TabIndex = 15;
            // 
            // tbFuelAmountLtr
            // 
            this.tbFuelAmountLtr.Location = new System.Drawing.Point(118, 155);
            this.tbFuelAmountLtr.Name = "tbFuelAmountLtr";
            this.tbFuelAmountLtr.ReadOnly = true;
            this.tbFuelAmountLtr.Size = new System.Drawing.Size(48, 20);
            this.tbFuelAmountLtr.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fuel Amount [l]";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 188);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbFuelAmountLtrPerTank);
            this.Controls.Add(this.tbFuelAmountLtr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFuelWeightLbPerTank);
            this.Controls.Add(this.tbFuelWeightLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFuelWeightKgPerTank);
            this.Controls.Add(this.tbFuelWeightKg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTankCount);
            this.Controls.Add(this.tbFuelAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFuelAmount;
        private System.Windows.Forms.TextBox tbTankCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFuelWeightKg;
        private System.Windows.Forms.TextBox tbFuelWeightKgPerTank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFuelWeightLbPerTank;
        private System.Windows.Forms.TextBox tbFuelWeightLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFuelAmountLtrPerTank;
        private System.Windows.Forms.TextBox tbFuelAmountLtr;
        private System.Windows.Forms.Label label8;
    }
}

