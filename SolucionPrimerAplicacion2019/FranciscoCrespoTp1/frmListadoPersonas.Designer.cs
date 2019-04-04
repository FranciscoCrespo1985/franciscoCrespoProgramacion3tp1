namespace FranciscoCrespoTp1
{
    partial class frmListadoPersonas
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
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.grpBoxSexo = new System.Windows.Forms.GroupBox();
            this.rBtnOtro = new System.Windows.Forms.RadioButton();
            this.rBtnFem = new System.Windows.Forms.RadioButton();
            this.rBtnMasc = new System.Windows.Forms.RadioButton();
            this.grpMusica = new System.Windows.Forms.GroupBox();
            this.chkOchentas = new System.Windows.Forms.CheckBox();
            this.chkJazz = new System.Windows.Forms.CheckBox();
            this.chkClasica = new System.Windows.Forms.CheckBox();
            this.chkRock = new System.Windows.Forms.CheckBox();
            this.chkMetal = new System.Windows.Forms.CheckBox();
            this.chkCumbia = new System.Windows.Forms.CheckBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpBoxSexo.SuspendLayout();
            this.grpMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(89, 28);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 0;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(89, 54);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 1;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Naranja",
            "Verde",
            "Marron",
            "Negro",
            "Plateado",
            "Amarillo",
            "Violeta"});
            this.cmbColor.Location = new System.Drawing.Point(152, 379);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "F DE NAC:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(217, 93);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(40, 13);
            this.lbEdad.TabIndex = 7;
            this.lbEdad.Text = "EDAD:";
            // 
            // grpBoxSexo
            // 
            this.grpBoxSexo.Controls.Add(this.rBtnOtro);
            this.grpBoxSexo.Controls.Add(this.rBtnFem);
            this.grpBoxSexo.Controls.Add(this.rBtnMasc);
            this.grpBoxSexo.Location = new System.Drawing.Point(15, 152);
            this.grpBoxSexo.Name = "grpBoxSexo";
            this.grpBoxSexo.Size = new System.Drawing.Size(351, 100);
            this.grpBoxSexo.TabIndex = 8;
            this.grpBoxSexo.TabStop = false;
            this.grpBoxSexo.Text = "SEXO";
            // 
            // rBtnOtro
            // 
            this.rBtnOtro.AutoSize = true;
            this.rBtnOtro.Location = new System.Drawing.Point(238, 41);
            this.rBtnOtro.Name = "rBtnOtro";
            this.rBtnOtro.Size = new System.Drawing.Size(45, 17);
            this.rBtnOtro.TabIndex = 2;
            this.rBtnOtro.Text = "Otro";
            this.rBtnOtro.UseVisualStyleBackColor = true;
            // 
            // rBtnFem
            // 
            this.rBtnFem.AutoSize = true;
            this.rBtnFem.Location = new System.Drawing.Point(137, 41);
            this.rBtnFem.Name = "rBtnFem";
            this.rBtnFem.Size = new System.Drawing.Size(71, 17);
            this.rBtnFem.TabIndex = 1;
            this.rBtnFem.Text = "Femenino";
            this.rBtnFem.UseVisualStyleBackColor = true;
            // 
            // rBtnMasc
            // 
            this.rBtnMasc.AutoSize = true;
            this.rBtnMasc.Checked = true;
            this.rBtnMasc.Location = new System.Drawing.Point(26, 41);
            this.rBtnMasc.Name = "rBtnMasc";
            this.rBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rBtnMasc.TabIndex = 0;
            this.rBtnMasc.TabStop = true;
            this.rBtnMasc.Text = "Masculino";
            this.rBtnMasc.UseVisualStyleBackColor = true;
            // 
            // grpMusica
            // 
            this.grpMusica.Controls.Add(this.chkOchentas);
            this.grpMusica.Controls.Add(this.chkJazz);
            this.grpMusica.Controls.Add(this.chkClasica);
            this.grpMusica.Controls.Add(this.chkRock);
            this.grpMusica.Controls.Add(this.chkMetal);
            this.grpMusica.Controls.Add(this.chkCumbia);
            this.grpMusica.Location = new System.Drawing.Point(15, 258);
            this.grpMusica.Name = "grpMusica";
            this.grpMusica.Size = new System.Drawing.Size(351, 100);
            this.grpMusica.TabIndex = 9;
            this.grpMusica.TabStop = false;
            this.grpMusica.Text = "Musica";
            // 
            // chkOchentas
            // 
            this.chkOchentas.AutoSize = true;
            this.chkOchentas.Location = new System.Drawing.Point(228, 64);
            this.chkOchentas.Name = "chkOchentas";
            this.chkOchentas.Size = new System.Drawing.Size(85, 17);
            this.chkOchentas.TabIndex = 12;
            this.chkOchentas.Text = "OCHENTAS";
            this.chkOchentas.UseVisualStyleBackColor = true;
            // 
            // chkJazz
            // 
            this.chkJazz.AutoSize = true;
            this.chkJazz.Location = new System.Drawing.Point(228, 19);
            this.chkJazz.Name = "chkJazz";
            this.chkJazz.Size = new System.Drawing.Size(52, 17);
            this.chkJazz.TabIndex = 10;
            this.chkJazz.Text = "JAZZ";
            this.chkJazz.UseVisualStyleBackColor = true;
            // 
            // chkClasica
            // 
            this.chkClasica.AutoSize = true;
            this.chkClasica.Location = new System.Drawing.Point(128, 64);
            this.chkClasica.Name = "chkClasica";
            this.chkClasica.Size = new System.Drawing.Size(70, 17);
            this.chkClasica.TabIndex = 11;
            this.chkClasica.Text = "CLASICA";
            this.chkClasica.UseVisualStyleBackColor = true;
            // 
            // chkRock
            // 
            this.chkRock.AutoSize = true;
            this.chkRock.Location = new System.Drawing.Point(128, 19);
            this.chkRock.Name = "chkRock";
            this.chkRock.Size = new System.Drawing.Size(56, 17);
            this.chkRock.TabIndex = 10;
            this.chkRock.Text = "ROCK";
            this.chkRock.UseVisualStyleBackColor = true;
            // 
            // chkMetal
            // 
            this.chkMetal.AutoSize = true;
            this.chkMetal.Location = new System.Drawing.Point(19, 64);
            this.chkMetal.Name = "chkMetal";
            this.chkMetal.Size = new System.Drawing.Size(62, 17);
            this.chkMetal.TabIndex = 10;
            this.chkMetal.Text = "METAL";
            this.chkMetal.UseVisualStyleBackColor = true;
            // 
            // chkCumbia
            // 
            this.chkCumbia.AutoSize = true;
            this.chkCumbia.Location = new System.Drawing.Point(19, 19);
            this.chkCumbia.Name = "chkCumbia";
            this.chkCumbia.Size = new System.Drawing.Size(67, 17);
            this.chkCumbia.TabIndex = 10;
            this.chkCumbia.Text = "CUMBIA";
            this.chkCumbia.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(38, 382);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(104, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "COLOR FAVORITO:";
            // 
            // dgvPersona
            // 
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Location = new System.Drawing.Point(372, 12);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersona.Size = new System.Drawing.Size(474, 383);
            this.dgvPersona.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(114, 439);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(220, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(507, 439);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(632, 439);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmListadoPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 498);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvPersona);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.grpMusica);
            this.Controls.Add(this.grpBoxSexo);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "frmListadoPersonas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.frmListadoPersonas_Load);
            this.grpBoxSexo.ResumeLayout(false);
            this.grpBoxSexo.PerformLayout();
            this.grpMusica.ResumeLayout(false);
            this.grpMusica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.GroupBox grpBoxSexo;
        private System.Windows.Forms.RadioButton rBtnOtro;
        private System.Windows.Forms.RadioButton rBtnFem;
        private System.Windows.Forms.RadioButton rBtnMasc;
        private System.Windows.Forms.GroupBox grpMusica;
        private System.Windows.Forms.CheckBox chkOchentas;
        private System.Windows.Forms.CheckBox chkJazz;
        private System.Windows.Forms.CheckBox chkClasica;
        private System.Windows.Forms.CheckBox chkRock;
        private System.Windows.Forms.CheckBox chkMetal;
        private System.Windows.Forms.CheckBox chkCumbia;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}