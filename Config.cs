using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullAoutomation_todorvachev_01
{
    internal class Config
    {
        public static string BaseURL = "https://testing.todorvachev.com/";
        public string SelectorsURL = "https://testing.todorvachev.com/category/selectors/";
        public string SpecialElementsURL = "https://testing.todorvachev.com/category/special-elements/";
        //public string BaseURL = "https://testing.todorvachev.com/";
        //public string BaseURL = "https://testing.todorvachev.com/";
        //public string BaseURL = "https://testing.todorvachev.com/";
        //public string BaseURL = "https://testing.todorvachev.com/";
        public class Credentials
        {
            public class Valid
            {
                public static string Name;
                public static string Password;
                public static string Email;
            }
            public class InValid
            {
                public class Name
                {
                    public static string Numbers = "12345";
                   
                }
                public class Password
                {
                    public static string Length6 = "123456";
                    public static string length13 = "1234567890123";
                }
                public static class Address
                {
                    public static string Characters = "abcdefg";
                }
                public static class Zip
                {
                    public static string Characters = "abcdefg";
                }
                public class Email
                {
                    public static string NoSignatur = "yomokatz@";
                }
            }
        }
    }
}
