﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Utf8Json;

namespace Nest
{
	[DataContract]
	public class IndexSegment
	{
		[DataMember(Name ="shards")]
		[JsonFormatter(typeof(VerbatimDictionaryInterfaceKeysFormatter<string, ShardsSegment>))]
		public IReadOnlyDictionary<string, ShardsSegment> Shards { get; internal set; } =
			EmptyReadOnly<string, ShardsSegment>.Dictionary;
	}
}
