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
            System.Windows.Forms.Button mostrar;
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.ingresa = new System.Windows.Forms.Button();
            this.RUT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrar
            // 
            mostrar.Location = new System.Drawing.Point(24, 251);
            mostrar.Name = "mostrar";
            mostrar.Size = new System.Drawing.Size(75, 23);
            mostrar.TabIndex = 3;
            mostrar.Text = "Mostrar Lista";
            mostrar.UseVisualStyleBackColor = true;
            mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(101, 13);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(196, 20);
            this.nombre.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 291);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 321);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(105, 251);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(186, 251);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 5;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(267, 251);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // ingresa
            // 
            this.ingresa.Location = new System.Drawing.Point(259, 197);
            this.ingresa.Name = "ingresa";
            this.ingresa.Size = new System.Drawing.Size(75, 23);
            this.ingresa.TabIndex = 7;
            this.ingresa.Text = "Ingresar";
            this.ingresa.UseVisualStyleBackColor = true;
            this.ingresa.Click += new System.EventHandler(this.ingresa_Click);
            // 
            // RUT
            // 
            this.RUT.AutoSize = true;
            this.RUT.Location = new System.Drawing.Point(21, 48);
            this.RUT.Name = "RUT";
            this.RUT.Size = new System.Drawing.Size(30, 13);
            this.RUT.TabIndex = 8;
            this.RUT.Text = "RUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seccion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 48);
            this.textBox1.MaxLength = 12;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 79);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(366, 624);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RUT);
            this.Controls.Add(this.ingresa);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(mostrar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lista de Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button ingresa;
        private System.Windows.Forms.Label RUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

