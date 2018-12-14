namespace ComponentsViewer
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblAltCodes = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtAltCod = new System.Windows.Forms.TextBox();
            this.btnUnLoad = new System.Windows.Forms.Button();
            this.boxPackage = new System.Windows.Forms.ComboBox();
            this.openImgDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(58, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(124, 20);
            this.txtCode.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 49);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Codigo";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(108, 306);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Agregar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(254, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 83);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Categoria";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 118);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Descripcion";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(12, 175);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(54, 13);
            this.lblInventory.TabIndex = 6;
            this.lblInventory.Text = "Inventario";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(12, 212);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(45, 13);
            this.lblPackage.TabIndex = 7;
            this.lblPackage.Text = "Capsula";
            // 
            // lblAltCodes
            // 
            this.lblAltCodes.AutoSize = true;
            this.lblAltCodes.Location = new System.Drawing.Point(12, 246);
            this.lblAltCodes.Name = "lblAltCodes";
            this.lblAltCodes.Size = new System.Drawing.Size(103, 13);
            this.lblAltCodes.TabIndex = 8;
            this.lblAltCodes.Text = "Codigos Alternativos";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(199, 48);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(42, 13);
            this.lblImage.TabIndex = 9;
            this.lblImage.Text = "Imagen";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(199, 175);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(65, 13);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comentarios";
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(306, 48);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(136, 118);
            this.imageBox.TabIndex = 11;
            this.imageBox.TabStop = false;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(202, 78);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(98, 23);
            this.btnLoadImg.TabIndex = 12;
            this.btnLoadImg.Text = "Cargar";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(127, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 20);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Agregar Componentes";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(202, 191);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(240, 91);
            this.txtComment.TabIndex = 14;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(70, 83);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(112, 20);
            this.txtCategory.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(81, 118);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(101, 51);
            this.txtDescription.TabIndex = 16;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(72, 175);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(110, 20);
            this.txtInventory.TabIndex = 17;
            this.txtInventory.TextChanged += new System.EventHandler(this.txtInventory_TextChanged);
            // 
            // txtAltCod
            // 
            this.txtAltCod.Location = new System.Drawing.Point(15, 262);
            this.txtAltCod.Name = "txtAltCod";
            this.txtAltCod.Size = new System.Drawing.Size(167, 20);
            this.txtAltCod.TabIndex = 19;
            // 
            // btnUnLoad
            // 
            this.btnUnLoad.Location = new System.Drawing.Point(202, 118);
            this.btnUnLoad.Name = "btnUnLoad";
            this.btnUnLoad.Size = new System.Drawing.Size(98, 23);
            this.btnUnLoad.TabIndex = 20;
            this.btnUnLoad.Text = "Quitar";
            this.btnUnLoad.UseVisualStyleBackColor = true;
            // 
            // boxPackage
            // 
            this.boxPackage.FormattingEnabled = true;
            this.boxPackage.Location = new System.Drawing.Point(63, 212);
            this.boxPackage.Name = "boxPackage";
            this.boxPackage.Size = new System.Drawing.Size(119, 21);
            this.boxPackage.TabIndex = 21;
            // 
            // openImgDialog
            // 
            this.openImgDialog.DefaultExt = "jpg";
            this.openImgDialog.Filter = "Imagen JPG | *.jpg";
            this.openImgDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openImgDialog_FileOk);
            // 
            // AddForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(454, 341);
            this.Controls.Add(this.boxPackage);
            this.Controls.Add(this.btnUnLoad);
            this.Controls.Add(this.txtAltCod);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblAltCodes);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Componente";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblAltCodes;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtAltCod;
        private System.Windows.Forms.Button btnUnLoad;
        private System.Windows.Forms.ComboBox boxPackage;
        private System.Windows.Forms.OpenFileDialog openImgDialog;
    }
}