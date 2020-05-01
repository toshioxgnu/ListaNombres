namespace listaNombres
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreAlumn = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.RUT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Asignatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.ingresa = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rutalum = new System.Windows.Forms.TextBox();
            this.edadAlum = new System.Windows.Forms.TextBox();
            this.seccionAlum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.asignaturaAlumn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreAlumn
            // 
            this.nombreAlumn.AcceptsTab = true;
            this.nombreAlumn.Location = new System.Drawing.Point(105, 13);
            this.nombreAlumn.Name = "nombreAlumn";
            this.nombreAlumn.Size = new System.Drawing.Size(196, 20);
            this.nombreAlumn.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Desktop;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RUT,
            this.Nombre,
            this.Edad,
            this.Seccion,
            this.Asignatura});
            this.listView1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 294);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 321);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // RUT
            // 
            this.RUT.Text = "RUT";
            this.RUT.Width = 83;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 83;
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            this.Edad.Width = 83;
            // 
            // Seccion
            // 
            this.Seccion.Text = "Seccion";
            this.Seccion.Width = 83;
            // 
            // Asignatura
            // 
            this.Asignatura.Text = "Asignatura";
            this.Asignatura.Width = 83;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(53, 251);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(177, 251);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 5;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(306, 251);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // ingresa
            // 
            this.ingresa.Location = new System.Drawing.Point(105, 192);
            this.ingresa.Name = "ingresa";
            this.ingresa.Size = new System.Drawing.Size(75, 23);
            this.ingresa.TabIndex = 7;
            this.ingresa.Text = "Ingresar";
            this.ingresa.UseVisualStyleBackColor = true;
            this.ingresa.Click += new System.EventHandler(this.ingresa_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(21, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(30, 13);
            this.label.TabIndex = 8;
            this.label.Text = "RUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seccion";
            // 
            // rutalum
            // 
            this.rutalum.AcceptsTab = true;
            this.rutalum.Location = new System.Drawing.Point(105, 48);
            this.rutalum.MaxLength = 12;
            this.rutalum.Name = "rutalum";
            this.rutalum.Size = new System.Drawing.Size(100, 20);
            this.rutalum.TabIndex = 11;
            // 
            // edadAlum
            // 
            this.edadAlum.Location = new System.Drawing.Point(105, 79);
            this.edadAlum.MaxLength = 3;
            this.edadAlum.Name = "edadAlum";
            this.edadAlum.Size = new System.Drawing.Size(33, 20);
            this.edadAlum.TabIndex = 12;
            // 
            // seccionAlum
            // 
            this.seccionAlum.Location = new System.Drawing.Point(105, 112);
            this.seccionAlum.Name = "seccionAlum";
            this.seccionAlum.Size = new System.Drawing.Size(33, 20);
            this.seccionAlum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Asignatura";
            // 
            // asignaturaAlumn
            // 
            this.asignaturaAlumn.Location = new System.Drawing.Point(105, 148);
            this.asignaturaAlumn.Name = "asignaturaAlumn";
            this.asignaturaAlumn.Size = new System.Drawing.Size(192, 20);
            this.asignaturaAlumn.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(455, 627);
            this.Controls.Add(this.asignaturaAlumn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seccionAlum);
            this.Controls.Add(this.edadAlum);
            this.Controls.Add(this.rutalum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ingresa);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nombreAlumn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lista de Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreAlumn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button ingresa;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edadAlum;
        private System.Windows.Forms.TextBox seccionAlum;
        private System.Windows.Forms.TextBox rutalum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox asignaturaAlumn;
        private System.Windows.Forms.ColumnHeader RUT;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.ColumnHeader Seccion;
        private System.Windows.Forms.ColumnHeader Asignatura;
    }
}

