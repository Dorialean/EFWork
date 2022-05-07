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
        }

        private void AddingEmployeeForm_Load(object sender, EventArgs e)
        {
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                dataGridView1.DataSource = db.Posts.ToList();
                dataGridView2.DataSource = db.Documents.ToList();
                dataGridView3.DataSource = db.Employees.ToList();
            }
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.HeaderText = "";
            buttonColumn1.Width = 80;
            buttonColumn1.Name = "buttonColumn";
            buttonColumn1.Text = "Delete";
            buttonColumn1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(3, buttonColumn1);
            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "";
            buttonColumn2.Width = 80;
            buttonColumn2.Name = "buttonColumn";
            buttonColumn2.Text = "Delete";
            buttonColumn2.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Insert(6, buttonColumn2);
            DataGridViewButtonColumn buttonColumn3 = new DataGridViewButtonColumn();
            buttonColumn3.HeaderText = "";
            buttonColumn3.Width = 80;
            buttonColumn3.Name = "buttonColumn";
            buttonColumn3.Text = "Delete";
            buttonColumn3.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Insert(11, buttonColumn3);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
                {
                    Models.Post removePost = db.Posts.Single(p => p.Id == e.RowIndex);
                    db.Posts.Remove(removePost);
                    db.SaveChanges();
                }
                dataGridView1.Update();
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
                {
                    Models.Document removeDocs = db.Documents.Single(d => d.DocumentsPackId == e.RowIndex);
                    db.Documents.Remove(removeDocs);
                    db.SaveChanges();
                }
                dataGridView2.Update();
            }
        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
                {
                    Models.Employee removeEmp = db.Employees.Single(emp => emp.TableNumberId == e.RowIndex);
                    db.Employees.Remove(removeEmp);
                    db.SaveChanges();
                }
                dataGridView3.Update();
            }
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

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployesForm addEmployesForm = new AddEmployesForm();
            addEmployesForm.Show();
        }
    }
}
