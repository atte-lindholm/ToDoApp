namespace ToDoApp
{
    partial class Form1
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
            Title_tb = new TextBox();
            label1 = new Label();
            Description_tb = new RichTextBox();
            label2 = new Label();
            Add_bt = new Button();
            Title_list_dg = new DataGridView();
            Date_picker = new DateTimePicker();
            label3 = new Label();
            Description_view_tb = new RichTextBox();
            deadline_view_lb = new Label();
            Done_bt = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Title_list_dg).BeginInit();
            SuspendLayout();
            // 
            // Title_tb
            // 
            Title_tb.Location = new Point(10, 36);
            Title_tb.Margin = new Padding(3, 2, 3, 2);
            Title_tb.Name = "Title_tb";
            Title_tb.Size = new Size(110, 23);
            Title_tb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // Description_tb
            // 
            Description_tb.Location = new Point(10, 86);
            Description_tb.Margin = new Padding(3, 2, 3, 2);
            Description_tb.Name = "Description_tb";
            Description_tb.Size = new Size(162, 91);
            Description_tb.TabIndex = 3;
            Description_tb.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 69);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "description";
            // 
            // Add_bt
            // 
            Add_bt.Location = new Point(10, 244);
            Add_bt.Margin = new Padding(3, 2, 3, 2);
            Add_bt.Name = "Add_bt";
            Add_bt.Size = new Size(82, 22);
            Add_bt.TabIndex = 5;
            Add_bt.Text = "Add";
            Add_bt.UseVisualStyleBackColor = true;
            Add_bt.Click += Add_bt_Click;
            // 
            // Title_list_dg
            // 
            Title_list_dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Title_list_dg.Location = new Point(262, 36);
            Title_list_dg.Margin = new Padding(3, 2, 3, 2);
            Title_list_dg.Name = "Title_list_dg";
            Title_list_dg.ReadOnly = true;
            Title_list_dg.RowHeadersWidth = 51;
            Title_list_dg.RowTemplate.Height = 29;
            Title_list_dg.Size = new Size(262, 222);
            Title_list_dg.TabIndex = 6;
            Title_list_dg.CellClick += Title_list_dg_CellClick;
            // 
            // Date_picker
            // 
            Date_picker.Format = DateTimePickerFormat.Short;
            Date_picker.Location = new Point(10, 209);
            Date_picker.Margin = new Padding(3, 2, 3, 2);
            Date_picker.Name = "Date_picker";
            Date_picker.Size = new Size(219, 23);
            Date_picker.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 192);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Deadline";
            // 
            // Description_view_tb
            // 
            Description_view_tb.Location = new Point(549, 36);
            Description_view_tb.Margin = new Padding(3, 2, 3, 2);
            Description_view_tb.Name = "Description_view_tb";
            Description_view_tb.ReadOnly = true;
            Description_view_tb.Size = new Size(128, 87);
            Description_view_tb.TabIndex = 9;
            Description_view_tb.Text = "";
            // 
            // deadline_view_lb
            // 
            deadline_view_lb.AutoSize = true;
            deadline_view_lb.Location = new Point(549, 161);
            deadline_view_lb.Name = "deadline_view_lb";
            deadline_view_lb.Size = new Size(10, 15);
            deadline_view_lb.TabIndex = 10;
            deadline_view_lb.Text = ":";
            // 
            // Done_bt
            // 
            Done_bt.Location = new Point(262, 267);
            Done_bt.Margin = new Padding(3, 2, 3, 2);
            Done_bt.Name = "Done_bt";
            Done_bt.Size = new Size(82, 22);
            Done_bt.TabIndex = 11;
            Done_bt.Text = "Done";
            Done_bt.UseVisualStyleBackColor = true;
            Done_bt.Click += Done_bt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 14);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 12;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(549, 146);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 13;
            label5.Text = "Deadline";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Done_bt);
            Controls.Add(deadline_view_lb);
            Controls.Add(Description_view_tb);
            Controls.Add(label3);
            Controls.Add(Date_picker);
            Controls.Add(Title_list_dg);
            Controls.Add(Add_bt);
            Controls.Add(label2);
            Controls.Add(Description_tb);
            Controls.Add(label1);
            Controls.Add(Title_tb);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Title_list_dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title_tb;
        private Label label1;
        private RichTextBox Description_tb;
        private Label label2;
        private Button Add_bt;
        private DataGridView Title_list_dg;
        private DateTimePicker Date_picker;
        private Label label3;
        private RichTextBox Description_view_tb;
        private Label deadline_view_lb;
        private Button Done_bt;
        private Label label4;
        private Label label5;
    }
}
