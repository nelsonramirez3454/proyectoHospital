using System;
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
	public partial class ingresocs : Form


	{

		PacienteManager _PacienteManager;

		public ingresocs()
		{
			InitializeComponent();
			Init();
		}

		private void Init() {
			_PacienteManager = new PacienteManager();
		}
		
		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Registrar_Click(object sender, EventArgs e)
		{

			string SeguridadSocial = textBoxNumeroSeguridad.Text;
			string Documento = textBoxDocumento.Text;
			string nombre = textBoxNombre.Text;
			string apellido = textBoxApellido.Text;
			string fecha = textBoxFecha.Text;

			Paciente paciente = new Paciente() {
				ID = 1,
				NumSeguridadSocial = SeguridadSocial,
				CI = Documento,
				Nombre = nombre,
				Apellido = apellido,
				FechaNacimiento = fecha
			};

			//
			_PacienteManager.Write(paciente);

			Form1 formu = new Form1();
			formu.Show();
			Hide();
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{

		}

		private void textBoxNumeroSeguridad_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
