﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeetySoft.Model
{
    public class User
    {
        public string Name { get; set; }
        public UserType UserType { get; set; }

        public User (string name, UserType userType)
        {
            Name = name;
            UserType = userType;
        }
        public override string ToString()
        {
            return string.Format("User: {0} ({1})", Name, UserType);
        }
    }
}
