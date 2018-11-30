using System;
using System.Drawing;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ComponentsViewer
{
    public partial class MainForm : Form
    {
        private Componente com;
        private Graphics graph;

        public MainForm()
        {
            InitializeComponent();
            
        }

        public void initDataGrid()
        {
            //Objeto componente
            com = new Componente();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            graph = e.Graphics;
        }
    }
    
}
