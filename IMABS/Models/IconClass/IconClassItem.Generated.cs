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
using CMS.CustomTables.Types.IMABS;
using CMS.CustomTables;

[assembly: RegisterCustomTable(IconClassItem.CLASS_NAME, typeof(IconClassItem))]

namespace CMS.CustomTables.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type IconClassItem.
	/// </summary>
	public partial class IconClassItem : CustomTableItem
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.IconClass";


		/// <summary>
		/// The instance of the class that provides extended API for working with IconClassItem fields.
		/// </summary>
		private readonly IconClassItemFields mFields;

		#endregion


		#region "Properties"

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
		/// Value.
		/// </summary>
		[DatabaseField]
		public string Value
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Value"), @"");
			}
			set
			{
				SetValue("Value", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with IconClassItem fields.
		/// </summary>
		[RegisterProperty]
		public IconClassItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with IconClassItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class IconClassItemFields : AbstractHierarchicalObject<IconClassItemFields>
		{
			/// <summary>
			/// The content item of type IconClassItem that is a target of the extended API.
			/// </summary>
			private readonly IconClassItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="IconClassItemFields" /> class with the specified content item of type IconClassItem.
			/// </summary>
			/// <param name="instance">The content item of type IconClassItem that is a target of the extended API.</param>
			public IconClassItemFields(IconClassItem instance)
			{
				mInstance = instance;
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
			/// Value.
			/// </summary>
			public string Value
			{
				get
				{
					return mInstance.Value;
				}
				set
				{
					mInstance.Value = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="IconClassItem" /> class.
		/// </summary>
		public IconClassItem() : base(CLASS_NAME)
		{
			mFields = new IconClassItemFields(this);
		}

		#endregion
	}
}