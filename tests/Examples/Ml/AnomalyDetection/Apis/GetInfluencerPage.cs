using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Ml.AnomalyDetection.Apis
{
	public class GetInfluencerPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("ml/anomaly-detection/apis/get-influencer.asciidoc:128")]
		public void Line128()
		{
			// tag::5bbccf103107e505c17ae59863753efd[]
			var response0 = new SearchResponse<object>();
			// end::5bbccf103107e505c17ae59863753efd[]

			response0.MatchesExample(@"GET _ml/anomaly_detectors/high_sum_total_sales/results/influencers
			{
			  ""sort"": ""influencer_score"",
			  ""desc"": true
			}");
		}
	}
}