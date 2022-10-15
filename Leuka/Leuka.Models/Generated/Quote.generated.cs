//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.6
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Leuka.Models.Generated
{
	/// <summary>Quote</summary>
	[PublishedModel("quote")]
	public partial class Quote : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "quote";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Quote, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Quote(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Image: Image of the person quoting
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("image")]
		public IEnumerable<Image> Image => this.Value<IEnumerable<Image>>("image");

		///<summary>
		/// Job title: Job title of the person quoting
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("jobTitle")]
		public string JobTitle => this.Value<string>("jobTitle");

		///<summary>
		/// Quotator name: Name of the person quoting
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("quotatorName")]
		public string QuotatorName => this.Value<string>("quotatorName");

		///<summary>
		/// Quote text: Quote text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("quoteText")]
		public string QuoteText => this.Value<string>("quoteText");
	}
}