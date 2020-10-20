using Microsoft.EntityFrameworkCore;
using MMK_IS.Atach.Domain.Entities;
using MMK_IS.Atach.Domain.Entities.Dictionary;
using MMK_IS.Atach.Persistence.Configurations;
using MMK_IS.Atach.Persistence.Configurations.Dictionary;
using MMK_IS.Atach.Domain;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MMK_IS.Atach.Persistence
{
    public partial class CommonContext : DbContext// IdentityDbContext<ApplicationUser>
    {
        public CommonContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseLazyLoadingProxies().UseNpgsql("Server=192.168.137.124;User Id=touchdb;Password=qwe12345;Port=5432;Database=attach_core;");
            optionsBuilder.UseNpgsql("Server=192.168.137.124;User Id=touchdb;Password=qwe12345;Port=5432;Database=attach_core;");
        }

        //   public DbSet<IdentityUserRole> IdentityUserRoles { get; set; }
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
        public DbSet<WorkplaceProperty> WorkplaceProperties { get; set; }


        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityProperty> ActivityProperties { get; set; }
        public DbSet<DocumentTypeActivity> DocumentTypeActivities { get; set; }
        public DbSet<ApplicationRoleActivity> ApplicationRoleActivities { get; set; }
        public DbSet<ApplicationRoleEditPermission> ApplicationRoleEditPermissions { get; set; }
        public DbSet<ApplicationRoleReadPermission> ApplicationRoleReadPermissions { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<GroupAssign> GroupAssigns { get; set; }
        public DbSet<UserGroupAssign> UserGroupAssigns { get; set; }



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
        public DbSet<DefaultUserSettings> DefaultUserSettings { get; set; }

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
        public DbSet<DictionaryKindOfOrderOZ> KindOfOrderOZ { get; set; }
        public DbSet<DictionaryKindOfStatement> KindOfStatement { get; set; }
        public DbSet<DictionaryDepartmentDirectory> DepartmentDirectory { get; set; }
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
        public DbSet<DictionaryPropertyDocumentType> DictionaryPropertyDocumentTypes { get; set; }
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

        public DbSet<Domain.Entities.Notification.Notification> Notifications { get; set; }
        public DbSet<Domain.Entities.Notification.NotificationTemplate> NotificationTemplates { get; set; }
        public DbSet<Domain.Entities.Notification.NotificationTemplateTag> NotificationTemplateTags { get; set; }
        public DbSet<Domain.Entities.Notification.NotificationTemplateVariable> NotificationTemplateVariables { get; set; }
        public DbSet<Domain.Entities.Notification.NotificationType> NotificationTypes { get; set; }

        public DbSet<KonturCloudTransaction> konturCloudTransactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationRole>(c => c.HasNoKey());

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
            modelBuilder.ApplyConfiguration(new WorkplacePropertyConfiguration());
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
            modelBuilder.ApplyConfiguration(new DefaultUserSettingsConfiguration());
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
            modelBuilder.ApplyConfiguration(new KindOfOrderOZConfiguration());
            modelBuilder.ApplyConfiguration(new KindOfStatementConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentDirectoryConfiguration());
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
            modelBuilder.ApplyConfiguration(new DictionaryPropertyDocumentTypeConfiguration());
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

            // Notifications mapping
            modelBuilder.ApplyConfiguration(new Configurations.Notification.NotificationConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.Notification.NotificationTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.Notification.NotificationTemplateTagConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.Notification.NotificationTemplateVariableConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.Notification.NotificationTypeConfiguration());

            modelBuilder.ApplyConfiguration(new KonturCloudTransactionConfiguration());




            modelBuilder.Entity<DictionaryPropertyType>().HasData(
            new DictionaryPropertyType
            {
                PropertyTypeId = Guid.Parse("f2b86841-ca7b-407b-b6e1-fb1b5f860ac4")
            }
            );

            var properties = new List<DictionaryProperty>
            {
                new DictionaryProperty
                {
                    Name = "ReApproval",
                    PropertyId = Guid.Parse("8e912623-a2ae-4a89-b8a4-3226f0a126f3"),
                    PropertyTypeId = Guid.Parse("f2b86841-ca7b-407b-b6e1-fb1b5f860ac4")
                },

                new DictionaryProperty
                {
                    Name = "ReApprovalWithdrawn",
                    PropertyId = Guid.Parse("9f89e5c6-2d52-4d78-bdea-20d4061cb90d"),
                    PropertyTypeId = Guid.Parse("f2b86841-ca7b-407b-b6e1-fb1b5f860ac4")
                }
            };
            modelBuilder.Entity<DictionaryProperty>().HasData(properties);


            var propertyDocTypes = new List<DictionaryPropertyDocumentType>
            {
                #region TD-1990 2 этап. Модернизация процесса принятия решения по документу
                new DictionaryPropertyDocumentType
                {
                    DictionaryPropertyDocumentTypeId = Guid.Parse("426ff152-8cff-4a91-ae91-bb59743de672"),
                    PropertyId = Guid.Parse("8e912623-a2ae-4a89-b8a4-3226f0a126f3"),
                    DocumentTypeId = Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b"),
                },
                new DictionaryPropertyDocumentType
                {
                    DictionaryPropertyDocumentTypeId = Guid.Parse("9655fc68-6b1f-4b31-8f3d-bd3a86172a96"),
                    PropertyId = Guid.Parse("8e912623-a2ae-4a89-b8a4-3226f0a126f3"),
                    DocumentTypeId = Guid.Parse("c64b0c39-b6c9-4abb-9f3d-e6e90833e0c0"),
                },
                #endregion

                #region TD-1990 2 этап. Модернизация функционала «Отозвать документ»
                new DictionaryPropertyDocumentType
                {
                    DictionaryPropertyDocumentTypeId = Guid.Parse("88386d9e-37f6-4bd6-8760-d0ab2b1f5408"),
                    PropertyId = Guid.Parse("9f89e5c6-2d52-4d78-bdea-20d4061cb90d"),
                    DocumentTypeId = Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b"),
                },
                new DictionaryPropertyDocumentType
                {
                    DictionaryPropertyDocumentTypeId = Guid.Parse("f28aa542-fa4d-4c7b-b406-9e183768e19c"),
                    PropertyId = Guid.Parse("9f89e5c6-2d52-4d78-bdea-20d4061cb90d"),
                    DocumentTypeId = Guid.Parse("c64b0c39-b6c9-4abb-9f3d-e6e90833e0c0"),
                },
                #endregion
            };
            modelBuilder.Entity<DictionaryPropertyDocumentType>().HasData(propertyDocTypes);

            var taskStatusTypes = new List<TaskStatusType>
            {
                new TaskStatusType
                {
                    TaskStatusTypeId = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    Name = "Cancel_Roll_Back"
                },  new TaskStatusType
                {
                    TaskStatusTypeId = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    Name = "Cancel_Roll_Back"
                },
                new TaskStatusType
                {
                    TaskStatusTypeId = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    Name = "Cancel_Roll_Back"
                },
                 new TaskStatusType
                {
                    TaskStatusTypeId = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    Name = "Cancel_Roll_Back"
                },
                  new TaskStatusType
                {
                    TaskStatusTypeId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    Name = "Cancel_Roll_Back"
                }
            };
            modelBuilder.Entity<TaskStatusType>().HasData(taskStatusTypes);

            var taskStatuses = new List<TaskStatus>
            {
                // Изменение подписанта
                new TaskStatus
                {
                    TaskStatusId = Guid.Parse("4605b437-4dca-4c92-856a-211c308ddbe9"),
                    StatusTypeId = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    Name = "На изменении подписанта",
                    CenterPanelType = "DRAFT_EDIT",
                    RightPanelType = "ROUTE",
                    SortOrder = 2,
                    StatusColor = "P_WHITE",
                },
                new TaskStatus
                {
                    TaskStatusId = Guid.Parse("99ec51d2-c7e7-41ed-8abf-ee63c1710613"),
                    StatusTypeId = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    Name = "Подписант изменен",
                    CenterPanelType = "DRAFT_DISABLED",
                    RightPanelType = "ROUTE_WITHOUT_ACTION",
                    SortOrder = 1,
                    StatusColor = "P_GREEN",
                },

                // Согласование изменений
                new TaskStatus
                {
                    TaskStatusId = Guid.Parse("b2ff87ea-a546-4a4c-a9b3-1f1263671deb"),
                    StatusTypeId = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    Name = "На согласование",
                    CenterPanelType = "FOR_APPROVAL_TAB",
                    RightPanelType = "ROUTE",
                    SortOrder = 2,
                    StatusColor = "P_WHITE",
                },
                new TaskStatus
                {
                    TaskStatusId = Guid.Parse("ffa39af4-0c81-4413-8ecb-8e00c274cb0d"),
                    StatusTypeId = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    Name = "Отклонено",
                    CenterPanelType = "FOR_APPROVAL_TAB",
                    RightPanelType = "ROUTE_WITHOUT_ACTION",
                    SortOrder = 1,
                    StatusColor = "P_RED",
                },
                   new TaskStatus
                {
                    TaskStatusId = Guid.Parse("00528441-39ed-40b5-9b8d-ee3887db8a45"),
                    StatusTypeId = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    Name = "Регистрация договора",
                    CenterPanelType = "FOR_APPROVAL_TAB",
                    RightPanelType = "ROUTE_WITHOUT_ACTION",
                    SortOrder = 1,
                    StatusColor = "P_RED",
                },
                     new TaskStatus
                {
                    TaskStatusId = Guid.Parse("b04c647c-7c05-4ded-aaa9-b7a4465f27c3"),
                    StatusTypeId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    Name = "На подписании",
                    CenterPanelType = "FOR_APPROVAL_TAB",
                    RightPanelType = "ROUTE_WITHOUT_ACTION",
                    SortOrder = 1,
                    StatusColor = "P_RED",
                },
                  new TaskStatus
                {
                    TaskStatusId = Guid.Parse("f9b78168-c08a-429e-b020-10566fdfb0c7"),
                    StatusTypeId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    Name = "На подписании",
                    CenterPanelType = "FOR_APPROVAL_TAB",
                    RightPanelType = "ROUTE_WITHOUT_ACTION",
                    SortOrder = 1,
                    StatusColor = "P_RED",
                },
                  new TaskStatus{
                        TaskStatusId = Guid.Parse("a8e5927b-e95a-4db7-8185-c78d8ea86e6c"),
                          StatusTypeId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    Name = "--",
                    CenterPanelType = "FOR_APPROVAL_TAB",
                    RightPanelType = "ROUTE_WITHOUT_ACTION",
                    SortOrder = 1,
                    StatusColor = "P_RED",
                  },
                   new TaskStatus{
                        TaskStatusId = Guid.Parse("afea2260-b7a6-452c-9b99-1a3f271e92c1"),
                          StatusTypeId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    Name = "--",
                    CenterPanelType = "FOR_APPROVAL_TAB",
                    RightPanelType = "ROUTE_WITHOUT_ACTION",
                    SortOrder = 1,
                    StatusColor = "P_RED",
                  },
                    new TaskStatus{
                        TaskStatusId = Guid.Parse("3ca781d3-03b0-4e23-82b3-1854c95d6e91"),
                          StatusTypeId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    Name = "--",
                    CenterPanelType = "FOR_APPROVAL_TAB",
                    RightPanelType = "ROUTE_WITHOUT_ACTION",
                    SortOrder = 1,
                    StatusColor = "P_RED",
                  }
            };
            modelBuilder.Entity<TaskStatus>().HasData(taskStatuses);

            var routeActionTypes = new List<RouteActionType>
            {

                new RouteActionType
                {
                    RouteActionTypeId = Guid.Parse("0546806e-9ed6-4a9d-bfc1-b960676bbaf6"),
                },
            };
            modelBuilder.Entity<RouteActionType>().HasData(routeActionTypes);

            var routeActions = new List<RouteAction>
            {
                //Изменение подписанта
                new RouteAction
                {
                    RouteActionTypeId = Guid.Parse("0546806e-9ed6-4a9d-bfc1-b960676bbaf6"),
                    RouteActionId = Guid.Parse("5117cc94-3153-4bb4-aa1e-57d77115a056"),
                    Name = "Измененить подписанта",
                },

                //Согласование изменений
                new RouteAction
                {
                    RouteActionTypeId = Guid.Parse("0546806e-9ed6-4a9d-bfc1-b960676bbaf6"),
                    RouteActionId = Guid.Parse("df764d31-c825-44c5-bd7d-84708e4c8d67"),
                    Name = "Согласовать изменения",
                },

                // TD-1990 2 этап. Модернизация процесса принятия решения по документу
                new RouteAction
                {
                    RouteActionTypeId = Guid.Parse("0546806e-9ed6-4a9d-bfc1-b960676bbaf6"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    Name = "Согласовать",
                },
                 new RouteAction
                {
                    RouteActionTypeId = Guid.Parse("0546806e-9ed6-4a9d-bfc1-b960676bbaf6"),
                    RouteActionId = Guid.Parse("3398fb67-3154-4ee2-a510-128d27772ac8"),
                    Name = "Задать",
                }, new RouteAction
                {
                    RouteActionTypeId = Guid.Parse("0546806e-9ed6-4a9d-bfc1-b960676bbaf6"),
                    RouteActionId = Guid.Parse("a5c41f33-b06f-4721-b2a3-14b91297a464"),
                    Name = "Задать",
                },
                };
            modelBuilder.Entity<RouteAction>().HasData(routeActions);

            var routeMethods = new List<RouteMethod>
            {
                //Согласование изменений
                new RouteMethod
                {
                    RouteMethodId = Guid.Parse("9cd6b0bd-f66e-4d44-8a87-a6273d8596c9"),
                    Name = "DenyRollBack"
                },
                //вставить QR and Watermark
                new RouteMethod
                {
                    RouteMethodId = Guid.Parse("ca1f1fd9-8c31-4ea7-80d0-22aea52af893"),
                    Name = "InsertQRAndWatermark"
                },
                new RouteMethod{
                    RouteMethodId=Guid.Parse("2e687d51-ab34-4cee-a29a-1249e61ddf55"),
                    Name="Задать"
                },
                  new RouteMethod{
                    RouteMethodId=Guid.Parse("15e24f35-3bc4-4326-978b-bb821cb5282e"),
                    Name="Задать"
                },
                     new RouteMethod{
                    RouteMethodId=Guid.Parse("b32f371f-fd13-4ac5-b090-fd386ab56957"),
                    Name="Задать"
                },
                       new RouteMethod{
                    RouteMethodId=Guid.Parse("f588dee0-bac9-4da3-9a1f-478b9b98b1f6"),
                    Name="Задать"
                },
                        new RouteMethod{
                    RouteMethodId=Guid.Parse("ed9dce5a-43f6-4b4a-a3bd-b353c31ae5f1"),
                    Name="Задать"
                },
                        new RouteMethod{
                    RouteMethodId=Guid.Parse("3398fb67-3154-4ee2-a510-128d27772ac8"),
                    Name="Задать"
                }
            };
            modelBuilder.Entity<RouteMethod>().HasData(routeMethods);

            var methodGroupes = new List<MethodGroupe>
            {
                //вставить QR and Watermark
                new MethodGroupe
                {
                    MethodGroupeId = Guid.Parse("ecf5765c-4c49-4046-a5c3-62f2174b4fb1"),
                },
                new MethodGroupe
                {
                    MethodGroupeId = Guid.Parse("21905bdb-0cf2-4286-aacf-3be3e651e3ae"),
                },
                new MethodGroupe
                {
                    MethodGroupeId = Guid.Parse("2907c1b0-f9f9-4044-b943-7867f1086477"),
                },
                new MethodGroupe
                {
                    MethodGroupeId = Guid.Parse("88076a94-4a88-48bb-9380-4a513f377754"),
                },
                

            };
            modelBuilder.Entity<MethodGroupe>().HasData(methodGroupes);

            var methodGroupeMethods = new List<MethodGroupeMethod>
            {
                //вставить QR and Watermark
                new MethodGroupeMethod
                {
                    MethodGroupeMethodId = Guid.Parse("577970bd-5a96-4808-b79c-1afb3c78b574"),
                    RouteMethodId = Guid.Parse("ca1f1fd9-8c31-4ea7-80d0-22aea52af893"),
                    MethodGroupeId = Guid.Parse("ecf5765c-4c49-4046-a5c3-62f2174b4fb1"),
                }
            };
            modelBuilder.Entity<MethodGroupeMethod>().HasData(methodGroupeMethods);


            var routeActionFieldTypes = new List<RouteActionFieldType>
            {
                new RouteActionFieldType
                {
                RouteActionFieldTypeId = Guid.Parse("9d569ac6-3316-402a-b5bb-52c896904fa2")
            },
                new RouteActionFieldType
                {
                    RouteActionFieldTypeId = Guid.Parse("89bbf4e2-f474-465c-b902-0edd36997550")
                },
                new RouteActionFieldType
                {
                    RouteActionFieldTypeId = Guid.Parse("74a6bc0c-88cb-4e60-93e6-a9e6c72363b0")
                }, new RouteActionFieldType
                {
                RouteActionFieldTypeId = Guid.Parse("4574e29f-8468-4ed0-8c09-cf217a431f0f")
                }
                 };
            modelBuilder.Entity<RouteActionFieldType>().HasData(routeActionFieldTypes);

            var routeActionsFields = new List<RouteActionField>
            {
                //Изменение подписанта
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("77ef8162-342c-41f7-8217-22003929644c"),
                    DisplayOrder = 5,
                    RouteActionFieldTypeId = Guid.Parse("89bbf4e2-f474-465c-b902-0edd36997550"),
                    Name = "Изменения внесены",
                    RouteActionId = Guid.Parse("5117cc94-3153-4bb4-aa1e-57d77115a056"),
                },

                //Согласование изменений
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("c98c17a1-8a74-4764-a973-96a08a19fd8a"),
                    DisplayOrder = 5,
                    RouteActionFieldTypeId = Guid.Parse("4574e29f-8468-4ed0-8c09-cf217a431f0f"),
                    Name = "Комментарий",
                    RouteActionId = Guid.Parse("df764d31-c825-44c5-bd7d-84708e4c8d67"),
                },
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("a4cf058e-ffc7-488d-a910-c533da1533df"),
                    DisplayOrder = 10,
                    RouteActionFieldTypeId = Guid.Parse("89bbf4e2-f474-465c-b902-0edd36997550"),
                    Name = "Согласовать",
                    RouteActionId = Guid.Parse("df764d31-c825-44c5-bd7d-84708e4c8d67"),
                },
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("063551fd-feec-4d14-a55d-6070fd5e6754"),
                    DisplayOrder = 15,
                    RouteActionFieldTypeId = Guid.Parse("89bbf4e2-f474-465c-b902-0edd36997550"),
                    Name = "Отклонить",
                    RouteActionId = Guid.Parse("df764d31-c825-44c5-bd7d-84708e4c8d67"),
                },

                #region TD-1990 2 этап. Модернизация процесса принятия решения по документу
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("5d6f03d0-e13d-48c3-b979-40f1343afb68"),
                    DisplayOrder = 20,
                    RouteActionFieldTypeId = Guid.Parse("89bbf4e2-f474-465c-b902-0edd36997550"),
                    Name = "Согласовать",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                },
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("8e85f5ca-7e61-4d0c-96cd-9ff8604e9fc6"),
                    DisplayOrder = 25,
                    RouteActionFieldTypeId = Guid.Parse("89bbf4e2-f474-465c-b902-0edd36997550"),
                    Name = "Отклонить",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                },
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("61ced04a-403f-443e-9185-a4a4b2bec306"),
                    DisplayOrder = 12,
                    RouteActionFieldTypeId = Guid.Parse("4574e29f-8468-4ed0-8c09-cf217a431f0f"),
                    Name = "Комментарий",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                },
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("9221e018-623f-425e-976d-36d889c24d95"),
                    DisplayOrder = 5,
                    RouteActionFieldTypeId = Guid.Parse("9d569ac6-3316-402a-b5bb-52c896904fa2"),
                    Name = "SlideCheckBox",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                },
                new RouteActionField
                {
                    ActionFieldId = Guid.Parse("35cc121b-766c-430a-833c-f8602f56aac2"),
                    DisplayOrder = 15,
                    RouteActionFieldTypeId = Guid.Parse("74a6bc0c-88cb-4e60-93e6-a9e6c72363b0"),
                    Name = "FileUploadComment",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                },
                #endregion
            };
            modelBuilder.Entity<RouteActionField>().HasData(routeActionsFields);

            var routeActionFieldMethods = new List<RouteActionFieldMethod>
            {
                //Изменение подписанта
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("77ef8162-342c-41f7-8217-22003929644c"),
                    RouteMethodId = Guid.Parse("2e687d51-ab34-4cee-a29a-1249e61ddf55"),
                    RouteActionFieldMethodId = Guid.Parse("ddab763b-0722-4f44-b261-c26d1044bf76"),
                },

                //Согласование изменений
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("c98c17a1-8a74-4764-a973-96a08a19fd8a"),
                    RouteMethodId = Guid.Parse("b32f371f-fd13-4ac5-b090-fd386ab56957"),
                    RouteActionFieldMethodId = Guid.Parse("87aa6e62-b0db-4d62-9a48-19775a4cfc99"),
                },
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("a4cf058e-ffc7-488d-a910-c533da1533df"),
                    RouteMethodId = Guid.Parse("2e687d51-ab34-4cee-a29a-1249e61ddf55"),
                    RouteActionFieldMethodId = Guid.Parse("44b086b2-b028-4859-b89f-8669b64d1dd1"),
                },
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("063551fd-feec-4d14-a55d-6070fd5e6754"),
                    RouteMethodId = Guid.Parse("9cd6b0bd-f66e-4d44-8a87-a6273d8596c9"),
                    RouteActionFieldMethodId = Guid.Parse("18f98bb1-70aa-471f-9a81-72368263b2b8")
                },

                #region TD-1990 2 этап. Модернизация процесса принятия решения по документу
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("35cc121b-766c-430a-833c-f8602f56aac2"),
                    RouteMethodId = Guid.Parse("ed9dce5a-43f6-4b4a-a3bd-b353c31ae5f1"),
                    RouteActionFieldMethodId = Guid.Parse("167b4d47-854c-4164-b49c-91269c67b6a5")
                },
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("5d6f03d0-e13d-48c3-b979-40f1343afb68"),
                    RouteMethodId = Guid.Parse("2e687d51-ab34-4cee-a29a-1249e61ddf55"),
                    RouteActionFieldMethodId = Guid.Parse("dc13e489-bc66-4340-9b28-653404fe2d23")
                },
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("61ced04a-403f-443e-9185-a4a4b2bec306"),
                    RouteMethodId = Guid.Parse("b32f371f-fd13-4ac5-b090-fd386ab56957"),
                    RouteActionFieldMethodId = Guid.Parse("e2d1b89e-6ef8-4bc0-89f8-740efed5630a")
                },
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("8e85f5ca-7e61-4d0c-96cd-9ff8604e9fc6"),
                    RouteMethodId = Guid.Parse("f588dee0-bac9-4da3-9a1f-478b9b98b1f6"),
                    RouteActionFieldMethodId = Guid.Parse("1c69ea31-d4ea-4c2b-b576-9754d5d9f02c")
                },
                new RouteActionFieldMethod
                {
                    RouteActionFieldId = Guid.Parse("9221e018-623f-425e-976d-36d889c24d95"),
                    RouteMethodId = Guid.Parse("15e24f35-3bc4-4326-978b-bb821cb5282e"),
                    RouteActionFieldMethodId = Guid.Parse("fe0cbe67-d73f-42a0-b29e-dff84812a878")
                },
                #endregion
            };
            modelBuilder.Entity<RouteActionFieldMethod>().HasData(routeActionFieldMethods);


            var routeStepTypes = new List<RouteStepType>
            {
                new RouteStepType
                {
                    Name = "На изменении подписанта",
                    RouteStepTypeId = Guid.Parse("38f8fa70-7daf-4d8c-b992-58fd6470f76d"),
                    OnCreateTaskStatusId = Guid.Parse("4605b437-4dca-4c92-856a-211c308ddbe9"),
                    OnAcceptTaskStatusId = Guid.Parse("99ec51d2-c7e7-41ed-8abf-ee63c1710613"),
                    OnRejectTaskStatusId = Guid.Parse("a8e5927b-e95a-4db7-8185-c78d8ea86e6c")
                },

                new RouteStepType
                {
                    Name = "Согласование изменений",
                    RouteStepTypeId = Guid.Parse("fb2e3686-cd00-4aa3-8d8a-d26a75d09203"),
                    OnCreateTaskStatusId = Guid.Parse("b2ff87ea-a546-4a4c-a9b3-1f1263671deb"),
                    OnAcceptTaskStatusId = Guid.Parse("afea2260-b7a6-452c-9b99-1a3f271e92c1"),
                    OnRejectTaskStatusId = Guid.Parse("ffa39af4-0c81-4413-8ecb-8e00c274cb0d")
                },

                #region Замена таск статусов
                new RouteStepType
                {
                    Name = "Регистрация договора",
                    //RouteStepTypeId = Guid.Parse("c254a294-7850-4f3e-9694-f219fbde1fa2"),
                    RouteStepTypeId = Guid.Parse("3b6f9a1b-e817-4a86-ae4e-bd987172f5b7"),
                    OnCreateTaskStatusId = Guid.Parse("f9b78168-c08a-429e-b020-10566fdfb0c7"),
                    OnAcceptTaskStatusId = Guid.Parse("00528441-39ed-40b5-9b8d-ee3887db8a45"),
                    OnRejectTaskStatusId = Guid.Parse("a8e5927b-e95a-4db7-8185-c78d8ea86e6c"),
                    OnInMethodGroupId = Guid.Parse("2907c1b0-f9f9-4044-b943-7867f1086477")
                },
                new RouteStepType
                {
                    Name = "На подписании",
                    //RouteStepTypeId = Guid.Parse("f68f3322-b75f-4c30-b7ba-ac468a6f3a69"),
                    RouteStepTypeId = Guid.Parse("db201569-310f-45b5-b1df-835fcf8b818a"),
                    OnCreateTaskStatusId = Guid.Parse("3ca781d3-03b0-4e23-82b3-1854c95d6e91"),
                    OnAcceptTaskStatusId = Guid.Parse("b04c647c-7c05-4ded-aaa9-b7a4465f27c3"),
                    OnRejectTaskStatusId = Guid.Parse("a8e5927b-e95a-4db7-8185-c78d8ea86e6c"),
                    OnInMethodGroupId = Guid.Parse("21905bdb-0cf2-4286-aacf-3be3e651e3ae")
                },
                new RouteStepType{
                    Name="Согласование",
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                     OnCreateTaskStatusId = Guid.Parse("3ca781d3-03b0-4e23-82b3-1854c95d6e91"),
                    OnAcceptTaskStatusId = Guid.Parse("b04c647c-7c05-4ded-aaa9-b7a4465f27c3"),
                    OnRejectTaskStatusId = Guid.Parse("a8e5927b-e95a-4db7-8185-c78d8ea86e6c"),
                    OnInMethodGroupId = Guid.Parse("21905bdb-0cf2-4286-aacf-3be3e651e3ae")
                }
                #endregion
            };
            modelBuilder.Entity<RouteStepType>().HasData(routeStepTypes);

            var routeStepTemplateProperties = new List<RouteStepTemplateProperty>
            {
                new RouteStepTemplateProperty
                {
                    RouteStepTemplatePropertyId = Guid.Parse("bdb3b853-eb15-448b-8464-c44a3a5040c5"),
                    RouteStepTemplateId = Guid.Parse("495a4dc5-dfb7-4de0-a4b0-5239192f1d37"),
                    PropertyId = Guid.Parse("ab68413e-6105-4a50-bb64-1e6c253b2439"),
                    Value = "true"
                },
                new RouteStepTemplateProperty
                {
                    RouteStepTemplatePropertyId = Guid.Parse("ba8a86e8-94b9-40ef-a03a-28c05127ced8"),
                    RouteStepTemplateId = Guid.Parse("62f3f172-89b9-44f6-a309-395b71349ded"),
                    PropertyId = Guid.Parse("ab68413e-6105-4a50-bb64-1e6c253b2439"),
                    Value = "true"
                },
                new RouteStepTemplateProperty
                {
                    RouteStepTemplatePropertyId = Guid.Parse("fac0b7f7-e403-4710-9d45-7a3c0b10f705"),
                    RouteStepTemplateId = Guid.Parse("945f23ab-f57b-4d9f-821a-7f96b3c4b731"),
                    PropertyId = Guid.Parse("ab68413e-6105-4a50-bb64-1e6c253b2439"),
                    Value = "true"
                },
                new RouteStepTemplateProperty
                {
                    RouteStepTemplatePropertyId = Guid.Parse("79dfc268-79a1-450c-ba37-6fce9c487ef1"),
                    RouteStepTemplateId = Guid.Parse("b4ad574c-a2c1-433c-adfb-a022c371de13"),
                    PropertyId = Guid.Parse("ab68413e-6105-4a50-bb64-1e6c253b2439"),
                    Value = "true"
                },
            };
            //routeStepTemplateProperties.ForEach(d => context.RouteStepTemplateProperties.AddOrUpdate(d));
            //TODO 
            /*var routeStepTemplatePropertiesId = routeStepTemplateProperties.Select(t => t.RouteStepTemplatePropertyId).ToArray();
            var routeStepTemplatePropertiesForDelete = context.RouteStepTemplateProperties
                .Where(t => routeStepTemplatePropertiesId.Contains(t.RouteStepTemplatePropertyId)).ToList();
            modelBuilder.Entity<RouteStepTemplateProperty>().HasData(routeStepTemplateProperties);
            context.RouteStepTemplateProperties.RemoveRange(routeStepTemplatePropertiesForDelete);
            */
            var documentStatuses = new List<DocumentStatus>
            {
                new DocumentStatus
                {
                    DocumentStatusId = Guid.Parse("f1d41f4e-5a1a-4b8f-a55f-3f318a5d593a"),
                    TypeStatus = "EXECUTE",
                    Name = "На изменении подписанта",
                    StatusColor = "P_WHITE",
                    CenterPanelType = "DRAFT",
                    RightPanelType = "DRAFTROUTE"
                },
                  new DocumentStatus
                {
                  Name = "Согласование изменений",
                DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763")

                  },
                    new DocumentStatus
                {

                  Name = "Подписание договора",

                    DocumentStatusId = Guid.Parse("4e488726-ca58-439e-983e-c27d5f002a4c"),
                    },
                      new DocumentStatus
                {


                      Name = "Регистрация договора",
                    DocumentStatusId = Guid.Parse("8d9555f2-c43e-4c18-9eed-1acfedf7ac4c"),
                    },



            };
            modelBuilder.Entity<DocumentStatus>().HasData(documentStatuses);

            var routeStepGroups = new List<RouteStepGroup>
            {
                //Изменение подписанта
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("307fa673-5d1b-4931-a7eb-33be670fadc9"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Изменение подписанта",
                    RouteActionId = Guid.Parse("5117cc94-3153-4bb4-aa1e-57d77115a056"),
                    RouteStepTypeId = Guid.Parse("38f8fa70-7daf-4d8c-b992-58fd6470f76d"),
                    DocumentStatusId = Guid.Parse("f1d41f4e-5a1a-4b8f-a55f-3f318a5d593a")
                },

                //Согласование изменений
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("738c8bc6-ce67-47cb-bf78-36dce03233b2"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Согласование изменений",
                    RouteActionId = Guid.Parse("df764d31-c825-44c5-bd7d-84708e4c8d67"),
                    RouteStepTypeId = Guid.Parse("fb2e3686-cd00-4aa3-8d8a-d26a75d09203"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763")
                },


                #region Замена таск статусов
                // Подписание договора
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("d74c0df9-853f-4a9e-ac88-ef10426f9fc5"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Подписание договора",
                    RouteActionId = Guid.Parse("3398fb67-3154-4ee2-a510-128d27772ac8"),
                    RouteStepTypeId = Guid.Parse("db201569-310f-45b5-b1df-835fcf8b818a"),
                    DocumentStatusId = Guid.Parse("4e488726-ca58-439e-983e-c27d5f002a4c"),
                    IsCreateInNewVersion = true,
                },

                // регистрация договора
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("f6d1a2ab-e684-4cc6-a68e-57d201b0f18b"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Регистрация договора",
                    RouteActionId = Guid.Parse("a5c41f33-b06f-4721-b2a3-14b91297a464"),
                    RouteStepTypeId = Guid.Parse("3b6f9a1b-e817-4a86-ae4e-bd987172f5b7"),
                    DocumentStatusId = Guid.Parse("8d9555f2-c43e-4c18-9eed-1acfedf7ac4c"),
                    OnOutMethodGroupId = Guid.Parse("88076a94-4a88-48bb-9380-4a513f377754"),
                    IsCreateInNewVersion = false,
                },

                // регистрация договора
                new RouteStepGroup
                {
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("3d5d474c-b15f-49d4-85cd-2d2e95681249"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Регистрация договора",
                    RouteActionId = Guid.Parse("a5c41f33-b06f-4721-b2a3-14b91297a464"),
                    RouteStepTypeId = Guid.Parse("3b6f9a1b-e817-4a86-ae4e-bd987172f5b7"),
                    DocumentStatusId = Guid.Parse("8d9555f2-c43e-4c18-9eed-1acfedf7ac4c"),
                    IsCreateInNewVersion = false,
                    OnOutMethodGroupId = Guid.Parse("88076a94-4a88-48bb-9380-4a513f377754")
                },
                #endregion

                #region Договор TD-1990 2 этап. Модернизация процесса принятия решения по документу
                // Согласующий ЗГД
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("38f7403a-37bf-4d82-bbe1-02770e919902"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Согласующий ЗГД",
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false,
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("400ff7fc-c960-4abf-8f30-7372ceefd66e"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Согласование ЦФО ",
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false,
                    IsParallelEditable = true
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("f675cf35-2391-4c83-a7e7-685c0bfed349"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Согласование ",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false,
                    IsParallelEditable = true
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("724e8a05-8e36-4089-a8b9-57e086bba1fa"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Согласование ПУ ",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    OnOutMethodGroupId =  Guid.Parse("ecf5765c-4c49-4046-a5c3-62f2174b4fb1"),
                    IsCreateInNewVersion = false,
                },

                // согласование ЦФО
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("c5659b0b-7bbb-492c-aa2e-0b0d302ff97c"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Согласование ЦФО",
                    // RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false,
                    IsParallelEditable = true
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("8c0e6d95-3762-4374-8cd3-0d81ce77378b"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Согласование",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false,
                    IsParallelEditable = true
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("99a0fdcd-2d96-4f5a-92d4-7e479145ab53"),
                    IsStepRequired = false,
                    Duration = 1,
                    Name = "Согласование ПУ",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    OnOutMethodGroupId =  Guid.Parse("ecf5765c-4c49-4046-a5c3-62f2174b4fb1"),
                    IsCreateInNewVersion = false,
                },
                #endregion

                #region ДС TD-1990 2 этап. Модернизация процесса принятия решения по документу
                // Согласующий ЗГД
                new RouteStepGroup
                {
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("bc487dbc-4c7a-4c29-a6d4-5727c24dc61a"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Согласующий ЗГД",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("52cb3782-b83d-4920-a1ed-2a05f477defd"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Согласование ЦФО ",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    // RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("36192a17-df04-4442-b24f-31bf2fdf20ae"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Согласование ",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("98d115d1-309e-44a7-830c-daa1eb4f2940"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Согласование ПУ ",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    OnOutMethodGroupId =  Guid.Parse("ecf5765c-4c49-4046-a5c3-62f2174b4fb1"),
                    IsCreateInNewVersion = false,
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("dea0aeaa-cf86-459c-babe-bdaf052fa1d8"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Согласование ЦФО",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    // RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    OnOutMethodGroupId =  Guid.Parse("ecf5765c-4c49-4046-a5c3-62f2174b4fb1"),
                    IsCreateInNewVersion = false
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("873d4126-0ae8-4730-b985-3c43e3e08c05"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Согласование",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    IsCreateInNewVersion = false
                },

                // согласование
                new RouteStepGroup
                {
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    AfterSendCardId = Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                    RouteStepGroupId = Guid.Parse("77fa9bcf-1902-4111-b4a0-8ccbc78dd909"),
                    IsStepRequired = false,
                    Duration = 0,
                    Name = "Согласование ПУ",
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    DocumentStatusId = Guid.Parse("43520ca6-bcfd-4181-8d39-119fc0e17763"),
                    OnOutMethodGroupId =  Guid.Parse("ecf5765c-4c49-4046-a5c3-62f2174b4fb1"),
                    IsCreateInNewVersion = false,
                },
                #endregion
            };
            modelBuilder.Entity<RouteStepGroup>().HasData(routeStepGroups);
            var routeTemplates = new List<RouteTemplate>
            {
                new RouteTemplate{
                    DocumentTypeId= Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                }, new RouteTemplate{
                    DocumentTypeId= Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b"),
                     RouteTemplateId = Guid.Parse("fee4c8ff-b91b-4d73-a529-c0f7e0555577"),
                }, 
                new RouteTemplate{
                    DocumentTypeId= Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b"),
                   RouteTemplateId = Guid.Parse("6aca249f-cc9e-4f9b-879b-d4375d205e13"),
                }, new RouteTemplate{
                    DocumentTypeId= Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b"),
                   RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                },
            };

                modelBuilder.Entity<RouteTemplate>().HasData(routeTemplates);

         /*TODO   var clientProfiles = new List<ClientProfile>
            {
                new ClientProfile{
                ClientProfileId=Guid.Parse("c2edcacc-e17e-4cf6-ad29-4c723de9ec30")
                }
            };*/

          //      modelBuilder.Entity<ClientProfile>().HasData(clientProfiles);

            var routeStepTemplates = new List<RouteStepTemplate>
            {
                #region Замена таск статусов
                // подписание договора
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("f844d8d9-eb1d-42ae-82f4-82d733278b95"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 13500,
                    RouteStepGroupId = Guid.Parse("d74c0df9-853f-4a9e-ac88-ef10426f9fc5"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    RouteActionId = Guid.Parse("3398fb67-3154-4ee2-a510-128d27772ac8"),
                    RouteStepTypeId = Guid.Parse("db201569-310f-45b5-b1df-835fcf8b818a"),
                    IsRequired = true,
                    IsVisible = true
                },
                // подписание договора
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("fee4c8ff-b91b-4d73-a529-c0f7e0555577"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 13500,
                    RouteStepGroupId = Guid.Parse("d74c0df9-853f-4a9e-ac88-ef10426f9fc5"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    RouteActionId = Guid.Parse("3398fb67-3154-4ee2-a510-128d27772ac8"),
                    RouteStepTypeId = Guid.Parse("db201569-310f-45b5-b1df-835fcf8b818a"),
                    IsRequired = true,
                    IsVisible = true
                },

                // регистрация договора
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("6aca249f-cc9e-4f9b-879b-d4375d205e13"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 13000,
                    RouteStepGroupId = Guid.Parse("f6d1a2ab-e684-4cc6-a68e-57d201b0f18b"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    RouteActionId = Guid.Parse("a5c41f33-b06f-4721-b2a3-14b91297a464"),
                    RouteStepTypeId = Guid.Parse("3b6f9a1b-e817-4a86-ae4e-bd987172f5b7"),
                    IsRequired = true,
                    IsVisible = true
                },
                // регистрация договора
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("6bfcd16e-a405-4e37-acf5-34374d02129e"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 11000,
                    RouteStepGroupId = Guid.Parse("f6d1a2ab-e684-4cc6-a68e-57d201b0f18b"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    RouteActionId = Guid.Parse("a5c41f33-b06f-4721-b2a3-14b91297a464"),
                    RouteStepTypeId = Guid.Parse("3b6f9a1b-e817-4a86-ae4e-bd987172f5b7"),
                    IsRequired = true,
                    IsVisible = true
                },
                #endregion

                // Договор
                // Изменение подписанта
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("1d87d4b3-30c2-4453-9c1f-62ab873cc61c"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 12000,
                    RouteStepGroupId = Guid.Parse("307fa673-5d1b-4931-a7eb-33be670fadc9"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    RouteActionId = Guid.Parse("5117cc94-3153-4bb4-aa1e-57d77115a056"),
                    RouteStepTypeId = Guid.Parse("38f8fa70-7daf-4d8c-b992-58fd6470f76d"),
                    IsRequired = true,
                    IsVisible = false
                },

                // Согласование изменений
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("911288ac-7c51-4c70-b4b8-f37b640ff4c5"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 12500,
                    RouteStepGroupId = Guid.Parse("738c8bc6-ce67-47cb-bf78-36dce03233b2"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    RouteActionId = Guid.Parse("df764d31-c825-44c5-bd7d-84708e4c8d67"),
                    RouteStepTypeId = Guid.Parse("fb2e3686-cd00-4aa3-8d8a-d26a75d09203"),
                    IsRequired = true,
                    IsVisible = false
                },

                // Доп. соглашение
                // Изменение подписанта
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("5f4b9806-9367-4481-8c3d-e1564e76c04a"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 10600,
                    RouteStepGroupId = Guid.Parse("307fa673-5d1b-4931-a7eb-33be670fadc9"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    RouteActionId = Guid.Parse("5117cc94-3153-4bb4-aa1e-57d77115a056"),
                    RouteStepTypeId = Guid.Parse("38f8fa70-7daf-4d8c-b992-58fd6470f76d"),
                    IsRequired = true,
                    IsVisible = false
                },

                // Согласование изменений
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("284528ca-6447-41e6-bf4e-d833c1db6d4c"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 10700,
                    RouteStepGroupId = Guid.Parse("738c8bc6-ce67-47cb-bf78-36dce03233b2"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    RouteActionId = Guid.Parse("df764d31-c825-44c5-bd7d-84708e4c8d67"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = false
                },

                #region Договор TD-1990 2 этап. Модернизация процесса принятия решения по документу
                // согласование ЗГД
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("de24d0fa-5a0b-4aa6-8ef0-78c2ec8ec596"),
                    IsEditable = true,
                    Duration = 1,
                    DisplayOrder = 9500,
                    RouteStepGroupId = Guid.Parse("38f7403a-37bf-4d82-bbe1-02770e919902"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = false,
                },

                // согласование ЦФО скрывающиеся
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("277a92ba-3db1-4c6e-90e8-df855e2dc70c"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 3000,
                    RouteStepGroupId = Guid.Parse("400ff7fc-c960-4abf-8f30-7372ceefd66e"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = false,
                },

                // Согласование 
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("6283a1d7-3c69-4aff-b295-54abdb9305be"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 4000,
                    RouteStepGroupId = Guid.Parse("f675cf35-2391-4c83-a7e7-685c0bfed349"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    ParallelOrder = 3,
                    IsVisible = false,
                },

                // согл директора ПУ
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("62f3f172-89b9-44f6-a309-395b71349ded"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 5000,
                    RouteStepGroupId = Guid.Parse("724e8a05-8e36-4089-a8b9-57e086bba1fa"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
         //TODO           UserId = Guid.Parse("c2edcacc-e17e-4cf6-ad29-4c723de9ec30"),
                    IsVisible = false,
                },

                // согласование
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("a5fc1340-cb51-49cd-afe9-825aec02d400"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 9000,
                    RouteStepGroupId = Guid.Parse("c5659b0b-7bbb-492c-aa2e-0b0d302ff97c"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = true
                },
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("4365fde6-04da-42e8-bd51-9359006f7b0f"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 10000,
                    RouteStepGroupId = Guid.Parse("8c0e6d95-3762-4374-8cd3-0d81ce77378b"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    ParallelOrder = 4,
                    IsVisible = true
                },
                //согласование пу
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("495a4dc5-dfb7-4de0-a4b0-5239192f1d37"),
                    IsEditable = false,
                    Duration = 1,
                    DisplayOrder = 11000,
                    RouteStepGroupId = Guid.Parse("99a0fdcd-2d96-4f5a-92d4-7e479145ab53"),
                    RouteTemplateId = Guid.Parse("dd43a2ba-becd-4f53-8fba-c2bcb2f195f6"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = true,
            //TODO        UserId = Guid.Parse("c2edcacc-e17e-4cf6-ad29-4c723de9ec30"),
                },
                #endregion

                #region ДС TD-1990 2 этап. Модернизация процесса принятия решения по документу
                // согласование ЗГД
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("30e47f1f-9ca4-4baf-83b3-ad2e4b81186a"),
                    IsEditable = true,
                    Duration = 0,
                    DisplayOrder = 9500,
                    RouteStepGroupId = Guid.Parse("38f7403a-37bf-4d82-bbe1-02770e919902"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = false,
                },

                // согласование ЦФО скрывающиеся
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("6e66d0e7-13ce-4f08-a6a1-fe6326bb7a58"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 3000,
                    RouteStepGroupId = Guid.Parse("400ff7fc-c960-4abf-8f30-7372ceefd66e"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = false,
                },

                // Согласование 
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("0823587c-c780-4ceb-9a3b-15d4c23f77ff"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 4000,
                    ParallelOrder = 3,
                    RouteStepGroupId = Guid.Parse("f675cf35-2391-4c83-a7e7-685c0bfed349"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = false,
                },

                // согл директора ПУ
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("b4ad574c-a2c1-433c-adfb-a022c371de13"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 5000,
                    RouteStepGroupId = Guid.Parse("724e8a05-8e36-4089-a8b9-57e086bba1fa"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
             //TODO       UserId = Guid.Parse("c2edcacc-e17e-4cf6-ad29-4c723de9ec30"),
                    IsVisible = false,
                },

                // согласование
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("17fcbef0-2025-44a5-b2b8-55c8ade04bca"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 9000,
                    RouteStepGroupId = Guid.Parse("c5659b0b-7bbb-492c-aa2e-0b0d302ff97c"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = true
                },
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("cedb694c-187e-403a-9e9e-2b2933a07283"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 10000,
                    ParallelOrder = 4,
                    RouteStepGroupId = Guid.Parse("8c0e6d95-3762-4374-8cd3-0d81ce77378b"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = true
                },
                new RouteStepTemplate
                {
                    RouteStepTemplateId = Guid.Parse("945f23ab-f57b-4d9f-821a-7f96b3c4b731"),
                    IsEditable = false,
                    Duration = 0,
                    DisplayOrder = 10500,
                    RouteStepGroupId = Guid.Parse("99a0fdcd-2d96-4f5a-92d4-7e479145ab53"),
                    RouteTemplateId = Guid.Parse("39df2950-61b5-44c5-9ffa-6bbc142c767f"),
                    //RouteActionId = Guid.Parse("9b5436ef-35a3-4597-a71e-05380a8d0244"),
                    RouteActionId = Guid.Parse("839b46c1-a7b3-406d-a55d-83b01de8a249"),
                    RouteStepTypeId = Guid.Parse("c782fc8d-99c4-4a6b-92c3-f018570f50a3"),
                    IsRequired = true,
                    IsVisible = true,
              //TODO      UserId = Guid.Parse("c2edcacc-e17e-4cf6-ad29-4c723de9ec30"),
                },
                #endregion  
            };
            modelBuilder.Entity<RouteStepTemplate>().HasData(routeStepTemplates);

            var documentTypes = new List<DocumentType>
            { new DocumentType{
                DocumentTypeId= Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b") },
                 new DocumentType{
                DocumentTypeId= Guid.Parse("c64b0c39-b6c9-4abb-9f3d-e6e90833e0c0") },
            };
            modelBuilder.Entity<DocumentType>().HasData(documentTypes);



            var fieldTargetTypes = new List<FieldTargetType>{
                new FieldTargetType{
                    FieldTargetTypeId=Guid.Parse("10000001-0000-0000-0000-000000000000")
                }
            };
            modelBuilder.Entity<FieldTargetType>().HasData(fieldTargetTypes);

            var fieldTypes = new List<FieldType>{
                new FieldType{

                    FieldTypeId=Guid.Parse("00000001-0000-0000-0000-000000000000")
                }
            };
            modelBuilder.Entity<FieldType>().HasData(fieldTypes);

            var fields = new List<Field>{
                new Field{
                    TargetTypeId=Guid.Parse("10000001-0000-0000-0000-000000000000"),
                    FieldTypeId=Guid.Parse("00000001-0000-0000-0000-000000000000"),
               FieldId= Guid.Parse("e7740a07-29f6-4cbe-b796-4a41d46e321a"),

                }
            };
            modelBuilder.Entity<Field>().HasData(fields);


            var fieldGroups = new List<FieldGroup>{
                new FieldGroup{
               FieldGroupId=  Guid.Parse("dab39dd9-962b-443f-b38b-1f5cf19ba106")
                }
            };
            modelBuilder.Entity<FieldGroup>().HasData(fieldGroups);

            var cards = new List<Card>
            { new Card{
                CardId=Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                DocumentTypeId= Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b") },
            new Card{
                CardId=Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                DocumentTypeId= Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b")
            },
            new Card{
                CardId=Guid.Parse("b1af1c2b-34e3-46ff-b296-5d8f5ed8807b"),
                DocumentTypeId= Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b") }
            };
            modelBuilder.Entity<Card>().HasData(cards);


            var cardFields = new List<CardField>
            {
                #region ДС TD-1990 2 этап. Модернизация процесса принятия решения по документу
                new CardField
                {
                    CardFieldId = Guid.Parse("74b43002-3b72-4a7c-b834-cd4501d2aa51"),
                    IsRequired = false,
                    DataUrl = "",
                    IsDisabled = false,
                    IsMultirow = false,
                    DisplayOrder = 17150,
                    FieldId = Guid.Parse("e7740a07-29f6-4cbe-b796-4a41d46e321a"),
                    CardId = Guid.Parse("544cc4e0-3664-48fc-85ca-58ddd2567cb7"),
                    FieldGroupId = Guid.Parse("dab39dd9-962b-443f-b38b-1f5cf19ba106"),
                    IsVisible = false
                },
                new CardField
                {
                    CardFieldId = Guid.Parse("15ef2c9f-d865-4a42-9b33-d9cdca381e43"),
                    IsRequired = false,
                    DataUrl = "",
                    IsDisabled = false,
                    IsMultirow = false,
                    DisplayOrder = 17150,
                    FieldId = Guid.Parse("e7740a07-29f6-4cbe-b796-4a41d46e321a"),
                    CardId = Guid.Parse("78d9a724-685e-4711-b645-05de390e93b9"),
                    FieldGroupId = Guid.Parse("dab39dd9-962b-443f-b38b-1f5cf19ba106"),
                    IsVisible = false
                },
            };
            modelBuilder.Entity<CardField>().HasData(cardFields);

            #endregion

            // Действия
            var activities = new List<Activity>
            {
                new Activity
                {
                    ActivityId = Guid.Parse("2319d801-dfbd-4eb4-9227-98674114f3aa"),
                    Name = "Изменить подписанта"
                }
            };
            modelBuilder.Entity<Activity>().HasData(activities);

            var taskStatusActivities = new List<TaskStatusActivity>
            {
                new TaskStatusActivity
                {
                    TaskStatusId = Guid.Parse("f9b78168-c08a-429e-b020-10566fdfb0c7"),
                    // Изменить подписанта
                    ActivityId = Guid.Parse("2319d801-dfbd-4eb4-9227-98674114f3aa"),
                    TaskStatusActivityId = Guid.Parse("ccbc9015-60be-4b25-ac2f-8d51c0d1f9c6")
                },
            };
            modelBuilder.Entity<TaskStatusActivity>().HasData(taskStatusActivities);

            var documentTypeActivities = new List<DocumentTypeActivity>
            {
                // Договор
                // "Изменить подписанта"
                new DocumentTypeActivity
                {
                    ActivityId = Guid.Parse("2319d801-dfbd-4eb4-9227-98674114f3aa"),
                    DocumentTypeId = Guid.Parse("8c7b5817-9da6-4480-ad3f-b0f465131d9b"),
                    DocumentTypeActivityId = Guid.Parse("ae8831ad-eefb-4b2c-a4e6-7895d574b49b"),
                },

                // Доп. соглашение
                // "Изменить подписанта"
                new DocumentTypeActivity
                {
                    ActivityId = Guid.Parse("2319d801-dfbd-4eb4-9227-98674114f3aa"),
                    DocumentTypeId = Guid.Parse("c64b0c39-b6c9-4abb-9f3d-e6e90833e0c0"),
                    DocumentTypeActivityId = Guid.Parse("0aa0406e-b939-466a-aed8-fcc855066f80"),
                },
            };
            modelBuilder.Entity<DocumentTypeActivity>().HasData(documentTypeActivities);

            var applicationRoleActivities = new List<ApplicationRoleActivity>
            {
                new ApplicationRoleActivity
                {
                    //"Изменить подписанта"
                    ActivityId = Guid.Parse("2319d801-dfbd-4eb4-9227-98674114f3aa"),
                    RoleId = "31be207b-c425-4b56-b96e-f1571b1bede4",
                    ApplicationRoleActivityId = Guid.Parse("9c8a3bfe-d24d-45cc-8d03-febdbe9f068e")
                },
            };
            modelBuilder.Entity<ApplicationRoleActivity>().HasData(applicationRoleActivities);
        }
    }
}