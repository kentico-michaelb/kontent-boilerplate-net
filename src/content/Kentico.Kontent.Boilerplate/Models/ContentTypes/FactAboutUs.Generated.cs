// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery;

namespace Kentico.Kontent.Boilerplate.Models
{
    public partial class FactAboutUs
    {
        public const string Codename = "fact_about_us";
        public const string DescriptionCodename = "description";
        public const string TitleCodename = "title";
        public const string SitemapCodename = "sitemap";
        public const string ImageCodename = "image";

        public string Description { get; set; }
        public string Title { get; set; }
        public IEnumerable<TaxonomyTerm> Sitemap { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}