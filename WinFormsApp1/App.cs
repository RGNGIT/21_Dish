using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            DirTabsEvents();
        }

        string connection = "Server=AORUS;Integrated Security=true;";

        void DirTabsEvents()
        {
            DB db = new(connection);
            switch (tabControlDir.SelectedIndex)
            {
                case 0:
                    dataGridViewDir.DataSource = db.ReturnTable("a.Name as Наименование", "menu2.dbo.Units_Of_Measurement as a", null!);
                    break;
                case 1:
                    dataGridViewDir.DataSource = db.ReturnTable("a.Name as Наименование", "menu2.dbo.Type_Ingredients as a", null!);
                    break;
                case 2:
                    dataGridViewDir.DataSource = db.ReturnTable("a.Name as Наименование", "menu2.dbo.Type_Dish as a", null!);
                    break;
                case 3:
                    dataGridViewDir.DataSource = db.ReturnTable("a.Name as Наименование", "menu2.dbo.Restaurant as a", null!);
                    break;
                case 4:
                    dataGridViewDir.DataSource = db.ReturnTable("a.Name as Наименование", "menu2.dbo.Rating as a", null!);
                    break;
                case 5:
                    dataGridViewDir.DataSource = db.ReturnTable("a.Name as Наименование, a.Salary as Зарплата", "menu2.dbo.Post as a", null!);
                    break;
            }
            db.connection.Close();
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            switch (tabControlDir.SelectedIndex)
            {
                case 0:
                    db.AddMeasureUnit(textBoxMeasureName.Text);
                    break;
                case 1:
                    db.AddIngrType(textBoxIngridientName.Text);
                    break;
                case 2:
                    db.AddDishType(textBoxDishType.Text);
                    break;
                case 3:
                    db.AddRestautant(textBoxRestaurant.Text);
                    break;
                case 4:
                    db.AddRating(textBoxRating.Text);
                    break;
                case 5:
                    db.AddPost(textBoxPostName.Text, textBoxSalary.Text);
                    break;
            }
            DirTabsEvents();
            db.connection.Close();
        }

        void DishIngrGridsUpdate()
        {

        }

        void MiscTabsEvents()
        {
            switch (tabControlMisc.SelectedIndex) 
            {
                case 0:
                    DishIngrGridsUpdate();
                    break;
                case 1:
                    break;
            }
        }

        void UpdateMeasureCombo()
        {
            DB db = new(connection);
            comboBoxMeasure.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "menu2.dbo.Units_Of_Measurement", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxMeasure.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void UpdateIngrTypeCombo()
        {
            DB db = new(connection);
            comboBoxIngrType.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "menu2.dbo.Type_Ingredients", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxIngrType.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void UpdateIngrGrid()
        {
            DB db = new(connection);
            dataGridViewIngr.DataSource = db.ReturnTable(
                "a.Name as Наименование, a.Number_of_calories as Калории, a.Number_of_proteins as Белки, a.Number_of_carbohydrates as Углеводы, b.Name as 'Единица измерения', c.Name as Тип",
                "menu2.dbo.Ingredients as a, menu2.dbo.Units_Of_Measurement as b, menu2.dbo.Type_Ingredients as c",
                "WHERE a.id_units_of_measurement = b.id AND a.id_type_ingredients = c.id"
                );
            db.connection.Close();
        }

        void UpdateEmpPostCombo()
        {
            DB db = new(connection);
            comboBoxPost.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "menu2.dbo.Post", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxPost.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void UpdateEmpGrid()
        {
            DB db = new(connection);
            dataGridViewEmp.DataSource = db.ReturnTable(
                "a.Surname as Фамилия, a.Name as Имя, a.Patronymic as Отчество, b.Name as Должность, b.Salary as Зарплата",
                "menu2.dbo.Employee as a, menu2.dbo.Post as b",
                "WHERE a.id_post = b.id"
                );
            db.connection.Close();
        }

        void UpdateRestorauntCombo()
        {
            DB db = new(connection);
            comboBoxMenuRest.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "menu2.dbo.Restaurant", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxMenuRest.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void UpdateMenuGrid()
        {
            DB db = new(connection);
            dataGridViewMenu.DataSource = db.ReturnTable(
                "a.Name as 'Наименование ресторана', b.Date as 'Дата добавления'",
                "menu2.dbo.Restaurant as a, menu2.dbo.Menu as b",
                "WHERE b.id_rest = a.id"
                );
            db.connection.Close();
        }

        void UpdateDishEmpCombo()
        {
            DB db = new(connection);
            comboBoxDishEmp.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "menu2.dbo.Employee", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxDishEmp.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value} {dataGridViewBuffer.Rows[i].Cells[2].Value} {dataGridViewBuffer.Rows[i].Cells[3].Value}");
            }
            db.connection.Close();
        }

        void UpdateDishTypeCombo()
        {
            DB db = new(connection);
            comboBoxDishType.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "menu2.dbo.Type_Dish", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxDishType.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void UpdateDishGrid()
        {
            DB db = new(connection);
            dataGridViewDish.DataSource = db.ReturnTable(
                "a.Name as 'Наименование', b.Name as 'Имя сотрудника', b.Surname as 'Фамилия сотрудника', b.Patronymic as 'Отчество сотрудника', c.Name as Тип",
                "menu2.dbo.Dish as a, menu2.dbo.Employee as b, menu2.dbo.Type_Dish as c",
                "WHERE a.id_employee = b.id AND a.id_type_dish = c.id"
                );
            db.connection.Close();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    DirTabsEvents();
                    break;
                case 1:
                    UpdateIngrGrid();
                    UpdateMeasureCombo();
                    UpdateIngrTypeCombo();
                    break;
                case 2:
                    UpdateEmpGrid();
                    UpdateEmpPostCombo();
                    break;
                case 3:
                    UpdateRestorauntCombo();
                    UpdateMenuGrid();
                    break;
                case 4:
                    UpdateDishGrid();
                    UpdateDishEmpCombo();
                    UpdateDishTypeCombo();
                    break;
                case 5:
                    MiscTabsEvents();
                    break;
            }
        }

        private void tabControlDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirTabsEvents();
        }

        private void buttonAddIngr_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.AddIngr(textBoxIngrName.Text, textBoxIngrCal.Text, textBoxIngrBel.Text, textBoxIngrUgl.Text, comboBoxMeasure.Text.Split(' ')[0], comboBoxIngrType.Text.Split(' ')[0]);
            UpdateIngrGrid();
            db.connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.AddEmployee(textBoxSurname.Text, textBoxName.Text, textBoxPatron.Text, comboBoxPost.Text.Split(' ')[0]);
            UpdateEmpGrid();
            db.connection.Close();
        }

        private void buttonAddMenu_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.AddMenu(dateTimePickerMenuDate.Value.ToString("dd/MM/yyyy"), comboBoxMenuRest.Text.Split(' ')[0]);
            UpdateMenuGrid();
            db.connection.Close();
        }

        private void buttonAddDish_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.AddDish(textBoxDishName.Text, comboBoxDishEmp.Text.Split(' ')[0], comboBoxDishType.Text.Split(' ')[0]);
            UpdateDishGrid();
            db.connection.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

        }
    }
}