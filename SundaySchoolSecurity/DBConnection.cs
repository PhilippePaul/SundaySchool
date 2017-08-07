using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SundaySchool
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "church";
            uid = "admin";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Profile GetProfile(int idprofile)
        {
            Profile profile = new Profile();
            if (this.OpenConnection() == true)
            {
                string query = $@"SELECT * FROM profile WHERE idprofile = '{idprofile}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    profile = new Profile()
                    {
                        FirstName = dataReader["first_name"].ToString(),
                        LastName = dataReader["last_name"].ToString(),
                        Age = (uint)dataReader["age"],
                        Gender = (Gender)dataReader["gender"],
                        Allergies = dataReader["allergies"].ToString().Split(',').ToList(),
                        WaitForParent = Convert.ToBoolean(dataReader["wait_for_parent"]),
                        PictureFileName = dataReader["picture_filename"].ToString(),
                        Id = (int)dataReader["idprofile"]
                    };
                }

                dataReader.Close();
            }
            return profile;
        }

        public Profile CreateProfile(Profile profile)
        {
            if (this.OpenConnection() == true)
            {
                string query = $@"INSERT INTO profile (first_name, last_name, age, gender, allergies,
                            wait_for_parent, picture_filename)
                            VALUES('{profile.FirstName}',
                                   '{profile.LastName}',
                                   '{profile.Age}',
                                   '{(int)profile.Gender}',
                                   '{string.Join(",", profile.Allergies)}',
                                   '{Convert.ToInt32(profile.WaitForParent)}',
                                   '{profile.PictureFileName}')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                query = "SELECT LAST_INSERT_ID();";
                cmd = new MySqlCommand(query, connection);
                var dataReader = cmd.ExecuteReader();
                if(dataReader.Read())
                {
                    profile.Id = Convert.ToInt32(dataReader[0]);
                }

                this.CloseConnection();
            }
            return profile;
        }

        public void UpdateProfile(Profile profile)
        {
            if (this.OpenConnection() == true)
            {
                string query = $@"UPDATE profile SET first_name='{profile.FirstName}',
                                                last_name='{profile.LastName}',
                                                age='{profile.Age}',
                                                gender='{(int)profile.Gender}',
                                                allergies='{string.Join(",", profile.Allergies)}',
                                                wait_for_parent='{Convert.ToInt32(profile.WaitForParent)}',
                                                picture_filename='{profile.PictureFileName}'
                                                WHERE idprofile='{profile.Id}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeleteProfile(Profile profile)
        {
            if (this.OpenConnection() == true)
            {
                string query = $"DELETE FROM profile WHERE idprofile='{profile.Id}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public SortableBindingList<Profile> GetAllProfiles()
        {
            SortableBindingList<Profile> profiles = new SortableBindingList<Profile>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM profile", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    profiles.Add(new Profile()
                    {
                        FirstName = dataReader["first_name"].ToString(),
                        LastName = dataReader["last_name"].ToString(),
                        Age = (uint)dataReader["age"],
                        Gender = (Gender)dataReader["gender"],
                        Allergies = dataReader["allergies"].ToString().Split(',').ToList(),
                        WaitForParent = Convert.ToBoolean(dataReader["wait_for_parent"]),
                        PictureFileName = dataReader["picture_filename"].ToString(),
                        Id = (int)dataReader["idprofile"]
                    });
                }

                dataReader.Close();

                this.CloseConnection();
            }
            return profiles;
        }
    }
}
