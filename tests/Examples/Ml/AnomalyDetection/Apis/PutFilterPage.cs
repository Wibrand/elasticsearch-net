using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Ml.AnomalyDetection.Apis
{
	public class PutFilterPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("ml/anomaly-detection/apis/put-filter.asciidoc:52")]
		public void Line52()
		{
			// tag::b4aec2a1d353852507c091bdb629b765[]
			var response0 = new SearchResponse<object>();
			// end::b4aec2a1d353852507c091bdb629b765[]

			response0.MatchesExample(@"PUT _ml/filters/safe_domains
			{
			  ""description"": ""A list of safe domains"",
			  ""items"": [""*.google.com"", ""wikipedia.org""]
			}");
		}
	}
}