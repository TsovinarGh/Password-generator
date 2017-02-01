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
        private byte[] content;

        private Password(byte[] content)
        {
            this.content = new byte[content.Length];
            this.content = content;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach (var member in content)
            {
                string pairStr = member.ToString("X2");
                builder.Append(pairStr);
            }

            return builder.ToString();
        }


        public static Password Generate(int length)
        {
            Password result;
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] tempArray = new byte[length];
                rng.GetBytes(tempArray);
                result = new Password(tempArray);
            }
            return result;
        }
    }
}
