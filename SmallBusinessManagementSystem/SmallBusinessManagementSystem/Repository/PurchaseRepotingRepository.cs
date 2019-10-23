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
    public class PurchaseRepotingRepository
    {
        public List<PurchaseRepotingModel > SearchValue(PurchaseRepotingModel purchaseRepotingModel)
        {
            string connectionString = @"Server=NANDITA\SQLEXPRESS;DataBase=Project1DB;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM [Purchase Report] WHERE Date BETWEEN '"+purchaseRepotingModel.Date+"'AND '"+ purchaseRepotingModel.Date2 + "' ";
          
            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<PurchaseRepotingModel> purchaseRepotingModels = new List<PurchaseRepotingModel>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                PurchaseRepotingModel _purchaseRepotingModel = new PurchaseRepotingModel();
              
                _purchaseRepotingModel.Code = Convert.ToString(sqlDataReader["Code"]);
                _purchaseRepotingModel.Name = Convert.ToString(sqlDataReader["Name"]);
                _purchaseRepotingModel.Category = Convert.ToString(sqlDataReader["Category"]);
                _purchaseRepotingModel.Quantity =Convert.ToDouble( sqlDataReader["Quantity"]);
                _purchaseRepotingModel.CP = Convert.ToDouble (sqlDataReader["CP"]);
                _purchaseRepotingModel.MRP = Convert.ToDouble(sqlDataReader["MRP"]);
                _purchaseRepotingModel.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                purchaseRepotingModels.Add(_purchaseRepotingModel);
            }

            sqlConnection.Close();
            
             return purchaseRepotingModels;
           
                
           
           
        }
    }
}
