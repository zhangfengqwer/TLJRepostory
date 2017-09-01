using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TLJCommon
{
    public class Consts
    {
        public enum Platform
        {
            Platform_Official,
        }

        public enum Code
        {
            Code_OK = 1000,
            Code_LoginFail,
        }

        public static string Tag_Login = "Login";
        public static string Tag_QuickRegister = "QuickRegister";
    }
}
