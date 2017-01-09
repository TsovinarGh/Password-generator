using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoServices
{
    public class Password
    {
        private byte[] content = new byte[16];

        private Password(byte[] content)
        {
            this.content = content;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach(var member in content)
            {
                string pairStr = member.ToString("X");
                builder.Append(pairStr);   
            }

            return builder.ToString();
        }

        public static Password Generate()
        {
            Password result;
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] tempArray = new byte[16];
                rng.GetBytes(tempArray);
                result = new Password(tempArray);
            }
            return result;
        }
    }
}
