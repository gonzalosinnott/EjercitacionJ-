﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vista.MVC.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Available { get; set; }
    }
}