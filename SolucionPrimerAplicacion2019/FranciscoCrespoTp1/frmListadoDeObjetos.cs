using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace FranciscoCrespoTp1
{
    public partial class frmListadoDeObjetos : Form
    {
      
        public frmListadoDeObjetos()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtObjeto.Text.Trim().Length > 0)
            {
                lstV1.Items.Add(txtObjeto.Text.Trim());

            }
        }

       

        private void btnAllRight_Click(object sender, EventArgs e)
        {

            bool copiar =true;
            if (lstV2.Items.Count > 0)
            {
                foreach (ListViewItem i in lstV1.Items)
                {
                    foreach (ListViewItem j in lstV2.Items)
                    {
                        if (i.Text == j.Text) copiar = false;
                    }
                    if (copiar)
                    {
                        lstV2.Items.Add((ListViewItem)i.Clone());
                        i.Remove();
                    }
                    copiar = true;
                }
            }
            else
            {
                if (lstV2.Items.Count <= 0)
                    foreach (ListViewItem i in lstV1.Items) {
                        if (buscarItem(i, lstV2)==false)
                        {
                            lstV2.Items.Add((ListViewItem)i.Clone());
                            i.Remove();
                        }
                    }
            }
        }
        
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lstV1.SelectedItems.Count > 0)
            {
                if (buscarItem(lstV1.SelectedItems[0], lstV2) == false)
                {
                    lstV2.Items.Add((ListViewItem)lstV1.SelectedItems[0].Clone());

                    foreach (ListViewItem i in lstV1.Items)
                    {
                        if (i.Selected)
                        {
                            i.Remove();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ITEM EXISTENTE");
                }
            }
        }



        private void btnLeft_Click(object sender, EventArgs e)
        {
            // ME FIJO SI LA LISTVIEW ESTA VACIA
            if (lstV2.SelectedItems.Count > 0)
            {
                // ME FIJO QUE EL ITEM NO SE REPITA EN LA OTRA LISTVIEW
                if (buscarItem(lstV2.SelectedItems[0], lstV1) == false)
                {
                    //AGREGO LO ITEMS SELECIONADOS EN ESTE CASO SIEMPRE VA A SER 1
                    lstV1.Items.Add((ListViewItem)lstV2.SelectedItems[0].Clone());

                    foreach (ListViewItem i in lstV2.Items)
                    {
                        if (i.Selected)
                        {
                            i.Remove();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ITEM EXISTENTE");
                }
            }
        }

        private void btnVaciarDerecha_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lstV2.Items) {
                i.Remove();


            }
        }

        private bool buscarItem(ListViewItem i, ListView l)
        {

            foreach (ListViewItem j in l.Items)
            {
                if (i.Text == j.Text)
                    return true;
            }
            return false;
        }
    }
    
}
