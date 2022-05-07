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
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext()) db.SaveChanges();
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