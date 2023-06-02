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
                    dataGridViewDir.DataSource = db.ReturnTable("a.id, a.Name as Наименование", "menu2.dbo.Units_Of_Measurement as a", null!);
                    break;
                case 1:
                    dataGridViewDir.DataSource = db.ReturnTable("a.id, a.Name as Наименование", "menu2.dbo.Type_Ingredients as a", null!);
                    break;
                case 2:
                    dataGridViewDir.DataSource = db.ReturnTable("a.id, a.Name as Наименование", "menu2.dbo.Type_Dish as a", null!);
                    break;
                case 3:
                    dataGridViewDir.DataSource = db.ReturnTable("a.id, a.Name as Наименование", "menu2.dbo.Restaurant as a", null!);
                    break;
                case 4:
                    dataGridViewDir.DataSource = db.ReturnTable("a.id, a.Name as Наименование, a.Salary as Зарплата", "menu2.dbo.Post as a", null!);
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
                    db.AddPost(textBoxPostName.Text, textBoxSalary.Text);
                    break;
            }
            DirTabsEvents();
            db.connection.Close();
        }

        void DishIngrGridsUpdate()
        {
            DB db = new(connection);
            dataGridViewDishConnect.DataSource = db.ReturnTable("id, Name", "menu2.dbo.Dish", null!);
            dataGridViewIngrConnect.DataSource = db.ReturnTable("id, Name", "menu2.dbo.Ingredients", null!);
            db.connection.Close();
        }

        void MenuDishGridsUpdate()
        {
            DB db = new(connection);
            dataGridViewDishMenu.DataSource = db.ReturnTable("id, Name", "menu2.dbo.Dish", null!);
            dataGridViewMenuDish.DataSource = db.ReturnTable("a.id, a.Date as Дата, b.Name as Ресторан", "menu2.dbo.Menu as a, menu2.dbo.Restaurant as b", "WHERE a.id_rest = b.id");
            db.connection.Close();
        }

        void MiscTabsEvents()
        {
            switch (tabControlMisc.SelectedIndex)
            {
                case 0:
                    labelTag.Text = "Ингредиенты блюда";
                    DishIngrGridsUpdate();
                    break;
                case 1:
                    labelTag.Text = "Блюда из меню";
                    MenuDishGridsUpdate();
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
                "a.id, a.Name as Наименование, a.Number_of_calories as Калории, a.Number_of_proteins as Белки, a.Number_of_carbohydrates as Углеводы, b.Name as 'Единица измерения', c.Name as Тип",
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
                "a.id, a.Surname as Фамилия, a.Name as Имя, a.Patronymic as Отчество, b.Name as Должность, b.Salary as Зарплата",
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
                "b.id, a.Name as 'Наименование ресторана', b.Date as 'Дата добавления'",
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

        void UpdateDishForRatingCombo()
        {
            DB db = new(connection);
            comboBoxDishRating.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "menu2.dbo.Dish", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxDishRating.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void UpdateRatingGrid()
        {
            DB db = new(connection);
            dataGridViewRating.DataSource = db.ReturnTable("a.id, b.Name as Блюдо, a.Name as Оценка, a.Date as Дата", "menu2.dbo.Rating as a, menu2.dbo.Dish as b", "WHERE a.id_dish = b.id");
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
                case 6:
                    UpdateDishForRatingCombo();
                    UpdateRatingGrid();
                    break;
                case 7:
                    TZTabsEvents();
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

        void ConnectDishIngr()
        {
            DB db = new(connection);
            for (int i = 0; i < dataGridViewIngrConnect.SelectedRows.Count; i++)
            {
                db.ConnectDishIngr(dataGridViewDishConnect.SelectedRows[0].Cells[0].Value.ToString()!, dataGridViewIngrConnect.SelectedRows[i].Cells[0].Value.ToString()!);
            }
            db.connection.Close();
        }

        void ConnectDishMenu()
        {
            DB db = new(connection);
            for (int i = 0; i < dataGridViewDishMenu.SelectedRows.Count; i++)
            {
                db.ConnectMenuDish(dataGridViewDishMenu.SelectedRows[i].Cells[0].Value.ToString()!, dataGridViewMenuDish.SelectedRows[0].Cells[0].Value.ToString()!);
            }
            db.connection.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            switch (tabControlMisc.SelectedIndex)
            {
                case 0:
                    ConnectDishIngr();
                    break;
                case 1:
                    ConnectDishMenu();
                    break;
            }
        }

        private void dataGridViewDishConnect_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DB db = new(connection);
            dataGridViewDishIngrs.DataSource = db.ReturnTable(
                "a.Name as Наименование, a.Number_of_calories as Калории, a.Number_of_proteins as Белки, a.Number_of_carbohydrates as Углеводы",
                "menu2.dbo.Ingredients as a, menu2.dbo.List_Dish_Ingr as b, menu2.dbo.Type_Ingredients as c, menu2.dbo.Units_Of_Measurement as d",
                $"WHERE a.id_units_of_measurement = d.id AND a.id_type_ingredients = c.id AND b.id_ingr = a.id AND b.id_dish = '{dataGridViewDishConnect.SelectedRows[0].Cells[0].Value}'"
                );
            db.connection.Close();
        }

        private void tabControlMisc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MiscTabsEvents();
        }

        private void dataGridViewMenuDish_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DB db = new(connection);
            dataGridViewDishIngrs.DataSource = db.ReturnTable(
                "a.Name as Наименование, c.Date as Дата, d.Name as Ресторан",
                "menu2.dbo.Dish as a, menu2.dbo.List_Menu_Dish as b, menu2.dbo.Menu as c, menu2.dbo.Restaurant as d",
                $"WHERE b.id_dish = a.id AND b.id_menu = c.id AND c.id_rest = d.id AND c.id = '{dataGridViewMenuDish.SelectedRows[0].Cells[0].Value}'"
                );
            db.connection.Close();
        }

        void ComboTZ1Updater()
        {
            DB db = new(connection);
            comboBoxTZ11Type.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "menu2.dbo.Type_Dish", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxTZ11Type.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void ComboTZ2Updater()
        {
            DB db = new(connection);
            comboBoxTZ22Menu.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("a.id, a.Date, b.Name", "menu2.dbo.Menu as a, menu2.dbo.Restaurant as b", "WHERE a.id_rest = b.id");
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxTZ22Menu.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} Меню от {dataGridViewBuffer.Rows[i].Cells[1].Value} из ресторана {dataGridViewBuffer.Rows[i].Cells[2].Value}");
            }
            db.connection.Close();
        }

        void DoTZ1()
        {
            DB db = new(connection);
            dataGridViewTZ11.DataSource = db.ReturnTable(
                "b.Name as Наименование, a.Name as Тип, d.Date as Дата",
                "menu2.dbo.Type_Dish as a, menu2.dbo.Dish as b, menu2.dbo.List_Menu_Dish as c, menu2.dbo.Menu as d",
                $"WHERE a.id = '{comboBoxTZ11Type.Text.Split(' ')[0]}' AND b.id_type_dish = a.id AND c.id_dish = b.id AND c.id_menu = d.id AND d.Date BETWEEN '{dateTimePickerTZ11From.Value.ToString("dd/MM/yyyy")}' AND '{dateTimePickerTZ11To.Value.ToString("dd/MM/yyyy")}'"
                );
            db.connection.Close();
        }

        void DoTZ2()
        {
            DB db = new(connection);
            dataGridViewTZ22.DataSource = db.ReturnTable(
                "c.Name as Наименование, c.Number_of_calories as Калории, c.Number_of_proteins as Белки, c.Number_of_carbohydrates as Углероды",
                "menu2.dbo.List_Menu_Dish as a, menu2.dbo.Dish as b, menu2.dbo.List_Dish_Ingr as d, menu2.dbo.Ingredients as c, menu2.dbo.Menu as e",
                $"WHERE a.id_dish = b.id AND d.id_dish = b.id AND d.id_ingr = c.id AND a.id_menu = '{comboBoxTZ22Menu.Text.Split(' ')[0]}' AND e.id = a.id_menu AND e.Date BETWEEN '{dateTimePickerTZ22From.Value.ToString("dd/MM/yyyy")}' AND '{dateTimePickerTZ22To.Value.ToString("dd/MM/yyyy")}'"
                );
            db.connection.Close();
        }

        void TZTabsEvents()
        {
            switch (tabControlTZ.SelectedIndex)
            {
                case 0:
                    ComboTZ1Updater();
                    break;
                case 1:
                    ComboTZ2Updater();
                    break;
                case 2:

                    break;
            }
        }

        private void buttonTZ1_Click(object sender, EventArgs e)
        {
            DoTZ1();
        }

        private void tabControlTZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            TZTabsEvents();
        }

        private void buttonTZ2_Click(object sender, EventArgs e)
        {
            DoTZ2();
        }

        private void buttonTZ11_Click(object sender, EventArgs e)
        {
            DoTZ1();
        }

        private void buttonTZ22_Click(object sender, EventArgs e)
        {
            DoTZ2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.AddRating(comboBoxDishRating.Text.Split(' ')[0], comboBoxDishRatingRate.Text);
            UpdateRatingGrid();
            db.connection.Close();
        }

        private void buttonTZ3_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            dataGridViewTZ3.DataSource = db.ReturnTable(
                "a.Name as Блюдо, b.Name as Оценка",
                "menu2.dbo.Dish as a, menu2.dbo.Rating as b",
                $"WHERE b.id_dish = a.id AND b.Date BETWEEN '{dateTimePickerTZ3From.Value.ToString("dd/MM/yyyy")}' AND '{dateTimePickerTZ3To.Value.ToString("dd/MM/yyyy")}' ORDER BY b.id_dish"
                );
            db.connection.Close();
        }

        private void buttonDelDir_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            string[] tabs = new string[]
            {
                "menu2.dbo.Units_Of_Measurement",
                "menu2.dbo.Type_Ingredients",
                "menu2.dbo.Type_Dish",
                "menu2.dbo.Restaurant",
                "menu2.dbo.Post"
            };
            db.Delete(dataGridViewDir.SelectedRows[0].Cells[0].Value.ToString()!, tabs[tabControlDir.SelectedIndex]);
            DirTabsEvents();
            db.connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.Delete(dataGridViewIngr.SelectedRows[0].Cells[0].Value.ToString()!, "menu2.dbo.Ingredients");
            UpdateIngrGrid();
            db.connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.Delete(dataGridViewEmp.SelectedRows[0].Cells[0].Value.ToString()!, "menu2.dbo.Employee");
            UpdateEmpGrid();
            db.connection.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.Delete(dataGridViewMenu.SelectedRows[0].Cells[0].Value.ToString()!, "menu2.dbo.Menu");
            UpdateMenuGrid();
            db.connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.Delete(dataGridViewDish.SelectedRows[0].Cells[0].Value.ToString()!, "menu2.dbo.Dish");
            UpdateDishGrid();
            db.connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DB db = new(connection);
            db.Delete(dataGridViewRating.SelectedRows[0].Cells[0].Value.ToString()!, "menu2.dbo.Rating");
            UpdateRatingGrid();
            db.connection.Close();
        }
    }
}