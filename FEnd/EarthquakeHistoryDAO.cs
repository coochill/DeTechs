using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FEnd
{
    internal class EarthquakeHistoryDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=detechs;";

        // Get history method
        public List<EQHistory> GetHistory()
        {
            List<EQHistory> history = new List<EQHistory>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM earthquake", connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EQHistory a = new EQHistory
                        {
                            Date = reader.GetString(0),
                            Time = reader.GetString(1),
                            Intensity = reader.GetInt32(2),
                        };
                        history.Add(a);
                    }
                }
            }
            return history;
        }

        // Add value to database method
        public void AddToHistory(BindingSource bs, string date, string time, int intensity)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Move existing data down by one row
                MySqlCommand shiftCommand = new MySqlCommand("UPDATE earthquake SET date = date + INTERVAL 1 SECOND", connection);
                shiftCommand.ExecuteNonQuery();

                // Insert the new record at the top
                string query = "INSERT INTO earthquake (date, time, intensity) VALUES (@Date, @Time, @Intensity)";
                MySqlCommand insertCommand = new MySqlCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@Date", date);
                insertCommand.Parameters.AddWithValue("@Time", time);
                insertCommand.Parameters.AddWithValue("@Intensity", intensity);
                insertCommand.ExecuteNonQuery();
           

                // Refresh the data on the UI thread
              
            }
        }

    }

}
