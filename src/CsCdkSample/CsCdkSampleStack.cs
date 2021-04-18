using Amazon.CDK;
using Amazon.CDK.AWS.S3;

namespace CsCdkSample
{
    public class CsCdkSampleStack : Stack
    {
        internal CsCdkSampleStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var bucket = new Bucket(this, "CsCdkSampleBucket", new BucketProps {
                Versioned = true
            });
        }
    }
}
