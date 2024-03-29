﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class Form1 : Form
    {
        public PacienteManager _Manager;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _Manager = new PacienteManager();
        }
        public void LimpiarTexto()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }

        private void btnlistarPaciente_Click(object sender, EventArgs e)
        {
            lstPaciente.Items.Clear();
            List<Paciente> pacientes = _Manager.GetPacientes();
            foreach(Paciente paciente in pacientes)
            {
                ListViewItem item = lstPaciente.Items.Add(paciente.ID.ToString());
                item.SubItems.Add(paciente.NumSeguridadSocial);
                item.SubItems.Add(paciente.CI);
                item.SubItems.Add(paciente.Nombre);
                item.SubItems.Add(paciente.Apellido);
                item.SubItems.Add(paciente.FechaNacimiento);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
			_Manager.Delete(int.Parse(textBoxId.Text));
			btnlistarPaciente_Click(this, new EventArgs());
			LimpiarTexto();
		}

		private void btnActualizarPaciente_Click(object sender, EventArgs e)
		{
			Paciente paciente = new Paciente()
			{
				ID = int.Parse(textBoxId.Text),
				NumSeguridadSocial = textBoxNum.Text,
				CI = textBoxDocumento.Text,
				Nombre = textBoxNombre.Text,
				Apellido = textBoxApellido.Text,
				FechaNacimiento = textBoxFecha.Text,
			};
			_Manager.Update(paciente);
			btnlistarPaciente_Click(this, new EventArgs());
			LimpiarTexto();
		}

		private void lstPaciente_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBoxId_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
