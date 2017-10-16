namespace practica5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvwDirectorios = new System.Windows.Forms.TreeView();
            this.lsvArchivos = new System.Windows.Forms.ListView();
            this.ilIconos = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwDirectorios
            // 
            this.tvwDirectorios.Location = new System.Drawing.Point(12, 12);
            this.tvwDirectorios.Name = "tvwDirectorios";
            this.tvwDirectorios.Size = new System.Drawing.Size(121, 214);
            this.tvwDirectorios.TabIndex = 0;
            this.tvwDirectorios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDirectorios_AfterSelect);
            // 
            // lsvArchivos
            // 
            this.lsvArchivos.Location = new System.Drawing.Point(173, 12);
            this.lsvArchivos.Name = "lsvArchivos";
            this.lsvArchivos.Size = new System.Drawing.Size(121, 214);
            this.lsvArchivos.SmallImageList = this.ilIconos;
            this.lsvArchivos.TabIndex = 1;
            this.lsvArchivos.UseCompatibleStateImageBehavior = false;
            this.lsvArchivos.View = System.Windows.Forms.View.List;
            // 
            // ilIconos
            // 
            this.ilIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIconos.ImageStream")));
            this.ilIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIconos.Images.SetKeyName(0, "Puesta de sol.jpg");
            this.ilIconos.Images.SetKeyName(1, "Invierno.jpg");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.lsvArchivos);
            this.Controls.Add(this.tvwDirectorios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwDirectorios;
        private System.Windows.Forms.ListView lsvArchivos;
        private System.Windows.Forms.ImageList ilIconos;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

