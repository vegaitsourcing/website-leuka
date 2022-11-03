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
	/// <summary>Article</summary>
	[PublishedModel("article")]
	public partial class Article : PublishedContentModel, IFooter, IHeader, IPage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "article";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Article, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Article(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Author Details
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("authorDetails")]
		public IEnumerable<AuthorDetails> AuthorDetails => this.Value<IEnumerable<AuthorDetails>>("authorDetails");

		///<summary>
		/// Headline Info
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("headlineInfo")]
		public IEnumerable<TitleDescriptionAndButton> HeadlineInfo => this.Value<IEnumerable<TitleDescriptionAndButton>>("headlineInfo");

		///<summary>
		/// Page Details
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("pageDetails")]
		public IHtmlString PageDetails => this.Value<IHtmlString>("pageDetails");

		///<summary>
		/// Preview image: This image will be shown on the article preview
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("previewImage")]
		public Image PreviewImage => this.Value<Image>("previewImage");

		///<summary>
		/// Preview text: This text will be shown as a description on the article preview
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("previewText")]
		public string PreviewText => this.Value<string>("previewText");

		///<summary>
		/// Related Articles
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("relatedArticles")]
		public IEnumerable<RelatedArticles> RelatedArticles => this.Value<IEnumerable<RelatedArticles>>("relatedArticles");

		///<summary>
		/// Tags
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("tags")]
		public IEnumerable<string> Tags => this.Value<IEnumerable<string>>("tags");

		///<summary>
		/// App Store URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("appStoreURL")]
		public Umbraco.Web.Models.Link AppStoreUrl => Footer.GetAppStoreUrl(this);

		///<summary>
		/// Contact Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("contactEmail")]
		public string ContactEmail => Footer.GetContactEmail(this);

		///<summary>
		/// Copyright Text: The site copyright text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("copyrightText")]
		public string CopyrightText => Footer.GetCopyrightText(this);

		///<summary>
		/// Facebook URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("facebookURL")]
		public Umbraco.Web.Models.Link FacebookUrl => Footer.GetFacebookUrl(this);

		///<summary>
		/// FooterLinks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("footerLinks")]
		public IEnumerable<Umbraco.Web.Models.Link> FooterLinks => Footer.GetFooterLinks(this);

		///<summary>
		/// Footer Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("footerLogo")]
		public Image FooterLogo => Footer.GetFooterLogo(this);

		///<summary>
		/// Instagram URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("instagramURL")]
		public Umbraco.Web.Models.Link InstagramUrl => Footer.GetInstagramUrl(this);

		///<summary>
		/// MediaLinks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("mediaLinks")]
		public IEnumerable<Umbraco.Web.Models.Link> MediaLinks => Footer.GetMediaLinks(this);

		///<summary>
		/// Play Store URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("playStoreURL")]
		public Umbraco.Web.Models.Link PlayStoreUrl => Footer.GetPlayStoreUrl(this);

		///<summary>
		/// Separator
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("separator")]
		public IEnumerable<Separator> Separator => Footer.GetSeparator(this);

		///<summary>
		/// Twitter URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("twitterURL")]
		public Umbraco.Web.Models.Link TwitterUrl => Footer.GetTwitterUrl(this);

		///<summary>
		/// Donation Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("donationButton")]
		public IEnumerable<Button> DonationButton => Header.GetDonationButton(this);

		///<summary>
		/// Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("links")]
		public IEnumerable<Umbraco.Web.Models.Link> Links => Header.GetLinks(this);

		///<summary>
		/// Logo: The site logo image.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("logo")]
		public Image Logo => Header.GetLogo(this);

		///<summary>
		/// PopupDonate
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("popupDonate")]
		public IEnumerable<DonatePopup> PopupDonate => Header.GetPopupDonate(this);

		///<summary>
		/// ThanksPopup
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("thanksPopup")]
		public IEnumerable<ThankyouPopup> ThanksPopup => Header.GetThanksPopup(this);

		///<summary>
		/// Alternate Languages: Language codes (en-US, en-GB etc).
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("alternateLanguages")]
		public IEnumerable<string> AlternateLanguages => Page.GetAlternateLanguages(this);

		///<summary>
		/// Canonical Link: The page canonical link.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("canonicalLink")]
		public Umbraco.Web.Models.Link CanonicalLink => Page.GetCanonicalLink(this);

		///<summary>
		/// External Redirect: Redirects to provided external URL.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("externalRedirect")]
		public string ExternalRedirect => Page.GetExternalRedirect(this);

		///<summary>
		/// Hide From Search Engines: Hides page from search engines like Google, Yahoo etc.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideFromSearchEngines")]
		public bool HideFromSearchEngines => Page.GetHideFromSearchEngines(this);

		///<summary>
		/// Hide From Sitemap: If selected, the node will be hidden from the sitemap.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideFromSitemap")]
		public bool HideFromSitemap => Page.GetHideFromSitemap(this);

		///<summary>
		/// Hide From Site Search: Hides page from the site search.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideFromSiteSearch")]
		public bool HideFromSiteSearch => Page.GetHideFromSiteSearch(this);

		///<summary>
		/// Navigation Title: If empty, page title will be used.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("navigationTitle")]
		public string NavigationTitle => Page.GetNavigationTitle(this);

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("openGraphDescription")]
		public string OpenGraphDescription => Page.GetOpenGraphDescription(this);

		///<summary>
		/// Image: Note: Image dimensions should be at least 1200x627 px.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("openGraphImage")]
		public Image OpenGraphImage => Page.GetOpenGraphImage(this);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("openGraphTitle")]
		public string OpenGraphTitle => Page.GetOpenGraphTitle(this);

		///<summary>
		/// Page Title: The page title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => Page.GetPageTitle(this);

		///<summary>
		/// Seo Description: The page SEO description.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoDescription")]
		public string SeoDescription => Page.GetSeoDescription(this);

		///<summary>
		/// Seo Keywords: The page SEO keywords.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoKeywords")]
		public string SeoKeywords => Page.GetSeoKeywords(this);

		///<summary>
		/// Seo Title: The page SEO title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoTitle")]
		public string SeoTitle => Page.GetSeoTitle(this);

		///<summary>
		/// Sitemap Change Frequency: The expected change frequency of the page, associated with the sitemap used by search engines.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("sitemapChangeFrequency")]
		public string SitemapChangeFrequency => Page.GetSitemapChangeFrequency(this);

		///<summary>
		/// Sitemap Priority: Priority of the page, associated with the sitemap used by search engines.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("sitemapPriority")]
		public string SitemapPriority => Page.GetSitemapPriority(this);

		///<summary>
		/// Hide From Site Navigation: If selected, the node will be hidden from site navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => Page.GetUmbracoNaviHide(this);

		///<summary>
		/// Internal Redirect: Redirects to selected Umbraco node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect => Page.GetUmbracoRedirect(this);

		///<summary>
		/// URL Alias: Alternative URLs of the node. Separate with commas.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => Page.GetUmbracoUrlAlias(this);

		///<summary>
		/// URL Name: Enables overriding default URL of the node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName => Page.GetUmbracoUrlName(this);
	}
}
