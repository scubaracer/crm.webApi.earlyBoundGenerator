using System;
using System.Dynamic;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;

namespace VW.WebForm.Core.Model.Entities
{
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CrmWebApiEarlyBoundGenerator", "1.0.4.0")]
    public class vw_brand : Entity
    {
		public new const string EntityLogicalName = "vw_brand";
		
		public new const string EntitySetName = "vw_brands";

        public const string PrimaryIdAttribute = "vw_brandid";

		public vw_brand(ExpandoObject expandoObject) : base(expandoObject)
        {
        }

        public vw_brand() 
        {
        }

		#region Properties

		/// <summary>
        ///  Unique identifier of the user who created the record. Уникальный идентификатор пользователя, создавшего запись.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_createdby_value")]
        public EntityReference CreatedBy {
            get => GetAttributeValue<EntityReference>("CreatedBy@odata.bind");
            set => SetAttributeValue("CreatedBy@odata.bind", value);
        }

		/// <summary>
        ///  Date and time when the record was created. Дата и время создания записи.
        /// </summary>

        public DateTime? CreatedOn {
            get => GetAttributeValue<DateTime?>(nameof(CreatedOn));
            set => SetAttributeValue(nameof(CreatedOn), value);
        }

		/// <summary>
        ///  Unique identifier of the delegate user who created the record. Уникальный идентификатор пользователя-делегата, создавшего запись.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_createdonbehalfby_value")]
        public EntityReference CreatedOnBehalfBy {
            get => GetAttributeValue<EntityReference>("CreatedOnBehalfBy@odata.bind");
            set => SetAttributeValue("CreatedOnBehalfBy@odata.bind", value);
        }

		/// <summary>
        ///  Sequence number of the import that created this record. Порядковый номер импорта, в результате которого была создана эта запись.
        /// </summary>

        public int? ImportSequenceNumber {
            get => GetAttributeValue<int?>(nameof(ImportSequenceNumber));
            set => SetAttributeValue(nameof(ImportSequenceNumber), value);
        }

		/// <summary>
        ///  Unique identifier of the user who modified the record. Уникальный идентификатор пользователя, изменившего запись.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_modifiedby_value")]
        public EntityReference ModifiedBy {
            get => GetAttributeValue<EntityReference>("ModifiedBy@odata.bind");
            set => SetAttributeValue("ModifiedBy@odata.bind", value);
        }

		/// <summary>
        ///  Date and time when the record was modified. Дата и время изменения записи.
        /// </summary>

        public DateTime? ModifiedOn {
            get => GetAttributeValue<DateTime?>(nameof(ModifiedOn));
            set => SetAttributeValue(nameof(ModifiedOn), value);
        }

		/// <summary>
        ///  Unique identifier of the delegate user who modified the record. Уникальный идентификатор пользователя-делегата, изменившего запись.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_modifiedonbehalfby_value")]
        public EntityReference ModifiedOnBehalfBy {
            get => GetAttributeValue<EntityReference>("ModifiedOnBehalfBy@odata.bind");
            set => SetAttributeValue("ModifiedOnBehalfBy@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier for the organization Уникальный идентификатор организации
        /// </summary>
        [EntityReferenceAttribute("organizations", "_organizationid_value")]
        public EntityReference OrganizationId {
            get => GetAttributeValue<EntityReference>("OrganizationId@odata.bind");
            set => SetAttributeValue("OrganizationId@odata.bind", value);
        }

		/// <summary>
        ///  Date and time that the record was migrated. Дата и время переноса записи.
        /// </summary>
        [OnlyDate]
        public DateTime? OverriddenCreatedOn {
            get => GetAttributeValue<DateTime?>(nameof(OverriddenCreatedOn));
            set => SetAttributeValue(nameof(OverriddenCreatedOn), value);
        }

		/// <summary>
        ///  Status of the Brand Состояние Марки
        /// </summary>

        public int? statecode {
            get => GetAttributeValue<int?>(nameof(statecode));
            set => SetAttributeValue(nameof(statecode), value);
        }

		/// <summary>
        ///  Reason for the status of the Brand Статус Марки
        /// </summary>

        public int? statuscode {
            get => GetAttributeValue<int?>(nameof(statuscode));
            set => SetAttributeValue(nameof(statuscode), value);
        }

		/// <summary>
        ///  For internal use only. Только для внутреннего использования.
        /// </summary>

        public int? TimeZoneRuleVersionNumber {
            get => GetAttributeValue<int?>(nameof(TimeZoneRuleVersionNumber));
            set => SetAttributeValue(nameof(TimeZoneRuleVersionNumber), value);
        }

		/// <summary>
        ///  Time zone code that was in use when the record was created. Код часового пояса, использовавшийся при создании записи.
        /// </summary>

        public int? UTCConversionTimeZoneCode {
            get => GetAttributeValue<int?>(nameof(UTCConversionTimeZoneCode));
            set => SetAttributeValue(nameof(UTCConversionTimeZoneCode), value);
        }

		/// <summary>
        ///  Version Number Номер версии
        /// </summary>

        public long? VersionNumber {
            get => GetAttributeValue<long?>(nameof(VersionNumber));
            set => SetAttributeValue(nameof(VersionNumber), value);
        }

		/// <summary>
        ///  Unique identifier for Team associated with Brand. 
        /// </summary>
        [EntityReferenceAttribute("teams", "_vw_adminteamid_value")]
        public EntityReference vw_AdminteamId {
            get => GetAttributeValue<EntityReference>("vw_AdminteamId@odata.bind");
            set => SetAttributeValue("vw_AdminteamId@odata.bind", value);
        }

		/// <summary>
        ///   Остаток для рассылки в текущем месяце
        /// </summary>

        public int? vw_availablethismonth {
            get => GetAttributeValue<int?>(nameof(vw_availablethismonth));
            set => SetAttributeValue(nameof(vw_availablethismonth), value);
        }

		/// <summary>
        ///  Unique identifier for entity instances Уникальный идентификатор экземпляров сущности
        /// </summary>

        public Guid? vw_brandId {
            get => GetAttributeValue<Guid?>(nameof(vw_brandId));
            set => SetAttributeValue(nameof(vw_brandId), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_Code {
            get => GetAttributeValue<string>(nameof(vw_Code));
            set => SetAttributeValue(nameof(vw_Code), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_GScode {
            get => GetAttributeValue<string>(nameof(vw_GScode));
            set => SetAttributeValue(nameof(vw_GScode), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_HLDNAcode {
            get => GetAttributeValue<string>(nameof(vw_HLDNAcode));
            set => SetAttributeValue(nameof(vw_HLDNAcode), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsVGR {
            get => GetAttributeValue<bool?>(nameof(vw_IsVGR));
            set => SetAttributeValue(nameof(vw_IsVGR), value);
        }

		/// <summary>
        ///   Лимит марки для рассылки в месяц
        /// </summary>

        public int? vw_monthlylimit {
            get => GetAttributeValue<int?>(nameof(vw_monthlylimit));
            set => SetAttributeValue(nameof(vw_monthlylimit), value);
        }

		/// <summary>
        ///  The name of the custom entity. 
        /// </summary>

        public string vw_name {
            get => GetAttributeValue<string>(nameof(vw_name));
            set => SetAttributeValue(nameof(vw_name), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_RSEcode {
            get => GetAttributeValue<string>(nameof(vw_RSEcode));
            set => SetAttributeValue(nameof(vw_RSEcode), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_SBCode {
            get => GetAttributeValue<string>(nameof(vw_SBCode));
            set => SetAttributeValue(nameof(vw_SBCode), value);
        }

		/// <summary>
        ///  Unique identifier for Team associated with Brand. 
        /// </summary>
        [EntityReferenceAttribute("teams", "_vw_teamid_value")]
        public EntityReference vw_TeamId {
            get => GetAttributeValue<EntityReference>("vw_TeamId@odata.bind");
            set => SetAttributeValue("vw_TeamId@odata.bind", value);
        }



		#endregion Properties

        public class Fields
        {
            public const string Id = "vw_brandid";
            public const string _CreatedBy_value = "_createdby_value";
            public const string _CreatedOnBehalfBy_value = "_createdonbehalfby_value";
            public const string _ModifiedBy_value = "_modifiedby_value";
            public const string _ModifiedOnBehalfBy_value = "_modifiedonbehalfby_value";
            public const string _OrganizationId_value = "_organizationid_value";
            public const string _vw_AdminteamId_value = "_vw_adminteamid_value";
            public const string _vw_TeamId_value = "_vw_teamid_value";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyname";
            public const string CreatedByYomiName = "createdbyyominame";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyname";
            public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyname";
            public const string ModifiedByYomiName = "modifiedbyyominame";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
            public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidname";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string statecode = "statecode";
            public const string statecodeName = "statecodename";
            public const string statuscode = "statuscode";
            public const string statuscodeName = "statuscodename";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string vw_AdminteamId = "vw_adminteamid";
            public const string vw_AdminteamIdName = "vw_adminteamidname";
            public const string vw_AdminteamIdYomiName = "vw_adminteamidyominame";
            public const string vw_availablethismonth = "vw_availablethismonth";
            public const string vw_brandId = "vw_brandid";
            public const string vw_Code = "vw_code";
            public const string vw_GScode = "vw_gscode";
            public const string vw_HLDNAcode = "vw_hldnacode";
            public const string vw_IsVGR = "vw_isvgr";
            public const string vw_isvgrName = "vw_isvgrname";
            public const string vw_monthlylimit = "vw_monthlylimit";
            public const string vw_name = "vw_name";
            public const string vw_RSEcode = "vw_rsecode";
            public const string vw_SBCode = "vw_sbcode";
            public const string vw_TeamId = "vw_teamid";
            public const string vw_TeamIdName = "vw_teamidname";
            public const string vw_TeamIdYomiName = "vw_teamidyominame";

        }

		public class Properties
        {
            public const string createdbyname = "createdbyname";
            public const string createdonbehalfbyname = "createdonbehalfbyname";
            public const string modifiedbyname = "modifiedbyname";
            public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
            public const string organizationid = "organizationid";
            public const string vw_AdminteamId = "vw_AdminteamId";
            public const string vw_infosource_brand = "vw_infosource_brand";
            public const string vw_TeamId = "vw_TeamId";

        }

		
		public class Schemas
        {
            public const string CreatedBy = "CreatedBy";
            public const string CreatedByName = "CreatedByName";
            public const string CreatedByYomiName = "CreatedByYomiName";
            public const string CreatedOn = "CreatedOn";
            public const string CreatedOnBehalfBy = "CreatedOnBehalfBy";
            public const string CreatedOnBehalfByName = "CreatedOnBehalfByName";
            public const string CreatedOnBehalfByYomiName = "CreatedOnBehalfByYomiName";
            public const string ImportSequenceNumber = "ImportSequenceNumber";
            public const string ModifiedBy = "ModifiedBy";
            public const string ModifiedByName = "ModifiedByName";
            public const string ModifiedByYomiName = "ModifiedByYomiName";
            public const string ModifiedOn = "ModifiedOn";
            public const string ModifiedOnBehalfBy = "ModifiedOnBehalfBy";
            public const string ModifiedOnBehalfByName = "ModifiedOnBehalfByName";
            public const string ModifiedOnBehalfByYomiName = "ModifiedOnBehalfByYomiName";
            public const string OrganizationId = "OrganizationId";
            public const string OrganizationIdName = "OrganizationIdName";
            public const string OverriddenCreatedOn = "OverriddenCreatedOn";
            public const string statecode = "statecode";
            public const string statecodeName = "statecodeName";
            public const string statuscode = "statuscode";
            public const string statuscodeName = "statuscodeName";
            public const string TimeZoneRuleVersionNumber = "TimeZoneRuleVersionNumber";
            public const string UTCConversionTimeZoneCode = "UTCConversionTimeZoneCode";
            public const string VersionNumber = "VersionNumber";
            public const string vw_AdminteamId = "vw_AdminteamId";
            public const string vw_AdminteamIdName = "vw_AdminteamIdName";
            public const string vw_AdminteamIdYomiName = "vw_AdminteamIdYomiName";
            public const string vw_availablethismonth = "vw_availablethismonth";
            public const string vw_brandId = "vw_brandId";
            public const string vw_Code = "vw_Code";
            public const string vw_GScode = "vw_GScode";
            public const string vw_HLDNAcode = "vw_HLDNAcode";
            public const string vw_IsVGR = "vw_IsVGR";
            public const string vw_isvgrName = "vw_isvgrName";
            public const string vw_monthlylimit = "vw_monthlylimit";
            public const string vw_name = "vw_name";
            public const string vw_RSEcode = "vw_RSEcode";
            public const string vw_SBCode = "vw_SBCode";
            public const string vw_TeamId = "vw_TeamId";
            public const string vw_TeamIdName = "vw_TeamIdName";
            public const string vw_TeamIdYomiName = "vw_TeamIdYomiName";

        }
    }
}