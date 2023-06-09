﻿using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    internal class DB
    {
        public SqlConnection connection;

        public DB(string Credentials)
        {
            connection = new SqlConnection(Credentials);
            connection.Open();
        }

        public DataView ReturnTable(string Columns, string TablesName, string Arguments)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT {Columns} FROM {TablesName} {Arguments}", connection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet);
            return dataSet.Tables[0].DefaultView;
        }

        public string AddMeasureUnit(string Name)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Units_Of_Measurement (Name) VALUES ('{Name}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddIngrType(string Name)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Type_Ingredients (Name) VALUES ('{Name}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddDishType(string Name)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Type_Dish (Name) VALUES ('{Name}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddRestautant(string Name)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Restaurant (Name) VALUES ('{Name}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddRating(string Name)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Rating (Name) VALUES ('{Name}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddPost(string Name, string Salary)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Post (Name, Salary) VALUES ('{Name}', '{Salary}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddIngr(string Name, string Calories, string Proteins, string Carbohydrates, string MeasureId, string TypeId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Ingredients (Name, Number_of_calories, Number_of_proteins, Number_of_carbohydrates, id_units_of_measurement, id_type_ingredients) VALUES ('{Name}', '{Calories}', '{Proteins}', '{Carbohydrates}', '{MeasureId}', '{TypeId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddEmployee(string Surname, string Name, string Patron, string PostId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Employee (Surname, Name, Patronymic, id_post) VALUES ('{Surname}', '{Name}', '{Patron}', '{PostId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddMenu(string Date, string RestId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Menu (Date, id_rest) VALUES ('{Date}', '{RestId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddDish(string Name, string EmpId, string TypeId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Dish (Name, id_employee, id_type_dish) VALUES ('{Name}', '{EmpId}', '{TypeId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string ConnectDishIngr(string DishId, string IngrId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.List_Dish_Ingr (id_ingr, id_dish) VALUES ('{IngrId}', '{DishId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string ConnectMenuDish(string DishId, string MenuId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.List_Menu_Dish (id_menu, id_dish) VALUES ('{MenuId}', '{DishId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string AddRating(string DishId, string Rating)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO menu2.dbo.Rating (Name, id_dish, Date) VALUES ('{Rating}', '{DishId}', GETDATE());", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public string Delete(string Id, string Table)
        {
            try
            {
                SqlCommand command = new SqlCommand($"DELETE FROM {Table} WHERE id = {Id};", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

    }
}
