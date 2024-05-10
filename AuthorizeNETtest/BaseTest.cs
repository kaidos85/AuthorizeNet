using NUnit.Framework;
using System;
using System.Configuration;
using AuthorizeNet.Utility;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AuthorizeNETtest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestFixture]
    public class BaseTest
    {
        protected static readonly WebRequestCreateLocal LocalRequestObject = new WebRequestCreateLocal();
        protected string ApiLogin;
        protected string TransactionKey;
        protected IConfigurationRoot _configuration;

        public BaseTest()
        {
            _configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
#if USELOCAL
            WebRequest.RegisterPrefix("https://", LocalRequestObject);
#endif
        }

        /// <summary>
        /// CheckApiLoginTransactionKey - make sure that we are not using the default invalid ApiLogin and TransactionKey.
        /// </summary>
        protected string CheckApiLoginTransactionKey()
        {
            ApiLogin = _configuration["AppSettings:" + AuthorizeNet.Util.Constants.PropApiLoginid];
            TransactionKey = _configuration["AppSettings:" + AuthorizeNet.Util.Constants.PropTransactionKey];

            string sRet = "";
            if ((string.IsNullOrEmpty(ApiLogin)) || (ApiLogin.Trim().Length == 0)
                || (string.IsNullOrEmpty(TransactionKey)) || (TransactionKey.Trim().Length == 0))
            {
                LoadLoginTranskey();
            }

            if ((string.IsNullOrEmpty(ApiLogin)) || (ApiLogin.Trim().Length == 0)
                || (string.IsNullOrEmpty(TransactionKey)) || (TransactionKey.Trim().Length == 0))
            {
                sRet = "Invalid Login / Password: blank \n";
            }

#if !USELOCAL
            if ((ApiLogin == "ApiLogin") || (TransactionKey == "TransactionKey"))
            {
                sRet += "Invalid Login / Password \n";
            }
#endif
            return sRet;
        }

        private void LoadLoginTranskey()
        {
            ApiLogin = _configuration["AppSettings:" + "ApiLogin"];
            TransactionKey = _configuration["AppSettings:" + "TransactionKey"];
        }

        protected decimal getValidAmount()
        {
            var rnd = new AnetRandom(DateTime.Now.Millisecond);

            return (decimal)rnd.Next(9999) / 100;
        }
    }
}
