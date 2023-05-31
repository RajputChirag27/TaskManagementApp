using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private List<string> tasks;

        public MainForm()
        {
            InitializeComponent();
            tasks = new List<string>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text;
            if (!string.IsNullOrWhiteSpace(description))
            {
                tasks.Add(description);
                RefreshTaskList();
                descriptionTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = taskListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                string description = descriptionTextBox.Text;
                if (!string.IsNullOrWhiteSpace(description))
                {
                    tasks[selectedIndex] = description;
                    RefreshTaskList();
                    descriptionTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a task description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = taskListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                tasks.RemoveAt(selectedIndex);
                RefreshTaskList();
                descriptionTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = taskListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                tasks.RemoveAt(selectedIndex);
                RefreshTaskList();
                descriptionTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshTaskList()
        {
            taskListBox.Items.Clear();
            foreach (string task in tasks)
            {
                taskListBox.Items.Add(task);
            }
        }
    }
}
