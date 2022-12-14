using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Leuka.Models.Generated;
using Umbraco.Core.Models;

namespace Leuka.Core.ViewModels.Shared
{
	public class ImageViewModel
	{
		public ImageViewModel(string url, string urlAbsolute, string type, 
			int width, int height, string alternateText = null)
		{
			Url = url;
			UrlAbsolute = urlAbsolute;
			Type = type;
			Width = width;
			Height = height;
			AlternateText = alternateText;
		}

		public ImageViewModel(Image image) 
			: this(image.Url(), image.MediaUrl(mode: UrlMode.Absolute), image.Type,
				  image.Width, image.Height, string.IsNullOrWhiteSpace(image.AlternateText) ? image.Name : image.AlternateText)
		{ }

		public ImageViewModel(MediaWithCrops mediaWithCrops)
			: this(mediaWithCrops.Url, mediaWithCrops.MediaUrl(mode: UrlMode.Absolute), mediaWithCrops.ContentType.Alias,
				  mediaWithCrops.Value<int>("umbracoWidth"), mediaWithCrops.Value<int>("umbracoHeight"), null)
		{
			
		}

		public string Url { get; }
		public string UrlAbsolute { get; }
		public string Type { get; }
		public int Width { get; }
		public int Height { get; }
		public string AlternateText { get; }
	}
}
