﻿using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name, @Description)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = categoryModel.Description;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Categories WHERE Category_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories
                                        SET Category_Name =@name,
                                        Category_Description = @Description
                                        WHERE Category_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = categoryModel.Description;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryList = new List<CategoryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories ORDER BY Category_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Category_Id"];
                        categoryModel.Name = reader["Category_Name"].ToString();
                        categoryModel.Description = reader["Category_Description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoryName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories
                                        WHERE Category_Id=@id or Category_Name LIKE @name+ '%'
                                        ORDER By Category_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Category_Id"];
                        categoryModel.Name = reader["Category_Name"].ToString();
                        categoryModel.Description = reader["Category_Description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }

            }
            return categoryList;

        }
    }
}