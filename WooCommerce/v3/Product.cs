﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WooCommerceNET.Base;

namespace WooCommerceNET.WooCommerce.v3
{
    public class ProductBatch : BatchObject<Product> { }

    [DataContract]
    public class Product : JsonObject
    {
        public static string Endpoint { get { return "products"; } }

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>
        /// Product slug.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string slug { get; set; }

        /// <summary>
        /// Product URL. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string permalink { get; set; }

        /// <summary>
        /// The date the product was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// The date the product was created, as GMT. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created_gmt { get; set; }

        /// <summary>
        /// The date the product was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_modified { get; set; }

        /// <summary>
        /// The date the product was last modified, as GMT. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_modified_gmt { get; set; }

        /// <summary>
        /// Product type. Options: simple, grouped, external and variable. Default is simple.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string type { get; set; }

        /// <summary>
        /// Product status (post status). Options: draft, pending, private and publish. Default is publish.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string status { get; set; }

        /// <summary>
        /// Featured product. Default is false.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? featured { get; set; }

        /// <summary>
        /// Catalog visibility. Options: visible, catalog, search and hidden. Default is visible.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string catalog_visibility { get; set; }

        /// <summary>
        /// Product description.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }

        /// <summary>
        /// Product short description.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string short_description { get; set; }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string sku { get; set; }
        
        [DataMember(EmitDefaultValue = false, Name = "price")]
        protected object priceValue { get; set; }
        /// <summary>
        /// Current product price. 
        /// read-only
        /// </summary>
        public decimal? price { get; set; }
        
        [DataMember(EmitDefaultValue = false, Name = "regular_price")]
        protected object regular_priceValue { get; set; }
        /// <summary>
        /// Product regular price.
        /// </summary>
        public decimal? regular_price { get; set; }
        
        [DataMember(EmitDefaultValue = false, Name = "sale_price")]
        protected object sale_priceValue { get; set; }
        /// <summary>
        /// Product sale price.
        /// </summary>
        public decimal? sale_price { get; set; }

        /// <summary>
        /// Start date of sale price, in the site’s timezone.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_on_sale_from { get; set; }

        /// <summary>
        /// Start date of sale price, as GMT.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_on_sale_from_gmt { get; set; }

        /// <summary>
        /// End date of sale price, in the site’s timezone.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_on_sale_to { get; set; }

        /// <summary>
        /// End date of sale price, in the site’s timezone.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_on_sale_to_gmt { get; set; }

        /// <summary>
        /// Price formatted in HTML. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string price_html { get; set; }

        /// <summary>
        /// Shows if the product is on sale. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? on_sale { get; set; }

        /// <summary>
        /// Shows if the product can be bought. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? purchasable { get; set; }

        /// <summary>
        /// Amount of sales. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? total_sales { get; set; }

        /// <summary>
        /// If the product is virtual. Default is false.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "virtual")]
        public bool? _virtual { get; set; }

        /// <summary>
        /// If the product is downloadable. Default is false.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? downloadable { get; set; }

        /// <summary>
        /// List of downloadable files. See Product - Downloads properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ProductDownloadLine> downloads { get; set; }

        /// <summary>
        /// Number of times downloadable files can be downloaded after purchase. Default is -1.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? download_limit { get; set; }

        /// <summary>
        /// Number of days until access to downloadable files expires. Default is -1.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? download_expiry { get; set; }

        /// <summary>
        /// Product external URL. Only for external products.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string external_url { get; set; }

        /// <summary>
        /// Product external button text. Only for external products.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string button_text { get; set; }

        /// <summary>
        /// Tax status. Options: taxable, shipping and none. Default is taxable.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string tax_status { get; set; }

        /// <summary>
        /// Tax class.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string tax_class { get; set; }

        /// <summary>
        /// Stock management at product level. Default is false.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? manage_stock { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "stock_quantity")]
        private object stock_quantityValue { get; set; }
        /// <summary>
        /// Stock quantity.
        /// </summary>
        public int? stock_quantity { get; set; }

        /// <summary>
        /// Controls the stock status of the product. Options: instock, outofstock, onbackorder. Default is instock.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string stock_status { get; set; }

        /// <summary>
        /// If managing stock, this controls if backorders are allowed. Options: no, notify and yes. Default is no.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string backorders { get; set; }

        /// <summary>
        /// Shows if backorders are allowed. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? backorders_allowed { get; set; }

        /// <summary>
        /// Shows if the product is on backordered. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? backordered { get; set; }

        /// <summary>
        /// Allow one item to be bought in a single order. Default is false.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? sold_individually { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "weight")]
        protected object weightValue { get; set; }
        /// <summary>
        /// Product weight (kg).
        /// </summary>
        [ Obsolete( "Do not use. Unclear weight units. For v3 api weight_unit is determined based on the country. There's a store-wide setting but no way to get it through the api. There's an api endpoint with the list of countries. But products don't have a country (customers and orders do)" ) ]
        public decimal? weight { get; set; }

        /// <summary>
        /// Product dimensions. See Product - Dimensions properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ProductDimension dimensions { get; set; }

        /// <summary>
        /// Shows if the product need to be shipped. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? shipping_required { get; set; }

        /// <summary>
        /// Shows whether or not the product shipping is taxable. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? shipping_taxable { get; set; }

        /// <summary>
        /// Shipping class slug.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string shipping_class { get; set; }

        /// <summary>
        /// Shipping class ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string shipping_class_id { get; set; }

        /// <summary>
        /// Allow reviews. Default is true.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? reviews_allowed { get; set; }

        /// <summary>
        /// Reviews average rating. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string average_rating { get; set; }

        /// <summary>
        /// Amount of reviews that the product have. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? rating_count { get; set; }

        /// <summary>
        /// List of related products IDs. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<int> related_ids { get; set; }

        /// <summary>
        /// List of up-sell products IDs.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<int> upsell_ids { get; set; }

        /// <summary>
        /// List of cross-sell products IDs.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<int> cross_sell_ids { get; set; }

        /// <summary>
        /// Product parent ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? parent_id { get; set; }

        /// <summary>
        /// Optional note to send the customer after purchase.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchase_note { get; set; }

        /// <summary>
        /// List of categories. See Product - Categories properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ProductCategoryLine> categories { get; set; }

        /// <summary>
        /// List of tags. See Product - Tags properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ProductTagLine> tags { get; set; }

        /// <summary>
        /// List of images. See Product - Images properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ProductImage> images { get; set; }

        /// <summary>
        /// List of attributes. See Product - Attributes properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ProductAttributeLine> attributes { get; set; }

        /// <summary>
        /// Defaults variation attributes. See Product - Default attributes properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ProductDefaultAttribute> default_attributes { get; set; }

        /// <summary>
        /// List of variations IDs. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<int> variations { get; set; }

        /// <summary>
        /// List of grouped products ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<int> grouped_products { get; set; }

        /// <summary>
        /// Menu order, used to custom sort products.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? menu_order { get; set; }

        /// <summary>
        /// Meta data. See Product - Meta data properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ProductMeta> meta_data { get; set; }

    }

    [DataContract]
    public class ProductDownloadLine : v2.ProductDownloadLine { }

    [DataContract]
    public class ProductDimension : v2.ProductDimension { }

    [DataContract]
    public class ProductCategoryLine : v2.ProductCategoryLine { }

    [DataContract]
    public class ProductTagLine : v2.ProductTagLine { }
    
    [DataContract]
    public class ProductImage
    {
        /// <summary>
        /// Image ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// The date the image was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// The date the image was created, as GMT. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created_gmt { get; set; }

        /// <summary>
        /// The date the image was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_modified { get; set; }

        /// <summary>
        /// The date the image was last modified, as GMT. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_modified_gmt { get; set; }

        /// <summary>
        /// Image URL.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string src { get; set; }

        /// <summary>
        /// Image name.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>
        /// Image alternative text.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string alt { get; set; }
    }

    [DataContract]
    public class ProductAttributeLine : v2.ProductAttributeLine { }

    [DataContract]
    public class ProductDefaultAttribute : v2.ProductDefaultAttribute { }

    [DataContract]
    public class ProductMeta : v2.ProductMeta { }

    [DataContract]
    public class ProductReview
    {
        public static string Endpoint { get { return "reviews"; } }

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// The date the review was created, in the site’s timezone.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// The date the review was created, as GMT.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created_gmt { get; set; }

        /// <summary>
        /// Unique identifier for the product that the review belongs to.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? product_id { get; set; }

        /// <summary>
        /// Status of the review. Options: approved, hold, spam, unspam, transh and untrash. Defauls to approved.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string status { get; set; }

        /// <summary>
        /// Reviewer name. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string reviewer { get; set; }

        /// <summary>
        /// Reviewer email. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string reviewer_email { get; set; }

        /// <summary>
        /// The content of the review. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string review { get; set; }

        /// <summary>
        /// Review rating (0 to 5).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? rating { get; set; }
        
        /// <summary>
        /// Shows if the reviewer bought the product or not. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? verified { get; set; }
    }

}
