using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApp.DAL
{
  public   class NewDataBase:IDisposable
    {
        private SqlConnection _sqlConnection;
        private string GetConnectionString(string connectionString)
        {
            return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
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
                _sqlConnection.Open();
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
                _sqlConnection.Open();
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
       
        public Book Insert(Book book)
        {

           
            try
            {

                _sqlConnection.Open();
                string query = $"INSERT INTO Books (Name,Price) VALUES('{book.Name}',{book.Price})";
                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    int row = sqlCommand.ExecuteNonQuery();
                    
                }


            }
            catch (SqlException exception)
            {
                throw exception;

            }
            return book;
        }
        public Book Update(int Id,Book book)
        {
           
            try
            {
              
                string query1 = $"UPDATE BOOKS SET NAME ='{book.Name}', PRICE = {book.Price} WHERE ID={Id}";
               
                using (SqlCommand sqlCommand = new SqlCommand(query1, _sqlConnection))
                {
                    int row = sqlCommand.ExecuteNonQuery();
                   
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
                _sqlConnection.Open();
                string query1 = $"DELETE FROM BOOKS WHERE ID={Id} ";

                using (SqlCommand sqlCommand = new SqlCommand(query1, _sqlConnection))
                {
                    int row = sqlCommand.ExecuteNonQuery();

                }

            }
            catch (SqlException exception)
            {
                throw exception;

            }

        
        }


        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
    }
}
