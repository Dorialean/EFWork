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
    public partial class AddingPostForm : Form
    {
        public AddingPostForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(JobTitleTextBox.Text) && !string.IsNullOrEmpty(SalaryTextBox.Text))
            {
                using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
                {
                    db.Posts.Add(new Models.Post()
                    {
                        Id = db.Posts.Count(),
                        JobTitle = JobTitleTextBox.Text,
                        Salary = int.Parse(SalaryTextBox.Text)
                    });
                    db.SaveChanges();
                }
                MessageBox.Show("Данные успешно сохранены!");
            }
            else
                MessageBox.Show("Были введены неверные данные!");
        }
    }
}
