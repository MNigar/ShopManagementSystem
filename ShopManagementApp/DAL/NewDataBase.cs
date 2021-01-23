using ShopManagementApp.Controls;
using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementApp.DAL
{
  public   class NewDataBase:IDisposable
    {
        private SqlConnection _sqlConnection;
        private string GetConnectionString(string connectionString)
        {
            return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
        }
        private void CheckConnection()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();
        }

        public NewDataBase(string connectionString)
        {
            string connection = GetConnectionString(connectionString);
            _sqlConnection = new SqlConnection(connection);

        }
        //public T Map(SqlDataReader sqlDataReader)
        //{
        //    return default(T);
        //}
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            try
            {
                CheckConnection();
                string query = "SELECT Id,Name,Price FROM BOOKS";
                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            Book book = new Book()
                            {
                                Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                                Name = sqlDataReader["Name"].ToString(),
                                Price = Convert.ToDecimal(sqlDataReader["Price"].ToString())
                            };

                            books.Add(book);
                        
                        }
                    }
                }

            
            }
            catch(SqlException exception)
            {
                throw exception;

            }
            return books;
        }
        public Book  GetById(int Id)
        {

            Book book = new Book();
            try
            { 
               
                string query = $"SELECT Id,Name,Price FROM BOOKS WHERE ID={Id}";
             
                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                  

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        

                        while (sqlDataReader.Read())
                        {

                            book.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                            book.Name = sqlDataReader["Name"].ToString();
                            book.Price = Convert.ToDecimal(sqlDataReader["Price"].ToString());

                        }
                    };
                }
                

            }
            catch (SqlException exception)
            {
                throw exception;

            }

            return book;
    }
       
        public Book Add(Book book)
        {

           
            try
            {
                CheckConnection();

                
                string query = $"INSERT INTO Books  VALUES(@name,@price)";
                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", book.Name);
                    sqlCommand.Parameters.AddWithValue("@price", book.Price);

                    int row = sqlCommand.ExecuteNonQuery();
                    
                }


            }
            catch (SqlException exception)
            {
                throw exception;

            }
            return book;
        }
        public Book Update(Book book)
        {
           
            try
            {
                CheckConnection();
              
                string query1 = $"UPDATE BOOKS SET Name=@name, Price=@price WHERE ID=@id";
               
                using (SqlCommand sqlCommand = new SqlCommand(query1, _sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", book.Name);
                    sqlCommand.Parameters.AddWithValue("@price", book.Price);
                    sqlCommand.Parameters.AddWithValue("@id", book.Id);

                     sqlCommand.ExecuteNonQuery();
                   
                }

            }
            catch (SqlException exception)
            {
                throw exception;

            }

            return book;
        }
        public void Delete(int Id)
        {

            try
            {

                CheckConnection();
                string query1 = $"DELETE FROM BOOKS WHERE ID=@Id ";

                using (SqlCommand sqlCommand = new SqlCommand(query1, _sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", Id);
                   sqlCommand.ExecuteNonQuery();
                    GetAll();
                }

            }
            catch (SqlException exception)
            {
                throw exception;

            }

        
        }

        public List<Book> Search(string value)
        {
            List<Book> books = new List<Book>();


            try
            {
                CheckConnection();
                string query = $"SELECT Id ,Name From Books WHERE Name LIKE '%{value}%'";
                     

                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {


                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {


                        while (sqlDataReader.Read())
                        {
                            Book book = new Book();

                            book.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                            book.Name = sqlDataReader["Name"].ToString();
                            books.Add(book);
                        }
                    };
                }


            }
            catch (SqlException exception)
            {
                throw exception;

            }

            return books;
        }
        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
    }
}
