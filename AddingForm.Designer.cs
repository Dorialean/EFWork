namespace EFWork
{
    partial class AddingForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.docsPicBox = new System.Windows.Forms.PictureBox();
            this.postPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.docsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 61);
            this.button3.TabIndex = 6;
            this.button3.Text = "Добавить набор документов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddDocsButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить новую должность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddPostButton_Click);
            // 
            // docsPicBox
            // 
            this.docsPicBox.Image = global::EFWork.Properties.Resources.Docs;
            this.docsPicBox.Location = new System.Drawing.Point(12, 12);
            this.docsPicBox.Name = "docsPicBox";
            this.docsPicBox.Size = new System.Drawing.Size(273, 219);
            this.docsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.docsPicBox.TabIndex = 8;
            this.docsPicBox.TabStop = false;
            // 
            // postPicBox
            // 
            this.postPicBox.Image = global::EFWork.Properties.Resources.Job;
            this.postPicBox.Location = new System.Drawing.Point(322, 12);
            this.postPicBox.Name = "postPicBox";
            this.postPicBox.Size = new System.Drawing.Size(248, 219);
            this.postPicBox.TabIndex = 9;
            this.postPicBox.TabStop = false;
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 325);
            this.Controls.Add(this.postPicBox);
            this.Controls.Add(this.docsPicBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "AddingForm";
            this.Text = "AddingEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.docsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button3;
        private Button button2;
        private PictureBox docsPicBox;
        private PictureBox postPicBox;
    }
}