using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    public class PacienteManager
    {
        private IDbConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=hospital;Trusted_Connection=True;");
            conn.Open();
            return conn;
        }

        public List<Paciente> GetPacientes()
        {

            List<Paciente> pacientes = new List<Paciente>();
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT idPaciente, numSeguridadSocial, ci, nombre, apellido, fechaNacimiento FROM Pacientes";
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            pacientes.Add(new Paciente()
                            {
                                ID = Convert.ToInt32(dr["idPaciente"]),
                                NumSeguridadSocial = dr["numSeguridadSocial"].ToString(),
                                CI = dr["ci"].ToString(),
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString(),
                                FechaNacimiento = dr["fechaNacimiento"].ToString(),

                            });
                        }
                    }
                }

            }
            return pacientes;
        }
		public void Write(Paciente paciente)
		{
			using (IDbConnection conn = CreateConnection())
			{
				using (IDbCommand cmd = conn.CreateCommand())
				{

					cmd.CommandText = "INSERT INTO Pacientes (numSeguridadSocial, ci, nombre, apellido, fechaNacimiento) VALUES (@numSeguridadSocial, @ci, @nombre, @apellido, @fechaNacimiento)";

					CreateParameter(cmd, "numSeguridadSocial", paciente.NumSeguridadSocial);
					CreateParameter(cmd, "ci", paciente.CI);
					CreateParameter(cmd, "nombre", paciente.Nombre);
					CreateParameter(cmd, "apellido", paciente.Apellido);
					CreateParameter(cmd, "fechaNacimiento", paciente.FechaNacimiento);

					cmd.ExecuteNonQuery();

			

					/*cmd.CommandText = "INSERT INTO logs(action, createDate) VALUES(@action, @createDate)";
					CreateParameter(cmd, "action", "New student created");
					CreateParameter(cmd, "createDate", DateTime.Now);
					cmd.ExecuteNonQuery();*/
				}

			}
		}


		public void Update(Paciente paciente)
		{
			using (IDbConnection conn = CreateConnection())
			{
				using (IDbCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = "UPDATE Pacientes SET NumSeguridadSocial=@numSeguridadSocial, CI=@ci, Nombre=@nombre, Apellido=@apellido WHERE idPaciente=@idPaciente";

					CreateParameter(cmd, "idPaciente", paciente.ID);
					CreateParameter(cmd, "numSeguridadSocial", paciente.NumSeguridadSocial);
					CreateParameter(cmd, "ci", paciente.CI);
					CreateParameter(cmd, "nombre", paciente.Nombre);
					CreateParameter(cmd, "apellido", paciente.Apellido);
					CreateParameter(cmd, "fechaNacimiento", paciente.FechaNacimiento);

					cmd.ExecuteNonQuery();
				}
			}
		}

		public void Delete(int ID)
		{
			using (IDbConnection conn = CreateConnection())
			{
				using (IDbCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = "DELETE FROM Pacientes WHERE idPaciente=@idPaciente";
					CreateParameter(cmd, "idPaciente", ID);
					cmd.ExecuteNonQuery();
				}
			}
		}
		private void CreateParameter<T>(IDbCommand cmd, string name, T value)
		{
			IDbDataParameter prm = cmd.CreateParameter();
			prm.ParameterName = name;
			prm.Value = value;
			cmd.Parameters.Add(prm);
		}

		
	}
}

       
    
