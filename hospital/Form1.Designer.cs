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
            this.lstPaciente.HideSelection = false;
            this.lstPaciente.Location = new System.Drawing.Point(31, 50);
            this.lstPaciente.Name = "lstPaciente";
            this.lstPaciente.Size = new System.Drawing.Size(710, 227);
            this.lstPaciente.TabIndex = 0;
            this.lstPaciente.UseCompatibleStateImageBehavior = false;
            this.lstPaciente.View = System.Windows.Forms.View.Details;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.btnActualizarPaciente);
            this.Controls.Add(this.btnlistarPaciente);
            this.Controls.Add(this.lstPaciente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

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
    }
}

