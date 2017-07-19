using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterApplication
{
    class databaseModel
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory;
        private static string connetionString;
        private static SqlConnection cnn;
        public string reason;
        public string result;
        public string condition;
        public string additional;
        public string location;
        public List<String> showItems;
        public databaseModel()
        {
            string remove = @"\CounterApplication\bin\Debug";
            int index = path.IndexOf(remove);
            string cleanPath = (index < 0) ? path : path.Remove(index, remove.Length);
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+cleanPath+ "Broken.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connetionString);
        }
        public Boolean removeItem(string database, string where)
        {
            Boolean success = false;
            SqlCommand execute = new SqlCommand("DELETE FROM " + database + " WHERE item= @ID", cnn);
            execute.Parameters.AddWithValue("@ID", where);
            cnn.Open();
            try
            {

                int sqltest = execute.ExecuteNonQuery();
                if (sqltest >= 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch
            {
                success = false;    
            }
            cnn.Close();
            return success;
        }  
        public Boolean updateitem(string database,string item, string update, string value)
        {
            Boolean success = false;
            SqlCommand execute = new SqlCommand("Update " + database + " SET " + update +" = @result WHERE item=@ID", cnn);
            execute.Parameters.AddWithValue("@ID",item);
            execute.Parameters.AddWithValue("@result", value);
            cnn.Open();
            try
            {
                execute.ExecuteNonQuery();
                success = true;
            }
            catch
            {
                success = false;
            }
            cnn.Close();
            return success;
        }
        public Boolean addItem(string database, string item)
        {
            Boolean success = false;
            SqlCommand execute = new SqlCommand("INSERT INTO "+ database + "(item) VALUES ('"+item+"')", cnn);

            cnn.Open();
            try
            {
                execute.ExecuteNonQuery();
                success = true;
            }
            catch
            {
                success = false;
            }   
            cnn.Close();
            return success;
        }
        public Boolean getItem(string database, string item)
        {
            Boolean success = false;
            SqlCommand execute = new SqlCommand("SELECT * FROM " +database +" where item=@ID", cnn);
            execute.Parameters.AddWithValue("@ID", item);
            cnn.Open();
            try
            {
                using (SqlDataReader reader = execute.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            switch (database)
                            {
                                case "BrokenPile":
                                    reason = reader["reason"].ToString();
                                    result = reader["result"].ToString();
                                    break;
                                case "Disposed":
                                    reason = reader["reason"].ToString();
                                    break;
                                case "StockCheck":
                                    condition = reader["condition"].ToString();
                                    additional = reader["name"].ToString();
                                    location = reader["location"].ToString();
                                    break;
                            }
                        }
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
                
            }
            catch
            {
                success = false;
            }
            cnn.Close();
            return success;
        }
        public Boolean showAll(string database) {
            showItems = new List<String>();
            Boolean success = false;
            SqlCommand execute = new SqlCommand("SELECT * FROM " + database , cnn);
            cnn.Open();
            try
            {
                using (SqlDataReader reader = execute.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        showItems.Add("Item: " + reader["item"].ToString() + "\n");
                        switch (database)
                        {
                            case "BrokenPile":
                                showItems.Add("Reason: " + reader["reason"].ToString() + "\n");
                                showItems.Add("Result: " + reader["result"].ToString() + "\n\n");
                                break;
                            case "Disposed":
                                showItems.Add("Reason: " + reader["reason"].ToString() + "\n\n");
                                break;
                            case "StockCheck":
                                showItems.Add("Name:  " + reader["name"].ToString() + "\n");
                                showItems.Add("Condition: " + reader["condition"].ToString() + "\n");                                
                                showItems.Add("Location: " + reader["location"].ToString() + "\n\n");
                                break;
                        }
                    }
                    success = true;
                }

            }
            catch
            {
                success = false;
            }
            cnn.Close();
            return success;
        }
    }


}
