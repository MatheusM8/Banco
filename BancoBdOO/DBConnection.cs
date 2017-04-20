using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BancoBdOO
{
    public class DBConnection
    {
        string str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection connection { get; set; }
        SqlTransaction sqlTran;

        public DBConnection()
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        public Conta Buscar(string Num)
        {
            var sql = "select * from Conta where Numero=@Numero;";

            connection.Close();

            connection.Open();

            var comando = new SqlCommand(sql, connection);
            comando.Parameters.AddWithValue("@Numero", Num);

            SqlDataReader rdr = comando.ExecuteReader();
            Conta c = null;
            while (rdr.Read())
            {
                String Tipo = rdr["Tipo"].ToString();
                if (Tipo == "P")
                {
                    c = new ContaPoupanca();
                }
                else
                {
                    c = new ContaCorrente();
                }

                c.Id = Convert.ToInt32(rdr["Id"]);
                c.Numero = rdr["Numero"].ToString();
                if (c.Numero.Equals(Num))
                {
                    c.Id = Convert.ToInt32(rdr["Id"]);
                    c.Numero = rdr["Numero"].ToString();
                    c.Agencia = rdr["Agencia"].ToString();
                    c.Saldo = Convert.ToDecimal(rdr["Saldo"]);
                    c.Tipo = Tipo;
                }
                
            }
            return c;
        }

        public List<Conta> GetAll()
        {
            //using (connection)
            //{
                var sql = "select * from Conta";

                connection.Close();

                connection.Open();

            var comando = new SqlCommand(sql, connection);

                SqlDataReader reader = comando.ExecuteReader();
                Conta conta = null;
                List<Conta> listUsuarios = new List<Conta>();
                while (reader.Read())
                {
                    String Tipo = reader["Tipo"].ToString();
                    if (Tipo == "P")
                    {
                        conta = new ContaPoupanca();
                    }
                    else
                    {
                        conta = new ContaCorrente();
                    }

                    conta.Id = Convert.ToInt32(reader["Id"]);
                    conta.Numero = reader["Numero"].ToString();
                    conta.Agencia = reader["Agencia"].ToString();
                    conta.Saldo = Convert.ToDecimal(reader["Saldo"]);
                    conta.Tipo = Tipo;

                    listUsuarios.Add(conta);
                }
                connection.Close();
                return listUsuarios;
            //}
        }


        public bool Inserir(Conta c)
        {
            //using (connection)
            //{
                var sql = "INSERT into Conta Values (@Numero, @Agencia, @Saldo, @Tipo)";

                connection.Close();

                connection.Open();

            sqlTran = connection.BeginTransaction();
                SqlCommand comando = connection.CreateCommand();
                comando.Transaction = sqlTran;

                try
                {
                    comando.CommandText = sql;
                    comando.Parameters.Add("@Numero", SqlDbType.VarChar, 50).Value = c.Numero;
                    comando.Parameters.Add("@Agencia", SqlDbType.VarChar, 50).Value = c.Agencia;
                    comando.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = Convert.ToDecimal(c.Saldo);
                    comando.Parameters.Add("@Tipo", SqlDbType.VarChar, 50).Value = c.Tipo;

                    Conta c1 = new Conta();
                    c1 = Buscar(c.Numero);
                    if(c1.Numero == c.Numero)
                    {
                        return false;
                    }
                    
                var retorno = comando.ExecuteNonQuery();
                    sqlTran.Commit();

                    if (retorno > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();                    
                    MessageBox.Show("SQL error" + ex);
                    return false;
                }
            //}
        }

        public bool Alterar(Conta c)
        {
            //using (connection)
            //{
                var sql = "Update Conta set Agencia = @Agencia, " +
                            "Tipo = @Tipo, Saldo = @Saldo WHERE ID = @ID";
                connection.Close();

                connection.Open();

                sqlTran = connection.BeginTransaction();
                SqlCommand comando = connection.CreateCommand();
                comando.Transaction = sqlTran;

                try
                {
                    comando.CommandText = sql;
                    comando.Parameters.Add("@Agencia", SqlDbType.Int).Value = c.Agencia;
                    comando.Parameters.Add("@Tipo", SqlDbType.VarChar, 50).Value = c.Tipo;
                    comando.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = c.Saldo;
                    comando.Parameters.Add("@ID", SqlDbType.Int).Value = c.Id;

                    var retorno = comando.ExecuteNonQuery();
                    sqlTran.Commit();

                    if (retorno > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();                    
                    MessageBox.Show("SQL error" + ex);
                    return false;
                }
            //}
        }

        public bool Deletar(Conta c)
        {
            //using (connection)
            //{

                var sql = "Delete from Conta where Id = @id";

                connection.Close();

                connection.Open();

            sqlTran = connection.BeginTransaction();
                SqlCommand comando = connection.CreateCommand();
                comando.Transaction = sqlTran;

                try
                {
                    comando.CommandText = sql;
                    comando.Parameters.Add("@ID", SqlDbType.Int).Value = c.Id;
                    sqlTran.Commit();

                    var retorno = comando.ExecuteNonQuery();
                    if (retorno > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();
                    MessageBox.Show("SQL error" + ex);
                    return false;
                }
            //}
        }
    }
}
