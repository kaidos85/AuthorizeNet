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
    public class updateHeldTransactionTest : ApiCoreTestBase 
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
	    public void MockupdateHeldTransactionTest()
	    {
		    //define all mocked objects as final
            var mockController = GetMockController<updateHeldTransactionRequest, updateHeldTransactionResponse>();
            var mockRequest = new updateHeldTransactionRequest
                {
                    merchantAuthentication = new merchantAuthenticationType() {name = "mocktest", Item = "mockKey", ItemElementName = ItemChoiceType.transactionKey},
                };

            var transactionResponse = new transactionResponse()
            {
                accountNumber = "1234",
            };

            var mockResponse = new updateHeldTransactionResponse
                {
                    refId = "1234",
                    sessionToken = "sessiontoken",
                    transactionResponse = transactionResponse
                };

		    var errorResponse = new ANetApiResponse();
		    var results = new List<String>();
            const messageTypeEnum messageTypeOk = messageTypeEnum.Ok;

            SetMockControllerExpectations<updateHeldTransactionRequest, updateHeldTransactionResponse, updateHeldTransactionController>(
                mockController.Object, mockRequest, mockResponse, errorResponse, results, messageTypeOk);
            mockController.Object.Execute(AuthorizeNet.Environment.CUSTOM);
            //mockController.Object.Execute();
            // or var controllerResponse = mockController.Object.ExecuteWithApiResponse(AuthorizeNet.Environment.CUSTOM);
            var controllerResponse = mockController.Object.GetApiResponse();
            ClassicAssert.IsNotNull(controllerResponse);

            ClassicAssert.IsNotNull(controllerResponse.transactionResponse);
            LogHelper.info(Logger, "updateHeldTransaction: Details:{0}", controllerResponse.transactionResponse.accountNumber);
	    }
    }
}
