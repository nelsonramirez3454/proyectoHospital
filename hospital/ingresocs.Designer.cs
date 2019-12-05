namespace hospital
{
	partial class ingresocs
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
			this.Registrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxI = new System.Windows.Forms.TextBox();
			this.textBoxNumeroSeguridad = new System.Windows.Forms.TextBox();
			this.textBoxDocumento = new System.Windows.Forms.TextBox();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxApellido = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxFecha = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Registrar
			// 
			this.Registrar.Location = new System.Drawing.Point(605, 374);
			this.Registrar.Name = "Registrar";
			this.Registrar.Size = new System.Drawing.Size(92, 45);
			this.Registrar.TabIndex = 0;
			this.Registrar.Text = "Registrar";
			this.Registrar.UseVisualStyleBackColor = true;
			this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(316, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hospital General S.E.S";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(328, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Registrar Paciente";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBoxI
			// 
			this.textBoxI.Enabled = false;
			this.textBoxI.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBoxI.Location = new System.Drawing.Point(385, 140);
			this.textBoxI.Name = "textBoxI";
			this.textBoxI.Size = new System.Drawing.Size(206, 20);
			this.textBoxI.TabIndex = 3;
			this.textBoxI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBoxNumeroSeguridad
			// 
			this.textBoxNumeroSeguridad.Location = new System.Drawing.Point(385, 178);
			this.textBoxNumeroSeguridad.Name = "textBoxNumeroSeguridad";
			this.textBoxNumeroSeguridad.Size = new System.Drawing.Size(206, 20);
			this.textBoxNumeroSeguridad.TabIndex = 4;
			this.textBoxNumeroSeguridad.TextChanged += new System.EventHandler(this.textBoxNumeroSeguridad_TextChanged);
			// 
			// textBoxDocumento
			// 
			this.textBoxDocumento.Location = new System.Drawing.Point(385, 215);
			this.textBoxDocumento.Name = "textBoxDocumento";
			this.textBoxDocumento.Size = new System.Drawing.Size(206, 20);
			this.textBoxDocumento.TabIndex = 5;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(385, 250);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(206, 20);
			this.textBoxNombre.TabIndex = 6;
			// 
			// textBoxApellido
			// 
			this.textBoxApellido.Location = new System.Drawing.Point(385, 287);
			this.textBoxApellido.Name = "textBoxApellido";
			this.textBoxApellido.Size = new System.Drawing.Size(206, 20);
			this.textBoxApellido.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(255, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "ID Paciente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(254, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Numero Seguridad Social";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(255, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Documento";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(255, 257);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Nombre ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(257, 291);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Apellido";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(257, 329);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Fecha Nacimiento";
			// 
			// textBoxFecha
			// 
			this.textBoxFecha.Location = new System.Drawing.Point(385, 325);
			this.textBoxFecha.Name = "textBoxFecha";
			this.textBoxFecha.Size = new System.Drawing.Size(206, 20);
			this.textBoxFecha.TabIndex = 13;
			// 
			// ingresocs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxFecha);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxApellido);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.textBoxDocumento);
			this.Controls.Add(this.textBoxNumeroSeguridad);
			this.Controls.Add(this.textBoxI);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Registrar);
			this.Name = "ingresocs";
			this.Text = "ingresocs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Registrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxI;
		private System.Windows.Forms.TextBox textBoxNumeroSeguridad;
		private System.Windows.Forms.TextBox textBoxDocumento;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxApellido;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxFecha;
	}
}