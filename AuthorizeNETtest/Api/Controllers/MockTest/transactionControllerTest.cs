namespace AuthorizeNet.Api.Controllers.MockTest
{
    //using System;
    //using System.Collections.Generic;
    //using AuthorizeNet.Api.Contracts.V1;
    //using AuthorizeNet.Api.Controllers;
    using AuthorizeNet.Api.Controllers.Test;
    //using AuthorizeNet.Util;
    using NUnit.Framework;

    [TestFixture]
    public class transactionTest : ApiCoreTestBase 
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
	    public void MocktransactionTest()
	    {
            //object transactionRequest does not exist
            /*
		    //define all mocked objects as final
            var mockController = GetMockController<transactionRequest, transactionResponse>();
            var mockRequest = new transactionRequest
                {
                    merchantAuthentication = new merchantAuthenticationType() {name = "mocktest", Item = "mockKey", ItemElementName = ItemChoiceType.transactionKey},
                };
            var mockResponse = new transactionResponse
                {
                    refId = "1234",
                    sessionToken = "sessiontoken",
                    Yyyyy = Yyyy,
                };

		    var errorResponse = new ANetApiResponse();
		    var results = new List<String>();
            const messageTypeEnum messageTypeOk = messageTypeEnum.Ok;

            SetMockControllerExpectations<transactionRequest, transactionResponse, transactionController>(
                mockController.Object, mockRequest, mockResponse, errorResponse, results, messageTypeOk);
            mockController.Object.Execute(AuthorizeNet.Environment.CUSTOM);
            //mockController.Object.Execute();
            // or var controllerResponse = mockController.Object.ExecuteWithApiResponse(AuthorizeNet.Environment.CUSTOM);
            var controllerResponse = mockController.Object.GetApiResponse();
            ClassicAssert.IsNotNull(controllerResponse);

		    ClassicAssert.IsNotNull(controllerResponse.Yyyyy);
		    LogHelper.info(Logger, "transaction: Details:{0}", controllerResponse.Yyyyy);
            */
	    }
    }
}
