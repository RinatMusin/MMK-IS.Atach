using Microsoft.EntityFrameworkCore;
using MMK_IS.Atach.Domain.Entities;
using MMK_IS.Atach.Domain.Entities.Dictionary;
using MMK_IS.Atach.Persistence.Configurations;
using MMK_IS.Atach.Persistence.Configurations.Dictionary;
using MMK_IS.Atach.Domain;


namespace MMK_IS.Atach.Persistence
{
    public partial class CommonContext : DbContext// IdentityDbContext<ApplicationUser>
    {
        static CommonContext()
        {
            Database.SetInitializer<CommonContext>(null);

        }
        public CommonContext() : base("Name=CommonContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

    //TODO   public DbSet<IdentityUserRole> IdentityUserRoles { get; set; }
        public DbSet<DocumentAttachment> DocumentAttachments { get; set; }
        public DbSet<FileProcessingStatus> FileProcessingStatuses { get; set; }
        public DbSet<FileEdit> AttachmentEdits { get; set; }

        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldCounterPartyType> FieldCounterParties { get; set; }

        public DbSet<FieldProperty> FieldProperties { get; set; }
        public DbSet<FieldDependency> FieldDependencies { get; set; }
        public DbSet<FieldTargetType> FieldTargetTypes { get; set; }

        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentStatus> DocumentStatuses { get; set; }
        public DbSet<DocumentTemplate> DocumentTemplates { get; set; }


        public DbSet<File> Files { get; set; }
        public DbSet<FileType> FileTypes { get; set; }

        public DbSet<FilePage> FilePages { get; set; }
        public DbSet<TaskEntity> TaskEntities { get; set; }
        public DbSet<TaskHistory> TaskHistories { get; set; }
        public DbSet<TaskAction> TaskActions { get; set; }


        public DbSet<FieldGroup> FieldGroups { get; set; }

        public DbSet<FieldType> FieldTypes { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardField> CardFields { get; set; }
        public DbSet<CardFieldDefaultValue> CardFieldDefaultValues { get; set; }
        public DbSet<TaskStatus> TaskStatuses { get; set; }
        public DbSet<TaskStatusType> TaskStatusTypes { get; set; }
        public DbSet<TaskStatusActivity> TaskStatusActivities { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }

        public DbSet<DocumentFieldValue> DocumentFieldValues { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<StampPosition> StampPositions { get; set; }
        public DbSet<StampPositionType> StampPositionTypes { get; set; }
        public DbSet<DocumentTypeRole> DocumentTypeRoles { get; set; }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<ClientProfileReplacement> ClientProfileReplacements { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<ApplicationType> ApplicationTypes { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityProperty> ActivityProperties { get; set; }
        public DbSet<DocumentTypeActivity> DocumentTypeActivities { get; set; }
        public DbSet<ApplicationRoleActivity> ApplicationRoleActivities { get; set; }
        public DbSet<ApplicationRoleEditPermission> ApplicationRoleEditPermissions { get; set; }
        public DbSet<ApplicationRoleReadPermission> ApplicationRoleReadPermissions { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }


        public DbSet<UserOrganization> UserOrganizations { get; set; }
        public DbSet<UserOrganizationType> UserOrganizationTypes { get; set; }

        public DbSet<RouteTemplate> RouteTemplates { get; set; }
        public DbSet<RouteStepType> RouteStepTypes { get; set; }
        public DbSet<RouteAction> RouteActions { get; set; }
        public DbSet<RouteActionType> RouteActionTypes { get; set; }
        public DbSet<RouteActionField> RouteActionFields { get; set; }
        public DbSet<RouteStepTemplate> RouteStepTemplates { get; set; }
        public DbSet<RouteActionFieldType> RouteActionFieldTypes { get; set; }
        public DbSet<RouteMethod> RouteMethods { get; set; }
        public DbSet<RouteActionFieldMethod> RouteActionFieldMethods { get; set; }

        public DbSet<Route> Routes { get; set; }
        public DbSet<RouteStep> RouteSteps { get; set; }
        public DbSet<Log> Logs { get; set; }

        public DbSet<RouteStepGroup> RouteStepGroups { get; set; }

        public DbSet<ViewPanel> ViewPanels { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentProperty> ComponentProperties { get; set; }
        public DbSet<ComponentElement> ComponentElements { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }
        public DbSet<ElementProperty> ElementProperties { get; set; }
        public DbSet<ElementDefaultValue> ElementDefaultValues { get; set; }

        public DbSet<RouteStepNote> RouteStepNotes { get; set; }

        public DbSet<DictionaryOrganization> DictionaryOrganizations { get; set; }
        public DbSet<DictionaryUser> DictionaryUsers { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }

        public DbSet<DictionarySubdivisionOZM> DictionarySubdivisionOZMs { get; set; }

        public DbSet<MethodGroupe> MethodGroupes { get; set; }
        public DbSet<MethodGroupeMethod> MethodGroupeMethods { get; set; }
        public DbSet<WorkplaceUser> WorkplaceUsers { get; set; }

        public DbSet<DictionaryCurrency> Currency { get; set; }
        public DbSet<DictionaryPaymentTerms> DictionaryPaymentTerms { get; set; }
        public DbSet<DictionarySendingForRevision> SendingForRevision { get; set; }
        public DbSet<DictionaryTypesOfContract> TypesOfContract { get; set; }
        public DbSet<DictionaryTypesOfDocumentContract> TypesOfDocumentContract { get; set; }
        public DbSet<DictionaryKindOfDocument> KindOfDocument { get; set; }
        public DbSet<DictionarySubSubject> DictionarySubSubject { get; set; }
        public DbSet<DictionarySubject> DictionarySubject { get; set; }
        public DbSet<DictionaryYesNo> DictionaryYesNo { get; set; }
        public DbSet<DictionaryGroupCFO> DictionaryGroupCFO { get; set; }
        public DbSet<DictionarySubSubjectGroupCFO> DictionarySubSubjectGroupCFO { get; set; }
        public DbSet<DictionaryGroupParticipant> DictionaryGroupParticipant { get; set; }
        public DbSet<DictionaryUserParticipant> DictionaryUserParticipant { get; set; }
        public DbSet<DictionarySubSubjectParticipant> DictionarySubSubjectParticipant { get; set; }
        public DbSet<DictionaryCounterPartyType> DictionaryCounterPartyType { get; set; }
        public DbSet<DictionaryCounterParty> DictionaryCounterParty { get; set; }
        public DbSet<DictionaryGroupCFOUsers> DictionaryGroupCFOUsers { get; set; }
        public DbSet<DictionaryDivizionOZM> DictionaryDivizionOZMs { get; set; }
        public DbSet<DictionaryProperty> DictionaryProperties { get; set; }
        public DbSet<DictionaryPropertyType> DictionaryPropertyTypes { get; set; }
        public DbSet<RouteStepProperty> RouteStepProperties { get; set; }
        public DbSet<RouteStepTemplateProperty> RouteStepTemplateProperties { get; set; }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatMember> ChatMembers { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<ChatMessageAttachment> ChatMessageAttachments { get; set; }
        public DbSet<ChatMessageReaded> ChatMessageReadeds { get; set; }
        public DbSet<DictionarySubSubjectDocumentTemplate> DictionarySubSubjectDocumentTemplates { get; set; }
        public DbSet<ChatMessagesQnt> ChatMessagesQnt { get; set; }
        public DbSet<DSSAuthenticationData> DSSAuthenticationData { get; set; }
        public DbSet<SignRequestLog> SignRequestLog { get; set; }
        public DbSet<SignDocsQueue> SignDocsQueue { get; set; }

        public DbSet<CargoCarrier> CargoCarriers { get; set; }
        public DbSet<CargoName> CargoNames { get; set; }
        public DbSet<DeliveryDirection> DeliveryDirections { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new CardFieldConfiguration());
            modelBuilder.ApplyConfiguration(new CardFieldDefaultValueConfiguration());
            modelBuilder.ApplyConfiguration(new FieldConfiguration());
            modelBuilder.ApplyConfiguration(new FieldPropertyConfiguration());
            modelBuilder.ApplyConfiguration(new FieldDependencyConfiguration());
            modelBuilder.ApplyConfiguration(new FieldTargetTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FieldGroupConfiguration());
            modelBuilder.ApplyConfiguration(new FieldTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FieldCounterPartyTypeConfiguration());

            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentStatusConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentFieldValueConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentTypeRoleConfiguration());

            modelBuilder.ApplyConfiguration(new StampPositionConfiguration());
            modelBuilder.ApplyConfiguration(new StampPositionTypeConfiguration());

            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            modelBuilder.ApplyConfiguration(new TaskStatusConfiguration());
            modelBuilder.ApplyConfiguration(new TaskStatusActivityConfiguration());
            modelBuilder.ApplyConfiguration(new TaskTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TaskStatusTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TaskActionConfiguration());
            modelBuilder.ApplyConfiguration(new TaskHistoryConfiguration());

            modelBuilder.ApplyConfiguration(new FileConfiguration());
            modelBuilder.ApplyConfiguration(new FileTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FileEditConfiguration());
            modelBuilder.ApplyConfiguration(new FilePageConfiguration());
            modelBuilder.ApplyConfiguration(new AttachmentConfiguration());
            modelBuilder.ApplyConfiguration(new FileProcessingStatusConfiguration());

            modelBuilder.ApplyConfiguration(new ClientProfileConfiguration());
            modelBuilder.ApplyConfiguration(new ClientProfileReplacementConfiguration());
            modelBuilder.ApplyConfiguration(new WorkplaceConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new RefreshTokenConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationTypeConfiguration());

            modelBuilder.ApplyConfiguration(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration(new ActivityPropertyConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentTypeActivityConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationRoleActivityConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationRoleEditPermissionConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationRoleReadPermissionConfiguration());


            modelBuilder.ApplyConfiguration(new UserGroupConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());

            modelBuilder.ApplyConfiguration(new UserOrganizationConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizationTypeConfiguration());

            modelBuilder.ApplyConfiguration(new RouteTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new RouteStepTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RouteActionConfiguration());
            modelBuilder.ApplyConfiguration(new RouteActionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RouteActionFieldConfiguration());
            modelBuilder.ApplyConfiguration(new RouteStepTemplateConfiguration());

            modelBuilder.ApplyConfiguration(new RouteConfiguration());
            modelBuilder.ApplyConfiguration(new RouteStepConfiguration());
            modelBuilder.ApplyConfiguration(new RouteStepGroupConfiguration());
            modelBuilder.ApplyConfiguration(new RouteMethodConfiguration());
            modelBuilder.ApplyConfiguration(new RouteActionFieldMethodConfiguration());
            modelBuilder.ApplyConfiguration(new RouteActionFieldTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RouteStepNoteConfiguration());

            modelBuilder.ApplyConfiguration(new ViewPanelConfiguration());
            modelBuilder.ApplyConfiguration(new ComponentConfiguration());
            modelBuilder.ApplyConfiguration(new ComponentPropertyConfiguration());
            modelBuilder.ApplyConfiguration(new ComponentElementConfiguration());
            modelBuilder.ApplyConfiguration(new ElementConfiguration());
            modelBuilder.ApplyConfiguration(new UserSettingsConfiguration());
            modelBuilder.ApplyConfiguration(new ElementPropertyConfiguration());
            modelBuilder.ApplyConfiguration(new ElementDefaultValueConfiguration());

            modelBuilder.ApplyConfiguration(new LogConfiguration());

            modelBuilder.ApplyConfiguration(new OrganizationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryMethodConfiguration());
            modelBuilder.ApplyConfiguration(new SubdivisionOZMConfiguration());

            modelBuilder.ApplyConfiguration(new MethodGroupeConfiguration());
            modelBuilder.ApplyConfiguration(new MethodGroupeMethodConfiguration());
            modelBuilder.ApplyConfiguration(new WorkplaceUserConfiguration());
            modelBuilder.ApplyConfiguration(new DictionaryCurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentTermsConfiguration());
            modelBuilder.ApplyConfiguration(new SendingForRevisionConfiguration());
            modelBuilder.ApplyConfiguration(new TypesOfContractConfiguration());
            modelBuilder.ApplyConfiguration(new TypesOfDocumentContractConfiguration());
            modelBuilder.ApplyConfiguration(new KindOfDocumentConfiguration());
            modelBuilder.ApplyConfiguration(new SubSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new YesNoConfiguration());
            modelBuilder.ApplyConfiguration(new GroupCFOConfiguration());
            modelBuilder.ApplyConfiguration(new SubSubjectGroupCFOConfiguration());
            modelBuilder.ApplyConfiguration(new GroupParticipantConfiguration());
            modelBuilder.ApplyConfiguration(new UserParticipantConfiguration());
            modelBuilder.ApplyConfiguration(new SubSubjectParticipantConfiguration());
            modelBuilder.ApplyConfiguration(new CounterPartyTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CounterPartyConfiguration());
            modelBuilder.ApplyConfiguration(new GroupCFOUsersConfiguration());
            modelBuilder.ApplyConfiguration(new DictionaryDivizionOZMConfiguration());
            modelBuilder.ApplyConfiguration(new DSSAuthenticationDataConfiguration());

            modelBuilder.ApplyConfiguration(new DictionaryPropertyConfiguration());
            modelBuilder.ApplyConfiguration(new DictionaryPropertyTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RouteStepPropertyConfiguration());
            modelBuilder.ApplyConfiguration(new RouteStepTemplatePropertyConfiguration());



            modelBuilder.ApplyConfiguration(new ChatMessageConfiguration());
            modelBuilder.ApplyConfiguration(new ChatMessageAttachmentConfiguration());
            modelBuilder.ApplyConfiguration(new ChatMessageReadedConfiguration());
            modelBuilder.ApplyConfiguration(new ChatMemberConfiguration());
            modelBuilder.ApplyConfiguration(new ChatConfiguration());
            modelBuilder.ApplyConfiguration(new SubSubjectDocumentTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new ChatMessagesQntConfiguration());
            modelBuilder.ApplyConfiguration(new SignRequestLogConfiguration());
            modelBuilder.ApplyConfiguration(new SignDocsQueueConfiguration());

            modelBuilder.ApplyConfiguration(new CargoCarrierConfiguration());
            modelBuilder.ApplyConfiguration(new CargoNameConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryDirectionConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());

            modelBuilder.ApplyConfiguration(new RatingConfiguration());
        }
    }
}