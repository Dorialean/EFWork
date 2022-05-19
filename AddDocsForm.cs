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
    public partial class AddDocsForm : Form
    {
        public AddDocsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PasportIdTextBox.Text)
                && !string.IsNullOrEmpty(EmpHistoryIdTextBox.Text)
                && !string.IsNullOrEmpty(MedicalBookIdTextBox.Text)
                && !string.IsNullOrEmpty(SnilsTextBox.Text)
                && !string.IsNullOrEmpty(ControlListIdTextBox.Text))
            {
                using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
                {
                    db.Documents.Add(new Models.Document()
                    {
                        DocumentsPackId = db.Documents.Count(),
                        PasportId = int.Parse(PasportIdTextBox.Text),
                        EmploementHistory = int.Parse(EmpHistoryIdTextBox.Text),
                        MedicalBook = int.Parse(MedicalBookIdTextBox.Text),
                        Snils = int.Parse(SnilsTextBox.Text),
                        ControlListId = int.Parse(ControlListIdTextBox.Text),
                    });
                    db.SaveChanges();
                }
                MessageBox.Show("Данные успешно сохранены!");
            }
            else
                MessageBox.Show("Данные были введены неверно!");
        }
    }
}
