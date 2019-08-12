namespace DeterninantTest
{
    partial class InputDataForm
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
            this.textLabel = new System.Windows.Forms.Label();
            this.dimNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dimNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(13, 13);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(728, 55);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Задайте размерность матрицы";
            // 
            // dimNumericUpDown
            // 
            this.dimNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dimNumericUpDown.Location = new System.Drawing.Point(12, 76);
            this.dimNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dimNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dimNumericUpDown.Name = "dimNumericUpDown";
            this.dimNumericUpDown.Size = new System.Drawing.Size(729, 61);
            this.dimNumericUpDown.TabIndex = 1;
            this.dimNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(12, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(729, 66);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // InputDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 236);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dimNumericUpDown);
            this.Controls.Add(this.textLabel);
            this.Name = "InputDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.InputDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.NumericUpDown dimNumericUpDown;
        private System.Windows.Forms.Button okButton;
    }
}