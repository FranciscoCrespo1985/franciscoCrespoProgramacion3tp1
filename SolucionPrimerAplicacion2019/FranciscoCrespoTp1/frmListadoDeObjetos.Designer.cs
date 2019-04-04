
namespace FranciscoCrespoTp1
{
    partial class frmListadoDeObjetos
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.lstV1 = new System.Windows.Forms.ListView();
            this.ch_objeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstV2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnVaciarDerecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtObjeto
            // 
            this.txtObjeto.Location = new System.Drawing.Point(12, 12);
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(100, 20);
            this.txtObjeto.TabIndex = 1;
            // 
            // lstV1
            // 
            this.lstV1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstV1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_objeto});
            this.lstV1.GridLines = true;
            this.lstV1.Location = new System.Drawing.Point(12, 192);
            this.lstV1.MultiSelect = false;
            this.lstV1.Name = "lstV1";
            this.lstV1.Size = new System.Drawing.Size(214, 158);
            this.lstV1.TabIndex = 2;
            this.lstV1.UseCompatibleStateImageBehavior = false;
            this.lstV1.View = System.Windows.Forms.View.Details;
            // 
            // ch_objeto
            // 
            this.ch_objeto.Text = "Objeto";
            // 
            // lstV2
            // 
            this.lstV2.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstV2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstV2.GridLines = true;
            this.lstV2.Location = new System.Drawing.Point(266, 192);
            this.lstV2.MultiSelect = false;
            this.lstV2.Name = "lstV2";
            this.lstV2.Size = new System.Drawing.Size(214, 158);
            this.lstV2.TabIndex = 2;
            this.lstV2.UseCompatibleStateImageBehavior = false;
            this.lstV2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Objeto";
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(209, 97);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(209, 126);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Location = new System.Drawing.Point(209, 68);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(75, 23);
            this.btnAllRight.TabIndex = 4;
            this.btnAllRight.Text = ">>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnVaciarDerecha
            // 
            this.btnVaciarDerecha.Location = new System.Drawing.Point(209, 155);
            this.btnVaciarDerecha.Name = "btnVaciarDerecha";
            this.btnVaciarDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarDerecha.TabIndex = 5;
            this.btnVaciarDerecha.Text = "...";
            this.btnVaciarDerecha.UseVisualStyleBackColor = true;
            this.btnVaciarDerecha.Click += new System.EventHandler(this.btnVaciarDerecha_Click);
            // 
            // frmListadoDeObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 362);
            this.Controls.Add(this.btnVaciarDerecha);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lstV2);
            this.Controls.Add(this.lstV1);
            this.Controls.Add(this.txtObjeto);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmListadoDeObjetos";
            this.Text = "frmListadoDeObjetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtObjeto;
        private System.Windows.Forms.ListView lstV1;
        private System.Windows.Forms.ColumnHeader ch_objeto;
        private System.Windows.Forms.ListView lstV2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnVaciarDerecha;
    }
}