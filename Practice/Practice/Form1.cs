using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        List<string> tasks;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form_Load;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tasks = new List<string>
            {
                "task 1",
                "task 2",
                "task 3",
                "task 4",
                "task 5",
                "task 6",
            };

            DisplayTasks(tasks);
        }

        private void DisplayTasks(List<string> tasks)
        {
            lbTasks.DataSource = tasks;
        }

        private void BtnCrossItOut_Click(object sender, EventArgs e)
        {
            if(lbTasks.SelectedIndex != -1)
            {
                var task = lbTasks.SelectedItem as string;
                tasks.Remove(task);
                ReloadTasksList();
            }
        }

        private void ReloadTasksList()
        {
            lbTasks.DataSource = null;
            lbTasks.DataSource = tasks;
        }
    }
}
