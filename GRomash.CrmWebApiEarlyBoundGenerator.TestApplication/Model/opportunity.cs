using System;
using System.Dynamic;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;

namespace VW.WebForm.Core.Model.Entities
{
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CrmWebApiEarlyBoundGenerator", "1.0.4.0")]
    public class Opportunity : Entity
    {
		public new const string EntityLogicalName = "opportunity";
		
		public new const string EntitySetName = "opportunities";

        public const string PrimaryIdAttribute = "opportunityid";

		public Opportunity(ExpandoObject expandoObject) : base(expandoObject)
        {
        }

        public Opportunity() 
        {
        }

		#region Properties

		/// <summary>
        ///  Unique identifier of the account with which the opportunity is associated. Уникальный идентификатор организации, с которой связана возможная сделка.
        /// </summary>
        [EntityReferenceAttribute("accounts", "_accountid_value")]
        public EntityReference AccountId {
            get => GetAttributeValue<EntityReference>("AccountId@odata.bind");
            set => SetAttributeValue("AccountId@odata.bind", value);
        }

		/// <summary>
        ///  Shows the date and time when the opportunity was closed or canceled. Показывает дату и время закрытия или отмены возможной сделки.
        /// </summary>
        [OnlyDate]
        public DateTime? ActualCloseDate {
            get => GetAttributeValue<DateTime?>(nameof(ActualCloseDate));
            set => SetAttributeValue(nameof(ActualCloseDate), value);
        }

		/// <summary>
        ///  Type the actual revenue amount for the opportunity for reporting and analysis of estimated versus actual sales. Field defaults to the Est. Revenue value when an opportunity is won. Введите сумму фактического дохода для возможной сделки для отчетности и анализа соответствия ожидаемых и фактических продаж. По умолчанию поле принимает значение "Предполагаемый доход" в случае реализации возможной сделки.
        /// </summary>

        public decimal? ActualValue {
            get => GetAttributeValue<decimal?>(nameof(ActualValue));
            set => SetAttributeValue(nameof(ActualValue), value);
        }

		/// <summary>
        ///  Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает поле "Фактический доход", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? ActualValue_Base {
            get => GetAttributeValue<decimal?>(nameof(ActualValue_Base));
            set => SetAttributeValue(nameof(ActualValue_Base), value);
        }

		/// <summary>
        ///  Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget. Введите значение от 0 до 1 000 000 000 000, указывающее потенциальный доступный интересу бюджет.
        /// </summary>

        public decimal? BudgetAmount {
            get => GetAttributeValue<decimal?>(nameof(BudgetAmount));
            set => SetAttributeValue(nameof(BudgetAmount), value);
        }

		/// <summary>
        ///  Shows the budget amount converted to the system's base currency. Показывает сумму бюджета, преобразованную в системную базовую валюту по умолчанию.
        /// </summary>

        public decimal? BudgetAmount_Base {
            get => GetAttributeValue<decimal?>(nameof(BudgetAmount_Base));
            set => SetAttributeValue(nameof(BudgetAmount_Base), value);
        }

		/// <summary>
        ///  Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach. Выберите вероятное состояние бюджета для компании интереса. Это может помочь оценить рейтинг бюджета или выбрать подход к продажам.
        /// </summary>

        public int? BudgetStatus {
            get => GetAttributeValue<int?>(nameof(BudgetStatus));
            set => SetAttributeValue(nameof(BudgetStatus), value);
        }

		/// <summary>
        ///  Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign. Показывает кампанию, на основе которой была создана возможная сделка. Этот идентификатор используется для отслеживания успеха кампании.
        /// </summary>
        [EntityReferenceAttribute("campaigns", "_campaignid_value")]
        public EntityReference CampaignId {
            get => GetAttributeValue<EntityReference>("CampaignId@odata.bind");
            set => SetAttributeValue("CampaignId@odata.bind", value);
        }

		/// <summary>
        ///  Choose whether the proposal feedback has been captured for the opportunity. Укажите, были ли для этой возможной сделки зарегистрированы отзывы по предложению.
        /// </summary>

        public bool? CaptureProposalFeedback {
            get => GetAttributeValue<bool?>(nameof(CaptureProposalFeedback));
            set => SetAttributeValue(nameof(CaptureProposalFeedback), value);
        }

		/// <summary>
        ///  Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team in their efforts to convert the opportunity in a sale. Введите число от 0 до 100, представляющее вероятность заключения возможной сделки. Оно может помочь рабочей группе продаж преобразовать эту возможную сделку в продажу.
        /// </summary>

        public int? CloseProbability {
            get => GetAttributeValue<int?>(nameof(CloseProbability));
            set => SetAttributeValue(nameof(CloseProbability), value);
        }

		/// <summary>
        ///  Select whether a final proposal has been completed for the opportunity. Укажите, готово ли окончательное предложение для этой возможной сделки.
        /// </summary>

        public bool? CompleteFinalProposal {
            get => GetAttributeValue<bool?>(nameof(CompleteFinalProposal));
            set => SetAttributeValue(nameof(CompleteFinalProposal), value);
        }

		/// <summary>
        ///  Select whether an internal review has been completed for this opportunity. Укажите, проводился ли внутренний контроль для этой возможной сделки.
        /// </summary>

        public bool? CompleteInternalReview {
            get => GetAttributeValue<bool?>(nameof(CompleteInternalReview));
            set => SetAttributeValue(nameof(CompleteInternalReview), value);
        }

		/// <summary>
        ///  Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the probability of it turning into an opportunity. Укажите, подтвердил ли интерес свою заинтересованность в ваших предложениях. Это поможет оценить качество интереса и вероятность его преобразования в возможную сделку.
        /// </summary>

        public bool? ConfirmInterest {
            get => GetAttributeValue<bool?>(nameof(ConfirmInterest));
            set => SetAttributeValue(nameof(ConfirmInterest), value);
        }

		/// <summary>
        ///  Unique identifier of the contact associated with the opportunity. Уникальный идентификатор контакта, связанного с рабочим листом
        /// </summary>
        [EntityReferenceAttribute("contacts", "_contactid_value")]
        public EntityReference ContactId {
            get => GetAttributeValue<EntityReference>("ContactId@odata.bind");
            set => SetAttributeValue("ContactId@odata.bind", value);
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
        ///  Type notes about the company or organization associated with the opportunity. Введите заметки о компании или организации, связанной с возможной сделкой.
        /// </summary>

        public string CurrentSituation {
            get => GetAttributeValue<string>(nameof(CurrentSituation));
            set => SetAttributeValue(nameof(CurrentSituation), value);
        }

		/// <summary>
        ///  Type some notes about the customer's requirements, to help the sales team identify products and services that could meet their requirements. Введите заметки о требованиях клиента, которые помогут рабочей группе продаж выбрать продукты и услуги в соответствии с потребностями клиента.
        /// </summary>

        public string CustomerNeed {
            get => GetAttributeValue<string>(nameof(CustomerNeed));
            set => SetAttributeValue(nameof(CustomerNeed), value);
        }

		/// <summary>
        ///  Type notes about the customer's pain points to help the sales team identify products and services that could address these pain points. Введите заметки о проблемных вопросах клиента, которые помогут рабочей группе продаж выбрать продукты и услуги, способные решить эти проблемные вопросы.
        /// </summary>

        public string CustomerPainPoints {
            get => GetAttributeValue<string>(nameof(CustomerPainPoints));
            set => SetAttributeValue(nameof(CustomerPainPoints), value);
        }

		/// <summary>
        ///  Select whether your notes include information about who makes the purchase decisions at the lead's company. Укажите, включают ли ваши заметки сведения о лице, принимающем решение о покупках в компании интереса.
        /// </summary>

        public bool? DecisionMaker {
            get => GetAttributeValue<bool?>(nameof(DecisionMaker));
            set => SetAttributeValue(nameof(DecisionMaker), value);
        }

		/// <summary>
        ///  Type additional information to describe the opportunity, such as possible products to sell or past purchases from the customer. Введите дополнительные сведения.
        /// </summary>

        public string Description {
            get => GetAttributeValue<string>(nameof(Description));
            set => SetAttributeValue(nameof(Description), value);
        }

		/// <summary>
        ///  Select whether a proposal has been developed for the opportunity. Укажите, разработано ли предложение для этой возможной сделки.
        /// </summary>

        public bool? DevelopProposal {
            get => GetAttributeValue<bool?>(nameof(DevelopProposal));
            set => SetAttributeValue(nameof(DevelopProposal), value);
        }

		/// <summary>
        ///  Type the discount amount for the opportunity if the customer is eligible for special savings. Введите сумму скидки для возможной сделки, если клиент имеет право на дополнительные скидки.
        /// </summary>

        public decimal? DiscountAmount {
            get => GetAttributeValue<decimal?>(nameof(DiscountAmount));
            set => SetAttributeValue(nameof(DiscountAmount), value);
        }

		/// <summary>
        ///  Shows the Opportunity Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает значение поля "Сумма скидки возможной сделки", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? DiscountAmount_Base {
            get => GetAttributeValue<decimal?>(nameof(DiscountAmount_Base));
            set => SetAttributeValue(nameof(DiscountAmount_Base), value);
        }

		/// <summary>
        ///  Type the discount rate that should be applied to the Product Totals field to include additional savings for the customer in the opportunity. Введите долю скидки, которая должна применяться к полю "Всего продуктов" для учета дополнительной скидки для клиента в данной возможной сделке.
        /// </summary>

        public decimal? DiscountPercentage {
            get => GetAttributeValue<decimal?>(nameof(DiscountPercentage));
            set => SetAttributeValue(nameof(DiscountPercentage), value);
        }

		/// <summary>
        ///  Enter the expected closing date of the opportunity to help make accurate revenue forecasts. Введите ожидаемую дату закрытия Рабочего листа для повышения точности прогнозов по доходу.
        /// </summary>
        [OnlyDate]
        public DateTime? EstimatedCloseDate {
            get => GetAttributeValue<DateTime?>(nameof(EstimatedCloseDate));
            set => SetAttributeValue(nameof(EstimatedCloseDate), value);
        }

		/// <summary>
        ///  Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue forecasting. This field can be either system-populated or editable based on the selection in the Revenue field. Введите сумму предполагаемого дохода, чтобы указать сумму потенциальной продажи или объем возможной сделки для прогнозирования доходов. Это поле может заполняться системой или быть редактируемым, в зависимости от значения поля "Доход".
        /// </summary>

        public decimal? EstimatedValue {
            get => GetAttributeValue<decimal?>(nameof(EstimatedValue));
            set => SetAttributeValue(nameof(EstimatedValue), value);
        }

		/// <summary>
        ///  Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает поле "Фактический доход", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? EstimatedValue_Base {
            get => GetAttributeValue<decimal?>(nameof(EstimatedValue_Base));
            set => SetAttributeValue(nameof(EstimatedValue_Base), value);
        }

		/// <summary>
        ///  Select whether the fit between the lead's requirements and your offerings was evaluated. Укажите степень соответствия между требованиями интереса и вашими предложениями.
        /// </summary>

        public bool? EvaluateFit {
            get => GetAttributeValue<bool?>(nameof(EvaluateFit));
            set => SetAttributeValue(nameof(EvaluateFit), value);
        }

		/// <summary>
        ///  Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency. Показывает обменный курс валюты записи. Этот валютный курс используется для преобразования всех денежных полей в записи из локальной валюты в валюту системы по умолчанию.
        /// </summary>

        public decimal? ExchangeRate {
            get => GetAttributeValue<decimal?>(nameof(ExchangeRate));
            set => SetAttributeValue(nameof(ExchangeRate), value);
        }

		/// <summary>
        ///  Choose whether the sales team has recorded detailed notes on the proposals and the account's responses. Укажите, записала ли рабочая группа продаж подробные заметки по предложениям и ответам организации.
        /// </summary>

        public bool? FileDebrief {
            get => GetAttributeValue<bool?>(nameof(FileDebrief));
            set => SetAttributeValue(nameof(FileDebrief), value);
        }

		/// <summary>
        ///  Enter the date and time when the final decision of the opportunity was made. Введите дату и время принятия окончательного решения по рабочему листу.
        /// </summary>
        [OnlyDate]
        public DateTime? FinalDecisionDate {
            get => GetAttributeValue<DateTime?>(nameof(FinalDecisionDate));
            set => SetAttributeValue(nameof(FinalDecisionDate), value);
        }

		/// <summary>
        ///  Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total Amount field. Введите стоимость доставки или транспортировки для включенных в возможную сделку продуктов. Она используется при вычислении значения поля "Общая сумма".
        /// </summary>

        public decimal? FreightAmount {
            get => GetAttributeValue<decimal?>(nameof(FreightAmount));
            set => SetAttributeValue(nameof(FreightAmount), value);
        }

		/// <summary>
        ///  Shows the Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает значение поля "Стоимость поставки", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? FreightAmount_Base {
            get => GetAttributeValue<decimal?>(nameof(FreightAmount_Base));
            set => SetAttributeValue(nameof(FreightAmount_Base), value);
        }

		/// <summary>
        ///  Select whether information about competitors is included. Укажите, включена ли информация о конкурентах.
        /// </summary>

        public bool? IdentifyCompetitors {
            get => GetAttributeValue<bool?>(nameof(IdentifyCompetitors));
            set => SetAttributeValue(nameof(IdentifyCompetitors), value);
        }

		/// <summary>
        ///  Select whether the customer contacts for this opportunity have been identified. Укажите, определены ли контакты клиента для этой возможной сделки.
        /// </summary>

        public bool? IdentifyCustomerContacts {
            get => GetAttributeValue<bool?>(nameof(IdentifyCustomerContacts));
            set => SetAttributeValue(nameof(IdentifyCustomerContacts), value);
        }

		/// <summary>
        ///  Choose whether you have recorded who will pursue the opportunity. Укажите, зафиксировано ли, кто будет работать над осуществлением возможной сделки.
        /// </summary>

        public bool? IdentifyPursuitTeam {
            get => GetAttributeValue<bool?>(nameof(IdentifyPursuitTeam));
            set => SetAttributeValue(nameof(IdentifyPursuitTeam), value);
        }

		/// <summary>
        ///  Unique identifier of the data import or data migration that created this record. Уникальный идентификатор импорта или переноса данных, создавшего эту запись.
        /// </summary>

        public int? ImportSequenceNumber {
            get => GetAttributeValue<int?>(nameof(ImportSequenceNumber));
            set => SetAttributeValue(nameof(ImportSequenceNumber), value);
        }

		/// <summary>
        ///  Choose whether someone from the sales team contacted this lead earlier. Укажите, обращался ли кто-либо из рабочей группы продаж к этому интересу ранее.
        /// </summary>

        public int? InitialCommunication {
            get => GetAttributeValue<int?>(nameof(InitialCommunication));
            set => SetAttributeValue(nameof(InitialCommunication), value);
        }

		/// <summary>
        ///  Indicates whether the opportunity is private or visible to the entire organization. Указывает, является ли возможная сделка личной или видна всей организации.
        /// </summary>

        public bool? IsPrivate {
            get => GetAttributeValue<bool?>(nameof(IsPrivate));
            set => SetAttributeValue(nameof(IsPrivate), value);
        }

		/// <summary>
        ///  Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered or entered manually by a user. Укажите, рассчитывается ли предполагаемая выручка от возможной сделки автоматически, на основе введенных продуктов, или она вводится вручную пользователем.
        /// </summary>

        public bool? IsRevenueSystemCalculated {
            get => GetAttributeValue<bool?>(nameof(IsRevenueSystemCalculated));
            set => SetAttributeValue(nameof(IsRevenueSystemCalculated), value);
        }

		/// <summary>
        ///  Contains the date time stamp of the last on hold time. Содержит метку даты и времени последней приостановки.
        /// </summary>

        public DateTime? LastOnHoldTime {
            get => GetAttributeValue<DateTime?>(nameof(LastOnHoldTime));
            set => SetAttributeValue(nameof(LastOnHoldTime), value);
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
        ///  Type a subject or descriptive name, such as the expected order or company name, for the opportunity. Введите тему или информативное название для Рабочего листа.
        /// </summary>

        public string Name {
            get => GetAttributeValue<string>(nameof(Name));
            set => SetAttributeValue(nameof(Name), value);
        }

		/// <summary>
        ///  Choose how high the level of need is for the lead's company. Укажите, насколько высок уровень заинтересованности в компании интереса.
        /// </summary>

        public int? Need {
            get => GetAttributeValue<int?>(nameof(Need));
            set => SetAttributeValue(nameof(Need), value);
        }

		/// <summary>
        ///  Shows the duration in minutes for which the opportunity was on hold. Показывает длительность приостановки возможной сделки в минутах.
        /// </summary>

        public int? OnHoldTime {
            get => GetAttributeValue<int?>(nameof(OnHoldTime));
            set => SetAttributeValue(nameof(OnHoldTime), value);
        }

		/// <summary>
        ///  Unique identifier of the Work list. Уникальный идентификатор возможной сделки.
        /// </summary>

        public Guid? OpportunityId {
            get => GetAttributeValue<Guid?>(nameof(OpportunityId));
            set => SetAttributeValue(nameof(OpportunityId), value);
        }

		/// <summary>
        ///  Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability. Выберите ожидаемую сумму или приоритет возможной сделки, исходя из дохода, состояния клиента или вероятности закрытия сделки.
        /// </summary>

        public int? OpportunityRatingCode {
            get => GetAttributeValue<int?>(nameof(OpportunityRatingCode));
            set => SetAttributeValue(nameof(OpportunityRatingCode), value);
        }

		/// <summary>
        ///  Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead. Выберите интерес, на основе которого был создан Рабочий лист. Это поле доступно только для чтения после создания Рабочего листа.
        /// </summary>
        [EntityReferenceAttribute("leads", "_originatingleadid_value")]
        public EntityReference OriginatingLeadId {
            get => GetAttributeValue<EntityReference>("OriginatingLeadId@odata.bind");
            set => SetAttributeValue("OriginatingLeadId@odata.bind", value);
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
        ///  Unique identifier of the business unit that owns the opportunity. Уникальный идентификатор подразделения, ответственного за возможную сделку.
        /// </summary>
        [EntityReferenceAttribute("businessunits", "_owningbusinessunit_value")]
        public EntityReference OwningBusinessUnit {
            get => GetAttributeValue<EntityReference>("OwningBusinessUnit@odata.bind");
            set => SetAttributeValue("OwningBusinessUnit@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier of the team who owns the opportunity. Уникальный идентификатор рабочей группы, ответственной за возможную сделку.
        /// </summary>
        [EntityReferenceAttribute("teams", "_owningteam_value")]
        public EntityReference OwningTeam {
            get => GetAttributeValue<EntityReference>("OwningTeam@odata.bind");
            set => SetAttributeValue("OwningTeam@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier of the user who owns the opportunity. Уникальный идентификатор пользователя, ответственного за возможную сделку.
        /// </summary>
        [EntityReferenceAttribute("systemusers", "_owninguser_value")]
        public EntityReference OwningUser {
            get => GetAttributeValue<EntityReference>("OwningUser@odata.bind");
            set => SetAttributeValue("OwningUser@odata.bind", value);
        }

		/// <summary>
        ///  Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and to provide a quick link to additional details, such as financial information and activities. Выберите организацию для соединения с этой возможной сделкой, чтобы взаимоотношение отображалось в отчетах и аналитике, а также для предоставления быстрой ссылки на дополнительные сведения, такие как финансовая информация и действия.
        /// </summary>
        [EntityReferenceAttribute("accounts", "_parentaccountid_value")]
        public EntityReference ParentAccountId {
            get => GetAttributeValue<EntityReference>("ParentAccountId@odata.bind");
            set => SetAttributeValue("ParentAccountId@odata.bind", value);
        }

		/// <summary>
        ///  Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics. Выберите контакт, с которым следует соединить эту возможную сделку, чтобы взаимоотношение отображалось в отчетах и аналитике.
        /// </summary>
        [EntityReferenceAttribute("contacts", "_parentcontactid_value")]
        public EntityReference ParentContactId {
            get => GetAttributeValue<EntityReference>("ParentContactId@odata.bind");
            set => SetAttributeValue("ParentContactId@odata.bind", value);
        }

		/// <summary>
        ///  Information about whether the opportunity participates in workflow rules. Сведения о том, входит ли возможная сделка в правила бизнес-процесса.
        /// </summary>

        public bool? ParticipatesInWorkflow {
            get => GetAttributeValue<bool?>(nameof(ParticipatesInWorkflow));
            set => SetAttributeValue(nameof(ParticipatesInWorkflow), value);
        }

		/// <summary>
        ///  Select whether the final proposal has been presented to the account. Укажите, представлено ли организации окончательное предложение.
        /// </summary>

        public bool? PresentFinalProposal {
            get => GetAttributeValue<bool?>(nameof(PresentFinalProposal));
            set => SetAttributeValue(nameof(PresentFinalProposal), value);
        }

		/// <summary>
        ///  Select whether a proposal for the opportunity has been presented to the account. Укажите, представлено ли организации предложение по возможной сделке.
        /// </summary>

        public bool? PresentProposal {
            get => GetAttributeValue<bool?>(nameof(PresentProposal));
            set => SetAttributeValue(nameof(PresentProposal), value);
        }

		/// <summary>
        ///  Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices. Выберите прайс-лист, связанный с этой записью, чтобы связанные с кампанией продукты предлагались по правильным ценам.
        /// </summary>
        [EntityReferenceAttribute("pricelevels", "_pricelevelid_value")]
        public EntityReference PriceLevelId {
            get => GetAttributeValue<EntityReference>("PriceLevelId@odata.bind");
            set => SetAttributeValue("PriceLevelId@odata.bind", value);
        }

		/// <summary>
        ///  Pricing error for the opportunity. Ошибка при вычислении цены для возможной сделки.
        /// </summary>

        public int? PricingErrorCode {
            get => GetAttributeValue<int?>(nameof(PricingErrorCode));
            set => SetAttributeValue(nameof(PricingErrorCode), value);
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
        ///  Type notes about the proposed solution for the opportunity. Введите заметки о предлагаемом решении по возможной сделке.
        /// </summary>

        public string ProposedSolution {
            get => GetAttributeValue<string>(nameof(ProposedSolution));
            set => SetAttributeValue(nameof(ProposedSolution), value);
        }

		/// <summary>
        ///  Choose whether an individual or a committee will be involved in the purchase process for the lead. Укажите, будет ли в процессе покупки со стороны интереса участвовать отдельное лицо или комитет.
        /// </summary>

        public int? PurchaseProcess {
            get => GetAttributeValue<int?>(nameof(PurchaseProcess));
            set => SetAttributeValue(nameof(PurchaseProcess), value);
        }

		/// <summary>
        ///  Choose how long the lead will likely take to make the purchase. Укажите, сколько времени может понадобиться интересу для совершения покупки.
        /// </summary>

        public int? PurchaseTimeframe {
            get => GetAttributeValue<int?>(nameof(PurchaseTimeframe));
            set => SetAttributeValue(nameof(PurchaseTimeframe), value);
        }

		/// <summary>
        ///  Select whether the decision about pursuing the opportunity has been made. Укажите, принято ли решение относительно целесообразности реализации этой возможной сделки.
        /// </summary>

        public bool? PursuitDecision {
            get => GetAttributeValue<bool?>(nameof(PursuitDecision));
            set => SetAttributeValue(nameof(PursuitDecision), value);
        }

		/// <summary>
        ///  Type comments about the qualification or scoring of the lead. Введите комментарии относительно квалификации или оценки интереса.
        /// </summary>

        public string QualificationComments {
            get => GetAttributeValue<string>(nameof(QualificationComments));
            set => SetAttributeValue(nameof(QualificationComments), value);
        }

		/// <summary>
        ///  Type comments about the quotes associated with the opportunity. Введите комментарии о предложениях с расценками, связанных с возможной сделкой.
        /// </summary>

        public string QuoteComments {
            get => GetAttributeValue<string>(nameof(QuoteComments));
            set => SetAttributeValue(nameof(QuoteComments), value);
        }

		/// <summary>
        ///  Choose whether the proposal feedback has been captured and resolved for the opportunity. Укажите, были ли для этой возможной сделки зарегистрированы и учтены отзывы по предложению.
        /// </summary>

        public bool? ResolveFeedback {
            get => GetAttributeValue<bool?>(nameof(ResolveFeedback));
            set => SetAttributeValue(nameof(ResolveFeedback), value);
        }

		/// <summary>
        ///  Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity. Укажите стадию продаж для этой возможной сделки, чтобы помочь рабочей группе осуществить эту возможную сделку.
        /// </summary>

        public int? SalesStage {
            get => GetAttributeValue<int?>(nameof(SalesStage));
            set => SetAttributeValue(nameof(SalesStage), value);
        }

		/// <summary>
        ///  Select the sales process stage for the opportunity to indicate the probability of closing the opportunity. Выберите стадию процесса продаж для этой возможной сделки, чтобы указать вероятность закрытия возможной сделки.
        /// </summary>

        public int? SalesStageCode {
            get => GetAttributeValue<int?>(nameof(SalesStageCode));
            set => SetAttributeValue(nameof(SalesStageCode), value);
        }

		/// <summary>
        ///  Enter the date and time of the prospecting follow-up meeting with the lead. Введите дату и время последующей встречи с потенциальным клиентом в процессе поиска потенциальных клиентов.
        /// </summary>
        [OnlyDate]
        public DateTime? ScheduleFollowup_Prospect {
            get => GetAttributeValue<DateTime?>(nameof(ScheduleFollowup_Prospect));
            set => SetAttributeValue(nameof(ScheduleFollowup_Prospect), value);
        }

		/// <summary>
        ///  Enter the date and time of the qualifying follow-up meeting with the lead. Введите дату и время последующей встречи с интересом для его квалификации.
        /// </summary>
        [OnlyDate]
        public DateTime? ScheduleFollowup_Qualify {
            get => GetAttributeValue<DateTime?>(nameof(ScheduleFollowup_Qualify));
            set => SetAttributeValue(nameof(ScheduleFollowup_Qualify), value);
        }

		/// <summary>
        ///  Enter the date and time of the proposal meeting for the opportunity. Введите дату и время встречи, на которой будет представлено предложение по возможной сделке.
        /// </summary>
        [OnlyDate]
        public DateTime? ScheduleProposalMeeting {
            get => GetAttributeValue<DateTime?>(nameof(ScheduleProposalMeeting));
            set => SetAttributeValue(nameof(ScheduleProposalMeeting), value);
        }

		/// <summary>
        ///  Select whether a thank you note has been sent to the account for considering the proposal. Укажите, отправлено ли организации благодарственное письмо за рассмотрение предложения.
        /// </summary>

        public bool? SendThankYouNote {
            get => GetAttributeValue<bool?>(nameof(SendThankYouNote));
            set => SetAttributeValue(nameof(SendThankYouNote), value);
        }

		/// <summary>
        ///  Choose the service level agreement (SLA) that you want to apply to the opportunity record. Выберите соглашение об уровнях обслуживания (SLA), которое нужно применить к этой записи возможной сделки.
        /// </summary>
        [EntityReferenceAttribute("slas", "_slaid_value")]
        public EntityReference SLAId {
            get => GetAttributeValue<EntityReference>("SLAId@odata.bind");
            set => SetAttributeValue("SLAId@odata.bind", value);
        }

		/// <summary>
        ///  Last SLA that was applied to this opportunity. This field is for internal use only. Последнее SLA, примененное к этой возможной сделке. Это поле предназначено только для внутреннего использования.
        /// </summary>
        [EntityReferenceAttribute("slas", "_slainvokedid_value")]
        public EntityReference SLAInvokedId {
            get => GetAttributeValue<EntityReference>("SLAInvokedId@odata.bind");
            set => SetAttributeValue("SLAInvokedId@odata.bind", value);
        }

		/// <summary>
        ///  Shows the ID of the stage. Показывает идентификатор стадии.
        /// </summary>

        public Guid? StageId {
            get => GetAttributeValue<Guid?>(nameof(StageId));
            set => SetAttributeValue(nameof(StageId), value);
        }

		/// <summary>
        ///  Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited until they are reactivated. Указывает, является ли Рабочий лист открытым, закрытым или упущеннум. Заключенные и упущенные рабочие листы доступны только для чтения. Их нельзя изменять без повторной активации.
        /// </summary>

        public int? StateCode {
            get => GetAttributeValue<int?>(nameof(StateCode));
            set => SetAttributeValue(nameof(StateCode), value);
        }

		/// <summary>
        ///  Select the opportunity's status. Выберите статус Рабочего листа.
        /// </summary>

        public int? StatusCode {
            get => GetAttributeValue<int?>(nameof(StatusCode));
            set => SetAttributeValue(nameof(StatusCode), value);
        }

		/// <summary>
        ///  Shows the ID of the workflow step. Показывает идентификатор шага бизнес-процесса.
        /// </summary>

        public Guid? StepId {
            get => GetAttributeValue<Guid?>(nameof(StepId));
            set => SetAttributeValue(nameof(StepId), value);
        }

		/// <summary>
        ///  Shows the current phase in the sales pipeline for the opportunity. This is updated by a workflow. Показывает текущую фазу в воронке продаж для возможной сделки. Обновляется бизнес-процессом.
        /// </summary>

        public string StepName {
            get => GetAttributeValue<string>(nameof(StepName));
            set => SetAttributeValue(nameof(StepName), value);
        }

		/// <summary>
        ///  Select when the opportunity is likely to be closed. Укажите, когда вероятно закрытие возможной сделки.
        /// </summary>

        public int? TimeLine {
            get => GetAttributeValue<int?>(nameof(TimeLine));
            set => SetAttributeValue(nameof(TimeLine), value);
        }

		/// <summary>
        ///  Total time spent for emails (read and write) and meetings by me in relation to the opportunity record. Общее время, затраченное мною на электронную почту (чтение и написание) и совещания в отношении записи возможной сделки.
        /// </summary>

        public string TimeSpentByMeOnEmailAndMeetings {
            get => GetAttributeValue<string>(nameof(TimeSpentByMeOnEmailAndMeetings));
            set => SetAttributeValue(nameof(TimeSpentByMeOnEmailAndMeetings), value);
        }

		/// <summary>
        ///  For internal use only. Только для внутреннего использования.
        /// </summary>

        public int? TimeZoneRuleVersionNumber {
            get => GetAttributeValue<int?>(nameof(TimeZoneRuleVersionNumber));
            set => SetAttributeValue(nameof(TimeZoneRuleVersionNumber), value);
        }

		/// <summary>
        ///  Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the opportunity. Показывает общую сумму к оплате. Она рассчитывается как сумма стоимости продуктов, скидок, транспортировки и налогов для возможной сделки.
        /// </summary>

        public decimal? TotalAmount {
            get => GetAttributeValue<decimal?>(nameof(TotalAmount));
            set => SetAttributeValue(nameof(TotalAmount), value);
        }

		/// <summary>
        ///  Shows the Total Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает значение поля "Общая сумма", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? TotalAmount_Base {
            get => GetAttributeValue<decimal?>(nameof(TotalAmount_Base));
            set => SetAttributeValue(nameof(TotalAmount_Base), value);
        }

		/// <summary>
        ///  Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount of the opportunity. Отображает общую сумму по продуктам для возможной сделки за вычетом скидок. Это значение добавляется к стоимости транспортировки и налогам при расчете общей суммы возможной сделки.
        /// </summary>

        public decimal? TotalAmountLessFreight {
            get => GetAttributeValue<decimal?>(nameof(TotalAmountLessFreight));
            set => SetAttributeValue(nameof(TotalAmountLessFreight), value);
        }

		/// <summary>
        ///  Shows the Total Pre-Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает значение поля "Общая стоимость без поставки", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? TotalAmountLessFreight_Base {
            get => GetAttributeValue<decimal?>(nameof(TotalAmountLessFreight_Base));
            set => SetAttributeValue(nameof(TotalAmountLessFreight_Base), value);
        }

		/// <summary>
        ///  Shows the total discount amount, based on the discount price and rate entered on the opportunity. Показывает общую сумму скидки, основанную на цене со скидкой и доле скидки, введенных в возможной сделке.
        /// </summary>

        public decimal? TotalDiscountAmount {
            get => GetAttributeValue<decimal?>(nameof(TotalDiscountAmount));
            set => SetAttributeValue(nameof(TotalDiscountAmount), value);
        }

		/// <summary>
        ///  Shows the Total Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает значение поля "Общая сумма скидки", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? TotalDiscountAmount_Base {
            get => GetAttributeValue<decimal?>(nameof(TotalDiscountAmount_Base));
            set => SetAttributeValue(nameof(TotalDiscountAmount_Base), value);
        }

		/// <summary>
        ///  Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list and quantities. Показывает сумму всех существующих и вписанных продуктов в составе возможной сделки, основанную на указанных прайс-листе и количествах.
        /// </summary>

        public decimal? TotalLineItemAmount {
            get => GetAttributeValue<decimal?>(nameof(TotalLineItemAmount));
            set => SetAttributeValue(nameof(TotalLineItemAmount), value);
        }

		/// <summary>
        ///  Shows the Total Detail Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает значение поля "Общая стоимость составляющих", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? TotalLineItemAmount_Base {
            get => GetAttributeValue<decimal?>(nameof(TotalLineItemAmount_Base));
            set => SetAttributeValue(nameof(TotalLineItemAmount_Base), value);
        }

		/// <summary>
        ///  Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified on the opportunity. Показывает общую сумму полей "Скидка, заданная вручную", указанных для всех включенных в возможную сделку продуктов. Это значение отражается в поле "Общая стоимость составляющих" возможной сделки и добавляется к любым суммам или процентам скидок, указанным в возможной сделке.
        /// </summary>

        public decimal? TotalLineItemDiscountAmount {
            get => GetAttributeValue<decimal?>(nameof(TotalLineItemDiscountAmount));
            set => SetAttributeValue(nameof(TotalLineItemDiscountAmount), value);
        }

		/// <summary>
        ///  Shows the Total Line Item Discount Amount field to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает значение поля "Общая скидка для позиции строки", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? TotalLineItemDiscountAmount_Base {
            get => GetAttributeValue<decimal?>(nameof(TotalLineItemDiscountAmount_Base));
            set => SetAttributeValue(nameof(TotalLineItemDiscountAmount_Base), value);
        }

		/// <summary>
        ///  Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total Amount field calculation for the opportunity. Показывает общую сумму значений "Налог", указанных для всех включенных в возможную сделку продуктов. Она включается в расчет поля "Общая сумма" для возможной сделки.
        /// </summary>

        public decimal? TotalTax {
            get => GetAttributeValue<decimal?>(nameof(TotalTax));
            set => SetAttributeValue(nameof(TotalTax), value);
        }

		/// <summary>
        ///  Shows the Total Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area. Показывает поле "Общая сумма налогов", преобразованное в системную базовую валюту по умолчанию в целях отчетности. При расчетах используется валютный курс, заданный в области "Валюты".
        /// </summary>

        public decimal? TotalTax_Base {
            get => GetAttributeValue<decimal?>(nameof(TotalTax_Base));
            set => SetAttributeValue(nameof(TotalTax_Base), value);
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
        ///  Version number of the opportunity. Номер версии возможной сделки.
        /// </summary>

        public long? VersionNumber {
            get => GetAttributeValue<long?>(nameof(VersionNumber));
            set => SetAttributeValue(nameof(VersionNumber), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_additionalcomment {
            get => GetAttributeValue<string>(nameof(vw_additionalcomment));
            set => SetAttributeValue(nameof(vw_additionalcomment), value);
        }

		/// <summary>
        ///  Unique identifier for Brand associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_brands", "_vw_brandid_value")]
        public EntityReference vw_BrandId {
            get => GetAttributeValue<EntityReference>("vw_BrandId@odata.bind");
            set => SetAttributeValue("vw_BrandId@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier for Brand associated with Work List. 
        /// </summary>
        [EntityAttribute("vw_brand", "vw_BrandId")]
        public vw_brand vw_BrandIdEntity {
            get => GetAttributeValue<vw_brand>(nameof(vw_BrandId));
            set => SetAttributeValue(nameof(vw_BrandId), value);
        }

		/// <summary>
        ///  Unique identifier for Brand associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_brands", "_vw_buyotherbrandid_value")]
        public EntityReference vw_BuyotherbrandId {
            get => GetAttributeValue<EntityReference>("vw_BuyotherbrandId@odata.bind");
            set => SetAttributeValue("vw_BuyotherbrandId@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier for Brand associated with Work List. 
        /// </summary>
        [EntityAttribute("vw_brand", "vw_BuyotherbrandId")]
        public vw_brand vw_BuyotherbrandIdEntity {
            get => GetAttributeValue<vw_brand>(nameof(vw_BuyotherbrandId));
            set => SetAttributeValue(nameof(vw_BuyotherbrandId), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_Category {
            get => GetAttributeValue<int?>(nameof(vw_Category));
            set => SetAttributeValue(nameof(vw_Category), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public DateTime? vw_changedinRSE {
            get => GetAttributeValue<DateTime?>(nameof(vw_changedinRSE));
            set => SetAttributeValue(nameof(vw_changedinRSE), value);
        }

		/// <summary>
        ///  Unique identifier for Client Source associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_clientsources", "_vw_clientsourceid_value")]
        public EntityReference vw_ClientSourceId {
            get => GetAttributeValue<EntityReference>("vw_ClientSourceId@odata.bind");
            set => SetAttributeValue("vw_ClientSourceId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>
        [OnlyDate]
        public DateTime? vw_ConfirmDate {
            get => GetAttributeValue<DateTime?>(nameof(vw_ConfirmDate));
            set => SetAttributeValue(nameof(vw_ConfirmDate), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_Confirmofpayment {
            get => GetAttributeValue<bool?>(nameof(vw_Confirmofpayment));
            set => SetAttributeValue(nameof(vw_Confirmofpayment), value);
        }

		/// <summary>
        ///   
        /// </summary>
        [OnlyDate]
        public DateTime? vw_ContractDate {
            get => GetAttributeValue<DateTime?>(nameof(vw_ContractDate));
            set => SetAttributeValue(nameof(vw_ContractDate), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_ContractNumber {
            get => GetAttributeValue<string>(nameof(vw_ContractNumber));
            set => SetAttributeValue(nameof(vw_ContractNumber), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_Cost {
            get => GetAttributeValue<int?>(nameof(vw_Cost));
            set => SetAttributeValue(nameof(vw_Cost), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_Coupon {
            get => GetAttributeValue<string>(nameof(vw_Coupon));
            set => SetAttributeValue(nameof(vw_Coupon), value);
        }

		/// <summary>
        ///   
        /// </summary>
        [OnlyDate]
        public DateTime? vw_couponclosedate {
            get => GetAttributeValue<DateTime?>(nameof(vw_couponclosedate));
            set => SetAttributeValue(nameof(vw_couponclosedate), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public DateTime? vw_CreatedinRSE {
            get => GetAttributeValue<DateTime?>(nameof(vw_CreatedinRSE));
            set => SetAttributeValue(nameof(vw_CreatedinRSE), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_Currentuser {
            get => GetAttributeValue<string>(nameof(vw_Currentuser));
            set => SetAttributeValue(nameof(vw_Currentuser), value);
        }

		/// <summary>
        ///  Unique identifier for Dealer associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_dealers", "_vw_dealerid_value")]
        public EntityReference vw_DealerId {
            get => GetAttributeValue<EntityReference>("vw_DealerId@odata.bind");
            set => SetAttributeValue("vw_DealerId@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier for Dealer`s Contact associated with Opportunity. 
        /// </summary>
        [EntityReferenceAttribute("vw_dealerscontacts", "_vw_dealerscontactid_value")]
        public EntityReference vw_DealersContactId {
            get => GetAttributeValue<EntityReference>("vw_DealersContactId@odata.bind");
            set => SetAttributeValue("vw_DealersContactId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_Descriptionofservice {
            get => GetAttributeValue<string>(nameof(vw_Descriptionofservice));
            set => SetAttributeValue(nameof(vw_Descriptionofservice), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_Drive {
            get => GetAttributeValue<string>(nameof(vw_Drive));
            set => SetAttributeValue(nameof(vw_Drive), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_Engine {
            get => GetAttributeValue<string>(nameof(vw_Engine));
            set => SetAttributeValue(nameof(vw_Engine), value);
        }

		/// <summary>
        ///   
        /// </summary>
        [OnlyDate]
        public DateTime? vw_ExpectedTestdriveDate {
            get => GetAttributeValue<DateTime?>(nameof(vw_ExpectedTestdriveDate));
            set => SetAttributeValue(nameof(vw_ExpectedTestdriveDate), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_ID {
            get => GetAttributeValue<string>(nameof(vw_ID));
            set => SetAttributeValue(nameof(vw_ID), value);
        }

		/// <summary>
        ///  Unique identifier for Info Source associated with Opportunity. 
        /// </summary>
        [EntityReferenceAttribute("vw_infosources", "_vw_infosourceid_value")]
        public EntityReference vw_InfoSourceId {
            get => GetAttributeValue<EntityReference>("vw_InfoSourceId@odata.bind");
            set => SetAttributeValue("vw_InfoSourceId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_InsuranceCheck {
            get => GetAttributeValue<bool?>(nameof(vw_InsuranceCheck));
            set => SetAttributeValue(nameof(vw_InsuranceCheck), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_Integrationstatus {
            get => GetAttributeValue<int?>(nameof(vw_Integrationstatus));
            set => SetAttributeValue(nameof(vw_Integrationstatus), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsCorporate {
            get => GetAttributeValue<bool?>(nameof(vw_IsCorporate));
            set => SetAttributeValue(nameof(vw_IsCorporate), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsCredit {
            get => GetAttributeValue<bool?>(nameof(vw_IsCredit));
            set => SetAttributeValue(nameof(vw_IsCredit), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsCreditConfirmed {
            get => GetAttributeValue<bool?>(nameof(vw_IsCreditConfirmed));
            set => SetAttributeValue(nameof(vw_IsCreditConfirmed), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsInsurance {
            get => GetAttributeValue<bool?>(nameof(vw_IsInsurance));
            set => SetAttributeValue(nameof(vw_IsInsurance), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsLeasing {
            get => GetAttributeValue<bool?>(nameof(vw_IsLeasing));
            set => SetAttributeValue(nameof(vw_IsLeasing), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsLeasingConfirmed {
            get => GetAttributeValue<bool?>(nameof(vw_IsLeasingConfirmed));
            set => SetAttributeValue(nameof(vw_IsLeasingConfirmed), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsMysteryShopping {
            get => GetAttributeValue<bool?>(nameof(vw_IsMysteryShopping));
            set => SetAttributeValue(nameof(vw_IsMysteryShopping), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsRepeat {
            get => GetAttributeValue<bool?>(nameof(vw_IsRepeat));
            set => SetAttributeValue(nameof(vw_IsRepeat), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public bool? vw_IsUsedCar {
            get => GetAttributeValue<bool?>(nameof(vw_IsUsedCar));
            set => SetAttributeValue(nameof(vw_IsUsedCar), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public DateTime? vw_LastInteractioninRSE {
            get => GetAttributeValue<DateTime?>(nameof(vw_LastInteractioninRSE));
            set => SetAttributeValue(nameof(vw_LastInteractioninRSE), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public DateTime? vw_LastupdatefromRSE {
            get => GetAttributeValue<DateTime?>(nameof(vw_LastupdatefromRSE));
            set => SetAttributeValue(nameof(vw_LastupdatefromRSE), value);
        }

		/// <summary>
        ///  Unique identifier for Line associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_lines", "_vw_lineid_value")]
        public EntityReference vw_LineId {
            get => GetAttributeValue<EntityReference>("vw_LineId@odata.bind");
            set => SetAttributeValue("vw_LineId@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier for Lost Reason associated with Opportunity. 
        /// </summary>
        [EntityReferenceAttribute("vw_lostreasons", "_vw_lostreasonid_value")]
        public EntityReference vw_LostReasonId {
            get => GetAttributeValue<EntityReference>("vw_LostReasonId@odata.bind");
            set => SetAttributeValue("vw_LostReasonId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>
        [EntityReferenceAttribute("opportunities", "_vw_mainworklistid_value")]
        public EntityReference vw_mainworklistid {
            get => GetAttributeValue<EntityReference>("vw_mainworklistid@odata.bind");
            set => SetAttributeValue("vw_mainworklistid@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>
        [EntityAttribute("opportunity", "vw_mainworklistid")]
        public Opportunity vw_mainworklistidEntity {
            get => GetAttributeValue<Opportunity>(nameof(vw_mainworklistid));
            set => SetAttributeValue(nameof(vw_mainworklistid), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_Mileage {
            get => GetAttributeValue<int?>(nameof(vw_Mileage));
            set => SetAttributeValue(nameof(vw_Mileage), value);
        }

		/// <summary>
        ///  Unique identifier for Model associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_models", "_vw_modelid_value")]
        public EntityReference vw_ModelId {
            get => GetAttributeValue<EntityReference>("vw_ModelId@odata.bind");
            set => SetAttributeValue("vw_ModelId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_Orderyear {
            get => GetAttributeValue<int?>(nameof(vw_Orderyear));
            set => SetAttributeValue(nameof(vw_Orderyear), value);
        }

		/// <summary>
        ///  Unique identifier for Phase Type associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_phasetypes", "_vw_phasetypeid_value")]
        public EntityReference vw_PhaseTypeId {
            get => GetAttributeValue<EntityReference>("vw_PhaseTypeId@odata.bind");
            set => SetAttributeValue("vw_PhaseTypeId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_ProcessingStatus {
            get => GetAttributeValue<int?>(nameof(vw_ProcessingStatus));
            set => SetAttributeValue(nameof(vw_ProcessingStatus), value);
        }

		/// <summary>
        ///  Unique identifier for Promotion associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_promotions", "_vw_promotionid_value")]
        public EntityReference vw_PromotionId {
            get => GetAttributeValue<EntityReference>("vw_PromotionId@odata.bind");
            set => SetAttributeValue("vw_PromotionId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>
        [OnlyDate]
        public DateTime? vw_purchasedate {
            get => GetAttributeValue<DateTime?>(nameof(vw_purchasedate));
            set => SetAttributeValue(nameof(vw_purchasedate), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_Registrationnumber {
            get => GetAttributeValue<string>(nameof(vw_Registrationnumber));
            set => SetAttributeValue(nameof(vw_Registrationnumber), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_RSECode {
            get => GetAttributeValue<string>(nameof(vw_RSECode));
            set => SetAttributeValue(nameof(vw_RSECode), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_SatusChangeComment {
            get => GetAttributeValue<string>(nameof(vw_SatusChangeComment));
            set => SetAttributeValue(nameof(vw_SatusChangeComment), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public DateTime? vw_Servicedate {
            get => GetAttributeValue<DateTime?>(nameof(vw_Servicedate));
            set => SetAttributeValue(nameof(vw_Servicedate), value);
        }

		/// <summary>
        ///  Unique identifier for Service status associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_servicestatuses", "_vw_servicestatusid_value")]
        public EntityReference vw_ServicestatusId {
            get => GetAttributeValue<EntityReference>("vw_ServicestatusId@odata.bind");
            set => SetAttributeValue("vw_ServicestatusId@odata.bind", value);
        }

		/// <summary>
        ///  Unique identifier for Status change reason associated with Opportunity. 
        /// </summary>
        [EntityReferenceAttribute("vw_changereasons", "_vw_statuschangereasonid_value")]
        public EntityReference vw_StatuschangereasonId {
            get => GetAttributeValue<EntityReference>("vw_StatuschangereasonId@odata.bind");
            set => SetAttributeValue("vw_StatuschangereasonId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_Term {
            get => GetAttributeValue<int?>(nameof(vw_Term));
            set => SetAttributeValue(nameof(vw_Term), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public string vw_VIN {
            get => GetAttributeValue<string>(nameof(vw_VIN));
            set => SetAttributeValue(nameof(vw_VIN), value);
        }

		/// <summary>
        ///  Unique identifier for Work List Status associated with Work List. 
        /// </summary>
        [EntityReferenceAttribute("vw_workliststatuses", "_vw_workliststatusid_value")]
        public EntityReference vw_WorkListStatusId {
            get => GetAttributeValue<EntityReference>("vw_WorkListStatusId@odata.bind");
            set => SetAttributeValue("vw_WorkListStatusId@odata.bind", value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_worklisttype {
            get => GetAttributeValue<int?>(nameof(vw_worklisttype));
            set => SetAttributeValue(nameof(vw_worklisttype), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_Year {
            get => GetAttributeValue<int?>(nameof(vw_Year));
            set => SetAttributeValue(nameof(vw_Year), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_YearFrom {
            get => GetAttributeValue<int?>(nameof(vw_YearFrom));
            set => SetAttributeValue(nameof(vw_YearFrom), value);
        }

		/// <summary>
        ///   
        /// </summary>

        public int? vw_YearTo {
            get => GetAttributeValue<int?>(nameof(vw_YearTo));
            set => SetAttributeValue(nameof(vw_YearTo), value);
        }



		#endregion Properties

        public class Fields
        {
            public const string Id = "opportunityid";
            public const string _AccountId_value = "_accountid_value";
            public const string _CampaignId_value = "_campaignid_value";
            public const string _ContactId_value = "_contactid_value";
            public const string _CreatedBy_value = "_createdby_value";
            public const string _CreatedOnBehalfBy_value = "_createdonbehalfby_value";
            public const string _ModifiedBy_value = "_modifiedby_value";
            public const string _ModifiedOnBehalfBy_value = "_modifiedonbehalfby_value";
            public const string _OriginatingLeadId_value = "_originatingleadid_value";
            public const string _OwningBusinessUnit_value = "_owningbusinessunit_value";
            public const string _OwningTeam_value = "_owningteam_value";
            public const string _OwningUser_value = "_owninguser_value";
            public const string _ParentAccountId_value = "_parentaccountid_value";
            public const string _ParentContactId_value = "_parentcontactid_value";
            public const string _PriceLevelId_value = "_pricelevelid_value";
            public const string _SLAId_value = "_slaid_value";
            public const string _SLAInvokedId_value = "_slainvokedid_value";
            public const string _TransactionCurrencyId_value = "_transactioncurrencyid_value";
            public const string _vw_BrandId_value = "_vw_brandid_value";
            public const string _vw_BuyotherbrandId_value = "_vw_buyotherbrandid_value";
            public const string _vw_ClientSourceId_value = "_vw_clientsourceid_value";
            public const string _vw_DealerId_value = "_vw_dealerid_value";
            public const string _vw_DealersContactId_value = "_vw_dealerscontactid_value";
            public const string _vw_InfoSourceId_value = "_vw_infosourceid_value";
            public const string _vw_LineId_value = "_vw_lineid_value";
            public const string _vw_LostReasonId_value = "_vw_lostreasonid_value";
            public const string _vw_mainworklistid_value = "_vw_mainworklistid_value";
            public const string _vw_ModelId_value = "_vw_modelid_value";
            public const string _vw_PhaseTypeId_value = "_vw_phasetypeid_value";
            public const string _vw_PromotionId_value = "_vw_promotionid_value";
            public const string _vw_ServicestatusId_value = "_vw_servicestatusid_value";
            public const string _vw_StatuschangereasonId_value = "_vw_statuschangereasonid_value";
            public const string _vw_WorkListStatusId_value = "_vw_workliststatusid_value";
            public const string AccountId = "accountid";
            public const string AccountIdName = "accountidname";
            public const string AccountIdYomiName = "accountidyominame";
            public const string ActualCloseDate = "actualclosedate";
            public const string ActualValue = "actualvalue";
            public const string ActualValue_Base = "actualvalue_base";
            public const string BudgetAmount = "budgetamount";
            public const string BudgetAmount_Base = "budgetamount_base";
            public const string BudgetStatus = "budgetstatus";
            public const string BudgetTypeName = "budgettypename";
            public const string CampaignId = "campaignid";
            public const string CampaignIdName = "campaignidname";
            public const string CaptureProposalFeedback = "captureproposalfeedback";
            public const string CaptureProposalFeedbackName = "captureproposalfeedbackname";
            public const string CloseProbability = "closeprobability";
            public const string CompleteFinalProposal = "completefinalproposal";
            public const string CompleteFinalProposalName = "completefinalproposalname";
            public const string CompleteInternalReview = "completeinternalreview";
            public const string CompleteInternalReviewName = "completeinternalreviewname";
            public const string ConfirmInterest = "confirminterest";
            public const string ConfirmInterestName = "confirminterestname";
            public const string ContactId = "contactid";
            public const string ContactIdName = "contactidname";
            public const string ContactIdYomiName = "contactidyominame";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyname";
            public const string CreatedByYomiName = "createdbyyominame";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyname";
            public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
            public const string CurrentSituation = "currentsituation";
            public const string CustomerId = "customerid";
            public const string CustomerIdName = "customeridname";
            public const string CustomerIdType = "customeridtype";
            public const string CustomerIdYomiName = "customeridyominame";
            public const string CustomerNeed = "customerneed";
            public const string CustomerPainPoints = "customerpainpoints";
            public const string DecisionMaker = "decisionmaker";
            public const string DecisionMakerName = "decisionmakername";
            public const string Description = "description";
            public const string DevelopProposal = "developproposal";
            public const string DevelopProposalName = "developproposalname";
            public const string DiscountAmount = "discountamount";
            public const string DiscountAmount_Base = "discountamount_base";
            public const string DiscountPercentage = "discountpercentage";
            public const string EstimatedCloseDate = "estimatedclosedate";
            public const string EstimatedValue = "estimatedvalue";
            public const string EstimatedValue_Base = "estimatedvalue_base";
            public const string EvaluateFit = "evaluatefit";
            public const string EvaluateFitName = "evaluatefitname";
            public const string ExchangeRate = "exchangerate";
            public const string FileDebrief = "filedebrief";
            public const string FileDeBriefName = "filedebriefname";
            public const string FinalDecisionDate = "finaldecisiondate";
            public const string FreightAmount = "freightamount";
            public const string FreightAmount_Base = "freightamount_base";
            public const string IdentifyCompetitors = "identifycompetitors";
            public const string IdentifyCompetitorsName = "identifycompetitorsname";
            public const string IdentifyCustomerContacts = "identifycustomercontacts";
            public const string IdentifyCustomerContactsName = "identifycustomercontactsname";
            public const string IdentifyPursuitTeam = "identifypursuitteam";
            public const string IdentifyPursuitTeamName = "identifypursuitteamname";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string InitialCommunication = "initialcommunication";
            public const string InitialCommunicationName = "initialcommunicationname";
            public const string IsPrivate = "isprivate";
            public const string IsPrivateName = "isprivatename";
            public const string IsRevenueSystemCalculated = "isrevenuesystemcalculated";
            public const string IsRevenueSystemCalculatedName = "isrevenuesystemcalculatedname";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyname";
            public const string ModifiedByYomiName = "modifiedbyyominame";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
            public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
            public const string Name = "name";
            public const string Need = "need";
            public const string NeedName = "needname";
            public const string OnHoldTime = "onholdtime";
            public const string OpportunityId = "opportunityid";
            public const string OpportunityRatingCode = "opportunityratingcode";
            public const string OpportunityRatingCodeName = "opportunityratingcodename";
            public const string OriginatingLeadId = "originatingleadid";
            public const string OriginatingLeadIdName = "originatingleadidname";
            public const string OriginatingLeadIdYomiName = "originatingleadidyominame";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwnerIdName = "owneridname";
            public const string OwnerIdType = "owneridtype";
            public const string OwnerIdYomiName = "owneridyominame";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string ParentAccountId = "parentaccountid";
            public const string ParentAccountIdName = "parentaccountidname";
            public const string ParentAccountIdYomiName = "parentaccountidyominame";
            public const string ParentContactId = "parentcontactid";
            public const string ParentContactIdName = "parentcontactidname";
            public const string ParentContactIdYomiName = "parentcontactidyominame";
            public const string ParticipatesInWorkflow = "participatesinworkflow";
            public const string ParticipatesInWorkflowName = "participatesinworkflowname";
            public const string PresentFinalProposal = "presentfinalproposal";
            public const string PresentFinalProposalName = "presentfinalproposalname";
            public const string PresentProposal = "presentproposal";
            public const string PresentProposalName = "presentproposalname";
            public const string PriceLevelId = "pricelevelid";
            public const string PriceLevelIdName = "pricelevelidname";
            public const string PricingErrorCode = "pricingerrorcode";
            public const string PricingErrorCodeName = "pricingerrorcodename";
            public const string PriorityCode = "prioritycode";
            public const string PriorityCodeName = "prioritycodename";
            public const string ProcessId = "processid";
            public const string ProposedSolution = "proposedsolution";
            public const string PurchaseProcess = "purchaseprocess";
            public const string PurchaseProcessName = "purchaseprocessname";
            public const string PurchaseTimeframe = "purchasetimeframe";
            public const string PurchaseTimeframeName = "purchasetimeframename";
            public const string PursuitDecision = "pursuitdecision";
            public const string PursuitDecisionName = "pursuitdecisionname";
            public const string QualificationComments = "qualificationcomments";
            public const string QuoteComments = "quotecomments";
            public const string ResolveFeedback = "resolvefeedback";
            public const string ResolveFeedbackName = "resolvefeedbackname";
            public const string SalesStage = "salesstage";
            public const string SalesStageCode = "salesstagecode";
            public const string SalesStageCodeName = "salesstagecodename";
            public const string SalesStageName = "salesstagename";
            public const string ScheduleFollowup_Prospect = "schedulefollowup_prospect";
            public const string ScheduleFollowup_Qualify = "schedulefollowup_qualify";
            public const string ScheduleProposalMeeting = "scheduleproposalmeeting";
            public const string SendThankYouNote = "sendthankyounote";
            public const string SendThankYouNoteName = "sendthankyounotename";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string SLAInvokedIdName = "slainvokedidname";
            public const string SLAName = "slaname";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StateCodeName = "statecodename";
            public const string StatusCode = "statuscode";
            public const string StatusCodeName = "statuscodename";
            public const string StepId = "stepid";
            public const string StepName = "stepname";
            public const string TimeLine = "timeline";
            public const string TimelineName = "timelinename";
            public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TotalAmount = "totalamount";
            public const string TotalAmount_Base = "totalamount_base";
            public const string TotalAmountLessFreight = "totalamountlessfreight";
            public const string TotalAmountLessFreight_Base = "totalamountlessfreight_base";
            public const string TotalDiscountAmount = "totaldiscountamount";
            public const string TotalDiscountAmount_Base = "totaldiscountamount_base";
            public const string TotalLineItemAmount = "totallineitemamount";
            public const string TotalLineItemAmount_Base = "totallineitemamount_base";
            public const string TotalLineItemDiscountAmount = "totallineitemdiscountamount";
            public const string TotalLineItemDiscountAmount_Base = "totallineitemdiscountamount_base";
            public const string TotalTax = "totaltax";
            public const string TotalTax_Base = "totaltax_base";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TransactionCurrencyIdName = "transactioncurrencyidname";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string vw_additionalcomment = "vw_additionalcomment";
            public const string vw_BrandId = "vw_brandid";
            public const string vw_BrandIdName = "vw_brandidname";
            public const string vw_BuyotherbrandId = "vw_buyotherbrandid";
            public const string vw_BuyotherbrandIdName = "vw_buyotherbrandidname";
            public const string vw_Category = "vw_category";
            public const string vw_categoryName = "vw_categoryname";
            public const string vw_changedinRSE = "vw_changedinrse";
            public const string vw_ClientSourceId = "vw_clientsourceid";
            public const string vw_ClientSourceIdName = "vw_clientsourceidname";
            public const string vw_ConfirmDate = "vw_confirmdate";
            public const string vw_Confirmofpayment = "vw_confirmofpayment";
            public const string vw_confirmofpaymentName = "vw_confirmofpaymentname";
            public const string vw_ContractDate = "vw_contractdate";
            public const string vw_ContractNumber = "vw_contractnumber";
            public const string vw_Cost = "vw_cost";
            public const string vw_Coupon = "vw_coupon";
            public const string vw_couponclosedate = "vw_couponclosedate";
            public const string vw_CreatedinRSE = "vw_createdinrse";
            public const string vw_Currentuser = "vw_currentuser";
            public const string vw_DealerId = "vw_dealerid";
            public const string vw_DealerIdName = "vw_dealeridname";
            public const string vw_DealersContactId = "vw_dealerscontactid";
            public const string vw_DealersContactIdName = "vw_dealerscontactidname";
            public const string vw_Descriptionofservice = "vw_descriptionofservice";
            public const string vw_Drive = "vw_drive";
            public const string vw_Engine = "vw_engine";
            public const string vw_ExpectedTestdriveDate = "vw_expectedtestdrivedate";
            public const string vw_ID = "vw_id";
            public const string vw_InfoSourceId = "vw_infosourceid";
            public const string vw_InfoSourceIdName = "vw_infosourceidname";
            public const string vw_InsuranceCheck = "vw_insurancecheck";
            public const string vw_insurancecheckName = "vw_insurancecheckname";
            public const string vw_Integrationstatus = "vw_integrationstatus";
            public const string vw_integrationstatusName = "vw_integrationstatusname";
            public const string vw_IsCorporate = "vw_iscorporate";
            public const string vw_iscorporateName = "vw_iscorporatename";
            public const string vw_IsCredit = "vw_iscredit";
            public const string vw_IsCreditConfirmed = "vw_iscreditconfirmed";
            public const string vw_iscreditconfirmedName = "vw_iscreditconfirmedname";
            public const string vw_iscreditName = "vw_iscreditname";
            public const string vw_IsInsurance = "vw_isinsurance";
            public const string vw_isinsuranceName = "vw_isinsurancename";
            public const string vw_IsLeasing = "vw_isleasing";
            public const string vw_IsLeasingConfirmed = "vw_isleasingconfirmed";
            public const string vw_isleasingconfirmedName = "vw_isleasingconfirmedname";
            public const string vw_isleasingName = "vw_isleasingname";
            public const string vw_IsMysteryShopping = "vw_ismysteryshopping";
            public const string vw_ismysteryshoppingName = "vw_ismysteryshoppingname";
            public const string vw_IsRepeat = "vw_isrepeat";
            public const string vw_isrepeatName = "vw_isrepeatname";
            public const string vw_IsUsedCar = "vw_isusedcar";
            public const string vw_isusedcarName = "vw_isusedcarname";
            public const string vw_LastInteractioninRSE = "vw_lastinteractioninrse";
            public const string vw_LastupdatefromRSE = "vw_lastupdatefromrse";
            public const string vw_LineId = "vw_lineid";
            public const string vw_LineIdName = "vw_lineidname";
            public const string vw_LostReasonId = "vw_lostreasonid";
            public const string vw_LostReasonIdName = "vw_lostreasonidname";
            public const string vw_mainworklistid = "vw_mainworklistid";
            public const string vw_mainworklistidName = "vw_mainworklistidname";
            public const string vw_Mileage = "vw_mileage";
            public const string vw_ModelId = "vw_modelid";
            public const string vw_ModelIdName = "vw_modelidname";
            public const string vw_Orderyear = "vw_orderyear";
            public const string vw_PhaseTypeId = "vw_phasetypeid";
            public const string vw_PhaseTypeIdName = "vw_phasetypeidname";
            public const string vw_ProcessingStatus = "vw_processingstatus";
            public const string vw_processingstatusName = "vw_processingstatusname";
            public const string vw_PromotionId = "vw_promotionid";
            public const string vw_PromotionIdName = "vw_promotionidname";
            public const string vw_purchasedate = "vw_purchasedate";
            public const string vw_Registrationnumber = "vw_registrationnumber";
            public const string vw_RSECode = "vw_rsecode";
            public const string vw_SatusChangeComment = "vw_satuschangecomment";
            public const string vw_Servicedate = "vw_servicedate";
            public const string vw_ServicestatusId = "vw_servicestatusid";
            public const string vw_ServicestatusIdName = "vw_servicestatusidname";
            public const string vw_StatuschangereasonId = "vw_statuschangereasonid";
            public const string vw_StatuschangereasonIdName = "vw_statuschangereasonidname";
            public const string vw_Term = "vw_term";
            public const string vw_VIN = "vw_vin";
            public const string vw_WorkListStatusId = "vw_workliststatusid";
            public const string vw_WorkListStatusIdName = "vw_workliststatusidname";
            public const string vw_worklisttype = "vw_worklisttype";
            public const string vw_worklisttypeName = "vw_worklisttypename";
            public const string vw_Year = "vw_year";
            public const string vw_YearFrom = "vw_yearfrom";
            public const string vw_YearTo = "vw_yearto";

        }

		public class Properties
        {
            public const string campaignid = "campaignid";
            public const string createdby = "createdby";
            public const string createdonbehalfby = "createdonbehalfby";
            public const string customerid_account = "customerid_account";
            public const string customerid_contact = "customerid_contact";
            public const string modifiedby = "modifiedby";
            public const string modifiedonbehalfby = "modifiedonbehalfby";
            public const string opportunitycompetitors_association = "opportunitycompetitors_association";
            public const string originatingleadid = "originatingleadid";
            public const string ownerid = "ownerid";
            public const string owningbusinessunit = "owningbusinessunit";
            public const string owningteam = "owningteam";
            public const string owninguser = "owninguser";
            public const string parentaccountid = "parentaccountid";
            public const string parentcontactid = "parentcontactid";
            public const string pricelevelid = "pricelevelid";
            public const string sla_opportunity_sla = "sla_opportunity_sla";
            public const string slainvokedid_opportunity_sla = "slainvokedid_opportunity_sla";
            public const string stageid_processstage = "stageid_processstage";
            public const string transactioncurrencyid = "transactioncurrencyid";
            public const string vw_BrandId = "vw_BrandId";
            public const string vw_BuyotherbrandId = "vw_BuyotherbrandId";
            public const string vw_ClientSourceId = "vw_ClientSourceId";
            public const string vw_DealerId = "vw_DealerId";
            public const string vw_DealersContactId = "vw_DealersContactId";
            public const string vw_InfoSourceId = "vw_InfoSourceId";
            public const string vw_LineId = "vw_LineId";
            public const string vw_LostReasonId = "vw_LostReasonId";
            public const string vw_mainworklistid = "vw_mainworklistid";
            public const string vw_ModelId = "vw_ModelId";
            public const string vw_PhaseTypeId = "vw_PhaseTypeId";
            public const string vw_PromotionId = "vw_PromotionId";
            public const string vw_ServicestatusId = "vw_ServicestatusId";
            public const string vw_StatuschangereasonId = "vw_StatuschangereasonId";
            public const string vw_WorkListStatusId = "vw_WorkListStatusId";

        }

		
		public class Schemas
        {
            public const string AccountId = "AccountId";
            public const string AccountIdName = "AccountIdName";
            public const string AccountIdYomiName = "AccountIdYomiName";
            public const string ActualCloseDate = "ActualCloseDate";
            public const string ActualValue = "ActualValue";
            public const string ActualValue_Base = "ActualValue_Base";
            public const string BudgetAmount = "BudgetAmount";
            public const string BudgetAmount_Base = "BudgetAmount_Base";
            public const string BudgetStatus = "BudgetStatus";
            public const string BudgetTypeName = "BudgetTypeName";
            public const string CampaignId = "CampaignId";
            public const string CampaignIdName = "CampaignIdName";
            public const string CaptureProposalFeedback = "CaptureProposalFeedback";
            public const string CaptureProposalFeedbackName = "CaptureProposalFeedbackName";
            public const string CloseProbability = "CloseProbability";
            public const string CompleteFinalProposal = "CompleteFinalProposal";
            public const string CompleteFinalProposalName = "CompleteFinalProposalName";
            public const string CompleteInternalReview = "CompleteInternalReview";
            public const string CompleteInternalReviewName = "CompleteInternalReviewName";
            public const string ConfirmInterest = "ConfirmInterest";
            public const string ConfirmInterestName = "ConfirmInterestName";
            public const string ContactId = "ContactId";
            public const string ContactIdName = "ContactIdName";
            public const string ContactIdYomiName = "ContactIdYomiName";
            public const string CreatedBy = "CreatedBy";
            public const string CreatedByName = "CreatedByName";
            public const string CreatedByYomiName = "CreatedByYomiName";
            public const string CreatedOn = "CreatedOn";
            public const string CreatedOnBehalfBy = "CreatedOnBehalfBy";
            public const string CreatedOnBehalfByName = "CreatedOnBehalfByName";
            public const string CreatedOnBehalfByYomiName = "CreatedOnBehalfByYomiName";
            public const string CurrentSituation = "CurrentSituation";
            public const string CustomerId = "CustomerId";
            public const string CustomerIdName = "CustomerIdName";
            public const string CustomerIdType = "CustomerIdType";
            public const string CustomerIdYomiName = "CustomerIdYomiName";
            public const string CustomerNeed = "CustomerNeed";
            public const string CustomerPainPoints = "CustomerPainPoints";
            public const string DecisionMaker = "DecisionMaker";
            public const string DecisionMakerName = "DecisionMakerName";
            public const string Description = "Description";
            public const string DevelopProposal = "DevelopProposal";
            public const string DevelopProposalName = "DevelopProposalName";
            public const string DiscountAmount = "DiscountAmount";
            public const string DiscountAmount_Base = "DiscountAmount_Base";
            public const string DiscountPercentage = "DiscountPercentage";
            public const string EstimatedCloseDate = "EstimatedCloseDate";
            public const string EstimatedValue = "EstimatedValue";
            public const string EstimatedValue_Base = "EstimatedValue_Base";
            public const string EvaluateFit = "EvaluateFit";
            public const string EvaluateFitName = "EvaluateFitName";
            public const string ExchangeRate = "ExchangeRate";
            public const string FileDebrief = "FileDebrief";
            public const string FileDeBriefName = "FileDeBriefName";
            public const string FinalDecisionDate = "FinalDecisionDate";
            public const string FreightAmount = "FreightAmount";
            public const string FreightAmount_Base = "FreightAmount_Base";
            public const string IdentifyCompetitors = "IdentifyCompetitors";
            public const string IdentifyCompetitorsName = "IdentifyCompetitorsName";
            public const string IdentifyCustomerContacts = "IdentifyCustomerContacts";
            public const string IdentifyCustomerContactsName = "IdentifyCustomerContactsName";
            public const string IdentifyPursuitTeam = "IdentifyPursuitTeam";
            public const string IdentifyPursuitTeamName = "IdentifyPursuitTeamName";
            public const string ImportSequenceNumber = "ImportSequenceNumber";
            public const string InitialCommunication = "InitialCommunication";
            public const string InitialCommunicationName = "InitialCommunicationName";
            public const string IsPrivate = "IsPrivate";
            public const string IsPrivateName = "IsPrivateName";
            public const string IsRevenueSystemCalculated = "IsRevenueSystemCalculated";
            public const string IsRevenueSystemCalculatedName = "IsRevenueSystemCalculatedName";
            public const string LastOnHoldTime = "LastOnHoldTime";
            public const string ModifiedBy = "ModifiedBy";
            public const string ModifiedByName = "ModifiedByName";
            public const string ModifiedByYomiName = "ModifiedByYomiName";
            public const string ModifiedOn = "ModifiedOn";
            public const string ModifiedOnBehalfBy = "ModifiedOnBehalfBy";
            public const string ModifiedOnBehalfByName = "ModifiedOnBehalfByName";
            public const string ModifiedOnBehalfByYomiName = "ModifiedOnBehalfByYomiName";
            public const string Name = "Name";
            public const string Need = "Need";
            public const string NeedName = "NeedName";
            public const string OnHoldTime = "OnHoldTime";
            public const string OpportunityId = "OpportunityId";
            public const string OpportunityRatingCode = "OpportunityRatingCode";
            public const string OpportunityRatingCodeName = "OpportunityRatingCodeName";
            public const string OriginatingLeadId = "OriginatingLeadId";
            public const string OriginatingLeadIdName = "OriginatingLeadIdName";
            public const string OriginatingLeadIdYomiName = "OriginatingLeadIdYomiName";
            public const string OverriddenCreatedOn = "OverriddenCreatedOn";
            public const string OwnerId = "OwnerId";
            public const string OwnerIdName = "OwnerIdName";
            public const string OwnerIdType = "OwnerIdType";
            public const string OwnerIdYomiName = "OwnerIdYomiName";
            public const string OwningBusinessUnit = "OwningBusinessUnit";
            public const string OwningTeam = "OwningTeam";
            public const string OwningUser = "OwningUser";
            public const string ParentAccountId = "ParentAccountId";
            public const string ParentAccountIdName = "ParentAccountIdName";
            public const string ParentAccountIdYomiName = "ParentAccountIdYomiName";
            public const string ParentContactId = "ParentContactId";
            public const string ParentContactIdName = "ParentContactIdName";
            public const string ParentContactIdYomiName = "ParentContactIdYomiName";
            public const string ParticipatesInWorkflow = "ParticipatesInWorkflow";
            public const string ParticipatesInWorkflowName = "ParticipatesInWorkflowName";
            public const string PresentFinalProposal = "PresentFinalProposal";
            public const string PresentFinalProposalName = "PresentFinalProposalName";
            public const string PresentProposal = "PresentProposal";
            public const string PresentProposalName = "PresentProposalName";
            public const string PriceLevelId = "PriceLevelId";
            public const string PriceLevelIdName = "PriceLevelIdName";
            public const string PricingErrorCode = "PricingErrorCode";
            public const string PricingErrorCodeName = "PricingErrorCodeName";
            public const string PriorityCode = "PriorityCode";
            public const string PriorityCodeName = "PriorityCodeName";
            public const string ProcessId = "ProcessId";
            public const string ProposedSolution = "ProposedSolution";
            public const string PurchaseProcess = "PurchaseProcess";
            public const string PurchaseProcessName = "PurchaseProcessName";
            public const string PurchaseTimeframe = "PurchaseTimeframe";
            public const string PurchaseTimeframeName = "PurchaseTimeframeName";
            public const string PursuitDecision = "PursuitDecision";
            public const string PursuitDecisionName = "PursuitDecisionName";
            public const string QualificationComments = "QualificationComments";
            public const string QuoteComments = "QuoteComments";
            public const string ResolveFeedback = "ResolveFeedback";
            public const string ResolveFeedbackName = "ResolveFeedbackName";
            public const string SalesStage = "SalesStage";
            public const string SalesStageCode = "SalesStageCode";
            public const string SalesStageCodeName = "SalesStageCodeName";
            public const string SalesStageName = "SalesStageName";
            public const string ScheduleFollowup_Prospect = "ScheduleFollowup_Prospect";
            public const string ScheduleFollowup_Qualify = "ScheduleFollowup_Qualify";
            public const string ScheduleProposalMeeting = "ScheduleProposalMeeting";
            public const string SendThankYouNote = "SendThankYouNote";
            public const string SendThankYouNoteName = "SendThankYouNoteName";
            public const string SLAId = "SLAId";
            public const string SLAInvokedId = "SLAInvokedId";
            public const string SLAInvokedIdName = "SLAInvokedIdName";
            public const string SLAName = "SLAName";
            public const string StageId = "StageId";
            public const string StateCode = "StateCode";
            public const string StateCodeName = "StateCodeName";
            public const string StatusCode = "StatusCode";
            public const string StatusCodeName = "StatusCodeName";
            public const string StepId = "StepId";
            public const string StepName = "StepName";
            public const string TimeLine = "TimeLine";
            public const string TimelineName = "TimelineName";
            public const string TimeSpentByMeOnEmailAndMeetings = "TimeSpentByMeOnEmailAndMeetings";
            public const string TimeZoneRuleVersionNumber = "TimeZoneRuleVersionNumber";
            public const string TotalAmount = "TotalAmount";
            public const string TotalAmount_Base = "TotalAmount_Base";
            public const string TotalAmountLessFreight = "TotalAmountLessFreight";
            public const string TotalAmountLessFreight_Base = "TotalAmountLessFreight_Base";
            public const string TotalDiscountAmount = "TotalDiscountAmount";
            public const string TotalDiscountAmount_Base = "TotalDiscountAmount_Base";
            public const string TotalLineItemAmount = "TotalLineItemAmount";
            public const string TotalLineItemAmount_Base = "TotalLineItemAmount_Base";
            public const string TotalLineItemDiscountAmount = "TotalLineItemDiscountAmount";
            public const string TotalLineItemDiscountAmount_Base = "TotalLineItemDiscountAmount_Base";
            public const string TotalTax = "TotalTax";
            public const string TotalTax_Base = "TotalTax_Base";
            public const string TransactionCurrencyId = "TransactionCurrencyId";
            public const string TransactionCurrencyIdName = "TransactionCurrencyIdName";
            public const string TraversedPath = "TraversedPath";
            public const string UTCConversionTimeZoneCode = "UTCConversionTimeZoneCode";
            public const string VersionNumber = "VersionNumber";
            public const string vw_additionalcomment = "vw_additionalcomment";
            public const string vw_BrandId = "vw_BrandId";
            public const string vw_BrandIdName = "vw_BrandIdName";
            public const string vw_BuyotherbrandId = "vw_BuyotherbrandId";
            public const string vw_BuyotherbrandIdName = "vw_BuyotherbrandIdName";
            public const string vw_Category = "vw_Category";
            public const string vw_categoryName = "vw_categoryName";
            public const string vw_changedinRSE = "vw_changedinRSE";
            public const string vw_ClientSourceId = "vw_ClientSourceId";
            public const string vw_ClientSourceIdName = "vw_ClientSourceIdName";
            public const string vw_ConfirmDate = "vw_ConfirmDate";
            public const string vw_Confirmofpayment = "vw_Confirmofpayment";
            public const string vw_confirmofpaymentName = "vw_confirmofpaymentName";
            public const string vw_ContractDate = "vw_ContractDate";
            public const string vw_ContractNumber = "vw_ContractNumber";
            public const string vw_Cost = "vw_Cost";
            public const string vw_Coupon = "vw_Coupon";
            public const string vw_couponclosedate = "vw_couponclosedate";
            public const string vw_CreatedinRSE = "vw_CreatedinRSE";
            public const string vw_Currentuser = "vw_Currentuser";
            public const string vw_DealerId = "vw_DealerId";
            public const string vw_DealerIdName = "vw_DealerIdName";
            public const string vw_DealersContactId = "vw_DealersContactId";
            public const string vw_DealersContactIdName = "vw_DealersContactIdName";
            public const string vw_Descriptionofservice = "vw_Descriptionofservice";
            public const string vw_Drive = "vw_Drive";
            public const string vw_Engine = "vw_Engine";
            public const string vw_ExpectedTestdriveDate = "vw_ExpectedTestdriveDate";
            public const string vw_ID = "vw_ID";
            public const string vw_InfoSourceId = "vw_InfoSourceId";
            public const string vw_InfoSourceIdName = "vw_InfoSourceIdName";
            public const string vw_InsuranceCheck = "vw_InsuranceCheck";
            public const string vw_insurancecheckName = "vw_insurancecheckName";
            public const string vw_Integrationstatus = "vw_Integrationstatus";
            public const string vw_integrationstatusName = "vw_integrationstatusName";
            public const string vw_IsCorporate = "vw_IsCorporate";
            public const string vw_iscorporateName = "vw_iscorporateName";
            public const string vw_IsCredit = "vw_IsCredit";
            public const string vw_IsCreditConfirmed = "vw_IsCreditConfirmed";
            public const string vw_iscreditconfirmedName = "vw_iscreditconfirmedName";
            public const string vw_iscreditName = "vw_iscreditName";
            public const string vw_IsInsurance = "vw_IsInsurance";
            public const string vw_isinsuranceName = "vw_isinsuranceName";
            public const string vw_IsLeasing = "vw_IsLeasing";
            public const string vw_IsLeasingConfirmed = "vw_IsLeasingConfirmed";
            public const string vw_isleasingconfirmedName = "vw_isleasingconfirmedName";
            public const string vw_isleasingName = "vw_isleasingName";
            public const string vw_IsMysteryShopping = "vw_IsMysteryShopping";
            public const string vw_ismysteryshoppingName = "vw_ismysteryshoppingName";
            public const string vw_IsRepeat = "vw_IsRepeat";
            public const string vw_isrepeatName = "vw_isrepeatName";
            public const string vw_IsUsedCar = "vw_IsUsedCar";
            public const string vw_isusedcarName = "vw_isusedcarName";
            public const string vw_LastInteractioninRSE = "vw_LastInteractioninRSE";
            public const string vw_LastupdatefromRSE = "vw_LastupdatefromRSE";
            public const string vw_LineId = "vw_LineId";
            public const string vw_LineIdName = "vw_LineIdName";
            public const string vw_LostReasonId = "vw_LostReasonId";
            public const string vw_LostReasonIdName = "vw_LostReasonIdName";
            public const string vw_mainworklistid = "vw_mainworklistid";
            public const string vw_mainworklistidName = "vw_mainworklistidName";
            public const string vw_Mileage = "vw_Mileage";
            public const string vw_ModelId = "vw_ModelId";
            public const string vw_ModelIdName = "vw_ModelIdName";
            public const string vw_Orderyear = "vw_Orderyear";
            public const string vw_PhaseTypeId = "vw_PhaseTypeId";
            public const string vw_PhaseTypeIdName = "vw_PhaseTypeIdName";
            public const string vw_ProcessingStatus = "vw_ProcessingStatus";
            public const string vw_processingstatusName = "vw_processingstatusName";
            public const string vw_PromotionId = "vw_PromotionId";
            public const string vw_PromotionIdName = "vw_PromotionIdName";
            public const string vw_purchasedate = "vw_purchasedate";
            public const string vw_Registrationnumber = "vw_Registrationnumber";
            public const string vw_RSECode = "vw_RSECode";
            public const string vw_SatusChangeComment = "vw_SatusChangeComment";
            public const string vw_Servicedate = "vw_Servicedate";
            public const string vw_ServicestatusId = "vw_ServicestatusId";
            public const string vw_ServicestatusIdName = "vw_ServicestatusIdName";
            public const string vw_StatuschangereasonId = "vw_StatuschangereasonId";
            public const string vw_StatuschangereasonIdName = "vw_StatuschangereasonIdName";
            public const string vw_Term = "vw_Term";
            public const string vw_VIN = "vw_VIN";
            public const string vw_WorkListStatusId = "vw_WorkListStatusId";
            public const string vw_WorkListStatusIdName = "vw_WorkListStatusIdName";
            public const string vw_worklisttype = "vw_worklisttype";
            public const string vw_worklisttypeName = "vw_worklisttypeName";
            public const string vw_Year = "vw_Year";
            public const string vw_YearFrom = "vw_YearFrom";
            public const string vw_YearTo = "vw_YearTo";

        }
    }
}