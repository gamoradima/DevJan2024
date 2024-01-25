namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyFreedomUIEventsSchema

	/// <exclude/>
	public class UsrRealtyFreedomUIEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyFreedomUIEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyFreedomUIEventsSchema(UsrRealtyFreedomUIEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2d3b2cfa-51a4-44a0-9424-01d579cb3864");
			Name = "UsrRealtyFreedomUIEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8df8ff32-6761-41be-88ca-e6de63f19f23");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,211,211,3,0,27,182,67,26,3,0,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("31384c56-872f-5469-02c6-4acc5cfcd674"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("8df8ff32-6761-41be-88ca-e6de63f19f23"),
				CreatedInSchemaUId = new Guid("2d3b2cfa-51a4-44a0-9424-01d579cb3864"),
				ModifiedInSchemaUId = new Guid("2d3b2cfa-51a4-44a0-9424-01d579cb3864")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d3b2cfa-51a4-44a0-9424-01d579cb3864"));
		}

		#endregion

	}

	#endregion

}

