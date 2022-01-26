using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backing
{
    class WO : Conexion
    {
        //public int Wo { get; set; }

        private SqlConnection Conex; // Obj Conexion

        public WO() =>
        Conex = new SqlConnection(@"Data Source=192.168.4.5\SQLEXPRESS;Initial Catalog=master;User ID=sa;Password=Mexmei15!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private SqlConnection Con { get => Conex; set => Conex = value; }


        /// <summary>
        /// Metodo para abrir la conexion con la base de datos
        /// </summary>
        public new void Abrir() // Metodo para Abrir la Conexion
        {
            Conex.Open();
        }

        /// <summary>
        /// Metodo para cerrar la conexion con la base de datos
        /// </summary>
        public new void Cerrar() // Metodo para Cerrar la Conexion
        {
            Conex.Close();
        }

        public string GetROI(string comando)
        {
            string valor;
            try
            {
                using (SqlCommand CMD = new SqlCommand(comando, Conex))
                {
                    this.Abrir();
                    //CMD.ExecuteNonQuery();
                    valor = CMD.ExecuteScalar().ToString();
                }
                if (valor == "")
                    valor = "0";
            }
            catch (Exception)
            {
                valor = "0";
            }
            this.Cerrar();
            return valor;
        }

        /// <summary>
        /// Metodo Para saber si ya existe un registro
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public bool ExisteROI(string comando)
        {
            this.Cerrar();
            using (SqlCommand cmd = new SqlCommand(comando, Conex))
            {
                this.Abrir();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                Cerrar();
                if (count == 0)
                    return false;
                else
                    return true;

                //Cerrar();
            }
        }
    }
}
