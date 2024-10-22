using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data; 

namespace ProjetoTeste
{
    [TestClass]
    public class UnitTest1
    {
        private MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" +
                "uid=root;" +
                "pwd=;" +
                "database=academico;";
            return new MySqlConnection(c);
        }

        [TestMethod]
        public void TestConnect()
        {
            var db = GetConnection();
            db.Open();
            Assert.IsTrue(db.State == System.Data.ConnectionState.Open);
        }

        [TestMethod]
        public void TestInsert()
        {
            string sql = "INSERT INTO aluno " +
                "(matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha) " +
                "VALUES " +
                "(@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";

            var db = GetConnection();
            db.Open();
            var cmd = new MySqlCommand(sql, db);

            cmd.Parameters.AddWithValue("@matricula", "BI3004007");
            cmd.Parameters.AddWithValue("@dt_nascimento", new DateTime(2000, 03, 11));
            cmd.Parameters.AddWithValue("@nome", "Caio");
            cmd.Parameters.AddWithValue("@endereco", "Rua dadadasdasd");
            cmd.Parameters.AddWithValue("@bairro", "Brigadeiro");
            cmd.Parameters.AddWithValue("@cidade", "São Paulo");
            cmd.Parameters.AddWithValue("@estado", "SP");
            cmd.Parameters.AddWithValue("@senha", "123456");
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        [TestMethod]
        public void TestSelect()
        {
            var db = GetConnection();
            db.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, db);

            var dt = new DataTable();
            sqlAd.Fill(dt);

           
          
            foreach (DataRow dr in dt.Rows)
            {
                Debug.WriteLine(dr["matricula"]);
                Debug.WriteLine(dr["nome"]);
                Debug.WriteLine(dr["dt_nascimento"]);
                Debug.WriteLine(dr["endereco"]);
                Debug.WriteLine(dr["bairro"]);
                Debug.WriteLine(dr["cidade"]);
                Debug.WriteLine(dr["estado"]);
                Debug.WriteLine(dr["senha"]);
                Debug.WriteLine(" ");
            }

            db.Close();
        }
    }
}