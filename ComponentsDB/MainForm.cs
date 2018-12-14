using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CDB;

namespace ComponentsViewer
{
    public partial class MainForm : Form
    {
        private List<Componente> mDataSource;
        private AddForm addForm;
        //private HTTPClient HttpClient;
        //private DataBaseRequest request;
        

        public MainForm()
        {
            InitializeComponent();

            FileManager.initFileManager();
            mDataSource = new List<Componente>();
            addForm = new AddForm();
            addForm.FormClosed += OnAddFormClosed;
            addForm.StartPosition = FormStartPosition.CenterParent;
            //com = new Componente();
            //com.cantidad = 10;
            //com.codigo = "NE555A";
            //com.fecha = DateTime.Now;
            //mDataSource.Add(com);


            //try
            //{
            //    FileManager.AddDocument(com);
            //}catch(Exception e)
            //{
            //    MessageBox.Show("[Error] "+e.Message);
            //}
        }

        private void OnAddFormClosed(object sender, FormClosedEventArgs e)
        {
            mDataSource = null;
            mDataSource = new List<Componente>();
            if (FileManager.SearchDocuments() != null)
            {
                mDataSource.AddRange(FileManager.SearchDocuments());
                //MessageBox.Show(""+mDataSource.Count);
                initDataGrid();
            }
            addForm = new AddForm();
            addForm.FormClosed += OnAddFormClosed;
            addForm.StartPosition = FormStartPosition.CenterParent;
        }

        public void initDataGrid()
        {
            //MessageBox.Show("" + mDataSource.Count);
            dataGrid.DataSource = null;
            dataGrid.DataSource = mDataSource;
            dataGrid.AutoResizeColumns();
            dataGrid.ColumnHeaderMouseClick += DataGrid_ColumnHeaderMouseClick;
            dataGrid.ClearSelection();
            
        }

        private void DataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewColumn[] matriz = new DataGridViewColumn[dataGrid.Columns.Count];
            //dataGrid.Columns.CopyTo(matriz, 0);
            //dataGrid.SelectedColumns.CopyTo(matriz, 0);
            //lblCode.Text = matriz[e.ColumnIndex].Name;
                
        }

        private void btnNCom_Click(object sender, EventArgs e)
        {
            if(!addForm.IsDisposed)
            {
                addForm.ShowDialog(this);
            }
            else
            {
                addForm = new AddForm();
                addForm.FormClosed += OnAddFormClosed;
                addForm.StartPosition = FormStartPosition.CenterParent;
                addForm.ShowDialog(this);

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                imageBox.Image = Properties.Resources.ImagenVacia;
                imageBox.SizeMode = PictureBoxSizeMode.Zoom;
                mDataSource.Clear();
                if(FileManager.SearchDocuments() != null)
                {
                    mDataSource.AddRange(FileManager.SearchDocuments());
                    initDataGrid();
                }
                
            }
            catch(Exception b)
            {
                MessageBox.Show("[ERROR] Al cargar la ventana - "+b.Message);
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                showData();
            }
            catch { }
        }

        private void showData()
        {
            imageBox.ImageLocation = "";
            DataGridViewCellCollection cells = dataGrid.SelectedRows[0].Cells;
            string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"/";
            string path = dataPath + "ComponentsDB/img/" + cells["Codigo"].Value.ToString() + ".jpg";

            if (cells["Codigo"].Value.ToString() != "") dCode.Text = cells["Codigo"].Value.ToString();
            if(cells["Descripcion"].Value.ToString() != "") dDescription.Text = cells["Descripcion"].Value.ToString();
            if (cells["Categoria"].Value.ToString() != "") dCategory.Text = cells["Categoria"].Value.ToString();
            if (cells["Paquete"].Value.ToString() != "") dPackage.Text = cells["Paquete"].Value.ToString();
            if (cells["Cantidad"].Value.ToString() != "") dInventory.Text = cells["Cantidad"].Value.ToString();
            if (cells["AltCodigo"].Value.ToString() != "") dEquivalents.Text = cells["AltCodigo"].Value.ToString();
            if (cells["Comentarios"].Value.ToString() != "") dComment.Text = cells["Comentarios"].Value.ToString();

            if ((bool)cells["Imagen"].Value)
            {
                if(FileManager.Exist(path))
                {
                    imageBox.ImageLocation = path;
                    imageBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    imageBox.Image = Properties.Resources.ImagenVacia;
                    imageBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void dataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mDataSource.Clear();
            if (FileManager.SearchDocuments() != null)
            {
                mDataSource.AddRange(FileManager.SearchDocuments());
                initDataGrid();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void componenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!addForm.IsDisposed)
            {
                addForm.ShowDialog(this);
            }
            else
            {
                addForm = new AddForm();
                addForm.FormClosed += OnAddFormClosed;
                addForm.StartPosition = FormStartPosition.CenterParent;
                addForm.ShowDialog(this);

            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.Show(this);
        }
    }
    
}
