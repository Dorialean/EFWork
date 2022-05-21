namespace EFWork
{
    public partial class Form1 : Form
    {
        List<Models.Employee> employees = new List<Models.Employee>();
        public Form1()
        {
            InitializeComponent();
            employeePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                foreach (var e in db.Employees)
                {
                    employees.Add(e);
                }
                postLabel.Text = db.Posts.Find(employees[0].PostId).JobTitle.ToString();
            }
            nameLabel.Text = employees[0].Name.ToString();
            surnameLabel.Text = employees[0].Surname.ToString();
            fatherNameLabel.Text = employees[0].FatherName.ToString();
            ageLabel.Text = employees[0].Age.ToString();
            sizeOfClothesLabel.Text = employees[0].SizeOfClothes.ToString();
            dateLabel.Text = employees[0].DateOfPromotion.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                List<Models.Employee> newEmployees = new List<Models.Employee>();
                foreach (var emp in db.Employees)
                {
                    newEmployees.Add(emp);
                }
                employees.Clear();
                employees = new List<Models.Employee>(newEmployees);
                postLabel.Text = db.Posts.Find(employees[0].PostId).JobTitle.ToString();
            }
            nameLabel.Text = employees[0].Name.ToString();
            surnameLabel.Text = employees[0].Surname.ToString();
            fatherNameLabel.Text = employees[0].FatherName.ToString();
            ageLabel.Text = employees[0].Age.ToString();
            sizeOfClothesLabel.Text = employees[0].SizeOfClothes.ToString();
            dateLabel.Text = employees[0].DateOfPromotion.ToString();
        }

        private void AddEmployeeButtonClick(object sender, EventArgs e)
        {
            AddingForm addingEmployeeForm = new AddingForm();
            addingEmployeeForm.Show();
        }

        private void showDocsButton_Click(object sender, EventArgs e)
        {
            int docId;
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                Models.Employee? emp = db.Employees.Find(employees.First(x=> x.Name == nameLabel.Text 
                && x.Surname == surnameLabel.Text
                && x.DateOfPromotion == DateTime.Parse(dateLabel.Text)
                && x.Age == int.Parse(ageLabel.Text)
                && x.SizeOfClothes == sizeOfClothesLabel.Text).TableNumberId);
                docId = (int)emp.DocumentsPackId; 
            }
            DocsShowForm docsShowForm = new DocsShowForm(docId);
            docsShowForm.Show();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            int empId;
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                empId = db.Employees.Find(db.Employees.First(x => x.Name == nameLabel.Text
                                && x.Surname == surnameLabel.Text
                                && x.DateOfPromotion == DateTime.Parse(dateLabel.Text)
                                && x.Age == int.Parse(ageLabel.Text)
                                && x.SizeOfClothes == sizeOfClothesLabel.Text).TableNumberId).TableNumberId;
            }
            int thisEmp = employees.FindIndex(x => x.TableNumberId == empId);
            if (employees[thisEmp] != employees[0])
            {
                nameLabel.Text = employees[thisEmp - 1].Name.ToString();
                surnameLabel.Text = employees[thisEmp - 1].Surname.ToString();
                fatherNameLabel.Text = employees[thisEmp - 1].FatherName.ToString();
                ageLabel.Text = employees[thisEmp - 1].Age.ToString();
                sizeOfClothesLabel.Text = employees[thisEmp - 1].SizeOfClothes.ToString();
                dateLabel.Text = employees[thisEmp - 1].DateOfPromotion.ToString();
            }
            else
                MessageBox.Show("Это первый сотрудник, перед ним никого нет!");
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int empId;
            using (Models.macdonaldsWorkContext db = new Models.macdonaldsWorkContext())
            {
                empId = db.Employees.Find(db.Employees.First(x => x.Name == nameLabel.Text
                                && x.Surname == surnameLabel.Text
                                && x.DateOfPromotion == DateTime.Parse(dateLabel.Text)
                                && x.Age == int.Parse(ageLabel.Text)
                                && x.SizeOfClothes == sizeOfClothesLabel.Text).TableNumberId).TableNumberId;
            }
            int thisEmp = employees.FindIndex(x => x.TableNumberId == empId);
            if (employees.Count - 1 != thisEmp)
            {
                nameLabel.Text = employees[thisEmp + 1].Name.ToString();
                surnameLabel.Text = employees[thisEmp + 1].Surname.ToString();
                fatherNameLabel.Text = employees[thisEmp + 1].FatherName.ToString();
                ageLabel.Text = employees[thisEmp + 1].Age.ToString();
                sizeOfClothesLabel.Text = employees[thisEmp + 1].SizeOfClothes.ToString();
                dateLabel.Text = employees[thisEmp + 1].DateOfPromotion.ToString();
            }
            else
                MessageBox.Show("Это последний сотрудник, после него никого нет!");
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployesForm addEmployesForm = new AddEmployesForm();
            addEmployesForm.Show();
        }
    }
}