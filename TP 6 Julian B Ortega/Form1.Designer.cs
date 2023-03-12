namespace TP_6_Julian_B_Ortega
{
    partial class mainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrame));
            this.tabsMain = new System.Windows.Forms.TabControl();
            this.tabIngreso = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbImportado = new System.Windows.Forms.CheckBox();
            this.inputGenero = new System.Windows.Forms.ComboBox();
            this.inputPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImportado = new System.Windows.Forms.Label();
            this.inputPaginas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.inputAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.tabsMain.SuspendLayout();
            this.tabIngreso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsMain
            // 
            this.tabsMain.Controls.Add(this.tabIngreso);
            this.tabsMain.Controls.Add(this.tabLista);
            this.tabsMain.Location = new System.Drawing.Point(4, 4);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.SelectedIndex = 0;
            this.tabsMain.Size = new System.Drawing.Size(297, 280);
            this.tabsMain.TabIndex = 0;
            // 
            // tabIngreso
            // 
            this.tabIngreso.Controls.Add(this.groupBox1);
            this.tabIngreso.Location = new System.Drawing.Point(4, 22);
            this.tabIngreso.Name = "tabIngreso";
            this.tabIngreso.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngreso.Size = new System.Drawing.Size(289, 254);
            this.tabIngreso.TabIndex = 0;
            this.tabIngreso.Text = "Ingreso";
            this.tabIngreso.UseVisualStyleBackColor = true;
            this.tabIngreso.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.chbImportado);
            this.groupBox1.Controls.Add(this.inputGenero);
            this.groupBox1.Controls.Add(this.inputPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblImportado);
            this.groupBox1.Controls.Add(this.inputPaginas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.inputAutor);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Controls.Add(this.inputNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Libro";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(174, 203);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(26, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chbImportado
            // 
            this.chbImportado.AutoSize = true;
            this.chbImportado.Location = new System.Drawing.Point(89, 134);
            this.chbImportado.Name = "chbImportado";
            this.chbImportado.Size = new System.Drawing.Size(35, 17);
            this.chbImportado.TabIndex = 14;
            this.chbImportado.Text = "Si";
            this.chbImportado.UseVisualStyleBackColor = true;
            // 
            // inputGenero
            // 
            this.inputGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputGenero.FormattingEnabled = true;
            this.inputGenero.Location = new System.Drawing.Point(89, 77);
            this.inputGenero.Name = "inputGenero";
            this.inputGenero.Size = new System.Drawing.Size(160, 21);
            this.inputGenero.TabIndex = 13;
            // 
            // inputPrecio
            // 
            this.inputPrecio.Location = new System.Drawing.Point(89, 161);
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.Size = new System.Drawing.Size(69, 22);
            this.inputPrecio.TabIndex = 12;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(23, 164);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblImportado
            // 
            this.lblImportado.AutoSize = true;
            this.lblImportado.Location = new System.Drawing.Point(23, 136);
            this.lblImportado.Name = "lblImportado";
            this.lblImportado.Size = new System.Drawing.Size(61, 13);
            this.lblImportado.TabIndex = 8;
            this.lblImportado.Text = "Importado";
            this.lblImportado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputPaginas
            // 
            this.inputPaginas.Location = new System.Drawing.Point(89, 105);
            this.inputPaginas.Name = "inputPaginas";
            this.inputPaginas.Size = new System.Drawing.Size(69, 22);
            this.inputPaginas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Páginas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(23, 80);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género";
            this.lblGenero.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputAutor
            // 
            this.inputAutor.Location = new System.Drawing.Point(89, 49);
            this.inputAutor.Name = "inputAutor";
            this.inputAutor.Size = new System.Drawing.Size(160, 22);
            this.inputAutor.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(23, 52);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(36, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(89, 21);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(160, 22);
            this.inputNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.lstLibros);
            this.tabLista.Location = new System.Drawing.Point(4, 22);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabLista.Size = new System.Drawing.Size(289, 254);
            this.tabLista.TabIndex = 2;
            this.tabLista.Text = "Lista";
            this.tabLista.UseVisualStyleBackColor = true;
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.Location = new System.Drawing.Point(6, 6);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(277, 238);
            this.lstLibros.TabIndex = 0;
            this.lstLibros.SelectedIndexChanged += new System.EventHandler(this.lstLibros_SelectedIndexChanged);
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 288);
            this.Controls.Add(this.tabsMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(319, 327);
            this.MinimizeBox = false;
            this.Name = "mainFrame";
            this.Text = "Cargar Libros - TP 6";
            this.tabsMain.ResumeLayout(false);
            this.tabIngreso.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsMain;
        private System.Windows.Forms.TabPage tabIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chbImportado;
        private System.Windows.Forms.ComboBox inputGenero;
        private System.Windows.Forms.TextBox inputPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImportado;
        private System.Windows.Forms.TextBox inputPaginas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox inputAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.ListBox lstLibros;
    }
}

