using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWork
{
    public partial class AddingForm : Form
    {
        public AddingForm()
        {
            InitializeComponent();
            docsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            postPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void AddPostButton_Click(object sender, EventArgs e)
        {
            AddingPostForm addingPostForm = new AddingPostForm();
            addingPostForm.Show();
        }

        private void AddDocsButton_Click(object sender, EventArgs e)
        {
            AddDocsForm addDocsForm = new AddDocsForm();
            addDocsForm.Show();
        }
    }
}
