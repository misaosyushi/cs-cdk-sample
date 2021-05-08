using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Xunit;
using Amazon.Lambda.TestUtilities;

namespace HelloHandler.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestHelloCdkFunction()
        {
            var function = new Function();
            var context = new TestLambdaContext();
            var apiGatewayProxyRequest = new APIGatewayProxyRequest();
            var response = function.FunctionHandler(apiGatewayProxyRequest, context);

            Assert.Equal("Hello CDK!", response.Body);
            Assert.Equal((int) HttpStatusCode.OK, response.StatusCode);
        }
    }
}