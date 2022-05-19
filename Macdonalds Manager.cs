namespace EFWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext()) 
            {
                EmployeeDataGridView.DataSource = db.Employees.ToList();
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var ids = new List<int>();
            for (int i = 0; i < EmployeeDataGridView.Rows.Count; i++)
            {
                ids.Add(int.Parse(EmployeeDataGridView.Rows[i].Cells[0].Value.ToString()));
            }    
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                foreach (var id in ids)
                {
                    var worker = db.Employees.Find(id);
                    worker.Name = EmployeeDataGridView.Rows[id].Cells[1].Value.ToString();
                    worker.Surname = EmployeeDataGridView.Rows[id].Cells[2].Value.ToString();
                    worker.FatherName = EmployeeDataGridView.Rows[id].Cells[3].Value.ToString();
                    worker.Age = int.Parse(EmployeeDataGridView.Rows[id].Cells[4].Value.ToString());
                    worker.SizeOfClothes = EmployeeDataGridView.Rows[id].Cells[5].Value.ToString();
                    worker.DateOfPromotion = (DateTime)EmployeeDataGridView.Rows[id].Cells[6].Value;
                }
                db.SaveChanges(); 
            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            //Нужно придумать как обновлять db по DataGrid
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext()) 
            { 
                EmployeeDataGridView.DataSource = db.Employees.ToList(); 
            }
            EmployeeDataGridView.Update();
        }

        private void AddEmployeeButtonClick(object sender, EventArgs e)
        {
            AddingForm addingEmployeeForm = new AddingForm();
            addingEmployeeForm.Show();
        }

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}