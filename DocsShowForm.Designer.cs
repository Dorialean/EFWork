namespace EFWork
{
    partial class DocsShowForm
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
            this.pasportIdLabel = new System.Windows.Forms.Label();
            this.emplHistoryLabel = new System.Windows.Forms.Label();
            this.medicalBookLabel = new System.Windows.Forms.Label();
            this.sNILSLabel = new System.Windows.Forms.Label();
            this.controlListIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Паспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Трудовая книжка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Медицинская книжка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "СНИЛС";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер контрольного листа";
            // 
            // pasportIdLabel
            // 
            this.pasportIdLabel.AutoSize = true;
            this.pasportIdLabel.Location = new System.Drawing.Point(370, 34);
            this.pasportIdLabel.Name = "pasportIdLabel";
            this.pasportIdLabel.Size = new System.Drawing.Size(75, 25);
            this.pasportIdLabel.TabIndex = 5;
            this.pasportIdLabel.Text = "Данные";
            // 
            // emplHistoryLabel
            // 
            this.emplHistoryLabel.AutoSize = true;
            this.emplHistoryLabel.Location = new System.Drawing.Point(387, 90);
            this.emplHistoryLabel.Name = "emplHistoryLabel";
            this.emplHistoryLabel.Size = new System.Drawing.Size(75, 25);
            this.emplHistoryLabel.TabIndex = 6;
            this.emplHistoryLabel.Text = "Данные";
            // 
            // medicalBookLabel
            // 
            this.medicalBookLabel.AutoSize = true;
            this.medicalBookLabel.Location = new System.Drawing.Point(394, 148);
            this.medicalBookLabel.Name = "medicalBookLabel";
            this.medicalBookLabel.Size = new System.Drawing.Size(75, 25);
            this.medicalBookLabel.TabIndex = 7;
            this.medicalBookLabel.Text = "Данные";
            // 
            // sNILSLabel
            // 
            this.sNILSLabel.AutoSize = true;
            this.sNILSLabel.Location = new System.Drawing.Point(404, 193);
            this.sNILSLabel.Name = "sNILSLabel";
            this.sNILSLabel.Size = new System.Drawing.Size(75, 25);
            this.sNILSLabel.TabIndex = 8;
            this.sNILSLabel.Text = "Данные";
            // 
            // controlListIdLabel
            // 
            this.controlListIdLabel.AutoSize = true;
            this.controlListIdLabel.Location = new System.Drawing.Point(424, 245);
            this.controlListIdLabel.Name = "controlListIdLabel";
            this.controlListIdLabel.Size = new System.Drawing.Size(75, 25);
            this.controlListIdLabel.TabIndex = 9;
            this.controlListIdLabel.Text = "Данные";
            // 
            // DocsShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 296);
            this.Controls.Add(this.controlListIdLabel);
            this.Controls.Add(this.sNILSLabel);
            this.Controls.Add(this.medicalBookLabel);
            this.Controls.Add(this.emplHistoryLabel);
            this.Controls.Add(this.pasportIdLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DocsShowForm";
            this.Text = "DocsShowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label pasportIdLabel;
        private Label emplHistoryLabel;
        private Label medicalBookLabel;
        private Label sNILSLabel;
        private Label controlListIdLabel;
    }
}