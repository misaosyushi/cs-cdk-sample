using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsCdkSample
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new CsCdkSampleStack(app, "CsCdkSampleStack");
            app.Synth();
        }
    }
}
