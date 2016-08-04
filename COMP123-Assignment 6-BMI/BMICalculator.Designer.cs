namespace COMP123_Assignment_6_BMI
{
    partial class BMICalculator
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
            this.BodyMassIndex = new System.Windows.Forms.Label();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MetricUnits = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyMassIndex
            // 
            this.BodyMassIndex.AutoSize = true;
            this.BodyMassIndex.Location = new System.Drawing.Point(13, 13);
            this.BodyMassIndex.Name = "BodyMassIndex";
            this.BodyMassIndex.Size = new System.Drawing.Size(221, 31);
            this.BodyMassIndex.TabIndex = 1;
            this.BodyMassIndex.Text = "Body Mass Index";
            // 
            // Imperial
            // 
            this.Imperial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Imperial.AutoSize = true;
            this.Imperial.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imperial.Location = new System.Drawing.Point(12, 7);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(114, 48);
            this.Imperial.TabIndex = 3;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.Imperial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricUnits, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 63);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MetricUnits
            // 
            this.MetricUnits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MetricUnits.AutoSize = true;
            this.MetricUnits.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MetricUnits.Location = new System.Drawing.Point(163, 7);
            this.MetricUnits.Name = "MetricUnits";
            this.MetricUnits.Size = new System.Drawing.Size(92, 48);
            this.MetricUnits.TabIndex = 5;
            this.MetricUnits.TabStop = true;
            this.MetricUnits.Text = "Metric";
            this.MetricUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricUnits.UseVisualStyleBackColor = true;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BodyMassIndex);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BodyMassIndex;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton MetricUnits;
    }
}

