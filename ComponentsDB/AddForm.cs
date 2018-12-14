using System;
using System.Windows.Forms;
using CDB;

namespace ComponentsViewer
{
    public partial class AddForm : Form
    {
        Componente document;
        string imgName;
        public AddForm()
        {
            InitializeComponent();
            boxPackage.DataSource = Enum.GetValues(typeof(packageType));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            document = new Componente();

            if(txtCode.Text != "") document.Codigo = txtCode.Text;
            if(txtCategory.Text != "") document.Categoria = txtCategory.Text;
            if(txtDescription.Text != "") document.Descripcion = txtDescription.Text;
            if(txtInventory.Text != "") document.Cantidad = Int32.Parse(txtInventory.Text);
            document.Paquete = (packageType)boxPackage.SelectedIndex;
            //MessageBox.Show("Capsula: "+document.Paquete);
            if(txtAltCod.Text != "") document.AltCodigo = txtAltCod.Text;
            if(imageBox.ImageLocation != null ) document.Imagen = true;
            //MessageBox.Show(""+imgName+" -"+(imageBox.Image==null)+"- -"+document.Imagen+"- ");
            if(txtComment.Text != "") document.Comentarios = txtComment.Text;

            try
            {
                FileManager.AddDocument(document);
                if(document.Imagen)
                {
                    FileManager.addImg(imgName, document.Codigo);
                }
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            openImgDialog.ShowDialog();
        }

        private void openImgDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                imgName = openImgDialog.FileName;
                imageBox.ImageLocation = imgName;
                imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void txtInventory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtInventory.Text);
            }
            catch(Exception c)
            {
                txtInventory.ResetText();
            }
        }
    }
}
