using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ScrapingReclameAqui.Helper
{
    class MD5Helper
    {
        public static string Generate(string message)
        {
			using (MD5 md5 = MD5.Create())
			{
				byte[] input = Encoding.ASCII.GetBytes(message);
				byte[] hash = md5.ComputeHash(input);

				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < hash.Length; i++)
				{
					sb.Append(hash[i].ToString("X2"));
				}
				return sb.ToString();
			}
		}
    }
}
