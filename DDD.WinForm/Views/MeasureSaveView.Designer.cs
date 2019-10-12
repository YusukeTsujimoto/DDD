namespace Ddd.WinForm.Views
{
    partial class MeasureSaveView
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
            this.MeasureDateLabel = new System.Windows.Forms.Label();
            this.MeasureDateTextBox = new System.Windows.Forms.DateTimePicker();
            this.MeasureValueLabel = new System.Windows.Forms.Label();
            this.MeasureValueTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MeasureDateLabel
            // 
            this.MeasureDateLabel.AutoSize = true;
            this.MeasureDateLabel.Location = new System.Drawing.Point(12, 17);
            this.MeasureDateLabel.Name = "MeasureDateLabel";
            this.MeasureDateLabel.Size = new System.Drawing.Size(80, 18);
            this.MeasureDateLabel.TabIndex = 0;
            this.MeasureDateLabel.Text = "計測日時";
            // 
            // MeasureDateTextBox
            // 
            this.MeasureDateTextBox.Location = new System.Drawing.Point(98, 12);
            this.MeasureDateTextBox.Name = "MeasureDateTextBox";
            this.MeasureDateTextBox.Size = new System.Drawing.Size(200, 25);
            this.MeasureDateTextBox.TabIndex = 1;
            // 
            // MeasureValueLabel
            // 
            this.MeasureValueLabel.AutoSize = true;
            this.MeasureValueLabel.Location = new System.Drawing.Point(12, 66);
            this.MeasureValueLabel.Name = "MeasureValueLabel";
            this.MeasureValueLabel.Size = new System.Drawing.Size(62, 18);
            this.MeasureValueLabel.TabIndex = 2;
            this.MeasureValueLabel.Text = "計測値";
            // 
            // MeasureValueTextBox
            // 
            this.MeasureValueTextBox.Location = new System.Drawing.Point(98, 63);
            this.MeasureValueTextBox.Name = "MeasureValueTextBox";
            this.MeasureValueTextBox.Size = new System.Drawing.Size(151, 25);
            this.MeasureValueTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(17, 126);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(255, 66);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(52, 18);
            this.UnitLabel.TabIndex = 5;
            this.UnitLabel.Text = "label1";
            // 
            // MeasureSaveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnitLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MeasureValueTextBox);
            this.Controls.Add(this.MeasureValueLabel);
            this.Controls.Add(this.MeasureDateTextBox);
            this.Controls.Add(this.MeasureDateLabel);
            this.Name = "MeasureSaveView";
            this.Text = "MeasureSaveView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MeasureDateLabel;
        private System.Windows.Forms.DateTimePicker MeasureDateTextBox;
        private System.Windows.Forms.Label MeasureValueLabel;
        private System.Windows.Forms.TextBox MeasureValueTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label UnitLabel;
    }
}