﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PengelolaanPegawai.Web.Models
{
    public class LoginViewModel
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public bool IsRemember { set; get; }
    }
}