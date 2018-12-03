using System.Collections.Generic;
using System.Windows.Forms;
using CDB;

namespace ComponentsViewer
{
    public partial class MainForm : Form
    {
        private Componente com;
        private List<Componente> mDataSource;
        private HTTPClient HttpClient;
        private DataBaseRequest request;

        public MainForm()
        {
            InitializeComponent();
            HttpClient = new HTTPClient();
            request = new DataBaseRequest();
            request.setType(RequestType.Empty);
            

            mDataSource = new List<Componente>();
            com = new Componente();
            com.cantidad = 10;
            com.codigo = "NE555";
            mDataSource.Add(com);
            mDataSource.Add(com);
            mDataSource.Add(com);
            mDataSource.Add(com);
            mDataSource.Add(com);

            initDataGrid();
        }

        public void initDataGrid()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = mDataSource;
            dataGrid.AutoResizeColumns();
            dataGrid.ColumnHeaderMouseClick += DataGrid_ColumnHeaderMouseClick;
        }

        private void DataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn[] matriz = new DataGridViewColumn[dataGrid.Columns.Count];
            dataGrid.Columns.CopyTo(matriz, 0);
            //dataGrid.SelectedColumns.CopyTo(matriz, 0);
            label.Text = matriz[e.ColumnIndex].Name;
                
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            label2.Text = HttpClient.SendRequestAsync(request);
        }
    }
    
}
