﻿namespace U6P2
{
    partial class Modifica
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
            this.ModificaI = new System.Windows.Forms.Button();
            this.regresaI = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dias = new System.Windows.Forms.TextBox();
            this.Id_obraA = new System.Windows.Forms.TextBox();
            this.Id_trabA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tipo = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Id_obra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Oficio = new System.Windows.Forms.ComboBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Id_trab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msg3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModificaI
            // 
            this.ModificaI.Location = new System.Drawing.Point(287, 278);
            this.ModificaI.Name = "ModificaI";
            this.ModificaI.Size = new System.Drawing.Size(75, 23);
            this.ModificaI.TabIndex = 5;
            this.ModificaI.Text = "Modificar";
            this.ModificaI.UseVisualStyleBackColor = true;
            this.ModificaI.Click += new System.EventHandler(this.ModificaI_Click);
            // 
            // regresaI
            // 
            this.regresaI.Location = new System.Drawing.Point(129, 278);
            this.regresaI.Name = "regresaI";
            this.regresaI.Size = new System.Drawing.Size(75, 23);
            this.regresaI.TabIndex = 4;
            this.regresaI.Text = "Regresa";
            this.regresaI.UseVisualStyleBackColor = true;
            this.regresaI.Click += new System.EventHandler(this.regresaI_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 262);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dias);
            this.tabPage1.Controls.Add(this.Id_obraA);
            this.tabPage1.Controls.Add(this.Id_trabA);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dias
            // 
            this.Dias.Location = new System.Drawing.Point(62, 68);
            this.Dias.Name = "Dias";
            this.Dias.Size = new System.Drawing.Size(100, 20);
            this.Dias.TabIndex = 5;
            this.Dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dias_KeyPress);
            // 
            // Id_obraA
            // 
            this.Id_obraA.Enabled = false;
            this.Id_obraA.Location = new System.Drawing.Point(62, 37);
            this.Id_obraA.Name = "Id_obraA";
            this.Id_obraA.ReadOnly = true;
            this.Id_obraA.Size = new System.Drawing.Size(100, 20);
            this.Id_obraA.TabIndex = 4;
            // 
            // Id_trabA
            // 
            this.Id_trabA.Enabled = false;
            this.Id_trabA.Location = new System.Drawing.Point(63, 11);
            this.Id_trabA.Name = "Id_trabA";
            this.Id_trabA.ReadOnly = true;
            this.Id_trabA.Size = new System.Drawing.Size(100, 20);
            this.Id_trabA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_obra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Trab:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Tipo);
            this.tabPage2.Controls.Add(this.Direccion);
            this.tabPage2.Controls.Add(this.Id_obra);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Tipo
            // 
            this.Tipo.Location = new System.Drawing.Point(67, 71);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(100, 20);
            this.Tipo.TabIndex = 11;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(67, 36);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 20);
            this.Direccion.TabIndex = 10;
            // 
            // Id_obra
            // 
            this.Id_obra.Enabled = false;
            this.Id_obra.Location = new System.Drawing.Point(59, 10);
            this.Id_obra.Name = "Id_obra";
            this.Id_obra.ReadOnly = true;
            this.Id_obra.Size = new System.Drawing.Size(100, 20);
            this.Id_obra.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Id_Obra:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.msg3);
            this.tabPage3.Controls.Add(this.Fecha);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.Oficio);
            this.tabPage3.Controls.Add(this.Sueldo);
            this.tabPage3.Controls.Add(this.Nombre);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.Id_trab);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(512, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trabajador";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(93, 97);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(207, 20);
            this.Fecha.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Oficio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fecha_Ingreso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Sueldo_hr:";
            // 
            // Oficio
            // 
            this.Oficio.FormattingEnabled = true;
            this.Oficio.Items.AddRange(new object[] {
            "CARPINTERO",
            "FONTANERO",
            "HERRERO",
            "ELECTRICO"});
            this.Oficio.Location = new System.Drawing.Point(92, 123);
            this.Oficio.Name = "Oficio";
            this.Oficio.Size = new System.Drawing.Size(121, 21);
            this.Oficio.TabIndex = 6;
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(92, 69);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(121, 20);
            this.Sueldo.TabIndex = 4;
            this.Sueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sueldo_KeyPress);
            this.Sueldo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Sueldo_KeyUp);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(91, 42);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(122, 20);
            this.Nombre.TabIndex = 3;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre:";
            // 
            // Id_trab
            // 
            this.Id_trab.Enabled = false;
            this.Id_trab.Location = new System.Drawing.Point(92, 15);
            this.Id_trab.Name = "Id_trab";
            this.Id_trab.ReadOnly = true;
            this.Id_trab.Size = new System.Drawing.Size(121, 20);
            this.Id_trab.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id_trab:";
            // 
            // msg3
            // 
            this.msg3.AutoSize = true;
            this.msg3.Location = new System.Drawing.Point(313, 72);
            this.msg3.Name = "msg3";
            this.msg3.Size = new System.Drawing.Size(0, 13);
            this.msg3.TabIndex = 12;
            // 
            // Modifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 310);
            this.Controls.Add(this.ModificaI);
            this.Controls.Add(this.regresaI);
            this.Controls.Add(this.tabControl1);
            this.Name = "Modifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModificaI;
        private System.Windows.Forms.Button regresaI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Dias;
        private System.Windows.Forms.TextBox Id_obraA;
        private System.Windows.Forms.TextBox Id_trabA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Tipo;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Id_obra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Oficio;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Id_trab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label msg3;
    }
}