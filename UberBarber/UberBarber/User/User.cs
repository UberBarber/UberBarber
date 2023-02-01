﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UberBarber.User
{
    public class User
    {
        // TODO: delete when unnecessary - draft User class
        public User(MySqlDataReader reader)
        {
            Username = (string)reader["username"];
            Password = (string)reader["password"];
            Is_worker = (bool)reader["is_worker"];
            Customer_id = (int)reader["customer_id"];
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Is_worker { get; set; }
        public int Customer_id { get; set;}
    }
}