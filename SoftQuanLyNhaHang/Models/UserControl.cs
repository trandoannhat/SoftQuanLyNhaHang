﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace SoftQuanLyNhaHang.Models
{
    class UserControl
    {
        public static string SHA256(string password)
        {
            try
            {
                SHA256Managed crypt = new SHA256Managed();
                string hash = String.Empty;
                byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0,
                    Encoding.UTF8.GetByteCount(password));
                foreach (byte bit in crypto)
                {
                    hash += bit.ToString("x2");
                }
                return hash;
            }
            catch
            { return null; }
        }
    }
}
