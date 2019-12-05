namespace hospital
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.lstPaciente = new System.Windows.Forms.ListView();
			this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNumSeguridadSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFechaNaci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnlistarPaciente = new System.Windows.Forms.Button();
			this.btnActualizarPaciente = new System.Windows.Forms.Button();
			this.btnEliminarPaciente = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.textBoxNum = new System.Windows.Forms.TextBox();
			this.textBoxDocumento = new System.Windows.Forms.TextBox();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxApellido = new System.Windows.Forms.TextBox();
			this.textBoxFecha = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstPaciente
			// 
			this.lstPaciente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNumSeguridadSocial,
            this.colCI,
            this.colNombre,
            this.colApellidos,
            this.colFechaNaci});
			this.lstPaciente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lstPaciente.HideSelection = false;
			this.lstPaciente.Location = new System.Drawing.Point(50, 78);
			this.lstPaciente.Name = "lstPaciente";
			this.lstPaciente.Size = new System.Drawing.Size(710, 162);
			this.lstPaciente.TabIndex = 0;
			this.lstPaciente.UseCompatibleStateImageBehavior = false;
			this.lstPaciente.View = System.Windows.Forms.View.Details;
			this.lstPaciente.SelectedIndexChanged += new System.EventHandler(this.lstPaciente_SelectedIndexChanged);
			// 
			// colID
			// 
			this.colID.Text = "ID paciente";
			this.colID.Width = 88;
			// 
			// colNumSeguridadSocial
			// 
			this.colNumSeguridadSocial.Text = "Numero Seguridad Social";
			this.colNumSeguridadSocial.Width = 145;
			// 
			// colCI
			// 
			this.colCI.Text = "Documento";
			this.colCI.Width = 98;
			// 
			// colNombre
			// 
			this.colNombre.Text = "Nombre Paciente";
			this.colNombre.Width = 102;
			// 
			// colApellidos
			// 
			this.colApellidos.Text = "Apellidos P";
			this.colApellidos.Width = 89;
			// 
			// colFechaNaci
			// 
			this.colFechaNaci.Text = "Fecha Nacimiento";
			this.colFechaNaci.Width = 104;
			// 
			// btnlistarPaciente
			// 
			this.btnlistarPaciente.Location = new System.Drawing.Point(457, 395);
			this.btnlistarPaciente.Name = "btnlistarPaciente";
			this.btnlistarPaciente.Size = new System.Drawing.Size(75, 23);
			this.btnlistarPaciente.TabIndex = 1;
			this.btnlistarPaciente.Text = "listar";
			this.btnlistarPaciente.UseVisualStyleBackColor = true;
			this.btnlistarPaciente.Click += new System.EventHandler(this.btnlistarPaciente_Click);
			// 
			// btnActualizarPaciente
			// 
			this.btnActualizarPaciente.Location = new System.Drawing.Point(538, 395);
			this.btnActualizarPaciente.Name = "btnActualizarPaciente";
			this.btnActualizarPaciente.Size = new System.Drawing.Size(75, 23);
			this.btnActualizarPaciente.TabIndex = 2;
			this.btnActualizarPaciente.Text = "Actualizar";
			this.btnActualizarPaciente.UseVisualStyleBackColor = true;
			this.btnActualizarPaciente.Click += new System.EventHandler(this.btnActualizarPaciente_Click);
			// 
			// btnEliminarPaciente
			// 
			this.btnEliminarPaciente.Location = new System.Drawing.Point(619, 395);
			this.btnEliminarPaciente.Name = "btnEliminarPaciente";
			this.btnEliminarPaciente.Size = new System.Drawing.Size(75, 23);
			this.btnEliminarPaciente.TabIndex = 3;
			this.btnEliminarPaciente.Text = "Eliminar";
			this.btnEliminarPaciente.UseVisualStyleBackColor = true;
			this.btnEliminarPaciente.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(305, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Pacientes Ingresados";
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(136, 270);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(182, 20);
			this.textBoxId.TabIndex = 5;
			this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
			// 
			// textBoxNum
			// 
			this.textBoxNum.Location = new System.Drawing.Point(136, 296);
			this.textBoxNum.Name = "textBoxNum";
			this.textBoxNum.Size = new System.Drawing.Size(182, 20);
			this.textBoxNum.TabIndex = 6;
			// 
			// textBoxDocumento
			// 
			this.textBoxDocumento.Location = new System.Drawing.Point(136, 322);
			this.textBoxDocumento.Name = "textBoxDocumento";
			this.textBoxDocumento.Size = new System.Drawing.Size(182, 20);
			this.textBoxDocumento.TabIndex = 7;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(136, 348);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(182, 20);
			this.textBoxNombre.TabIndex = 8;
			// 
			// textBoxApellido
			// 
			this.textBoxApellido.Location = new System.Drawing.Point(136, 379);
			this.textBoxApellido.Name = "textBoxApellido";
			this.textBoxApellido.Size = new System.Drawing.Size(182, 20);
			this.textBoxApellido.TabIndex = 9;
			// 
			// textBoxFecha
			// 
			this.textBoxFecha.Location = new System.Drawing.Point(136, 405);
			this.textBoxFecha.Name = "textBoxFecha";
			this.textBoxFecha.Size = new System.Drawing.Size(182, 20);
			this.textBoxFecha.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 272);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "ID Paciente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 299);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Numero S.S";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 325);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Documento";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(43, 352);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Nombre ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 382);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Apellido";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(42, 409);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Fecha Nacimiento";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxFecha);
			this.Controls.Add(this.textBoxApellido);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.textBoxDocumento);
			this.Controls.Add(this.textBoxNum);
			this.Controls.Add(this.textBoxId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEliminarPaciente);
			this.Controls.Add(this.btnActualizarPaciente);
			this.Controls.Add(this.btnlistarPaciente);
			this.Controls.Add(this.lstPaciente);
			this.Name = "Form1";
			this.Text = "Pacientes Ingresados";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPaciente;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNumSeguridadSocial;
        private System.Windows.Forms.ColumnHeader colCI;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellidos;
        private System.Windows.Forms.ColumnHeader colFechaNaci;
        private System.Windows.Forms.Button btnlistarPaciente;
        private System.Windows.Forms.Button btnActualizarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.TextBox textBoxNum;
		private System.Windows.Forms.TextBox textBoxDocumento;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxApellido;
		private System.Windows.Forms.TextBox textBoxFecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

