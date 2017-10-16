using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tvwDirectorios.Nodes.Add("C:\\");
            RefrescarArbol("C:\\", tvwDirectorios.Nodes[0]);
        }
        public void RefrescarArbol(string strDir, TreeNode tnRaiz)
        {
            string[] strDirArreglos = Directory.GetDirectories(strDir);
            if (strDirArreglos.Length != 0)
            {
                foreach (string dir in strDirArreglos)
                {
                    TreeNode tnNodo = new TreeNode(dir);
                    tnRaiz.Nodes.Add(tnNodo);

                }
            }
        }

        private void tvwDirectorios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefrescarArbol(e.Node.Text, e.Node);
            RefrescarListView(e.Node.Text);
        }

        public void RefrescarListView(string strDir)
        {
                  
                 lsvArchivos.Items.Clear();
                 FileInfo[] archivos = new DirectoryInfo(strDir).GetFiles();
            
                 foreach (FileInfo archivo in archivos)
               {
              
                  ListViewItem nuevoArchivo =lsvArchivos.Items.Add(archivo.Name);
                  nuevoArchivo.ImageIndex = 0;

               }
           }
    }
}
        