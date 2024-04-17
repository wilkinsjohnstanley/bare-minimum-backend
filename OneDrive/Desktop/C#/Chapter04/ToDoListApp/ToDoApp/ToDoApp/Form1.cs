using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class ToDoApp : Form
    {
        public ToDoApp()
        {
            InitializeComponent();
        }
        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            //create columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");
            //Point our datagrid view to our datasource
            list.DataSource = todoList;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete button
            try
            {
                todoList.Rows[list.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            //Fill text fields with data from the table
            titleTextBox.Text = todoList.Rows[list.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[list.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[list.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[list.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;

            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);
            }
            //Clear fields
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing = false;
        }
    }
}
