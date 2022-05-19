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
    public partial class DocsShowForm : Form
    {
        public DocsShowForm()
        {
            InitializeComponent();
        }

        public DocsShowForm(int id)
        {
            InitializeComponent();
            Models.Document doc = new Models.Document();
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                doc = db.Documents.Find(id);
            }
            pasportIdLabel.Text = doc.PasportId.ToString();
            emplHistoryLabel.Text = doc.EmploementHistory.ToString();
            medicalBookLabel.Text = doc.MedicalBook.ToString();
            sNILSLabel.Text = doc.Snils.ToString();
            controlListIdLabel.Text = doc.ControlListId.ToString();
        }
    }
}
