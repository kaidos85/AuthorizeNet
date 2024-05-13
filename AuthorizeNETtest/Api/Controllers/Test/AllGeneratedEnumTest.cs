namespace AuthorizeNet.Api.Controllers.Test
{
    using System;
    using AuthorizeNet.Api.Contracts.V1;
    using NUnit.Framework;

    [TestFixture]
    public class AllGeneratedEnumTest : ApiCoreTestBase
    {

        [OneTimeSetUp]
        public new static void SetUpBeforeClass()
        {
            ApiCoreTestBase.SetUpBeforeClass();
        }

        [OneTimeTearDown]
        public new static void TearDownAfterClass()
        {
            ApiCoreTestBase.TearDownAfterClass();
        }

        [SetUp]
        public new void SetUp()
        {
            base.SetUp();
        }

        [TearDown]
        public new void TearDown()
        {
            base.TearDown();
        }

        //Generated by cs-enum-test on Tue 11/04/2014-11:49:24.42 
        [Test]
        public void AllEnumTest()
        {

            foreach (var anEnum in Enum.GetValues(typeof(messageTypeEnum)))
            {
                var aValue = anEnum.ToString();
                messageTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(bankAccountTypeEnum)))
            {
                var aValue = anEnum.ToString();
                bankAccountTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(echeckTypeEnum)))
            {
                var aValue = anEnum.ToString();
                echeckTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ARBSubscriptionStatusEnum)))
            {
                var aValue = anEnum.ToString();
                ARBSubscriptionStatusEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(paymentMethodEnum)))
            {
                var aValue = anEnum.ToString();
                paymentMethodEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ARBGetSubscriptionListOrderFieldEnum)))
            {
                var aValue = anEnum.ToString();
                ARBGetSubscriptionListOrderFieldEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(TransactionListOrderFieldEnum)))
            {
                var aValue = anEnum.ToString();
                TransactionListOrderFieldEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(deviceActivationEnum)))
            {
                var aValue = anEnum.ToString();
                deviceActivationEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(afdsTransactionEnum)))
            {
                var aValue = anEnum.ToString();
                afdsTransactionEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(messageTypeEnum)))
            {
                var aValue = anEnum.ToString();
                messageTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(customerTypeEnum)))
            {
                var aValue = anEnum.ToString();
                customerTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(merchantInitTransReasonEnum)))
            {
                var aValue = anEnum.ToString();
                merchantInitTransReasonEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(authIndicatorEnum)))
            {
                var aValue = anEnum.ToString();
                authIndicatorEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(EncodingType)))
            {
                var aValue = anEnum.ToString();
                EncodingType enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(EncryptionAlgorithmType)))
            {
                var aValue = anEnum.ToString();
                EncryptionAlgorithmType enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(OperationType)))
            {
                var aValue = anEnum.ToString();
                OperationType enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ItemChoiceType1)))
            {
                var aValue = anEnum.ToString();
                ItemChoiceType1 enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(customerProfileTypeEnum)))
            {
                var aValue = anEnum.ToString();
                customerProfileTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ARBSubscriptionUnitEnum)))
            {
                var aValue = anEnum.ToString();
                ARBSubscriptionUnitEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(webCheckOutTypeEnum)))
            {
                var aValue = anEnum.ToString();
                webCheckOutTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }														   
            foreach (var anEnum in Enum.GetValues(typeof(ItemChoiceType)))
            {
                var aValue = anEnum.ToString();
                ItemChoiceType enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(validationModeEnum)))
            {
                var aValue = anEnum.ToString();
                validationModeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(splitTenderStatusEnum)))
            {
                var aValue = anEnum.ToString();
                splitTenderStatusEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(TransactionGroupStatusEnum)))
            {
                var aValue = anEnum.ToString();
                TransactionGroupStatusEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ARBGetSubscriptionListSearchTypeEnum)))
            {
                var aValue = anEnum.ToString();
                ARBGetSubscriptionListSearchTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(accountTypeEnum)))
            {
                var aValue = anEnum.ToString();
                accountTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(cardTypeEnum)))
            {
                var aValue = anEnum.ToString();
                cardTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(FDSFilterActionEnum)))
            {
                var aValue = anEnum.ToString();
                FDSFilterActionEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(permissionsEnum)))
            {
                var aValue = anEnum.ToString();
                permissionsEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(settingNameEnum)))
            {
                var aValue = anEnum.ToString();
                settingNameEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(settlementStateEnum)))
            {
                var aValue = anEnum.ToString();
                settlementStateEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(transactionStatusEnum)))
            {
                var aValue = anEnum.ToString();
                transactionStatusEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(transactionTypeEnum)))
            {
                var aValue = anEnum.ToString();
                transactionTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(CustomerPaymentProfileSearchTypeEnum)))
            {
                var aValue = anEnum.ToString();
                CustomerPaymentProfileSearchTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(CustomerPaymentProfileOrderFieldEnum)))
            {
                var aValue = anEnum.ToString();
                CustomerPaymentProfileOrderFieldEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(AUJobTypeEnum)))
            {
                var aValue = anEnum.ToString();
                AUJobTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(paymentMethodsTypeEnum)))
            {
                var aValue = anEnum.ToString();
                paymentMethodsTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }
        }

        /*
        private <T extends enum > void XX<T>()
        {
            for ( T anEnum : T.values())
            {
                String unitValue = anEnum.value();
                T unitEnum = T.fromValue(unitValue);
                Assert.assertEquals(anEnum, unitEnum);
            }
        }
        */
    }
}
