using Amazon.CDK;
using Amazon.CDK.AWS.APIGateway;
using Amazon.CDK.AWS.Lambda;

namespace CsCdkSample
{
    public class CsCdkSampleStack : Stack
    {
        internal CsCdkSampleStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var helloLambda = new Function(this, "HelloHandler", new FunctionProps
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("./lambda/HelloHandler/src/HelloHandler/bin/Debug/netcoreapp3.1/publish"),
                Handler = "HelloHandler::HelloHandler.Function::FunctionHandler"
            });

            new LambdaRestApi(this, "HelloApi", new LambdaRestApiProps
            {
                Handler = helloLambda
            });
        }
    }
}