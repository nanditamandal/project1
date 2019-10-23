using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;   
using System.Threading.Tasks;

using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.Repository
{
    class SaleRepotingRepository
    {
        public List<SaleRepotingModel> SearchValue(SaleRepotingModel saleRepotingModel)
        {
            string connectionString = @"Server=NANDITA\SQLEXPRESS;DataBase=Project1DB;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM [Purchase Report] WHERE Date BETWEEN '" + saleRepotingModel.Date + "'AND '" + saleRepotingModel.Date2 + "' ";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<SaleRepotingModel> saleRepotingModels = new List<SaleRepotingModel>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
               SaleRepotingModel _saleRepotingModel = new SaleRepotingModel();

                _saleRepotingModel.Code = Convert.ToString(sqlDataReader["Code"]);
                _saleRepotingModel.Name = Convert.ToString(sqlDataReader["Name"]);
                _saleRepotingModel.Category = Convert.ToString(sqlDataReader["Category"]);
                _saleRepotingModel.Quantity = Convert.ToDouble(sqlDataReader["Quantity"]);
                _saleRepotingModel.CP = Convert.ToDouble(sqlDataReader["CP"]);
               // _saleRepotingModel.MRP = Convert.ToDouble(sqlDataReader["MRP"]);
                _saleRepotingModel.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                saleRepotingModels.Add(_saleRepotingModel);
            }

            sqlConnection.Close();

            return saleRepotingModels;




        }
    }
}
