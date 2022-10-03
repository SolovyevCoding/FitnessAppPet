﻿using FitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException("Поле пользователь введено неккоректно", nameof(user));
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
                
            } 
        }
    }
}
