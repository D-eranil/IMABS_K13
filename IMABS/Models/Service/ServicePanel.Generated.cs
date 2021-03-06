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

[assembly: RegisterDocumentType(ServicePanel.CLASS_NAME, typeof(ServicePanel))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type ServicePanel.
	/// </summary>
	public partial class ServicePanel : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.ServicePanel";


		/// <summary>
		/// The instance of the class that provides extended API for working with ServicePanel fields.
		/// </summary>
		private readonly ServicePanelFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ServicePanelID.
		/// </summary>
		[DatabaseIDField]
		public int ServicePanelID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ServicePanelID"), 0);
			}
			set
			{
				SetValue("ServicePanelID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Title
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Title"), @"");
			}
			set
			{
				SetValue("Title", value);
			}
		}


		/// <summary>
		/// Sub title.
		/// </summary>
		[DatabaseField]
		public string SubTItle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SubTItle"), @"");
			}
			set
			{
				SetValue("SubTItle", value);
			}
		}


		/// <summary>
		/// Link text.
		/// </summary>
		[DatabaseField]
		public string LinkText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("LinkText"), @"");
			}
			set
			{
				SetValue("LinkText", value);
			}
		}


		/// <summary>
		/// Link url.
		/// </summary>
		[DatabaseField]
		public string LinkUrl
		{
			get
			{
				return ValidationHelper.GetString(GetValue("LinkUrl"), @"");
			}
			set
			{
				SetValue("LinkUrl", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ServicePanel fields.
		/// </summary>
		[RegisterProperty]
		public ServicePanelFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ServicePanel fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ServicePanelFields : AbstractHierarchicalObject<ServicePanelFields>
		{
			/// <summary>
			/// The content item of type ServicePanel that is a target of the extended API.
			/// </summary>
			private readonly ServicePanel mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ServicePanelFields" /> class with the specified content item of type ServicePanel.
			/// </summary>
			/// <param name="instance">The content item of type ServicePanel that is a target of the extended API.</param>
			public ServicePanelFields(ServicePanel instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ServicePanelID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ServicePanelID;
				}
				set
				{
					mInstance.ServicePanelID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.Title;
				}
				set
				{
					mInstance.Title = value;
				}
			}


			/// <summary>
			/// Sub title.
			/// </summary>
			public string SubTItle
			{
				get
				{
					return mInstance.SubTItle;
				}
				set
				{
					mInstance.SubTItle = value;
				}
			}


			/// <summary>
			/// Link text.
			/// </summary>
			public string LinkText
			{
				get
				{
					return mInstance.LinkText;
				}
				set
				{
					mInstance.LinkText = value;
				}
			}


			/// <summary>
			/// Link url.
			/// </summary>
			public string LinkUrl
			{
				get
				{
					return mInstance.LinkUrl;
				}
				set
				{
					mInstance.LinkUrl = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ServicePanel" /> class.
		/// </summary>
		public ServicePanel() : base(CLASS_NAME)
		{
			mFields = new ServicePanelFields(this);
		}

		#endregion
	}
}