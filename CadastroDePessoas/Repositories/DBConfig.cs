using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace CadastroDePessoas.Repositories
{
    public class DBConfig
    {
        private static SQLiteConnection _sqliteConnection;
        public DBConfig() { }

        private static SQLiteConnection DbConnection()
        {
            if (!Directory.Exists("C:\\temp"))
            {
                Directory.CreateDirectory("C:\\temp");
            }
            _sqliteConnection = new SQLiteConnection("Data Source=C:\\temp\\Cadastro.sqlite; Version=3;");
            _sqliteConnection.Open();
            return _sqliteConnection;
        }
        public static void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Endereco(Id text primary key, Logradouro Varchar(50), Numero int, Cidade VarChar(30), UF VarChar(2), Complemento Varchar(50), CEP Varchar(8))";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Pessoa(Id text primary key, Nome Varchar(30), Sobrenome VarChar(20), CPF VarChar(14), DataNascimento DateTime, Genero int, Endereco int, FOREIGN KEY (Endereco) REFERENCES Endereco(Id))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
