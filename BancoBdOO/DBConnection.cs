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
        string str = @"Data Source=DESKTOP-M163R49;Initial Catalog=DBBanco;Integrated Security=True;Pooling=False";
        public SqlConnection connection { get; set; }
        SqlTransaction sqlTran;

        public DBConnection()
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        public List<Conta> GetAll()
        {
            //using (connection)
            //{
                var sql = "select * from Conta";
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

                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
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
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                var sql = "Delete from Conta where Id = @id";

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
