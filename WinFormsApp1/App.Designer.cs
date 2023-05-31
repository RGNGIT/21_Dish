namespace WinFormsApp1
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            buttonDelDir = new Button();
            buttonAddDir = new Button();
            tabControlDir = new TabControl();
            tabPage3 = new TabPage();
            label1 = new Label();
            textBoxMeasureName = new TextBox();
            tabPage4 = new TabPage();
            label2 = new Label();
            textBoxIngridientName = new TextBox();
            tabPage5 = new TabPage();
            label3 = new Label();
            textBoxDishType = new TextBox();
            tabPage6 = new TabPage();
            label4 = new Label();
            textBoxRestaurant = new TextBox();
            tabPage7 = new TabPage();
            label5 = new Label();
            textBoxRating = new TextBox();
            tabPage8 = new TabPage();
            label7 = new Label();
            textBoxSalary = new TextBox();
            label6 = new Label();
            textBoxPostName = new TextBox();
            dataGridViewDir = new DataGridView();
            tabPage2 = new TabPage();
            comboBoxIngrType = new ComboBox();
            label13 = new Label();
            comboBoxMeasure = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            textBoxIngrUgl = new TextBox();
            button1 = new Button();
            buttonAddIngr = new Button();
            label10 = new Label();
            textBoxIngrBel = new TextBox();
            label9 = new Label();
            textBoxIngrCal = new TextBox();
            label8 = new Label();
            textBoxIngrName = new TextBox();
            dataGridViewIngr = new DataGridView();
            tabPage9 = new TabPage();
            button2 = new Button();
            buttonAddEmp = new Button();
            comboBoxPost = new ComboBox();
            label17 = new Label();
            label14 = new Label();
            textBoxPatron = new TextBox();
            label15 = new Label();
            textBoxName = new TextBox();
            label16 = new Label();
            textBoxSurname = new TextBox();
            dataGridViewEmp = new DataGridView();
            tabPage10 = new TabPage();
            button3 = new Button();
            buttonAddMenu = new Button();
            label19 = new Label();
            dateTimePickerMenuDate = new DateTimePicker();
            comboBoxMenuRest = new ComboBox();
            label18 = new Label();
            dataGridViewMenu = new DataGridView();
            tabPage11 = new TabPage();
            comboBoxDishType = new ComboBox();
            label22 = new Label();
            comboBoxDishEmp = new ComboBox();
            label21 = new Label();
            label20 = new Label();
            textBoxDishName = new TextBox();
            button4 = new Button();
            buttonAddDish = new Button();
            dataGridViewDish = new DataGridView();
            tabPage12 = new TabPage();
            buttonConnect = new Button();
            dataGridView1 = new DataGridView();
            tabControlMisc = new TabControl();
            tabPage13 = new TabPage();
            dataGridViewIngrConnect = new DataGridView();
            dataGridViewDishConnect = new DataGridView();
            tabPage14 = new TabPage();
            dataGridViewBuffer = new DataGridView();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControlDir.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDir).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngr).BeginInit();
            tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmp).BeginInit();
            tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDish).BeginInit();
            tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControlMisc.SuspendLayout();
            tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngrConnect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishConnect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuffer).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage9);
            tabControlMain.Controls.Add(tabPage10);
            tabControlMain.Controls.Add(tabPage11);
            tabControlMain.Controls.Add(tabPage12);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(804, 454);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonDelDir);
            tabPage1.Controls.Add(buttonAddDir);
            tabPage1.Controls.Add(tabControlDir);
            tabPage1.Controls.Add(dataGridViewDir);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(796, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Справочники";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDelDir
            // 
            buttonDelDir.ForeColor = Color.Red;
            buttonDelDir.Location = new Point(496, 368);
            buttonDelDir.Name = "buttonDelDir";
            buttonDelDir.Size = new Size(294, 23);
            buttonDelDir.TabIndex = 3;
            buttonDelDir.Text = "Удалить";
            buttonDelDir.UseVisualStyleBackColor = true;
            // 
            // buttonAddDir
            // 
            buttonAddDir.Location = new Point(496, 397);
            buttonAddDir.Name = "buttonAddDir";
            buttonAddDir.Size = new Size(294, 23);
            buttonAddDir.TabIndex = 2;
            buttonAddDir.Text = "Добавить";
            buttonAddDir.UseVisualStyleBackColor = true;
            buttonAddDir.Click += buttonAddDir_Click;
            // 
            // tabControlDir
            // 
            tabControlDir.Controls.Add(tabPage3);
            tabControlDir.Controls.Add(tabPage4);
            tabControlDir.Controls.Add(tabPage5);
            tabControlDir.Controls.Add(tabPage6);
            tabControlDir.Controls.Add(tabPage7);
            tabControlDir.Controls.Add(tabPage8);
            tabControlDir.Location = new Point(496, 6);
            tabControlDir.Name = "tabControlDir";
            tabControlDir.SelectedIndex = 0;
            tabControlDir.Size = new Size(294, 356);
            tabControlDir.TabIndex = 1;
            tabControlDir.SelectedIndexChanged += tabControlDir_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(textBoxMeasureName);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(286, 328);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Меры";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Наименование";
            // 
            // textBoxMeasureName
            // 
            textBoxMeasureName.Location = new Point(6, 21);
            textBoxMeasureName.Name = "textBoxMeasureName";
            textBoxMeasureName.Size = new Size(274, 23);
            textBoxMeasureName.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(textBoxIngridientName);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(286, 328);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Типы ингридиентов";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Наименование";
            // 
            // textBoxIngridientName
            // 
            textBoxIngridientName.Location = new Point(6, 21);
            textBoxIngridientName.Name = "textBoxIngridientName";
            textBoxIngridientName.Size = new Size(274, 23);
            textBoxIngridientName.TabIndex = 2;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label3);
            tabPage5.Controls.Add(textBoxDishType);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(286, 328);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Тип блюда";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Наименование";
            // 
            // textBoxDishType
            // 
            textBoxDishType.Location = new Point(6, 22);
            textBoxDishType.Name = "textBoxDishType";
            textBoxDishType.Size = new Size(274, 23);
            textBoxDishType.TabIndex = 4;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label4);
            tabPage6.Controls.Add(textBoxRestaurant);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(286, 328);
            tabPage6.TabIndex = 3;
            tabPage6.Text = "Ресторан";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 7;
            label4.Text = "Наименование";
            // 
            // textBoxRestaurant
            // 
            textBoxRestaurant.Location = new Point(6, 21);
            textBoxRestaurant.Name = "textBoxRestaurant";
            textBoxRestaurant.Size = new Size(274, 23);
            textBoxRestaurant.TabIndex = 6;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(label5);
            tabPage7.Controls.Add(textBoxRating);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(286, 328);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Оценка";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 9;
            label5.Text = "Наименование";
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(6, 21);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(274, 23);
            textBoxRating.TabIndex = 8;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(label7);
            tabPage8.Controls.Add(textBoxSalary);
            tabPage8.Controls.Add(label6);
            tabPage8.Controls.Add(textBoxPostName);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(286, 328);
            tabPage8.TabIndex = 5;
            tabPage8.Text = "Должность";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 44);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Зарплата";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(6, 62);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(274, 23);
            textBoxSalary.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 11;
            label6.Text = "Наименование";
            // 
            // textBoxPostName
            // 
            textBoxPostName.Location = new Point(6, 18);
            textBoxPostName.Name = "textBoxPostName";
            textBoxPostName.Size = new Size(274, 23);
            textBoxPostName.TabIndex = 10;
            // 
            // dataGridViewDir
            // 
            dataGridViewDir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDir.Location = new Point(6, 6);
            dataGridViewDir.Name = "dataGridViewDir";
            dataGridViewDir.RowTemplate.Height = 25;
            dataGridViewDir.Size = new Size(484, 414);
            dataGridViewDir.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBoxIngrType);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(comboBoxMeasure);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBoxIngrUgl);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(buttonAddIngr);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBoxIngrBel);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBoxIngrCal);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBoxIngrName);
            tabPage2.Controls.Add(dataGridViewIngr);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(796, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ингредиенты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxIngrType
            // 
            comboBoxIngrType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIngrType.FormattingEnabled = true;
            comboBoxIngrType.Location = new Point(496, 243);
            comboBoxIngrType.Name = "comboBoxIngrType";
            comboBoxIngrType.Size = new Size(294, 23);
            comboBoxIngrType.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(493, 225);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 14;
            label13.Text = "Тип";
            // 
            // comboBoxMeasure
            // 
            comboBoxMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeasure.FormattingEnabled = true;
            comboBoxMeasure.Location = new Point(496, 200);
            comboBoxMeasure.Name = "comboBoxMeasure";
            comboBoxMeasure.Size = new Size(294, 23);
            comboBoxMeasure.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(493, 182);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 12;
            label12.Text = "Мера";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(493, 138);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 11;
            label11.Text = "Углеводы";
            // 
            // textBoxIngrUgl
            // 
            textBoxIngrUgl.Location = new Point(496, 156);
            textBoxIngrUgl.Name = "textBoxIngrUgl";
            textBoxIngrUgl.Size = new Size(294, 23);
            textBoxIngrUgl.TabIndex = 10;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(496, 368);
            button1.Name = "button1";
            button1.Size = new Size(294, 23);
            button1.TabIndex = 9;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonAddIngr
            // 
            buttonAddIngr.Location = new Point(496, 397);
            buttonAddIngr.Name = "buttonAddIngr";
            buttonAddIngr.Size = new Size(294, 23);
            buttonAddIngr.TabIndex = 8;
            buttonAddIngr.Text = "Добавить";
            buttonAddIngr.UseVisualStyleBackColor = true;
            buttonAddIngr.Click += buttonAddIngr_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(493, 93);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 7;
            label10.Text = "Белки";
            // 
            // textBoxIngrBel
            // 
            textBoxIngrBel.Location = new Point(496, 111);
            textBoxIngrBel.Name = "textBoxIngrBel";
            textBoxIngrBel.Size = new Size(294, 23);
            textBoxIngrBel.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 49);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 5;
            label9.Text = "Калории";
            // 
            // textBoxIngrCal
            // 
            textBoxIngrCal.Location = new Point(496, 67);
            textBoxIngrCal.Name = "textBoxIngrCal";
            textBoxIngrCal.Size = new Size(294, 23);
            textBoxIngrCal.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(493, 6);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 3;
            label8.Text = "Наименование";
            // 
            // textBoxIngrName
            // 
            textBoxIngrName.Location = new Point(496, 24);
            textBoxIngrName.Name = "textBoxIngrName";
            textBoxIngrName.Size = new Size(294, 23);
            textBoxIngrName.TabIndex = 2;
            // 
            // dataGridViewIngr
            // 
            dataGridViewIngr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngr.Location = new Point(6, 6);
            dataGridViewIngr.Name = "dataGridViewIngr";
            dataGridViewIngr.RowTemplate.Height = 25;
            dataGridViewIngr.Size = new Size(484, 414);
            dataGridViewIngr.TabIndex = 1;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(button2);
            tabPage9.Controls.Add(buttonAddEmp);
            tabPage9.Controls.Add(comboBoxPost);
            tabPage9.Controls.Add(label17);
            tabPage9.Controls.Add(label14);
            tabPage9.Controls.Add(textBoxPatron);
            tabPage9.Controls.Add(label15);
            tabPage9.Controls.Add(textBoxName);
            tabPage9.Controls.Add(label16);
            tabPage9.Controls.Add(textBoxSurname);
            tabPage9.Controls.Add(dataGridViewEmp);
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(796, 426);
            tabPage9.TabIndex = 2;
            tabPage9.Text = "Служащий";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(496, 368);
            button2.Name = "button2";
            button2.Size = new Size(294, 23);
            button2.TabIndex = 17;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmp
            // 
            buttonAddEmp.Location = new Point(496, 397);
            buttonAddEmp.Name = "buttonAddEmp";
            buttonAddEmp.Size = new Size(294, 23);
            buttonAddEmp.TabIndex = 16;
            buttonAddEmp.Text = "Добавить";
            buttonAddEmp.UseVisualStyleBackColor = true;
            buttonAddEmp.Click += button3_Click;
            // 
            // comboBoxPost
            // 
            comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPost.FormattingEnabled = true;
            comboBoxPost.Location = new Point(496, 157);
            comboBoxPost.Name = "comboBoxPost";
            comboBoxPost.Size = new Size(294, 23);
            comboBoxPost.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(493, 139);
            label17.Name = "label17";
            label17.Size = new Size(69, 15);
            label17.TabIndex = 14;
            label17.Text = "Должность";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(493, 93);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 13;
            label14.Text = "Отчество";
            // 
            // textBoxPatron
            // 
            textBoxPatron.Location = new Point(496, 111);
            textBoxPatron.Name = "textBoxPatron";
            textBoxPatron.Size = new Size(294, 23);
            textBoxPatron.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(493, 49);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 11;
            label15.Text = "Имя";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(496, 67);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(294, 23);
            textBoxName.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(493, 6);
            label16.Name = "label16";
            label16.Size = new Size(58, 15);
            label16.TabIndex = 9;
            label16.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(496, 24);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(294, 23);
            textBoxSurname.TabIndex = 8;
            // 
            // dataGridViewEmp
            // 
            dataGridViewEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmp.Location = new Point(6, 6);
            dataGridViewEmp.Name = "dataGridViewEmp";
            dataGridViewEmp.RowTemplate.Height = 25;
            dataGridViewEmp.Size = new Size(484, 414);
            dataGridViewEmp.TabIndex = 2;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(button3);
            tabPage10.Controls.Add(buttonAddMenu);
            tabPage10.Controls.Add(label19);
            tabPage10.Controls.Add(dateTimePickerMenuDate);
            tabPage10.Controls.Add(comboBoxMenuRest);
            tabPage10.Controls.Add(label18);
            tabPage10.Controls.Add(dataGridViewMenu);
            tabPage10.Location = new Point(4, 24);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(796, 426);
            tabPage10.TabIndex = 3;
            tabPage10.Text = "Меню";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = Color.Red;
            button3.Location = new Point(496, 368);
            button3.Name = "button3";
            button3.Size = new Size(294, 23);
            button3.TabIndex = 21;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonAddMenu
            // 
            buttonAddMenu.Location = new Point(496, 397);
            buttonAddMenu.Name = "buttonAddMenu";
            buttonAddMenu.Size = new Size(294, 23);
            buttonAddMenu.TabIndex = 20;
            buttonAddMenu.Text = "Добавить";
            buttonAddMenu.UseVisualStyleBackColor = true;
            buttonAddMenu.Click += buttonAddMenu_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(493, 6);
            label19.Name = "label19";
            label19.Size = new Size(32, 15);
            label19.TabIndex = 19;
            label19.Text = "Дата";
            // 
            // dateTimePickerMenuDate
            // 
            dateTimePickerMenuDate.Location = new Point(496, 24);
            dateTimePickerMenuDate.Name = "dateTimePickerMenuDate";
            dateTimePickerMenuDate.Size = new Size(294, 23);
            dateTimePickerMenuDate.TabIndex = 18;
            // 
            // comboBoxMenuRest
            // 
            comboBoxMenuRest.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMenuRest.FormattingEnabled = true;
            comboBoxMenuRest.Location = new Point(496, 68);
            comboBoxMenuRest.Name = "comboBoxMenuRest";
            comboBoxMenuRest.Size = new Size(294, 23);
            comboBoxMenuRest.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(493, 50);
            label18.Name = "label18";
            label18.Size = new Size(58, 15);
            label18.TabIndex = 16;
            label18.Text = "Ресторан";
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Location = new Point(6, 6);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowTemplate.Height = 25;
            dataGridViewMenu.Size = new Size(484, 414);
            dataGridViewMenu.TabIndex = 3;
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(comboBoxDishType);
            tabPage11.Controls.Add(label22);
            tabPage11.Controls.Add(comboBoxDishEmp);
            tabPage11.Controls.Add(label21);
            tabPage11.Controls.Add(label20);
            tabPage11.Controls.Add(textBoxDishName);
            tabPage11.Controls.Add(button4);
            tabPage11.Controls.Add(buttonAddDish);
            tabPage11.Controls.Add(dataGridViewDish);
            tabPage11.Location = new Point(4, 24);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new Padding(3);
            tabPage11.Size = new Size(796, 426);
            tabPage11.TabIndex = 4;
            tabPage11.Text = "Блюдо";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // comboBoxDishType
            // 
            comboBoxDishType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDishType.FormattingEnabled = true;
            comboBoxDishType.Location = new Point(496, 112);
            comboBoxDishType.Name = "comboBoxDishType";
            comboBoxDishType.Size = new Size(294, 23);
            comboBoxDishType.TabIndex = 29;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(493, 94);
            label22.Name = "label22";
            label22.Size = new Size(27, 15);
            label22.TabIndex = 28;
            label22.Text = "Тип";
            // 
            // comboBoxDishEmp
            // 
            comboBoxDishEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDishEmp.FormattingEnabled = true;
            comboBoxDishEmp.Location = new Point(496, 67);
            comboBoxDishEmp.Name = "comboBoxDishEmp";
            comboBoxDishEmp.Size = new Size(294, 23);
            comboBoxDishEmp.TabIndex = 27;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(493, 49);
            label21.Name = "label21";
            label21.Size = new Size(66, 15);
            label21.TabIndex = 26;
            label21.Text = "Сотрудник";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(493, 6);
            label20.Name = "label20";
            label20.Size = new Size(90, 15);
            label20.TabIndex = 25;
            label20.Text = "Наименование";
            // 
            // textBoxDishName
            // 
            textBoxDishName.Location = new Point(496, 24);
            textBoxDishName.Name = "textBoxDishName";
            textBoxDishName.Size = new Size(294, 23);
            textBoxDishName.TabIndex = 24;
            // 
            // button4
            // 
            button4.ForeColor = Color.Red;
            button4.Location = new Point(496, 368);
            button4.Name = "button4";
            button4.Size = new Size(294, 23);
            button4.TabIndex = 23;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonAddDish
            // 
            buttonAddDish.Location = new Point(496, 397);
            buttonAddDish.Name = "buttonAddDish";
            buttonAddDish.Size = new Size(294, 23);
            buttonAddDish.TabIndex = 22;
            buttonAddDish.Text = "Добавить";
            buttonAddDish.UseVisualStyleBackColor = true;
            buttonAddDish.Click += buttonAddDish_Click;
            // 
            // dataGridViewDish
            // 
            dataGridViewDish.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDish.Location = new Point(6, 6);
            dataGridViewDish.Name = "dataGridViewDish";
            dataGridViewDish.RowTemplate.Height = 25;
            dataGridViewDish.Size = new Size(484, 414);
            dataGridViewDish.TabIndex = 4;
            // 
            // tabPage12
            // 
            tabPage12.Controls.Add(buttonConnect);
            tabPage12.Controls.Add(dataGridView1);
            tabPage12.Controls.Add(tabControlMisc);
            tabPage12.Location = new Point(4, 24);
            tabPage12.Name = "tabPage12";
            tabPage12.Padding = new Padding(3);
            tabPage12.Size = new Size(796, 426);
            tabPage12.TabIndex = 5;
            tabPage12.Text = "Остальное";
            tabPage12.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(306, 393);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(484, 23);
            buttonConnect.TabIndex = 23;
            buttonConnect.Text = "Соединить";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(306, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(484, 381);
            dataGridView1.TabIndex = 3;
            // 
            // tabControlMisc
            // 
            tabControlMisc.Controls.Add(tabPage13);
            tabControlMisc.Controls.Add(tabPage14);
            tabControlMisc.Location = new Point(8, 6);
            tabControlMisc.Name = "tabControlMisc";
            tabControlMisc.SelectedIndex = 0;
            tabControlMisc.Size = new Size(292, 414);
            tabControlMisc.TabIndex = 0;
            // 
            // tabPage13
            // 
            tabPage13.Controls.Add(dataGridViewIngrConnect);
            tabPage13.Controls.Add(dataGridViewDishConnect);
            tabPage13.Location = new Point(4, 24);
            tabPage13.Name = "tabPage13";
            tabPage13.Padding = new Padding(3);
            tabPage13.Size = new Size(284, 386);
            tabPage13.TabIndex = 0;
            tabPage13.Text = "Блюдо-Ингредиент";
            tabPage13.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIngrConnect
            // 
            dataGridViewIngrConnect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngrConnect.Location = new Point(3, 203);
            dataGridViewIngrConnect.Name = "dataGridViewIngrConnect";
            dataGridViewIngrConnect.RowTemplate.Height = 25;
            dataGridViewIngrConnect.Size = new Size(278, 180);
            dataGridViewIngrConnect.TabIndex = 5;
            // 
            // dataGridViewDishConnect
            // 
            dataGridViewDishConnect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDishConnect.Location = new Point(3, 3);
            dataGridViewDishConnect.Name = "dataGridViewDishConnect";
            dataGridViewDishConnect.RowTemplate.Height = 25;
            dataGridViewDishConnect.Size = new Size(278, 183);
            dataGridViewDishConnect.TabIndex = 4;
            // 
            // tabPage14
            // 
            tabPage14.Location = new Point(4, 24);
            tabPage14.Name = "tabPage14";
            tabPage14.Padding = new Padding(3);
            tabPage14.Size = new Size(284, 386);
            tabPage14.TabIndex = 1;
            tabPage14.Text = "Меню-Блюдо";
            tabPage14.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuffer
            // 
            dataGridViewBuffer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuffer.Location = new Point(810, 30);
            dataGridViewBuffer.Name = "dataGridViewBuffer";
            dataGridViewBuffer.RowTemplate.Height = 25;
            dataGridViewBuffer.Size = new Size(484, 414);
            dataGridViewBuffer.TabIndex = 2;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewBuffer);
            Controls.Add(tabControlMain);
            Name = "App";
            Text = "Form1";
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControlDir.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDir).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngr).EndInit();
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmp).EndInit();
            tabPage10.ResumeLayout(false);
            tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            tabPage11.ResumeLayout(false);
            tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDish).EndInit();
            tabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControlMisc.ResumeLayout(false);
            tabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngrConnect).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishConnect).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuffer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewDir;
        private TabControl tabControlDir;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button buttonDelDir;
        private Button buttonAddDir;
        private Label label1;
        private TextBox textBoxMeasureName;
        private Label label2;
        private TextBox textBoxIngridientName;
        private TabPage tabPage5;
        private Label label3;
        private TextBox textBoxDishType;
        private TabPage tabPage6;
        private Label label4;
        private TextBox textBoxRestaurant;
        private TabPage tabPage7;
        private Label label5;
        private TextBox textBoxRating;
        private TabPage tabPage8;
        private Label label7;
        private TextBox textBoxSalary;
        private Label label6;
        private TextBox textBoxPostName;
        private DataGridView dataGridViewIngr;
        private DataGridView dataGridViewBuffer;
        private Label label8;
        private TextBox textBoxIngrName;
        private Label label10;
        private TextBox textBoxIngrBel;
        private Label label9;
        private TextBox textBoxIngrCal;
        private Button button1;
        private Button buttonAddIngr;
        private Label label11;
        private TextBox textBoxIngrUgl;
        private ComboBox comboBoxIngrType;
        private Label label13;
        private ComboBox comboBoxMeasure;
        private Label label12;
        private TabPage tabPage9;
        private DataGridView dataGridViewEmp;
        private Button button2;
        private Button buttonAddEmp;
        private ComboBox comboBoxPost;
        private Label label17;
        private Label label14;
        private TextBox textBoxPatron;
        private Label label15;
        private TextBox textBoxName;
        private Label label16;
        private TextBox textBoxSurname;
        private TabPage tabPage10;
        private DataGridView dataGridViewMenu;
        private Label label19;
        private DateTimePicker dateTimePickerMenuDate;
        private ComboBox comboBoxMenuRest;
        private Label label18;
        private Button button3;
        private Button buttonAddMenu;
        private TabPage tabPage11;
        private Button button4;
        private Button buttonAddDish;
        private DataGridView dataGridViewDish;
        private Label label20;
        private TextBox textBoxDishName;
        private ComboBox comboBoxDishEmp;
        private Label label21;
        private ComboBox comboBoxDishType;
        private Label label22;
        private TabPage tabPage12;
        private Button buttonConnect;
        private DataGridView dataGridViewDishConnect;
        private DataGridView dataGridView1;
        private TabControl tabControlMisc;
        private TabPage tabPage13;
        private DataGridView dataGridViewIngrConnect;
        private TabPage tabPage14;
    }
}