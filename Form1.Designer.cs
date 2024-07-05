namespace DOCUMENTFRESHER
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            treeView1 = new TreeView();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            gb2 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button3 = new Button();
            richTextBox2 = new RichTextBox();
            groupBox5 = new GroupBox();
            listBox2 = new ListBox();
            groupBox3 = new GroupBox();
            listBox1 = new ListBox();
            groupBox6 = new GroupBox();
            textBox6 = new TextBox();
            groupBox4 = new GroupBox();
            textBox5 = new TextBox();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            label4 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            treeView2 = new TreeView();
            groupBox7 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gb2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BackColor = SystemColors.ButtonFace;
            treeView1.Location = new Point(12, 32);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(170, 427);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Info;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(662, 398);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += DataGridView_DoubleClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Название";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Отклонение";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Утверждение";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Состояние";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Исполнители";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Дополнение";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // gb2
            // 
            gb2.Controls.Add(dataGridView1);
            gb2.Location = new Point(6, 3);
            gb2.Name = "gb2";
            gb2.Size = new Size(668, 420);
            gb2.TabIndex = 2;
            gb2.TabStop = false;
            gb2.Text = "Отображаемые документы";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(188, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(695, 455);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gb2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(687, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Отображение";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox7);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(687, 427);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Редактирование";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 381);
            button3.Name = "button3";
            button3.Size = new Size(352, 40);
            button3.TabIndex = 5;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Info;
            richTextBox2.Location = new Point(6, 22);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(305, 372);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(listBox2);
            groupBox5.Location = new Point(182, 85);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(176, 226);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Статус документа";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(6, 18);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(164, 199);
            listBox2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox1);
            groupBox3.Location = new Point(6, 85);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(170, 226);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Утверждение (ремарка)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(7, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(157, 199);
            listBox1.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox6);
            groupBox6.Location = new Point(6, 317);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(352, 58);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Отклонение";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Info;
            textBox6.Location = new Point(7, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(339, 23);
            textBox6.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox5);
            groupBox4.Location = new Point(6, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(352, 58);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Фамилии разработавших";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(7, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(339, 23);
            textBox5.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(687, 427);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Добавление";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 421);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Документы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 152);
            label4.Name = "label4";
            label4.Size = new Size(311, 15);
            label4.TabIndex = 7;
            label4.Text = "=====================================>";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(6, 170);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 199);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(312, 177);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 4;
            label2.Text = "Ссылка на документ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 4;
            label3.Text = "Фамилия добавившего";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 65);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "Имя документа";
            // 
            // button2
            // 
            button2.Location = new Point(6, 382);
            button2.Name = "button2";
            button2.Size = new Size(312, 33);
            button2.TabIndex = 2;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 66);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 2;
            button1.Text = "добавить ссылку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Location = new Point(132, 83);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(186, 23);
            textBox4.TabIndex = 1;
            textBox4.WordWrap = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(6, 126);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(312, 23);
            textBox3.TabIndex = 1;
            textBox3.WordWrap = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(treeView2);
            groupBox1.Location = new Point(333, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 421);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Категории";
            // 
            // treeView2
            // 
            treeView2.Dock = DockStyle.Fill;
            treeView2.Location = new Point(3, 19);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(345, 399);
            treeView2.TabIndex = 0;
            treeView2.AfterSelect += treeView2_AfterSelect;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(richTextBox2);
            groupBox7.Location = new Point(364, 21);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(317, 400);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Комментарий";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 475);
            Controls.Add(treeView1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Документооборотия";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gb2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private DataGridView dataGridView1;
        private GroupBox gb2;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label1;
        private Label label3;
        private RichTextBox richTextBox1;
        private TreeView treeView2;
        private Label label4;
        private TextBox textBox1;
        private ListBox listBox1;
        private GroupBox groupBox4;
        private TextBox textBox5;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private ListBox listBox2;
        private RichTextBox richTextBox2;
        private GroupBox groupBox6;
        private TextBox textBox6;
        private Button button3;
        private GroupBox groupBox7;
    }
}
