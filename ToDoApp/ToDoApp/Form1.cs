using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        List<ToDoTask> taskList = new List<ToDoTask>();
        public Form1()
        {
            InitializeComponent();
            Title_list_dg.AutoGenerateColumns = false;
            Title_list_dg.RowHeadersVisible = false;
            Title_list_dg.AllowUserToResizeRows = false;
            Title_list_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            // Load tasks from the file on application startup
            FileController.LoadFromFile(taskList);

            // Bind the taskList to the DataGridView
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            Title_list_dg.DataSource = null;
            Title_list_dg.DataSource = taskList;
            Title_list_dg.Columns.Clear();

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Task Title";
            column.DataPropertyName = "TaskTitle";
            Title_list_dg.Columns.Add(column);
        }

        private void Add_bt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Title_tb.Text) && string.IsNullOrWhiteSpace(Description_tb.Text))
            {
                // Both title and description are missing
                MessageBox.Show("Please enter title and description.", "Empty Fields", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrWhiteSpace(Title_tb.Text))
            {
                // Only title is missing
                MessageBox.Show("Please add title.", "Empty Title", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrWhiteSpace(Description_tb.Text))
            {
                // Only description is missing
                MessageBox.Show("Please add description.", "Empty Description", MessageBoxButtons.OK);
            }
            else
            {
                // Both title and description are present
                taskList.Add(new ToDoTask { TaskTitle = Title_tb.Text, TaskDescription = Description_tb.Text, TaskDueDate = Date_picker.Value });

                // Refresh the DataGridView
                refreshDataGridView();

                // Save to file
                FileController.SaveToFile(taskList);

            }
        }





        private void Title_list_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a valid cell is clicked
            {
                var cellValue = Title_list_dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    ToDoTask selectedTask = (ToDoTask)Title_list_dg.Rows[e.RowIndex].DataBoundItem;
                    Description_view_tb.Text = selectedTask.TaskDescription;
                    deadline_view_lb.Text = selectedTask.TaskDueDate.ToShortDateString();
                }
                else
                {
                    Description_view_tb.Text = string.Empty;
                }
            }
        }

        private void Done_bt_Click(object sender, EventArgs e)
        {
            if (Title_list_dg.SelectedRows.Count > 0)
            {
                int selectedIndex = Title_list_dg.SelectedRows[0].Index;

                if (selectedIndex >= 0)
                {
                    taskList.RemoveAt(selectedIndex);
                    refreshDataGridView();

                    FileController.SaveToFile(taskList);
                }
            }
            else 
            {            
                MessageBox.Show("Please select a task to delete");
            }
        }
    }
}
