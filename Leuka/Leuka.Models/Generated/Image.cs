using Umbraco.Core.Models.PublishedContent;
using Umbraco.ModelsBuilder;
using Leuka.Models.MediaTypes;

namespace Leuka.Models.Generated
{
	/// <summary>
	/// Image media type model.
	/// </summary>
	[RenamePropertyType("umbracoExtension", "Type")]
	[RenamePropertyType("umbracoFile", "Cropper")]
	[RenamePropertyType("umbracoHeight", "Height")]
	[RenamePropertyType("umbracoWidth", "Width")]
	[RenamePropertyType("umbracoBytes", "Size")]
	public partial class Image : PublishedContentModel, IMedia
	{
	}
}
