namespace EFWork
{
    partial class AddDocsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PasportIdTextBox = new System.Windows.Forms.TextBox();
            this.EmpHistoryIdTextBox = new System.Windows.Forms.TextBox();
            this.MedicalBookIdTextBox = new System.Windows.Forms.TextBox();
            this.SnilsTextBox = new System.Windows.Forms.TextBox();
            this.ControlListIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasport Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emploement History Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medical Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "SNILS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Control List Id";
            // 
            // PasportIdTextBox
            // 
            this.PasportIdTextBox.Location = new System.Drawing.Point(206, 12);
            this.PasportIdTextBox.Name = "PasportIdTextBox";
            this.PasportIdTextBox.Size = new System.Drawing.Size(542, 31);
            this.PasportIdTextBox.TabIndex = 5;
            // 
            // EmpHistoryIdTextBox
            // 
            this.EmpHistoryIdTextBox.Location = new System.Drawing.Point(206, 49);
            this.EmpHistoryIdTextBox.Name = "EmpHistoryIdTextBox";
            this.EmpHistoryIdTextBox.Size = new System.Drawing.Size(542, 31);
            this.EmpHistoryIdTextBox.TabIndex = 6;
            // 
            // MedicalBookIdTextBox
            // 
            this.MedicalBookIdTextBox.Location = new System.Drawing.Point(206, 86);
            this.MedicalBookIdTextBox.Name = "MedicalBookIdTextBox";
            this.MedicalBookIdTextBox.Size = new System.Drawing.Size(542, 31);
            this.MedicalBookIdTextBox.TabIndex = 7;
            // 
            // SnilsTextBox
            // 
            this.SnilsTextBox.Location = new System.Drawing.Point(206, 129);
            this.SnilsTextBox.Name = "SnilsTextBox";
            this.SnilsTextBox.Size = new System.Drawing.Size(542, 31);
            this.SnilsTextBox.TabIndex = 8;
            // 
            // ControlListIdTextBox
            // 
            this.ControlListIdTextBox.Location = new System.Drawing.Point(206, 166);
            this.ControlListIdTextBox.Name = "ControlListIdTextBox";
            this.ControlListIdTextBox.Size = new System.Drawing.Size(542, 31);
            this.ControlListIdTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddDocsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ControlListIdTextBox);
            this.Controls.Add(this.SnilsTextBox);
            this.Controls.Add(this.MedicalBookIdTextBox);
            this.Controls.Add(this.EmpHistoryIdTextBox);
            this.Controls.Add(this.PasportIdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDocsForm";
            this.Text = "AddDocsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox PasportIdTextBox;
        private TextBox EmpHistoryIdTextBox;
        private TextBox MedicalBookIdTextBox;
        private TextBox SnilsTextBox;
        private TextBox ControlListIdTextBox;
        private Button button1;
    }
}