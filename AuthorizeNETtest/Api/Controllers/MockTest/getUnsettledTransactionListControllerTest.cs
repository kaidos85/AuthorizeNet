namespace AuthorizeNet.Api.Controllers.MockTest
{
    using System;
    using System.Collections.Generic;
    using AuthorizeNet.Api.Contracts.V1;
    using AuthorizeNet.Api.Controllers;
    using AuthorizeNet.Api.Controllers.Test;
    using AuthorizeNet.Util;
    using NUnit.Framework;
    using NUnit.Framework.Legacy;

    [TestFixture]
    public class getUnsettledTransactionListTest : ApiCoreTestBase 
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

        [Test]
	    public void MockgetUnsettledTransactionListTest()
	    {
		    //define all mocked objects as final
            var mockController = GetMockController<getUnsettledTransactionListRequest, getUnsettledTransactionListResponse>();
            var mockRequest = new getUnsettledTransactionListRequest
                {
                    merchantAuthentication = new merchantAuthenticationType {name = "mocktest", Item = "mockKey", ItemElementName = ItemChoiceType.transactionKey},
                };
            var transactionSummaryType = new transactionSummaryType[]
                {
                    new transactionSummaryType
                        {
                            accountNumber = "1234",
                        }
                };
            var mockResponse = new getUnsettledTransactionListResponse
                {
                    refId = "1234",
                    sessionToken = "sessiontoken",
                    transactions = transactionSummaryType,
                };

		    var errorResponse = new ANetApiResponse();
		    var results = new List<String>();
            const messageTypeEnum messageTypeOk = messageTypeEnum.Ok;

            SetMockControllerExpectations<getUnsettledTransactionListRequest, getUnsettledTransactionListResponse, getUnsettledTransactionListController>(
                mockController.Object, mockRequest, mockResponse, errorResponse, results, messageTypeOk);
            mockController.Object.Execute(AuthorizeNet.Environment.CUSTOM);
            //mockController.Object.Execute();
            // or var controllerResponse = mockController.Object.ExecuteWithApiResponse(AuthorizeNet.Environment.CUSTOM);
            var controllerResponse = mockController.Object.GetApiResponse();
            ClassicAssert.IsNotNull(controllerResponse);

            ClassicAssert.IsNotNull(controllerResponse.transactions);
            LogHelper.info(Logger, "getUnsettledTransactionList: Details:{0}", controllerResponse.transactions);
	    }
    }
}
