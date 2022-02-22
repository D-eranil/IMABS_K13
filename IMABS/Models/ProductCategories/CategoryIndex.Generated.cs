﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(CategoryIndex.CLASS_NAME, typeof(CategoryIndex))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type CategoryIndex.
	/// </summary>
	public partial class CategoryIndex : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.CategoryIndex";


		/// <summary>
		/// The instance of the class that provides extended API for working with CategoryIndex fields.
		/// </summary>
		private readonly CategoryIndexFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// CategoryIndexID.
		/// </summary>
		[DatabaseIDField]
		public int CategoryIndexID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("CategoryIndexID"), 0);
			}
			set
			{
				SetValue("CategoryIndexID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// Enable CTA banner?.
		/// </summary>
		[DatabaseField]
		public bool EnableCallToTactionBanner
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnableCallToTactionBanner"), false);
			}
			set
			{
				SetValue("EnableCallToTactionBanner", value);
			}
		}


		/// <summary>
		/// Enable promotions banner?.
		/// </summary>
		[DatabaseField]
		public bool EnablePromotionsBanner
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnablePromotionsBanner"), false);
			}
			set
			{
				SetValue("EnablePromotionsBanner", value);
			}
		}


		/// <summary>
		/// Enable Breadcrumb?.
		/// </summary>
		[DatabaseField]
		public bool EnableBreadcrumb
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnableBreadcrumb"), false);
			}
			set
			{
				SetValue("EnableBreadcrumb", value);
			}
		}


		/// <summary>
		/// Visible In Header?.
		/// </summary>
		[DatabaseField]
		public bool AllowToViewInHeader
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("AllowToViewInHeader"), false);
			}
			set
			{
				SetValue("AllowToViewInHeader", value);
			}
		}


		/// <summary>
		/// Visible In Footer?.
		/// </summary>
		[DatabaseField]
		public bool AllowToViewInFooter
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("AllowToViewInFooter"), false);
			}
			set
			{
				SetValue("AllowToViewInFooter", value);
			}
		}


		/// <summary>
		/// Title.
		/// </summary>
		[DatabaseField]
		public string MainTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MainTitle"), @"Product Category");
			}
			set
			{
				SetValue("MainTitle", value);
			}
		}


		/// <summary>
		/// Sub category title.
		/// </summary>
		[DatabaseField]
		public string SubCategoryTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SubCategoryTitle"), @"We stock the following sub-categories");
			}
			set
			{
				SetValue("SubCategoryTitle", value);
			}
		}


		/// <summary>
		/// Brand Title.
		/// </summary>
		[DatabaseField]
		public string BrandTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("BrandTitle"), @"Brands we work with");
			}
			set
			{
				SetValue("BrandTitle", value);
			}
		}


		/// <summary>
		/// Resource title.
		/// </summary>
		[DatabaseField]
		public string ResourceTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ResourceTitle"), @"Resources & Support");
			}
			set
			{
				SetValue("ResourceTitle", value);
			}
		}


		/// <summary>
		/// Resource description.
		/// </summary>
		[DatabaseField]
		public string ResourceDescription
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ResourceDescription"), @"We offer you a dedicated team that understands your business needs and can deliver qualified, effective support for your sales efforts.");
			}
			set
			{
				SetValue("ResourceDescription", value);
			}
		}


		/// <summary>
		/// Popup title.
		/// </summary>
		[DatabaseField]
		public string PopupTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("PopupTitle"), @"Let us know who you are");
			}
			set
			{
				SetValue("PopupTitle", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with CategoryIndex fields.
		/// </summary>
		[RegisterProperty]
		public CategoryIndexFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with CategoryIndex fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class CategoryIndexFields : AbstractHierarchicalObject<CategoryIndexFields>
		{
			/// <summary>
			/// The content item of type CategoryIndex that is a target of the extended API.
			/// </summary>
			private readonly CategoryIndex mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="CategoryIndexFields" /> class with the specified content item of type CategoryIndex.
			/// </summary>
			/// <param name="instance">The content item of type CategoryIndex that is a target of the extended API.</param>
			public CategoryIndexFields(CategoryIndex instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// CategoryIndexID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.CategoryIndexID;
				}
				set
				{
					mInstance.CategoryIndexID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}


			/// <summary>
			/// Enable CTA banner?.
			/// </summary>
			public bool EnableCallToTactionBanner
			{
				get
				{
					return mInstance.EnableCallToTactionBanner;
				}
				set
				{
					mInstance.EnableCallToTactionBanner = value;
				}
			}


			/// <summary>
			/// Enable promotions banner?.
			/// </summary>
			public bool EnablePromotionsBanner
			{
				get
				{
					return mInstance.EnablePromotionsBanner;
				}
				set
				{
					mInstance.EnablePromotionsBanner = value;
				}
			}


			/// <summary>
			/// Enable Breadcrumb?.
			/// </summary>
			public bool EnableBreadcrumb
			{
				get
				{
					return mInstance.EnableBreadcrumb;
				}
				set
				{
					mInstance.EnableBreadcrumb = value;
				}
			}


			/// <summary>
			/// Visible In Header?.
			/// </summary>
			public bool AllowToViewInHeader
			{
				get
				{
					return mInstance.AllowToViewInHeader;
				}
				set
				{
					mInstance.AllowToViewInHeader = value;
				}
			}


			/// <summary>
			/// Visible In Footer?.
			/// </summary>
			public bool AllowToViewInFooter
			{
				get
				{
					return mInstance.AllowToViewInFooter;
				}
				set
				{
					mInstance.AllowToViewInFooter = value;
				}
			}


			/// <summary>
			/// Title.
			/// </summary>
			public string MainTitle
			{
				get
				{
					return mInstance.MainTitle;
				}
				set
				{
					mInstance.MainTitle = value;
				}
			}


			/// <summary>
			/// Sub category title.
			/// </summary>
			public string SubCategoryTitle
			{
				get
				{
					return mInstance.SubCategoryTitle;
				}
				set
				{
					mInstance.SubCategoryTitle = value;
				}
			}


			/// <summary>
			/// Brand Title.
			/// </summary>
			public string BrandTitle
			{
				get
				{
					return mInstance.BrandTitle;
				}
				set
				{
					mInstance.BrandTitle = value;
				}
			}


			/// <summary>
			/// Resource title.
			/// </summary>
			public string ResourceTitle
			{
				get
				{
					return mInstance.ResourceTitle;
				}
				set
				{
					mInstance.ResourceTitle = value;
				}
			}


			/// <summary>
			/// Resource description.
			/// </summary>
			public string ResourceDescription
			{
				get
				{
					return mInstance.ResourceDescription;
				}
				set
				{
					mInstance.ResourceDescription = value;
				}
			}


			/// <summary>
			/// Popup title.
			/// </summary>
			public string PopupTitle
			{
				get
				{
					return mInstance.PopupTitle;
				}
				set
				{
					mInstance.PopupTitle = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="CategoryIndex" /> class.
		/// </summary>
		public CategoryIndex() : base(CLASS_NAME)
		{
			mFields = new CategoryIndexFields(this);
		}

		#endregion
	}
}