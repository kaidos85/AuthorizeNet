namespace AuthorizeNet.Test
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using AuthorizeNet.Util;
    using Castle.Core.Configuration;
    using Microsoft.Extensions.Configuration;

    public abstract class UnitTestData
    {
        protected static string ApiLoginId;
        protected static string TransactionKey;
        protected static string MerchantMd5Key;

        private static readonly Log Logger = LogFactory.getLog(typeof(UnitTestData));
        static IConfigurationRoot _configuration;

        /**
         * Default static constructor
         */
        static UnitTestData()
        {
            _configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

            //getPropertyFromNames get the value from properties file or environment
            ApiLoginId = GetPropertyFromNames(Constants.EnvApiLoginid, Constants.PropApiLoginid);
            TransactionKey = GetPropertyFromNames(Constants.EnvTransactionKey, Constants.PropTransactionKey);
            MerchantMd5Key = GetPropertyFromNames(Constants.EnvMd5Hashkey, Constants.PropMd5Hashkey);

            if (null == ApiLoginId || null == TransactionKey)
            {
                throw new ArgumentException("LoginId and/or TransactionKey have not been set.");
            }
            else
            {
                LogHelper.info(Logger, "PropertyValues: ApiLoginId:'{0}', TransactionKey:'{1}', MD5Key:'{2}' ", ApiLoginId, TransactionKey, MerchantMd5Key);
            }
        }

        public static string GetPropertyFromNames(string pFirstName, string pSecondName)
        {
            var section = _configuration.GetSection("AppSettings");
            var value = section[pFirstName] ?? section[pSecondName];

            return value;
        }
    }
}