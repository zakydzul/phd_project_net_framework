using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace phd_project_net_framework.Costum_Class
{
    internal class DbJob
    {
        // sql connection
        public static MySqlConnection GetConnection()
        {
            string connectionString = "server=localhost;port=3307;uid=root;pwd=root;database=job_table";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //try connectiong to server
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                System.Windows.MessageBox.Show("MySQL Connection ! \n"+ex.Message , "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
            return connection;
        }

        //method to add job to server
        public static void AddJob(Job job)
        {
            string sql = "INSERT INTO job_table  (ID, Name, Physical_Channel, MinVal, MaxVal, Rate, Samples, Sensitivity, Sens_Units, Input_Coupling, Terminal_Coupling, Excitation_Source, Excitation_Val)  VALUES (NULL, @name, @physical_channel, @min_val, @max_val, @rate, @samples, @sensitivity, @sens_units, @input_coupling, @terminal_coupling, @excitation_source, @excitation_val)";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", job.Name);
            command.Parameters.AddWithValue("@physical_channel", job.Physical_Channel);
            command.Parameters.AddWithValue("@min_val", job.MinVal);
            command.Parameters.AddWithValue("@max_val", job.MaxVal);
            command.Parameters.AddWithValue("@rate", job.Rate);
            command.Parameters.AddWithValue("@samples", job.Samples);
            command.Parameters.AddWithValue("@sensitivity", job.Sensitivity);
            command.Parameters.AddWithValue("@sens_units", job.Sens_Units);
            command.Parameters.AddWithValue("@input_coupling", job.Input_Coupling);
            command.Parameters.AddWithValue("@terminal_coupling", job.Terminal_Coupling);
            command.Parameters.AddWithValue("@excitation_source", job.Excitation_Source);
            command.Parameters.AddWithValue("@excitation_val", job.Excitaion_Val);

            //try to excecute non query, if error throw an exception
            try
            {
                command.ExecuteNonQuery();
                //add succesful messagebox
                System.Windows.MessageBox.Show("Succesfully added new Job", "Information", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                System.Windows.MessageBox.Show("Data is not inserted ! \n" + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }

            connection.Close();
        }

        //method to update job instance in server
        public static void UpdateJob(Job job, string ID)
        {
            MySqlConnection connection = (MySqlConnection)GetConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE job_table SET Name = '" + job.Name + "' WHERE ID = '" + ID + "'";
            //try to excecute non query, if error throw an exception
            try
            {
                command.ExecuteNonQuery();
                //add succesful messagebox
                System.Windows.MessageBox.Show("Succesfully updated Job", "Information", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                System.Windows.MessageBox.Show("MySQL Connection ! \n" + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }

            connection.Close();
        }

        // metod to delete job from server
        public static void DeleteJob(int ID)
        {
            MySqlConnection connection = (MySqlConnection)GetConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM job_table WHERE ID = '" + ID + "'";
            //try to excecute non query, if error throw an exception
            try
            {
                command.ExecuteNonQuery();
                //add succesful messagebox
                System.Windows.MessageBox.Show("Succesfully deleted Job", "Information", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                System.Windows.MessageBox.Show("MySQL Connection ! \n" + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }

            connection.Close();
        }

        internal static void DeleteJob(object job_ID)
        {
            throw new NotImplementedException();
        }

        // method to get all job from server
        public static List<Job> GetAllJob()
        {
            MySqlConnection connection = (MySqlConnection)GetConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM job_table";
            //try to excecute non query, if error throw an exception
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                List<Job> jobs = new List<Job>();
                while (reader.Read())
                {
                    Job job = new Job();
                    job.ID = reader.GetInt32(0);
                    job.Name = reader.GetString(1);
                    jobs.Add(job);
                }
                return jobs;
            }
            catch (MySqlException ex)
            {
                System.Windows.MessageBox.Show("MySQL Connection ! \n" + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }

            connection.Close();
            return null;
        }

    }
}
