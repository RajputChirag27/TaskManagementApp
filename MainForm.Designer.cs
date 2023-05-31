namespace TaskManagementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button completeButton;

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex != -1)
            {
                descriptionTextBox.Text = taskListBox.SelectedItem.ToString();
            }
        }

        private void InitializeComponent()
        {
            taskListBox = new ListBox();
            descriptionLabel = new Label();
            descriptionTextBox = new TextBox();
            createButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            completeButton = new Button();
            SuspendLayout();
            // 
            // taskListBox
            // 
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 20;
            taskListBox.Location = new Point(16, 18);
            taskListBox.Margin = new Padding(4, 5, 4, 5);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(265, 284);
            taskListBox.TabIndex = 0;
            taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(309, 23);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(313, 48);
            descriptionTextBox.Margin = new Padding(4, 5, 4, 5);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(265, 27);
            descriptionTextBox.TabIndex = 2;
            // 
            // createButton
            // 
            createButton.Location = new Point(313, 103);
            createButton.Margin = new Padding(4, 5, 4, 5);
            createButton.Name = "createButton";
            createButton.Size = new Size(267, 35);
            createButton.TabIndex = 3;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(313, 148);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(267, 35);
            updateButton.TabIndex = 4;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(313, 192);
            deleteButton.Margin = new Padding(4, 5, 4, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(267, 35);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // completeButton
            // 
            completeButton.Location = new Point(313, 237);
            completeButton.Margin = new Padding(4, 5, 4, 5);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(267, 35);
            completeButton.TabIndex = 6;
            completeButton.Text = "Mark as Completed";
            completeButton.UseVisualStyleBackColor = true;
            completeButton.Click += completeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 323);
            Controls.Add(completeButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(createButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(taskListBox);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Task Management App";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
