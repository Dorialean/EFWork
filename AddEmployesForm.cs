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
    public partial class AddEmployesForm : Form
    {
        public AddEmployesForm()
        {
            InitializeComponent();
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                postComboBox.DataSource = db.Posts.Select(x => x.JobTitle).ToList();
                documentsComboBox.DataSource = db.Documents.Select(x => x.DocumentsPackId).ToList();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmployeeNameTextBox.Text)
                && !string.IsNullOrEmpty(EmployeeSurnameTextBox.Text)
                && !string.IsNullOrEmpty(EmployeeFatherNameTextBox.Text)
                && !string.IsNullOrEmpty(AgeTextBox.Text)
                && !string.IsNullOrEmpty(AgeTextBox.Text)
                && !string.IsNullOrEmpty(DateOfPromotionPicker.Text)
                && (radioButton1.Checked
                || radioButton2.Checked
                || radioButton3.Checked
                || radioButton4.Checked
                || radioButton5.Checked
                || radioButton6.Checked
                || radioButton7.Checked))
            {
                using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
                {
                    string sizeOfClothes;
                    if (radioButton1.Checked) sizeOfClothes = radioButton1.Text;
                    else if (radioButton2.Checked) sizeOfClothes = radioButton2.Text;
                    else if (radioButton3.Checked) sizeOfClothes = radioButton3.Text;
                    else if (radioButton4.Checked) sizeOfClothes = radioButton4.Text;
                    else if (radioButton5.Checked) sizeOfClothes = radioButton5.Text;
                    else if (radioButton6.Checked) sizeOfClothes = radioButton6.Text;
                    else if (radioButton7.Checked) sizeOfClothes = radioButton7.Text;
                    else sizeOfClothes = null;
                    db.Employees.Add(new Models.Employee()
                    {
                        TableNumberId = db.Employees.Count(),
                        Name = EmployeeNameTextBox.Text,
                        Surname = EmployeeSurnameTextBox.Text,
                        FatherName = EmployeeFatherNameTextBox.Text,
                        Age = int.Parse(AgeTextBox.Text),
                        SizeOfClothes = sizeOfClothes,
                        DateOfPromotion = DateOfPromotionPicker.Value,
                        DocumentsPack = db.Documents.First(d => d.DocumentsPackId == int.Parse(documentsComboBox.SelectedValue.ToString())),
                        Post = db.Posts.First(x => x.JobTitle == postComboBox.SelectedValue.ToString())
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
