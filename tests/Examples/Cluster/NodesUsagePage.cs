using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Cluster
{
	public class NodesUsagePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("cluster/nodes-usage.asciidoc:61")]
		public void Line61()
		{
			// tag::3d6a56dd3d93ece0e3da3fb66b4696d3[]
			var response0 = new SearchResponse<object>();
			// end::3d6a56dd3d93ece0e3da3fb66b4696d3[]

			response0.MatchesExample(@"GET _nodes/usage");
		}
	}
}