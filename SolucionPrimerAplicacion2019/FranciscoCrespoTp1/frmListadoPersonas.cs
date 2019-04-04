using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
namespace FranciscoCrespoTp1
{
    public partial class frmListadoPersonas : Form
    {

        private List<Persona> listadoPersonas = new List<Persona>();
        private BindingList<Persona> listaBindeable;
        int edad;
        public frmListadoPersonas()
        {
            
            InitializeComponent();
            txtBoxApellido.MaxLength = 20;
            txtBoxNombre.MaxLength = 20;
        }

        private void frmListadoPersonas_Load(object sender, EventArgs e)
        {

            listaBindeable = new BindingList<Persona>(listadoPersonas);
            dgvPersona.DataSource = listaBindeable;

            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
       

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           // lbEdad.Text = "EDAD: " + (DateTime.Today.AddTicks(-dateTimePicker1.Value.Ticks).Year - 1).ToString();
            int edad = CalculateAgeCorrect(dateTimePicker1.Value,DateTime.Now);
            lbEdad.Text = " EDAD: "+edad;


         
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona nueva = new Persona();

            if (validarPersona(nueva)) {


                listadoPersonas.Add(nueva);
                refresh();

            }

         


        }

        bool validarPersona(Persona nueva) {

            if (txtBoxApellido.Text.Trim() == "" || txtBoxNombre.Text.Trim() == "" || cmbColor.SelectedIndex < 0)
            {
                MessageBox.Show("Debes completar todos los campos");
                return false;
            }
            nueva.apellido = txtBoxApellido.Text;
            nueva.name = txtBoxNombre.Text;
            nueva.color = cmbColor.Text;

            if (edad < 12)
            {
                nueva.nacio = dateTimePicker1.Value;
            }
            else
            {
                MessageBox.Show("Fecha incorrecta, debe ser mayor que 12");
                return false;
            }

            if (rBtnMasc.Checked)
            {
                nueva.sexo = "M";
            }
            if (rBtnFem.Checked)
            {
                nueva.sexo = "F";
            }
            if (rBtnOtro.Checked)
            {
                nueva.sexo = "O";
            }

            nueva.musicaCumbia = (chkCumbia.Checked) ? true : false;
            nueva.musicaClasica = (chkClasica.Checked) ? true : false;
            nueva.musicaJazz = (chkJazz.Checked) ? true : false;
            nueva.musicaMetal = (chkMetal.Checked) ? true : false;
            nueva.musicaOchentas = (chkOchentas.Checked) ? true : false;
            nueva.musicaRock = (chkRock.Checked) ? true : false;
            return true;
        }


        public int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }




        private void refresh() {

            listaBindeable.ResetBindings();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBoxApellido.Text = "";
            txtBoxNombre.Text = "";

            dateTimePicker1.Value = DateTime.Now;

            rBtnMasc.Checked = true;

            chkClasica.Checked = false;
            chkJazz.Checked = false;
            chkCumbia.Checked = false;
            chkMetal.Checked = false;
            chkOchentas.Checked = false;
            chkRock.Checked = false;

            cmbColor.SelectedIndex = -1;
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Persona p = new Persona();




            try
            {
                int index = dgvPersona.CurrentCell.RowIndex;
                if (validarPersona(p))
                {                   
                    listadoPersonas[index] = p;
                }
            }
            catch (NullReferenceException eu)
            {

            }
            


            refresh();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {

                int index = dgvPersona.CurrentCell.RowIndex;
               
                listadoPersonas.RemoveAt(index);

                
            }
            catch (NullReferenceException eu)
            {

            }
            refresh();
        }

        private void dgvPersona_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                
                
                    cargarPersona(dgvPersona.CurrentCell.RowIndex);
                
                
            }
            catch (NullReferenceException nrf) {

                    
            }
                
        }
        
        private void cargarPersona(int index)
        {
            try
            {
                txtBoxApellido.Text = listadoPersonas[index].apellido;
                txtBoxNombre.Text = listadoPersonas[index].name;
                dateTimePicker1.Value = listadoPersonas[index].nacio;

                switch (listadoPersonas[index].sexo)
                {
                    case "M":
                        rBtnMasc.Checked = true;
                        break;
                    case "F":
                        rBtnFem.Checked = true;
                        break;
                    case "O":
                        rBtnOtro.Checked = true;
                        break;
                }

                chkRock.Checked = listadoPersonas[index].musicaRock ? true : false;
                chkOchentas.Checked = listadoPersonas[index].musicaOchentas ? true : false;
                chkMetal.Checked = listadoPersonas[index].musicaMetal ? true : false;
                chkJazz.Checked = listadoPersonas[index].musicaJazz ? true : false;
                chkCumbia.Checked = listadoPersonas[index].musicaCumbia ? true : false;
                chkClasica.Checked = listadoPersonas[index].musicaClasica ? true : false;

                switch (listadoPersonas[index].color)
                {
                    case "Rojo":
                        cmbColor.SelectedIndex = 0;
                        break;
                    case "Azul":
                        cmbColor.SelectedIndex = 1;
                        break;
                    case "Naranja":
                        cmbColor.SelectedIndex = 2;
                        break;
                    case "Verde":
                        cmbColor.SelectedIndex = 3;
                        break;
                    case "Marron":
                        cmbColor.SelectedIndex = 4;
                        break;
                    case "Negro":
                        cmbColor.SelectedIndex = 5;
                        break;
                    case "Plateado":
                        cmbColor.SelectedIndex = 6;
                        break;
                    case "Amarillo":
                        cmbColor.SelectedIndex = 7;
                        break;
                    case "Violeta":
                        cmbColor.SelectedIndex = 8;
                        break;
                }


            }
            catch (ArgumentOutOfRangeException e) {
            }

        


        }
    }
}
