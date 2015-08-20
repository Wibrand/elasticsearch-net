﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest
{
	/// <summary>
	/// A set of analyzers aimed at analyzing specific language text. 
	/// </summary>
	public interface ILanguageAnalyzer : IAnalyzer
	{
		/// <summary>
		/// A list of stopword to initialize the stop filter with. Defaults to the english stop words.
		/// </summary>
		[JsonProperty("stopwords")]
		IEnumerable<string> StopWords { get; set; }

		/// <summary>
		/// The stem_exclusion parameter allows you to specify an array of lowercase words that should not be stemmed. 
		/// </summary>
		[JsonProperty("stem_exclusion")]
		IEnumerable<string> StemExclusionList { get; set; }

		/// <summary>
		/// A path (either relative to config location, or absolute) to a stopwords file configuration.
		/// </summary>
		[JsonProperty("stopwords_path")]
		string StopwordsPath { get; set; }
	} 

	public class LanguageAnalyzer : AnalyzerBase, ILanguageAnalyzer
	{
		public LanguageAnalyzer(Language language)
		{
			language.ThrowIfNull("language");
			var langName = language.GetStringValue().ToLowerInvariant();
			Type = langName;
		}

		/// </inheritdoc>
		public IEnumerable<string> StopWords { get; set; }

		/// </inheritdoc>
		public IEnumerable<string> StemExclusionList { get; set; }

		/// </inheritdoc>
		public string StopwordsPath { get; set; }
	}

	public class LanguageAnalyzerDescriptor :
		AnalyzerDescriptorBase<LanguageAnalyzerDescriptor, ILanguageAnalyzer>, ILanguageAnalyzer
	{
		private string _type = "language";
		protected override string Type => _type;

		IEnumerable<string> ILanguageAnalyzer.StopWords { get; set; }
		IEnumerable<string> ILanguageAnalyzer.StemExclusionList { get; set; }
		string ILanguageAnalyzer.StopwordsPath { get; set; }

		public LanguageAnalyzerDescriptor Language(Language language)
		{
			language.ThrowIfNull("language");
			var langName = language.GetStringValue().ToLowerInvariant();
			_type = langName;
			return this;
		}
		public LanguageAnalyzerDescriptor StopWords(params string[] stopWords) =>
			Assign(a => a.StopWords = stopWords);

		public LanguageAnalyzerDescriptor StopWords(IEnumerable<string> stopWords) =>
			Assign(a => a.StopWords = stopWords);

	}
}