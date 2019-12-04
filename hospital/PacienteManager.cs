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
                                FechaNacimiento = DateTime.Parse("fechaNacimiento"),
                              
                            });
                        }
                    }
                }

            }
            return pacientes;
        }
    }
}

       
    
