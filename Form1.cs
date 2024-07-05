using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace DOCUMENTFRESHER
{
    public partial class Form1 : Form
    {
        #region vals
        TreeNode? nower;
        DogConfigs configManager = new();
        public List<Folder> lists = [];
        #endregion
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += closing;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lists = configManager.Deserialize<List<Folder>>();
            List<string> names1 = new(){
            "�����������",
            "������",
            "��_������",
            "��_��������"
            };
            List<string> names2 = new() {
            "���������������",
            "�_��������",
            "������������",
            "��������"
            };
            for (int i = 0; i < 4; i++)
            {
                listBox1.Items.Add(names1[i]);
                listBox2.Items.Add(names2[i]);
            }
            button3.Enabled = false;
            button2.Enabled = false;
            this.MaximizeBox = false;
        }
        private void closing(object? sender, FormClosedEventArgs e)
        {
            foreach (var item in lists)
            {
                if (item.list is not null)
                {
                    var del = item.list.Where(x => x.remark is LISTEN.Remark.��_��������).ToList();
                    foreach (var delitem in del)
                    {
                        if (item.list.Contains(delitem))
                        {
                            item.list.Remove(delitem);
                        }
                    }
                }
            }
            configManager.Serialize(lists);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TVUpdate();
            TREEF();
        }
        #region Folders
        public void AddFolder(string name) => lists.Add(new Folder(name));
        public void AddFolder(string name, List<LISTEN> list) => lists.Add(new Folder(name, list));
        public void RemoveFolder(string name) => lists.Remove(lists.Where(x => x.name == name).First());
        #endregion
        #region Methods
        private void FillGrids(List<List<string>> tableData)
        {            
            dataGridView1.Rows.Clear();
            foreach (List<string> rowData in tableData)
            {                
                while (rowData.Count < dataGridView1.Columns.Count)
                {
                    rowData.Add(string.Empty);
                }
                DataGridViewRow row = new();
                row.CreateCells(dataGridView1);
                Color c = new();//���� ������
                for (int i = 0; i < rowData.Count; i++)
                {
                    if (i == 2)
                    {                        
                        switch (rowData[i])
                        {
                            case "������": c = Color.YellowGreen; break;
                            case "��_������": c = Color.Pink; break;
                            case "��_��������": c = Color.OrangeRed; break;
                            default:
                                break;
                        }
                    }
                    row.DefaultCellStyle.BackColor = c;
                    row.Cells[i].Value = rowData[i];
                }
                dataGridView1.Rows.Add(row);
                    //(rowData.ToArray());
            }
            dataGridView1.ClearSelection();
        }
        public void TVUpdate()
        {
            treeView1.Nodes.Clear();
            foreach (Folder folder in lists)
            {            
                TreeNode folderNode = NewNodes(folder);
                treeView1.Nodes.Add(folderNode);
            }
        }

        // ����� ��� �������� ���� TreeNode � �������� �����
        private TreeNode NewNodes(object obj)
        {
            try
            {
                TreeNode node = new TreeNode();

                if (obj is Folder)
                {
                    Folder folder = (Folder)obj;
                    node.Text = folder.name;                                       
                    if (folder.list is not null)
                    {
                        foreach (LISTEN listenObject in folder.list)
                        {
                            TreeNode listenNode = new TreeNode(listenObject.Name);
                            node.Nodes.Add(listenNode);
                        }
                    }
                }
                else if (obj is LISTEN)
                {
                    LISTEN listenObject = (LISTEN)obj;
                    node.Text = listenObject.Name;
                }

                return node;
            }
            catch (Exception e)
            {
                MessageBox.Show("������ � ������ �������� ����� ��� TreeNode: " + e.Message);
                return new TreeNode();
            }
        }
        //���������
        public void TREEF()
        {
            treeView2.Nodes.Clear();
            foreach (Folder folder in lists)
            {               
                TreeNode folderNode = new();
                folderNode.Text = folder.name;
                treeView2.Nodes.Add(folderNode);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nower = e.Node;
            if (nower is null)
            {
                return;
            }
            else
            {
                var target = nower.Text;
                List<LISTEN>? newt = null;
                //lists.Where(x => x.name == target).First().list;
                foreach (var item in lists)
                {
                    if (item.name == target)
                    {
                        newt = item.list;
                        break;
                    }
                }
                LISTEN? tawt = null;
                foreach (var item in lists)
                {
                    if (item.list is not null)
                    {
                        foreach (var names in item.list)
                        {
                            if (names.Name == target)
                            {
                                tawt = names;
                                break;
                            }
                        }
                    }
                }
                //var tawt = lists.Select(x => x.list.First(x => x.Name == target)).First();
                if (newt is null || newt.Count == 0)
                {
                    if (tawt is not null)
                    {
                        button3.Enabled = true;
                        textBox5.Text = string.Join(", ", tawt.humans);
                        textBox6.Text = tawt.Delay;
                        listBox1.SelectedItem = tawt.remark.ToString();
                        listBox2.SelectedItem = tawt.status.ToString();
                        richTextBox2.Text = tawt.PS;

                        FillGrids(new List<List<string>> {
                        new List<string> {
                        $"{tawt.Name}",
                        $"{tawt.Delay}",
                        $"{tawt.remark}",
                        $"{tawt.status}",
                        $"{string.Join(", ", tawt.humans)}",
                        $"{tawt.PS}"
                        }});
                    }                    
                }
                else
                {
                    button3.Enabled = false;
                    List<List<string>> resulter = new();
                    foreach (var item in newt)
                    {
                        resulter.Add(
                        new List<string> {
                        $"{item.Name}",
                        $"{item.Delay}",
                        $"{item.remark}",
                        $"{item.status}",
                        $"{string.Join(", ", item.humans)}",
                        $"{item.PS}"
                        });
                    }
                    FillGrids(resulter);
                }

            }
        }
        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {                
                var selectedRow = dataGridView1.CurrentRow;
                var name = selectedRow.Cells[0].Value.ToString();
                foreach (var list in lists)
                {
                    if (list.list is not null)
                    {
                        foreach (var item in list.list)
                        {
                            if (item.Name == name)
                            {                                
                                Process.Start("explorer.exe", $"/select,\"{item.PATCH}\"");
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������! " + ex.Message);
            }
        }
        public void CLEAR()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            richTextBox1.Clear();
            richTextBox2.Clear();

            button2.Enabled = false;
            button3.Enabled = false;
            //================
            TREEF();
            TVUpdate();
        }        
        //���������
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {                
                string filePath = openFileDialog1.FileName;
                textBox3.Text = filePath;
                textBox4.Text = Path.GetFileName(filePath).Split('.').First();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    textBox1.Text == string.Empty ||
                    textBox2.Text == string.Empty ||
                    textBox3.Text == string.Empty ||
                    textBox4.Text == string.Empty
                    )
                {
                    throw new Exception("������ ������ �����������.");
                }
                var folder = textBox1.Text;

                var family = textBox2.Text;
                var patch = textBox3.Text;
                var name = textBox4.Text;
                var ps = richTextBox1.Text;

                for (int i = 0; i < lists.Count; i++)
                {
                    if (lists[i].name == folder)
                    {
                        if (lists[i].list is not null)
                        {
                            lists[i].list.Add(
                            new LISTEN(
                                Name: name,
                                PATCH: patch,
                                humans: new List<string> { family },
                                PS: ps
                                )
                            );
                        }
                        else
                        {
                            lists[i].list = new()
                            {
                                new LISTEN(
                                Name: name,
                                PATCH: patch,
                                humans: new List<string> { family },
                                PS: ps
                                )
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������!: " + ex.Message);
            }
            finally
            {
                CLEAR();
            }
        }
        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is not null)
            {
                textBox1.Text = e.Node.Text;
                button2.Enabled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var list in lists)
                {
                    if (list.list is null)
                    {
                        continue;
                    }
                    for (int i = 0; i < list.list.Count; i++)
                    {
                        if (list.list[i].Name == nower.Text)
                        {
                            list.list[i].humans = textBox5.Text.Split(", ").ToList();
                            list.list[i].Delay = textBox6.Text;
                            list.list[i].PS = richTextBox2.Text;
                            LISTEN.Remark gg;
                            LISTEN.Status tt;
                            Enum.TryParse(listBox1.SelectedItem.ToString(), out gg);
                            Enum.TryParse(listBox2.SelectedItem.ToString(), out tt);
                            list.list[i].remark = gg;
                            list.list[i].status = tt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������! " + ex.Message);
            }
            finally
            {
                CLEAR();
            }
        }
        #endregion
    }
    #region Classes
    /// <summary>
    /// ����� ��� ���������� ������ �������� ���������
    /// </summary>
    /// <param name="Name"> ��� ���������</param>
    /// <param name="Delay">����������(����� �� ��� ������������� ����-����)</param>
    /// <param name="remark">������� ��� ���������, ��� � ���������� ���������� �������</param>
    /// <param name="status">������ ��������� ��� ��������� �� ��������� ������</param>
    /// <param name="humans">����������� ���������� ���������</param>
    /// <param name="PS">�������������� �����������</param>
    /// /// <param name="PATCH">���� ���������(������ �� ����)</param>
    public class LISTEN
    {
        public string Name;
        public string? Delay;
        public Remark remark;
        public Status status;
        public List<string> humans;
        public string? PS;
        public string PATCH;
        public LISTEN(string Name, string PATCH, List<string> humans, string? Delay = null, Status status = Status.���������������, Remark remark = Remark.�����������, string? PS = null)
        {
            this.Name = Name;
            this.PATCH = PATCH;
            this.Delay = Delay;
            this.remark = remark;
            this.status = status;
            this.humans = humans;
            this.PS = PS;
        }       

        #region Values
        /// <summary>
        ///  ������� ��� ����������
        /// </summary>
        public enum Remark
        {
            �����������,
            ������,
            ��_������,
            ��_��������
        }
        /// <summary>
        /// ������ ��������� (���������)
        /// </summary>
        public enum Status
        {
            ���������������,
            �_��������,
            ������������,
            ��������
        }
        #endregion
    }
    /// <summary>
    /// �����, �������������� ����� ����� ��� �������� ������
    /// </summary>
    /// <param name="name">��� �����</param>
    /// <param name="list">���� � �����������</param>
    public class Folder
    {
        public string name;
        public List<LISTEN>? list;
        public Folder(string name, List<LISTEN>? list = null)
        {
            this.name = name;
            this.list = list;
        }
    }
    #endregion
}
