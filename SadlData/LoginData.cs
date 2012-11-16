﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SadlData
{
    public enum UserTypeEnum
    {
        user,
        manager,
        owner
    }

    public class LoginData
    {
        public string userName;
        public UserTypeEnum type;
        public string password;
    }

}