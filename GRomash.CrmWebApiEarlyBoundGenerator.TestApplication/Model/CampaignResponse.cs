using System;
using System.Dynamic;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;

namespace VW.WebForm.Core.Model.Entities
{
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CrmWebApiEarlyBoundGenerator", "1.0.4.0")]
    public class CampaignResponse : Entity
    {
		public new const string EntityLogicalName = "campaignresponse";
		
		public new const string EntitySetName = "campaignresponses";

        public const string PrimaryIdAttribute = "activityid";

		public CampaignResponse(ExpandoObject expandoObject) : base(expandoObject)
        {
        }

        public CampaignResponse() 
        {
        }

		#region Properties

		/// <summary>
        ///  For internal use only. Только для внутреннего использования.
        /// </summary>

        public string ActivityAdditionalParams {
            get => GetAttributeValue<string>(nameof(ActivityAdditionalParams));
            set => SetAttributeValue(nameof(ActivityAdditionalParams), value);
        }

		/// <summary>
        ///  Unique identifier of the campaign response. Уникальный идентификатор отклика от кампании.
        /// </summary>

        public Guid? ActivityId {
            get => GetAttributeValue<Guid?>(nameof(ActivityId));
            set => SetAttributeValue(nameof(ActivityId), value);
        }

		/// <summary>
        ///  Type the number of minutes spent on this activity. The duration is used in reporting. Введите число минут, затраченных на это действие. Эта длительность используется в отчетах.
        /// </summary>

        public int? ActualDurationMinutes {
            get => GetAttributeValue<int?>(nameof(ActualDurationMinutes));
            set => SetAttributeValue(nameof(ActualDurationMinutes), value);
        }

		/// <summary>
        ///  Enter the date when the campaign response was actually completed. Введите дату фактического завершения отклика от кампании.
        /// </summary>
        [OnlyDate]
        public DateTime? ActualEnd {
            get => GetAttributeValue<DateTime?>(nameof(ActualEnd));
            set => SetAttributeValue(nameof(ActualEnd), value);
        }

		/// <summary>
        ///  Enter the actual start date and time for the campaign response. Введите фактические дату и время начала отклика от кампании.
        /// </summary>
        [OnlyDate]
        public DateTime? ActualStart {
            get => GetAttributeValue<DateTime?>(nameof(ActualStart));
            set => SetAttributeValue(nameof(ActualStart), value);
        }

		/// <summary>
        ///  Type a category to identify the campaign response type, such as new business development or customer retention, to tie the campaign response to a business group or function. Введите категорию, определяющую тип отклика кампании, например развитие нового бизнеса или удержание клиентов, чтобы связать отклик кампании с бизнес-группой или бизнес-функцией.
        /// </summary>

        public string Category {
            get => GetAttributeValue<string>(nameof(Category));
            set => SetAttributeValue(nameof(Category), value);
        }

		/// <summary>
        ///  Select how the response was received, such as phone, letter, fax, or email. Укажите, как был получен отклик, например по телефону, в письме, факсе или сообщении электронной почты.
        /// </summary>

        public int? ChannelTypeCode {
            get => GetAttributeValue<int?>(nameof(ChannelTypeCode));
            set => SetAttributeValue(nameof(ChannelTypeCode), value);
        }

		/// <summary>
        ///  Type the name of the company if the campaign response was received from a new prospect or customer. Введите наименование компании, если отклик от кампании получен от нового клиента или от заинтересованного лица.
        /// </summary>

        public string CompanyName {
            get => GetAttributeValue<string>(nameof(CompanyName));
            set => SetAttributeValue(nameof(CompanyName), value);
        }

		/// <summary>
        ///  Shows who created the record. Показывает, кто создал запись.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_createdby_value")]
        public EntityReference CreatedBy {
            get => GetAttributeValue<EntityReference>("CreatedBy@odata.bind");
            set => SetAttributeValue("CreatedBy@odata.bind", value);
        }

		/// <summary>
        ///  Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. Показывает дату и время, в которые была создана запись. Дата и время отображаются для часового пояса, выбранного в параметрах Microsoft Dynamics 365.
        /// </summary>

        public DateTime? CreatedOn {
            get => GetAttributeValue<DateTime?>(nameof(CreatedOn));
            set => SetAttributeValue(nameof(CreatedOn), value);
        }

		/// <summary>
        ///  Shows who created the record on behalf of another user. Показывает, кто создал запись от имени другого пользователя.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_createdonbehalfby_value")]
        public EntityReference CreatedOnBehalfBy {
            get => GetAttributeValue<EntityReference>("CreatedOnBehalfBy@odata.bind");
            set => SetAttributeValue("CreatedOnBehalfBy@odata.bind", value);
        }

		/// <summary>
        ///  Type additional information to describe the campaign response, such as key discussion points or objectives. Введите дополнительные сведения, описывающие отклик от кампании, например основные обсуждаемые вопросы или задачи.
        /// </summary>

        public string Description {
            get => GetAttributeValue<string>(nameof(Description));
            set => SetAttributeValue(nameof(Description), value);
        }

		/// <summary>
        ///  Type the responder's email address. Введите адрес электронной почты респондента.
        /// </summary>

        public string EMailAddress {
            get => GetAttributeValue<string>(nameof(EMailAddress));
            set => SetAttributeValue(nameof(EMailAddress), value);
        }

		/// <summary>
        ///  Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency. Показывает обменный курс валюты записи. Этот валютный курс используется для преобразования всех денежных полей в записи из локальной валюты в валюту системы по умолчанию.
        /// </summary>

        public decimal? ExchangeRate {
            get => GetAttributeValue<decimal?>(nameof(ExchangeRate));
            set => SetAttributeValue(nameof(ExchangeRate), value);
        }

		/// <summary>
        ///  Type the responder's fax number. Введите номер факса респондента.
        /// </summary>

        public string Fax {
            get => GetAttributeValue<string>(nameof(Fax));
            set => SetAttributeValue(nameof(Fax), value);
        }

		/// <summary>
        ///  Type the responder's first name if the campaign response was received from a new prospect or customer. Введите имя респондента, если отклик от кампании получен от нового клиента или от заинтересованного лица.
        /// </summary>

        public string FirstName {
            get => GetAttributeValue<string>(nameof(FirstName));
            set => SetAttributeValue(nameof(FirstName), value);
        }

		/// <summary>
        ///  Unique identifier of the data import or data migration that created this record. Уникальный идентификатор импорта или переноса данных, создавшего эту запись.
        /// </summary>

        public int? ImportSequenceNumber {
            get => GetAttributeValue<int?>(nameof(ImportSequenceNumber));
            set => SetAttributeValue(nameof(ImportSequenceNumber), value);
        }

		/// <summary>
        ///  Specifies whether the campaign response was billed as part of resolving a case. Сведения о том, был ли выставлен счет по отклику от кампании как часть разрешения обращения.
        /// </summary>

        public bool? IsBilled {
            get => GetAttributeValue<bool?>(nameof(IsBilled));
            set => SetAttributeValue(nameof(IsBilled), value);
        }

		/// <summary>
        ///  Information regarding whether the activity is a regular activity type or event type. Сведения о том, является ли действие обычным действием или событием.
        /// </summary>

        public bool? IsRegularActivity {
            get => GetAttributeValue<bool?>(nameof(IsRegularActivity));
            set => SetAttributeValue(nameof(IsRegularActivity), value);
        }

		/// <summary>
        ///  Specifies whether the campaign response is created by a workflow rule. Определяет, создан ли отклик от кампании правилом бизнес-процесса.
        /// </summary>

        public bool? IsWorkflowCreated {
            get => GetAttributeValue<bool?>(nameof(IsWorkflowCreated));
            set => SetAttributeValue(nameof(IsWorkflowCreated), value);
        }

		/// <summary>
        ///  Type the responder's last name if the campaign response was received from a new prospect or customer. Введите фамилию респондента, если отклик от кампании получен от нового клиента или от заинтересованного лица.
        /// </summary>

        public string LastName {
            get => GetAttributeValue<string>(nameof(LastName));
            set => SetAttributeValue(nameof(LastName), value);
        }

		/// <summary>
        ///  Shows who last updated the record. Показывает, кто последний обновил запись.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_modifiedby_value")]
        public EntityReference ModifiedBy {
            get => GetAttributeValue<EntityReference>("ModifiedBy@odata.bind");
            set => SetAttributeValue("ModifiedBy@odata.bind", value);
        }

		/// <summary>
        ///  Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. Показывает дату и время последнего обновления записи. Дата и время отображаются для часового пояса, выбранного в параметрах Microsoft Dynamics 365.
        /// </summary>

        public DateTime? ModifiedOn {
            get => GetAttributeValue<DateTime?>(nameof(ModifiedOn));
            set => SetAttributeValue(nameof(ModifiedOn), value);
        }

		/// <summary>
        ///  Shows who last updated the record on behalf of another user. Показывает, кто последним обновил запись от имени другого пользователя.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_modifiedonbehalfby_value")]
        public EntityReference ModifiedOnBehalfBy {
            get => GetAttributeValue<EntityReference>("ModifiedOnBehalfBy@odata.bind");
            set => SetAttributeValue("ModifiedOnBehalfBy@odata.bind", value);
        }

		/// <summary>
        ///  Choose the phone call, email, fax, letter, or appointment activity that led the prospect or customer to respond to the campaign. Выберите действие (звонок, сообщение электронной почты, факс, письмо или встречу), после которого заинтересованное лицо или клиент откликнулись на кампанию.
        /// </summary>
        [EntityReferenceAttribute("faxes", "_originatingactivityid_value")]
        public EntityReference OriginatingActivityId {
            get => GetAttributeValue<EntityReference>("OriginatingActivityId@odata.bind");
            set => SetAttributeValue("OriginatingActivityId@odata.bind", value);
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
        ///  Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. Введите пользователя или рабочую группу, которым назначено управление записью. Это поле обновляется при каждом назначении записи другому пользователю.
        /// </summary>

        public Guid? OwnerId {
            get => GetAttributeValue<Guid?>(nameof(OwnerId));
            set => SetAttributeValue(nameof(OwnerId), value);
        }

		/// <summary>
        ///  Unique identifier for the business unit that owns the campaign response. Уникальный идентификатор подразделения, ответственного за отклик от кампании.
        /// </summary>
        [EntityReferenceAttribute("businessunits", "_owningbusinessunit_value")]
        public EntityReference OwningBusinessUnit {
            get => GetAttributeValue<EntityReference>("OwningBusinessUnit@odata.bind");
            set => SetAttributeValue("OwningBusinessUnit@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier of the team who owns the campaign response. Уникальный идентификатор рабочей группы, ответственной за отклик от кампании.
        /// </summary>
        [EntityReferenceAttribute("teams", "_owningteam_value")]
        public EntityReference OwningTeam {
            get => GetAttributeValue<EntityReference>("OwningTeam@odata.bind");
            set => SetAttributeValue("OwningTeam@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier of the user who owns the campaign response. Уникальный идентификатор пользователя, ответственного за отклик от кампании.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_owninguser_value")]
        public EntityReference OwningUser {
            get => GetAttributeValue<EntityReference>("OwningUser@odata.bind");
            set => SetAttributeValue("OwningUser@odata.bind", value);
        }

		/// <summary>
        ///  Select the priority so that preferred customers or critical issues are handled quickly. Выберите приоритет для быстрого обслуживания предпочитаемых клиентов и разрешения критически важных вопросов.
        /// </summary>

        public int? PriorityCode {
            get => GetAttributeValue<int?>(nameof(PriorityCode));
            set => SetAttributeValue(nameof(PriorityCode), value);
        }

		/// <summary>
        ///  Shows the ID of the process. Показывает идентификатор процесса.
        /// </summary>

        public Guid? ProcessId {
            get => GetAttributeValue<Guid?>(nameof(ProcessId));
            set => SetAttributeValue(nameof(ProcessId), value);
        }

		/// <summary>
        ///  Type a promotional code to track sales related to the campaign response or to allow the responder to redeem a discount offer. Введите промокод для отслеживания продаж, связанных с откликом от кампании, или чтобы респондент мог воспользоваться предложением со скидкой.
        /// </summary>

        public string PromotionCodeName {
            get => GetAttributeValue<string>(nameof(PromotionCodeName));
            set => SetAttributeValue(nameof(PromotionCodeName), value);
        }

		/// <summary>
        ///  Enter the date when the campaign response was received. Введите дату получения отклика от кампании.
        /// </summary>
        [OnlyDate]
        public DateTime? ReceivedOn {
            get => GetAttributeValue<DateTime?>(nameof(ReceivedOn));
            set => SetAttributeValue(nameof(ReceivedOn), value);
        }

		/// <summary>
        ///  Choose the parent campaign so that the campaign's response rate is tracked correctly. Выберите родительскую кампанию для правильного отслеживания доли откликов от кампании.
        /// </summary>
        [EntityReferenceAttribute("campaignresponses", "_regardingobjectid_value")]
        public EntityReference RegardingObjectId {
            get => GetAttributeValue<EntityReference>("RegardingObjectId@odata.bind");
            set => SetAttributeValue("RegardingObjectId@odata.bind", value);
        }

		/// <summary>
        ///  Choose the parent campaign so that the campaign's response rate is tracked correctly. Выберите родительскую кампанию для правильного отслеживания доли откликов от кампании.
        /// </summary>
        [EntityAttribute("campaignresponse", "RegardingObjectId")]
        public CampaignResponse RegardingObjectIdEntity {
            get => GetAttributeValue<CampaignResponse>(nameof(RegardingObjectId));
            set => SetAttributeValue(nameof(RegardingObjectId), value);
        }

		/// <summary>
        ///  Select the type of response from the prospect or customer to indicate their interest in the campaign. Выберите тип отклика от заинтересованного лица или клиента, указывающий их интерес в кампании.
        /// </summary>

        public int? ResponseCode {
            get => GetAttributeValue<int?>(nameof(ResponseCode));
            set => SetAttributeValue(nameof(ResponseCode), value);
        }

		/// <summary>
        ///  Scheduled duration of the campaign response in minutes. Запланированная длительность отклика от кампании в минутах.
        /// </summary>

        public int? ScheduledDurationMinutes {
            get => GetAttributeValue<int?>(nameof(ScheduledDurationMinutes));
            set => SetAttributeValue(nameof(ScheduledDurationMinutes), value);
        }

		/// <summary>
        ///  Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign response. Введите ожидаемые дату и время выполнения действия, уточняющие временные рамки для отклика от кампании.
        /// </summary>
        [OnlyDate]
        public DateTime? ScheduledEnd {
            get => GetAttributeValue<DateTime?>(nameof(ScheduledEnd));
            set => SetAttributeValue(nameof(ScheduledEnd), value);
        }

		/// <summary>
        ///  Enter the expected start date and time for the activity to provide details about the timing of the campaign response. Введите ожидаемые дату и время начала действия, уточняющие временные рамки для отклика от кампании.
        /// </summary>
        [OnlyDate]
        public DateTime? ScheduledStart {
            get => GetAttributeValue<DateTime?>(nameof(ScheduledStart));
            set => SetAttributeValue(nameof(ScheduledStart), value);
        }

		/// <summary>
        ///  Shows the ID of the stage. Показывает идентификатор стадии.
        /// </summary>

        public Guid? StageId {
            get => GetAttributeValue<Guid?>(nameof(StageId));
            set => SetAttributeValue(nameof(StageId), value);
        }

		/// <summary>
        ///  Shows whether the campaign response is open, closed, or canceled. Closed and canceled campaign responses are read-only and can't be edited. Указывает, является ли отклик на кампанию открытым, закрытым или отмененным. Закрытые и отмененные отклики от кампании доступны только для чтения, их невозможно изменять.
        /// </summary>

        public int? StateCode {
            get => GetAttributeValue<int?>(nameof(StateCode));
            set => SetAttributeValue(nameof(StateCode), value);
        }

		/// <summary>
        ///  Select the campaign response's status. Выберите состояние отклика от кампании.
        /// </summary>

        public int? StatusCode {
            get => GetAttributeValue<int?>(nameof(StatusCode));
            set => SetAttributeValue(nameof(StatusCode), value);
        }

		/// <summary>
        ///  Type a subcategory to identify the campaign response type and relate the activity to a specific product, sales region, business group, or other function. Введите подкатегорию, определяющую тип отклика от кампании и связывающую действие с конкретным продуктом, регионом продаж, бизнес-группой или другой функцией.
        /// </summary>

        public string Subcategory {
            get => GetAttributeValue<string>(nameof(Subcategory));
            set => SetAttributeValue(nameof(Subcategory), value);
        }

		/// <summary>
        ///  Type a short description about the objective or primary topic of the campaign response. Введите краткое описание цели или основной темы отклика от кампании.
        /// </summary>

        public string Subject {
            get => GetAttributeValue<string>(nameof(Subject));
            set => SetAttributeValue(nameof(Subject), value);
        }

		/// <summary>
        ///  Type the responder's primary phone number. Введите основной номер телефона респондента.
        /// </summary>

        public string Telephone {
            get => GetAttributeValue<string>(nameof(Telephone));
            set => SetAttributeValue(nameof(Telephone), value);
        }

		/// <summary>
        ///  For internal use only. Только для внутреннего использования.
        /// </summary>

        public int? TimeZoneRuleVersionNumber {
            get => GetAttributeValue<int?>(nameof(TimeZoneRuleVersionNumber));
            set => SetAttributeValue(nameof(TimeZoneRuleVersionNumber), value);
        }

		/// <summary>
        ///  Choose the local currency for the record to make sure budgets are reported in the correct currency. Выберите для записи локальную валюту, чтобы отчеты по бюджетам формировались в правильной валюте.
        /// </summary>
        [EntityReferenceAttribute("transactioncurrencies", "_transactioncurrencyid_value")]
        public EntityReference TransactionCurrencyId {
            get => GetAttributeValue<EntityReference>("TransactionCurrencyId@odata.bind");
            set => SetAttributeValue("TransactionCurrencyId@odata.bind", value);
        }

		/// <summary>
        ///  For internal use only. Только для внутреннего использования.
        /// </summary>

        public string TraversedPath {
            get => GetAttributeValue<string>(nameof(TraversedPath));
            set => SetAttributeValue(nameof(TraversedPath), value);
        }

		/// <summary>
        ///  Time zone code that was in use when the record was created. Код часового пояса, использовавшийся при создании записи.
        /// </summary>

        public int? UTCConversionTimeZoneCode {
            get => GetAttributeValue<int?>(nameof(UTCConversionTimeZoneCode));
            set => SetAttributeValue(nameof(UTCConversionTimeZoneCode), value);
        }

		/// <summary>
        ///  Version number of the campaign response. Номер версии отклика от кампании.
        /// </summary>

        public long? VersionNumber {
            get => GetAttributeValue<long?>(nameof(VersionNumber));
            set => SetAttributeValue(nameof(VersionNumber), value);
        }

		/// <summary>
        ///  Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications. Введите фонетическое произношение названия компании, если ее название указано на японском языке, для правильного произношения названия при телефонных звонках и других видах общения.
        /// </summary>

        public string YomiCompanyName {
            get => GetAttributeValue<string>(nameof(YomiCompanyName));
            set => SetAttributeValue(nameof(YomiCompanyName), value);
        }

		/// <summary>
        ///  Type the phonetic spelling of the campaign responder's first name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications. Введите фонетическое произношение имени респондента кампании, если оно указано на японском языке, для правильного произношения имени при телефонных звонках и других видах общения.
        /// </summary>

        public string YomiFirstName {
            get => GetAttributeValue<string>(nameof(YomiFirstName));
            set => SetAttributeValue(nameof(YomiFirstName), value);
        }

		/// <summary>
        ///  Type the phonetic spelling of the campaign responder's last name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications. Введите фонетическое произношение фамилии респондента кампании, если она указана на японском языке, для правильного произношения фамилии при телефонных звонках и других видах общения.
        /// </summary>

        public string YomiLastName {
            get => GetAttributeValue<string>(nameof(YomiLastName));
            set => SetAttributeValue(nameof(YomiLastName), value);
        }



		#endregion Properties

        public class Fields
        {
            public const string Id = "activityid";
            public const string _CreatedBy_value = "_createdby_value";
            public const string _CreatedOnBehalfBy_value = "_createdonbehalfby_value";
            public const string _ModifiedBy_value = "_modifiedby_value";
            public const string _ModifiedOnBehalfBy_value = "_modifiedonbehalfby_value";
            public const string _OriginatingActivityId_value = "_originatingactivityid_value";
            public const string _OwningBusinessUnit_value = "_owningbusinessunit_value";
            public const string _OwningTeam_value = "_owningteam_value";
            public const string _OwningUser_value = "_owninguser_value";
            public const string _RegardingObjectId_value = "_regardingobjectid_value";
            public const string _ServiceId_value = "_serviceid_value";
            public const string _TransactionCurrencyId_value = "_transactioncurrencyid_value";
            public const string ActivityAdditionalParams = "activityadditionalparams";
            public const string ActivityId = "activityid";
            public const string ActivityTypeCode = "activitytypecode";
            public const string ActivityTypeCodeName = "activitytypecodename";
            public const string ActualDurationMinutes = "actualdurationminutes";
            public const string ActualEnd = "actualend";
            public const string ActualStart = "actualstart";
            public const string Category = "category";
            public const string ChannelTypeCode = "channeltypecode";
            public const string ChannelTypeCodeName = "channeltypecodename";
            public const string CompanyName = "companyname";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyname";
            public const string CreatedByYomiName = "createdbyyominame";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyname";
            public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
            public const string Customer = "customer";
            public const string Description = "description";
            public const string EMailAddress = "emailaddress";
            public const string ExchangeRate = "exchangerate";
            public const string Fax = "fax";
            public const string FirstName = "firstname";
            public const string from = "from";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IsBilled = "isbilled";
            public const string IsBilledName = "isbilledname";
            public const string IsRegularActivity = "isregularactivity";
            public const string IsRegularActivityName = "isregularactivityname";
            public const string IsWorkflowCreated = "isworkflowcreated";
            public const string IsWorkflowCreatedName = "isworkflowcreatedname";
            public const string LastName = "lastname";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyname";
            public const string ModifiedByYomiName = "modifiedbyyominame";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
            public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
            public const string OriginatingActivityId = "originatingactivityid";
            public const string OriginatingActivityIdTypeCode = "originatingactivityidtypecode";
            public const string OriginatingActivityName = "originatingactivityname";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwnerIdName = "owneridname";
            public const string OwnerIdType = "owneridtype";
            public const string OwnerIdYomiName = "owneridyominame";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string Partner = "partner";
            public const string PriorityCode = "prioritycode";
            public const string PriorityCodeName = "prioritycodename";
            public const string ProcessId = "processid";
            public const string PromotionCodeName = "promotioncodename";
            public const string ReceivedOn = "receivedon";
            public const string RegardingObjectId = "regardingobjectid";
            public const string RegardingObjectIdName = "regardingobjectidname";
            public const string RegardingObjectIdYomiName = "regardingobjectidyominame";
            public const string RegardingObjectTypeCode = "regardingobjecttypecode";
            public const string ResponseCode = "responsecode";
            public const string ResponseCodeName = "responsecodename";
            public const string ScheduledDurationMinutes = "scheduleddurationminutes";
            public const string ScheduledEnd = "scheduledend";
            public const string ScheduledStart = "scheduledstart";
            public const string ServiceId = "serviceid";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StateCodeName = "statecodename";
            public const string StatusCode = "statuscode";
            public const string StatusCodeName = "statuscodename";
            public const string Subcategory = "subcategory";
            public const string Subject = "subject";
            public const string Telephone = "telephone";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TransactionCurrencyIdName = "transactioncurrencyidname";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string YomiCompanyName = "yomicompanyname";
            public const string YomiFirstName = "yomifirstname";
            public const string YomiLastName = "yomilastname";

        }

		public class Properties
        {
            public const string activityid_activitypointer = "activityid_activitypointer";
            public const string createdby_campaignresponse = "createdby_campaignresponse";
            public const string createdonbehalfby_campaignresponse = "createdonbehalfby_campaignresponse";
            public const string modifiedby_campaignresponse = "modifiedby_campaignresponse";
            public const string modifiedonbehalfby_campaignresponse = "modifiedonbehalfby_campaignresponse";
            public const string originatingactivityid_activitypointer = "originatingactivityid_activitypointer";
            public const string originatingactivityid_appointment = "originatingactivityid_appointment";
            public const string originatingactivityid_cdi_txtmessage_campaignresponse = "originatingactivityid_cdi_txtmessage_campaignresponse";
            public const string originatingactivityid_email = "originatingactivityid_email";
            public const string originatingactivityid_fax = "originatingactivityid_fax";
            public const string originatingactivityid_letter = "originatingactivityid_letter";
            public const string originatingactivityid_phonecall = "originatingactivityid_phonecall";
            public const string originatingactivityid_recurringappointmentmaster = "originatingactivityid_recurringappointmentmaster";
            public const string owningbusinessunit_campaignresponse = "owningbusinessunit_campaignresponse";
            public const string owningteam_campaignresponse = "owningteam_campaignresponse";
            public const string owninguser_campaignresponse = "owninguser_campaignresponse";
            public const string regardingobjectid_bulkoperation_campaignresponse = "regardingobjectid_bulkoperation_campaignresponse";
            public const string regardingobjectid_campaign_campaignresponse = "regardingobjectid_campaign_campaignresponse";
            public const string stageid_processstage = "stageid_processstage";
            public const string transactioncurrencyid_campaignresponse = "transactioncurrencyid_campaignresponse";

        }

		
		public class Schemas
        {
            public const string ActivityAdditionalParams = "ActivityAdditionalParams";
            public const string ActivityId = "ActivityId";
            public const string ActivityTypeCode = "ActivityTypeCode";
            public const string ActivityTypeCodeName = "ActivityTypeCodeName";
            public const string ActualDurationMinutes = "ActualDurationMinutes";
            public const string ActualEnd = "ActualEnd";
            public const string ActualStart = "ActualStart";
            public const string Category = "Category";
            public const string ChannelTypeCode = "ChannelTypeCode";
            public const string ChannelTypeCodeName = "ChannelTypeCodeName";
            public const string CompanyName = "CompanyName";
            public const string CreatedBy = "CreatedBy";
            public const string CreatedByName = "CreatedByName";
            public const string CreatedByYomiName = "CreatedByYomiName";
            public const string CreatedOn = "CreatedOn";
            public const string CreatedOnBehalfBy = "CreatedOnBehalfBy";
            public const string CreatedOnBehalfByName = "CreatedOnBehalfByName";
            public const string CreatedOnBehalfByYomiName = "CreatedOnBehalfByYomiName";
            public const string Customer = "Customer";
            public const string Description = "Description";
            public const string EMailAddress = "EMailAddress";
            public const string ExchangeRate = "ExchangeRate";
            public const string Fax = "Fax";
            public const string FirstName = "FirstName";
            public const string from = "from";
            public const string ImportSequenceNumber = "ImportSequenceNumber";
            public const string IsBilled = "IsBilled";
            public const string IsBilledName = "IsBilledName";
            public const string IsRegularActivity = "IsRegularActivity";
            public const string IsRegularActivityName = "IsRegularActivityName";
            public const string IsWorkflowCreated = "IsWorkflowCreated";
            public const string IsWorkflowCreatedName = "IsWorkflowCreatedName";
            public const string LastName = "LastName";
            public const string ModifiedBy = "ModifiedBy";
            public const string ModifiedByName = "ModifiedByName";
            public const string ModifiedByYomiName = "ModifiedByYomiName";
            public const string ModifiedOn = "ModifiedOn";
            public const string ModifiedOnBehalfBy = "ModifiedOnBehalfBy";
            public const string ModifiedOnBehalfByName = "ModifiedOnBehalfByName";
            public const string ModifiedOnBehalfByYomiName = "ModifiedOnBehalfByYomiName";
            public const string OriginatingActivityId = "OriginatingActivityId";
            public const string OriginatingActivityIdTypeCode = "OriginatingActivityIdTypeCode";
            public const string OriginatingActivityName = "OriginatingActivityName";
            public const string OverriddenCreatedOn = "OverriddenCreatedOn";
            public const string OwnerId = "OwnerId";
            public const string OwnerIdName = "OwnerIdName";
            public const string OwnerIdType = "OwnerIdType";
            public const string OwnerIdYomiName = "OwnerIdYomiName";
            public const string OwningBusinessUnit = "OwningBusinessUnit";
            public const string OwningTeam = "OwningTeam";
            public const string OwningUser = "OwningUser";
            public const string Partner = "Partner";
            public const string PriorityCode = "PriorityCode";
            public const string PriorityCodeName = "PriorityCodeName";
            public const string ProcessId = "ProcessId";
            public const string PromotionCodeName = "PromotionCodeName";
            public const string ReceivedOn = "ReceivedOn";
            public const string RegardingObjectId = "RegardingObjectId";
            public const string RegardingObjectIdName = "RegardingObjectIdName";
            public const string RegardingObjectIdYomiName = "RegardingObjectIdYomiName";
            public const string RegardingObjectTypeCode = "RegardingObjectTypeCode";
            public const string ResponseCode = "ResponseCode";
            public const string ResponseCodeName = "ResponseCodeName";
            public const string ScheduledDurationMinutes = "ScheduledDurationMinutes";
            public const string ScheduledEnd = "ScheduledEnd";
            public const string ScheduledStart = "ScheduledStart";
            public const string ServiceId = "ServiceId";
            public const string StageId = "StageId";
            public const string StateCode = "StateCode";
            public const string StateCodeName = "StateCodeName";
            public const string StatusCode = "StatusCode";
            public const string StatusCodeName = "StatusCodeName";
            public const string Subcategory = "Subcategory";
            public const string Subject = "Subject";
            public const string Telephone = "Telephone";
            public const string TimeZoneRuleVersionNumber = "TimeZoneRuleVersionNumber";
            public const string TransactionCurrencyId = "TransactionCurrencyId";
            public const string TransactionCurrencyIdName = "TransactionCurrencyIdName";
            public const string TraversedPath = "TraversedPath";
            public const string UTCConversionTimeZoneCode = "UTCConversionTimeZoneCode";
            public const string VersionNumber = "VersionNumber";
            public const string YomiCompanyName = "YomiCompanyName";
            public const string YomiFirstName = "YomiFirstName";
            public const string YomiLastName = "YomiLastName";

        }
    }
}