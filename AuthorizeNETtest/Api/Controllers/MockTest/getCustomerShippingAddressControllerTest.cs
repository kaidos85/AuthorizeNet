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
    public class getCustomerShippingAddressTest : ApiCoreTestBase 
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
	    public void MockgetCustomerShippingAddressTest()
	    {
		    //define all mocked objects as final
            var mockController = GetMockController<getCustomerShippingAddressRequest, getCustomerShippingAddressResponse>();
            var mockRequest = new getCustomerShippingAddressRequest
                {
                    merchantAuthentication = new merchantAuthenticationType {name = "mocktest", Item = "mockKey", ItemElementName = ItemChoiceType.transactionKey},
                };
            var customerAddressExType = new customerAddressExType
                {
                    customerAddressId = "1234",
                };
            var mockResponse = new getCustomerShippingAddressResponse
                {
                    refId = "1234",
                    sessionToken = "sessiontoken",
                    address = customerAddressExType,
                };

		    var errorResponse = new ANetApiResponse();
		    var results = new List<String>();
            const messageTypeEnum messageTypeOk = messageTypeEnum.Ok;

            SetMockControllerExpectations<getCustomerShippingAddressRequest, getCustomerShippingAddressResponse, getCustomerShippingAddressController>(
                mockController.Object, mockRequest, mockResponse, errorResponse, results, messageTypeOk);
            mockController.Object.Execute(AuthorizeNet.Environment.CUSTOM);
            //mockController.Object.Execute();
            // or var controllerResponse = mockController.Object.ExecuteWithApiResponse(AuthorizeNet.Environment.CUSTOM);
            var controllerResponse = mockController.Object.GetApiResponse();
            ClassicAssert.IsNotNull(controllerResponse);

            ClassicAssert.IsNotNull(controllerResponse.address);
            LogHelper.info(Logger, "getCustomerShippingAddress: Details:{0}", controllerResponse.address);
	    }
    }
}
