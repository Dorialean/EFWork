namespace EFWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.employeePicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.dateOfPromotionLabel = new System.Windows.Forms.Label();
            this.showDocsButton = new System.Windows.Forms.Button();
            this.postLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sizeOfClothesLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(589, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить новое";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddEmployeeButtonClick);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(12, 614);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(276, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить информацию";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // employeePicBox
            // 
            this.employeePicBox.BackColor = System.Drawing.Color.Peru;
            this.employeePicBox.Image = global::EFWork.Properties.Resources.Employee;
            this.employeePicBox.Location = new System.Drawing.Point(6, 30);
            this.employeePicBox.Name = "employeePicBox";
            this.employeePicBox.Size = new System.Drawing.Size(194, 204);
            this.employeePicBox.TabIndex = 5;
            this.employeePicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(257, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(257, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(257, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(257, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Размер одежды";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(247, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Набор документов";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(257, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Должность";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(571, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 30);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Данные";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.ForeColor = System.Drawing.Color.Black;
            this.surnameLabel.Location = new System.Drawing.Point(571, 52);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(98, 30);
            this.surnameLabel.TabIndex = 15;
            this.surnameLabel.Text = "Данные";
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.fatherNameLabel.ForeColor = System.Drawing.Color.Black;
            this.fatherNameLabel.Location = new System.Drawing.Point(571, 77);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(98, 30);
            this.fatherNameLabel.TabIndex = 16;
            this.fatherNameLabel.Text = "Данные";
            this.fatherNameLabel.Click += new System.EventHandler(this.fatherNameLabel_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ageLabel.ForeColor = System.Drawing.Color.Black;
            this.ageLabel.Location = new System.Drawing.Point(571, 127);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(98, 30);
            this.ageLabel.TabIndex = 17;
            this.ageLabel.Text = "Данные";
            // 
            // dateOfPromotionLabel
            // 
            this.dateOfPromotionLabel.AutoSize = true;
            this.dateOfPromotionLabel.Location = new System.Drawing.Point(551, 237);
            this.dateOfPromotionLabel.Name = "dateOfPromotionLabel";
            this.dateOfPromotionLabel.Size = new System.Drawing.Size(75, 25);
            this.dateOfPromotionLabel.TabIndex = 19;
            this.dateOfPromotionLabel.Text = "Данные";
            // 
            // showDocsButton
            // 
            this.showDocsButton.Location = new System.Drawing.Point(496, 253);
            this.showDocsButton.Name = "showDocsButton";
            this.showDocsButton.Size = new System.Drawing.Size(250, 38);
            this.showDocsButton.TabIndex = 20;
            this.showDocsButton.Text = "Показать документы";
            this.showDocsButton.UseVisualStyleBackColor = true;
            this.showDocsButton.Click += new System.EventHandler(this.showDocsButton_Click);
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.postLabel.ForeColor = System.Drawing.Color.Black;
            this.postLabel.Location = new System.Drawing.Point(571, 187);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(98, 30);
            this.postLabel.TabIndex = 21;
            this.postLabel.Text = "Данные";
            this.postLabel.Click += new System.EventHandler(this.postLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.sizeOfClothesLabel);
            this.groupBox1.Controls.Add(this.addEmployeeButton);
            this.groupBox1.Controls.Add(this.prevButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.showDocsButton);
            this.groupBox1.Controls.Add(this.employeePicBox);
            this.groupBox1.Controls.Add(this.postLabel);
            this.groupBox1.Controls.Add(this.ageLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.fatherNameLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.surnameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 584);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cотрудник";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sizeOfClothesLabel
            // 
            this.sizeOfClothesLabel.AutoSize = true;
            this.sizeOfClothesLabel.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.sizeOfClothesLabel.ForeColor = System.Drawing.Color.Black;
            this.sizeOfClothesLabel.Location = new System.Drawing.Point(571, 157);
            this.sizeOfClothesLabel.Name = "sizeOfClothesLabel";
            this.sizeOfClothesLabel.Size = new System.Drawing.Size(98, 30);
            this.sizeOfClothesLabel.TabIndex = 25;
            this.sizeOfClothesLabel.Text = "Данные";
            this.sizeOfClothesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sizeOfClothesLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(279, 502);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(192, 60);
            this.addEmployeeButton.TabIndex = 24;
            this.addEmployeeButton.Text = "Добавить нового сотрудника";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(6, 502);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(194, 60);
            this.prevButton.TabIndex = 23;
            this.prevButton.Text = "Предыдущий сотрудник";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(600, 502);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(195, 60);
            this.nextButton.TabIndex = 22;
            this.nextButton.Text = "Следующий сотрудник";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(859, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateOfPromotionLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form1";
            this.Text = "Macdonalds Managment Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeePicBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button2;
        private Button button4;
        private PictureBox employeePicBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label nameLabel;
        private Label surnameLabel;
        private Label fatherNameLabel;
        private Label ageLabel;
        private Label dateOfPromotionLabel;
        private Button showDocsButton;
        private Label postLabel;
        private GroupBox groupBox1;
        private Button prevButton;
        private Button nextButton;
        private Button addEmployeeButton;
        private Label sizeOfClothesLabel;
    }
}