using System;
using System.Collections.Specialized;
using System.Net.Http;
using Leuka.Common;

namespace Leuka.Core.Models
{
	public class Page
	{
		private readonly Uri _currentUri;

		public Page(int index, bool isActive, Uri currentUri)
		{
			if (index <= 0) throw new ArgumentOutOfRangeException(nameof(index));

			_currentUri = currentUri ?? throw new ArgumentNullException(nameof(currentUri));

			Index = index;
			IsActive = isActive;
			Url = GetPageUrl();
		}

		public int Index { get; }
		public bool IsActive { get; }
		public string Url { get; }

		private string GetPageUrl()
		{
			NameValueCollection queryString = _currentUri.ParseQueryString();
			queryString[Common.Constants.RequestParameters.Page] = Index.ToString();

			return $"{_currentUri.AbsolutePath}?{queryString}";
		}
	}
}
