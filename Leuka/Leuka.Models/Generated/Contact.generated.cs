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
	/// <summary>Contact</summary>
	[PublishedModel("contact")]
	public partial class Contact : PublishedContentModel, IFooter, IHeader, IPage, ISiteSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "contact";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Contact(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// App promo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("appPromo")]
		public IEnumerable<AppPromotion> AppPromo => this.Value<IEnumerable<AppPromotion>>("appPromo");

		///<summary>
		/// Contact us
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("contactUs")]
		public IEnumerable<Contactus> ContactUs => this.Value<IEnumerable<Contactus>>("contactUs");

		///<summary>
		/// Notification
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("notification")]
		public IEnumerable<ContactAndHowToHelpNotification> Notification => this.Value<IEnumerable<ContactAndHowToHelpNotification>>("notification");

		///<summary>
		/// Page description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("pageDescription")]
		public string PageDescription => this.Value<string>("pageDescription");

		///<summary>
		/// Page post description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("pagePostDescription")]
		public string PagePostDescription => this.Value<string>("pagePostDescription");

		///<summary>
		/// Quote
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("quote")]
		public IEnumerable<Quote> Quote => this.Value<IEnumerable<Quote>>("quote");

		///<summary>
		/// Separator 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("separator1")]
		public IEnumerable<Separator> Separator1 => this.Value<IEnumerable<Separator>>("separator1");

		///<summary>
		/// Separator 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("separator2")]
		public IEnumerable<Separator> Separator2 => this.Value<IEnumerable<Separator>>("separator2");

		///<summary>
		/// Separator 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("separator3")]
		public IEnumerable<Separator> Separator3 => this.Value<IEnumerable<Separator>>("separator3");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");

		///<summary>
		/// Top text block
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("topTextBlock")]
		public IEnumerable<TitleDescriptionAndButton> TopTextBlock => this.Value<IEnumerable<TitleDescriptionAndButton>>("topTextBlock");

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

		///<summary>
		/// Canonical Domain: The site canonical domain.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("canonicalDomain")]
		public string CanonicalDomain => SiteSettings.GetCanonicalDomain(this);

		///<summary>
		/// Cookie Script
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("cookieScript")]
		public string CookieScript => SiteSettings.GetCookieScript(this);

		///<summary>
		/// Google Analytics Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("googleAnalyticsScriptCode")]
		public string GoogleAnalyticsScriptCode => SiteSettings.GetGoogleAnalyticsScriptCode(this);

		///<summary>
		/// Google Tag Manager Non-Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("googleTagManagerNonScriptCode")]
		public string GoogleTagManagerNonScriptCode => SiteSettings.GetGoogleTagManagerNonScriptCode(this);

		///<summary>
		/// Google Tag Manager Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("googleTagManagerScriptCode")]
		public string GoogleTagManagerScriptCode => SiteSettings.GetGoogleTagManagerScriptCode(this);

		///<summary>
		/// Hide All Pages From Search Engines: This will create robots meta tag with "noindex,nofollow" value. Note: this should be unchecked on the live site.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideAllPagesFromSearchEngines")]
		public bool HideAllPagesFromSearchEngines => SiteSettings.GetHideAllPagesFromSearchEngines(this);

		///<summary>
		/// Port
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("port")]
		public string Port => SiteSettings.GetPort(this);

		///<summary>
		/// Receiver Email Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("receiverEmailAddress")]
		public string ReceiverEmailAddress => SiteSettings.GetReceiverEmailAddress(this);

		///<summary>
		/// Robots: Content that will be served when Robots.txt is requested.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("robots")]
		public string Robots => SiteSettings.GetRobots(this);

		///<summary>
		/// Sender Email Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("senderEmailAddress")]
		public string SenderEmailAddress => SiteSettings.GetSenderEmailAddress(this);

		///<summary>
		/// Sender Email Password
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("senderEmailPassword")]
		public string SenderEmailPassword => SiteSettings.GetSenderEmailPassword(this);

		///<summary>
		/// Server Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("serverAddress")]
		public string ServerAddress => SiteSettings.GetServerAddress(this);

		///<summary>
		/// Site Name: The site name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("siteName")]
		public string SiteName => SiteSettings.GetSiteName(this);
	}
}
