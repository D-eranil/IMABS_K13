//--------------------------------------------------------------------------------------------------
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

[assembly: RegisterDocumentType(Footer.CLASS_NAME, typeof(Footer))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type Footer.
	/// </summary>
	public partial class Footer : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.Footer";


		/// <summary>
		/// The instance of the class that provides extended API for working with Footer fields.
		/// </summary>
		private readonly FooterFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// FooterID.
		/// </summary>
		[DatabaseIDField]
		public int FooterID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("FooterID"), 0);
			}
			set
			{
				SetValue("FooterID", value);
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
		/// Gets an object that provides extended API for working with Footer fields.
		/// </summary>
		[RegisterProperty]
		public FooterFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Footer fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class FooterFields : AbstractHierarchicalObject<FooterFields>
		{
			/// <summary>
			/// The content item of type Footer that is a target of the extended API.
			/// </summary>
			private readonly Footer mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="FooterFields" /> class with the specified content item of type Footer.
			/// </summary>
			/// <param name="instance">The content item of type Footer that is a target of the extended API.</param>
			public FooterFields(Footer instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// FooterID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.FooterID;
				}
				set
				{
					mInstance.FooterID = value;
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
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Footer" /> class.
		/// </summary>
		public Footer() : base(CLASS_NAME)
		{
			mFields = new FooterFields(this);
		}

		#endregion
	}
}