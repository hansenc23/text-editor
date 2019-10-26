using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextEditor
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string User_Type { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Date_Of_Birth { get; set; }

        public List<User> list = new List<User>();

        public User()
        {
            
        }

        //get the list of users
        public List<User> getList() 
        {
            return list;
        }

        //add a user to the list
        public void addUser(User user) 
        {
            list.Add(user);
        }


        //load user from login.txt and store it as User object in a list
        public List<User> loadUsers() 
        {
            using (StreamReader sr = new StreamReader("login.txt"))
            {
                
                string[] lines = System.IO.File.ReadAllLines("login.txt");

                int lineCount = 1;
                //store each line in login.txt file as a Login object in a list 
                foreach (string line in lines)
                {
                    User user = new User();
                    string[] column = line.Split(',');
                    if (lineCount != 0)
                    {

                        user.Username = column[0];
                        user.Password = column[1];
                        user.User_Type = column[2];
                        user.First_Name = column[3];
                        user.Last_Name = column[4];
                        user.Date_Of_Birth = column[5];
                        addUser(user);
                    }
                    lineCount++;
                }

                return list;
            }
        }


        //create new user and append it to login.txt
        public void newUser(string username, string password, string userType, string firstName, string lastName, string dateOfBirth) 
        {
            using (FileStream fs = new FileStream("login.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Username = username;
                    Password = password;
                    User_Type = userType;
                    First_Name = firstName;
                    Last_Name = lastName;
                    Date_Of_Birth = dateOfBirth;
                   
                    string fullText = (username + "," + password + "," + userType + "," + firstName + "," + lastName + "," + dateOfBirth);

                    sw.WriteLine(fullText);

                   
                }
            }
        }

        //check for matching username and password on the list of Users
        public bool ValidLogin(string username, string password)
        {
            //List<User> users = new List<User>();
            list = loadUsers();
            foreach (User user in list)
            {
                if (user.Username.Equals(username) && user.Password.Equals(password))
                {
                    return true;
                }
            }

            return false;
        }


        //get the User object by username input
        public User getCurrentUser(string username)
        {
            

            list = loadUsers();

            foreach (User user in list)
            {
                if (user.Username.Equals(username))
                {
                    return user;
                }
            }

            return null;

        }

       
    }
}
