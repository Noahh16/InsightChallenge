namespace InsightChallenge
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.customerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.addPointGroupBox = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.addPointButton = new System.Windows.Forms.Button();
            this.colorPickerButtoni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierRadioButton = new System.Windows.Forms.RadioButton();
            this.customerRadioButton = new System.Windows.Forms.RadioButton();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerChart)).BeginInit();
            this.addPointGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerChart
            // 
            this.customerChart.AllowDrop = true;
            this.customerChart.BackColor = System.Drawing.Color.DarkGray;
            this.customerChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.customerChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customerChart.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.Maximum = 500D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea1.AxisY.Maximum = 500D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea1.Name = "supplyChart";
            this.customerChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.customerChart.Legends.Add(legend1);
            this.customerChart.Location = new System.Drawing.Point(13, 43);
            this.customerChart.Name = "customerChart";
            series1.ChartArea = "supplyChart";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Suppliers";
            series2.ChartArea = "supplyChart";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Customers";
            this.customerChart.Series.Add(series1);
            this.customerChart.Series.Add(series2);
            this.customerChart.Size = new System.Drawing.Size(554, 395);
            this.customerChart.TabIndex = 0;
            this.customerChart.Text = "customerChart";
            // 
            // addPointGroupBox
            // 
            this.addPointGroupBox.Controls.Add(this.errorLabel);
            this.addPointGroupBox.Controls.Add(this.addPointButton);
            this.addPointGroupBox.Controls.Add(this.colorPickerButtoni);
            this.addPointGroupBox.Controls.Add(this.label3);
            this.addPointGroupBox.Controls.Add(this.label2);
            this.addPointGroupBox.Controls.Add(this.label1);
            this.addPointGroupBox.Controls.Add(this.supplierRadioButton);
            this.addPointGroupBox.Controls.Add(this.customerRadioButton);
            this.addPointGroupBox.Controls.Add(this.yTextBox);
            this.addPointGroupBox.Controls.Add(this.xTextBox);
            this.addPointGroupBox.Location = new System.Drawing.Point(573, 43);
            this.addPointGroupBox.Name = "addPointGroupBox";
            this.addPointGroupBox.Size = new System.Drawing.Size(252, 199);
            this.addPointGroupBox.TabIndex = 1;
            this.addPointGroupBox.TabStop = false;
            this.addPointGroupBox.Text = "Add Points";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(17, 177);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 9;
            // 
            // addPointButton
            // 
            this.addPointButton.Location = new System.Drawing.Point(17, 136);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(220, 34);
            this.addPointButton.TabIndex = 8;
            this.addPointButton.Text = "Add point";
            this.addPointButton.UseVisualStyleBackColor = true;
            this.addPointButton.Click += new System.EventHandler(this.addPointButton_Click);
            // 
            // colorPickerButtoni
            // 
            this.colorPickerButtoni.Enabled = false;
            this.colorPickerButtoni.Location = new System.Drawing.Point(94, 105);
            this.colorPickerButtoni.Name = "colorPickerButtoni";
            this.colorPickerButtoni.Size = new System.Drawing.Size(143, 22);
            this.colorPickerButtoni.TabIndex = 7;
            this.colorPickerButtoni.Text = "Open Color Picker";
            this.colorPickerButtoni.UseVisualStyleBackColor = true;
            this.colorPickerButtoni.Click += new System.EventHandler(this.colorPickerButtoni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supplier Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coordinates:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type:";
            // 
            // supplierRadioButton
            // 
            this.supplierRadioButton.AutoSize = true;
            this.supplierRadioButton.Location = new System.Drawing.Point(169, 34);
            this.supplierRadioButton.Name = "supplierRadioButton";
            this.supplierRadioButton.Size = new System.Drawing.Size(63, 17);
            this.supplierRadioButton.TabIndex = 3;
            this.supplierRadioButton.TabStop = true;
            this.supplierRadioButton.Text = "Supplier";
            this.supplierRadioButton.UseVisualStyleBackColor = true;
            this.supplierRadioButton.CheckedChanged += new System.EventHandler(this.supplierRadioButton_CheckedChanged);
            // 
            // customerRadioButton
            // 
            this.customerRadioButton.AutoSize = true;
            this.customerRadioButton.Location = new System.Drawing.Point(94, 34);
            this.customerRadioButton.Name = "customerRadioButton";
            this.customerRadioButton.Size = new System.Drawing.Size(69, 17);
            this.customerRadioButton.TabIndex = 2;
            this.customerRadioButton.TabStop = true;
            this.customerRadioButton.Text = "Customer";
            this.customerRadioButton.UseVisualStyleBackColor = true;
            this.customerRadioButton.CheckedChanged += new System.EventHandler(this.customerRadioButton_CheckedChanged);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(169, 72);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(68, 20);
            this.yTextBox.TabIndex = 1;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(94, 72);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(68, 20);
            this.xTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Challenge program made by Noah Haig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(510, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Insight Supply and Demand Challenge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addPointGroupBox);
            this.Controls.Add(this.customerChart);
            this.Name = "Form1";
            this.Text = "Supply and Demand chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerChart)).EndInit();
            this.addPointGroupBox.ResumeLayout(false);
            this.addPointGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart customerChart;
        private System.Windows.Forms.GroupBox addPointGroupBox;
        private System.Windows.Forms.RadioButton supplierRadioButton;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorPickerButtoni;
        private System.Windows.Forms.Button addPointButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

