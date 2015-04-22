USE [Hdwih_Resume_Test]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 4/21/2015 6:49:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[AddressId] [bigint] IDENTITY(1,1) NOT NULL,
	[OrganizationId] [bigint] NULL,
	[EducationInstituationId] [bigint] NULL,
	[AddressName] [varchar](15) NOT NULL,
	[AddressType] [smallint] NOT NULL,
	[StreetAddress] [varchar](100) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[PostalCode] [varchar](12) NOT NULL,
	[CountryId] [int] NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Award]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Award](
	[AwardId] [bigint] IDENTITY(1,1) NOT NULL,
	[PersonResumeId] [bigint] NULL,
	[EducationInstitutionId] [bigint] NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[DateReceived] [datetime2](7) NOT NULL,
	[EmploymentPositionId] [bigint] NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Award] PRIMARY KEY CLUSTERED 
(
	[AwardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EducationInstitution]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EducationInstitution](
	[EducationInstitutionId] [bigint] NOT NULL,
	[InstitutionName] [varchar](50) NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_EducationInstitution] PRIMARY KEY CLUSTERED 
(
	[EducationInstitutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmploymentPosition]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmploymentPosition](
	[EmploymentPositionId] [bigint] IDENTITY(1,1) NOT NULL,
	[JobPostingId] [bigint] NULL,
	[ResumeId] [bigint] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[SupervisorPhone] [varchar](14) NULL,
	[SupervisorName] [varchar](30) NULL,
	[StartDate] [datetime2](7) NULL,
	[EndDate] [datetime2](7) NULL,
	[NumberOWeeklyHours] [smallint] NOT NULL,
	[IsCurrentlyInPosition] [bit] NULL,
	[IsVolunteerPosition] [bit] NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_EmploymentPosition] PRIMARY KEY CLUSTERED 
(
	[EmploymentPositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobPosting]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JobPosting](
	[JobPostingId] [bigint] IDENTITY(1,1) NOT NULL,
	[PostingDate] [datetime2](7) NOT NULL,
	[ClosingDate] [nchar](10) NULL,
	[OrganizationId] [bigint] NULL,
	[IsSecurityClearanceNeeded] [bit] NULL,
	[MaximumSalary] [decimal](7, 2) NULL,
	[MinimumSalary] [decimal](7, 2) NULL,
	[IsTravelRequired] [nchar](10) NOT NULL,
	[Summary] [varchar](max) NOT NULL,
	[JobPostingTitle] [varchar](50) NOT NULL,
	[Benefits] [varchar](max) NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_JobPosting] PRIMARY KEY CLUSTERED 
(
	[JobPostingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobPostingNote]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JobPostingNote](
	[NoteId] [bigint] IDENTITY(1,1) NOT NULL,
	[JobPostingId] [bigint] NOT NULL,
	[NoteTitle] [varchar](40) NOT NULL,
	[NoteBody] [varchar](500) NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_JobPostingNote] PRIMARY KEY CLUSTERED 
(
	[NoteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KeyRequirements]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KeyRequirements](
	[RequirementId] [bigint] IDENTITY(1,1) NOT NULL,
	[JobPostingId] [bigint] NOT NULL,
	[RequirementDescription] [varchar](50) NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_KeyRequirements] PRIMARY KEY CLUSTERED 
(
	[RequirementId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LanguageSpoken]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageSpoken](
	[LanguageId] [bigint] NOT NULL,
	[PersonResumeId] [bigint] NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LanguageSpoken] PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Organization]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Organization](
	[OrganizationId] [bigint] IDENTITY(1,1) NOT NULL,
	[OrganizationName] [varchar](100) NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED 
(
	[OrganizationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person] (
    [PersonId]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName]      VARCHAR (30)  NOT NULL,
    [LastName]       VARCHAR (70)  NOT NULL,
    [MiddleName]     VARCHAR (25)  NULL,
    [Gender]         SMALLINT      NOT NULL,
    [BirthDate]      DATETIME2 (7) NOT NULL,
    [EmailAddress]   VARCHAR (50)  NOT NULL,
    [InsertDateTime] DATETIME2 (7) NOT NULL,
    [LastUpdateTime] DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC)
);



GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonAddress]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonAddress](
	[PersonId] [bigint] NOT NULL,
	[AddressId] [bigint] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PersonAddress] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC,
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonEducation]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonEducation](
	[PersonResumeId] [bigint] NOT NULL,
	[EducationInstitutionId] [bigint] NOT NULL,
	[StartDate] [datetime2](7) NULL,
	[EndDate] [datetime2](7) NULL,
	[WasDegreeAwarded] [bit] NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PersonEducation_1] PRIMARY KEY CLUSTERED 
(
	[PersonResumeId] ASC,
	[EducationInstitutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonOrganization]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonOrganization](
	[OrganizationId] [bigint] NOT NULL,
	[PersonId] [bigint] NOT NULL,
	[ContactDesignatedStartDate] [datetime2](7) NOT NULL,
	[ContactDesignatedEndDate] [datetime2](7) NOT NULL,
	[RelationshipType] [int] NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NULL,
 CONSTRAINT [PK_PersonOrganization] PRIMARY KEY CLUSTERED 
(
	[OrganizationId] ASC,
	[PersonId] ASC,
	[ContactDesignatedStartDate] ASC,
	[ContactDesignatedEndDate] ASC,
	[RelationshipType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonReference]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonReference](
	[PersonResumeId] [bigint] NOT NULL,
	[PersonId] [bigint] NOT NULL,
	[RelationshipType] [int] NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PersonReference_1] PRIMARY KEY CLUSTERED 
(
	[PersonResumeId] ASC,
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonResume]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonResume] (
    [PersonResumeId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [ParentResumeId] BIGINT         NULL,
    [Introduction]   VARCHAR (4000) NULL,
    [Name]           VARCHAR (50)   NOT NULL,
    [PersonId]       BIGINT         NOT NULL,
    [ResumeTypeId]   SMALLINT       NOT NULL,
    [InsertDateTime] DATETIME2 (7)  NOT NULL,
    [LastUpdateTime] DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_PersonResume] PRIMARY KEY CLUSTERED ([PersonResumeId] ASC),
    CONSTRAINT [FK_PersonResume_PersonResume] FOREIGN KEY ([ParentResumeId]) REFERENCES [dbo].[PersonResume] ([PersonResumeId]),
    CONSTRAINT [FK_PersonResume_PersonResumeType] FOREIGN KEY ([ResumeTypeId]) REFERENCES [dbo].[PersonResumeType] ([ResumeTypeId]),
    CONSTRAINT [PersonHasOneOrMoreResumes] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId])
);



GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhoneNumber]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhoneNumber](
	[PhoneNumberId] [bigint] IDENTITY(1,1) NOT NULL,
	[AreaCode] [varchar](4) NOT NULL,
	[CountryCode] [smallint] NOT NULL,
	[Number] [bigint] NOT NULL,
	[PhoneType] [char](1) NOT NULL,
	[PersonId] [bigint] NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PhoneNumber] PRIMARY KEY CLUSTERED 
(
	[PhoneNumberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PositionDuty]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PositionDuty](
	[PositionDutyId] [bigint] IDENTITY(1,1) NOT NULL,
	[JobPostingId] [bigint] NULL,
	[PositionId] [bigint] NULL,
	[DutyDescrption] [varchar](500) NOT NULL,
	[DutyLocation] [varchar](25) NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PositionDuty] PRIMARY KEY CLUSTERED 
(
	[PositionDutyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Qualification]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Qualification](
	[QualificationId] [bigint] IDENTITY(1,1) NOT NULL,
	[JobPostingId] [bigint] NOT NULL,
	[QualificationTitle] [varchar](50) NOT NULL,
	[QualificationDescription] [varchar](300) NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Qualification] PRIMARY KEY CLUSTERED 
(
	[QualificationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RelationshipType]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RelationshipType](
	[RelationshipTypeId] [int] IDENTITY(1,1) NOT NULL,
	[RelationshipTypeName] [varchar](30) NOT NULL,
	[RelationshipTypeDescription] [varchar](70) NULL,
	[InsertDateTime] [datetime] NOT NULL,
	[LastUpdateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_RelationshipType] PRIMARY KEY CLUSTERED 
(
	[RelationshipTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RequiredDocument]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RequiredDocument](
	[RequiredDocumentId] [bigint] NOT NULL,
	[JobPostingId] [bigint] NOT NULL,
	[RequiredDocumentName] [varchar](50) NOT NULL,
	[RequiredDocumentDescription] [varchar](500) NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SkillOrSpeciality]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SkillOrSpeciality](
	[SkillOrSpecialtyId] [bigint] IDENTITY(1,1) NOT NULL,
	[PersonResumeId] [bigint] NOT NULL,
	[SkillOrSpecialtyDescription] [varchar](50) NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SkillOrSpeciality] PRIMARY KEY CLUSTERED 
(
	[SkillOrSpecialtyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserAccountProfile]    Script Date: 4/21/2015 6:49:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccountProfile](
	[AccountId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[ClosedDate] [datetime2](7) NULL,
	[AccountTypeId] [int] NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserAccountProfile] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_EducationInstitution1] FOREIGN KEY([EducationInstituationId])
REFERENCES [dbo].[EducationInstitution] ([EducationInstitutionId])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_EducationInstitution1]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Organization] FOREIGN KEY([OrganizationId])
REFERENCES [dbo].[Organization] ([OrganizationId])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Organization]
GO
ALTER TABLE [dbo].[Award]  WITH CHECK ADD  CONSTRAINT [FK_Award_PersonEducation] FOREIGN KEY([PersonResumeId], [EducationInstitutionId])
REFERENCES [dbo].[PersonEducation] ([PersonResumeId], [EducationInstitutionId])
GO
ALTER TABLE [dbo].[Award] CHECK CONSTRAINT [FK_Award_PersonEducation]
GO
ALTER TABLE [dbo].[Award]  WITH CHECK ADD  CONSTRAINT [PersonMayHaveReceivedOneOrMoreAwardsWhileInAPosition] FOREIGN KEY([EmploymentPositionId])
REFERENCES [dbo].[EmploymentPosition] ([EmploymentPositionId])
GO
ALTER TABLE [dbo].[Award] CHECK CONSTRAINT [PersonMayHaveReceivedOneOrMoreAwardsWhileInAPosition]
GO
ALTER TABLE [dbo].[EmploymentPosition]  WITH CHECK ADD  CONSTRAINT [ResumeIncludesOneOreMorePositions] FOREIGN KEY([ResumeId])
REFERENCES [dbo].[PersonResume] ([PersonResumeId])
GO
ALTER TABLE [dbo].[EmploymentPosition] CHECK CONSTRAINT [ResumeIncludesOneOreMorePositions]
GO
ALTER TABLE [dbo].[JobPosting]  WITH CHECK ADD  CONSTRAINT [FK_JobPosting_Organization] FOREIGN KEY([OrganizationId])
REFERENCES [dbo].[Organization] ([OrganizationId])
GO
ALTER TABLE [dbo].[JobPosting] CHECK CONSTRAINT [FK_JobPosting_Organization]
GO
ALTER TABLE [dbo].[JobPostingNote]  WITH CHECK ADD  CONSTRAINT [FK_JobPostingNote_JobPosting] FOREIGN KEY([JobPostingId])
REFERENCES [dbo].[JobPosting] ([JobPostingId])
GO
ALTER TABLE [dbo].[JobPostingNote] CHECK CONSTRAINT [FK_JobPostingNote_JobPosting]
GO
ALTER TABLE [dbo].[KeyRequirements]  WITH CHECK ADD  CONSTRAINT [FK_KeyRequirements_JobPosting] FOREIGN KEY([JobPostingId])
REFERENCES [dbo].[JobPosting] ([JobPostingId])
GO
ALTER TABLE [dbo].[KeyRequirements] CHECK CONSTRAINT [FK_KeyRequirements_JobPosting]
GO
ALTER TABLE [dbo].[LanguageSpoken]  WITH CHECK ADD  CONSTRAINT [FK_LanguageSpoken_PersonResume] FOREIGN KEY([PersonResumeId])
REFERENCES [dbo].[PersonResume] ([PersonResumeId])
GO
ALTER TABLE [dbo].[LanguageSpoken] CHECK CONSTRAINT [FK_LanguageSpoken_PersonResume]
GO
ALTER TABLE [dbo].[PersonAddress]  WITH CHECK ADD  CONSTRAINT [FK_PersonAddress_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([AddressId])
GO
ALTER TABLE [dbo].[PersonAddress] CHECK CONSTRAINT [FK_PersonAddress_Address]
GO
ALTER TABLE [dbo].[PersonAddress]  WITH CHECK ADD  CONSTRAINT [FK_PersonAddress_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[PersonAddress] CHECK CONSTRAINT [FK_PersonAddress_Person]
GO
ALTER TABLE [dbo].[PersonEducation]  WITH CHECK ADD  CONSTRAINT [FK_PersonEducation_EducationInstitution] FOREIGN KEY([EducationInstitutionId])
REFERENCES [dbo].[EducationInstitution] ([EducationInstitutionId])
GO
ALTER TABLE [dbo].[PersonEducation] CHECK CONSTRAINT [FK_PersonEducation_EducationInstitution]
GO
ALTER TABLE [dbo].[PersonEducation]  WITH CHECK ADD  CONSTRAINT [PersonMayHaveOneOrMoreEducationBackground] FOREIGN KEY([PersonResumeId])
REFERENCES [dbo].[PersonResume] ([PersonResumeId])
GO
ALTER TABLE [dbo].[PersonEducation] CHECK CONSTRAINT [PersonMayHaveOneOrMoreEducationBackground]
GO
ALTER TABLE [dbo].[PersonOrganization]  WITH CHECK ADD  CONSTRAINT [FK_PersonOrganization_Organization] FOREIGN KEY([OrganizationId])
REFERENCES [dbo].[Organization] ([OrganizationId])
GO
ALTER TABLE [dbo].[PersonOrganization] CHECK CONSTRAINT [FK_PersonOrganization_Organization]
GO
ALTER TABLE [dbo].[PersonOrganization]  WITH CHECK ADD  CONSTRAINT [FK_PersonOrganization_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[PersonOrganization] CHECK CONSTRAINT [FK_PersonOrganization_Person]
GO
ALTER TABLE [dbo].[PersonOrganization]  WITH CHECK ADD  CONSTRAINT [FK_PersonOrganization_RelationshipType] FOREIGN KEY([RelationshipType])
REFERENCES [dbo].[RelationshipType] ([RelationshipTypeId])
GO
ALTER TABLE [dbo].[PersonOrganization] CHECK CONSTRAINT [FK_PersonOrganization_RelationshipType]
GO
ALTER TABLE [dbo].[PersonReference]  WITH CHECK ADD  CONSTRAINT [FK_PersonReference_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[PersonReference] CHECK CONSTRAINT [FK_PersonReference_Person]
GO
ALTER TABLE [dbo].[PersonReference]  WITH CHECK ADD  CONSTRAINT [FK_PersonReference_PersonResume] FOREIGN KEY([PersonResumeId])
REFERENCES [dbo].[PersonResume] ([PersonResumeId])
GO
ALTER TABLE [dbo].[PersonReference] CHECK CONSTRAINT [FK_PersonReference_PersonResume]
GO
ALTER TABLE [dbo].[PersonReference]  WITH CHECK ADD  CONSTRAINT [FK_PersonReference_RelationshipType] FOREIGN KEY([RelationshipType])
REFERENCES [dbo].[RelationshipType] ([RelationshipTypeId])
GO
ALTER TABLE [dbo].[PersonReference] CHECK CONSTRAINT [FK_PersonReference_RelationshipType]
GO

GO

GO
ALTER TABLE [dbo].[PhoneNumber]  WITH CHECK ADD  CONSTRAINT [PersonHasOneOrMorePhoneNumbers] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[PhoneNumber] CHECK CONSTRAINT [PersonHasOneOrMorePhoneNumbers]
GO
ALTER TABLE [dbo].[PositionDuty]  WITH CHECK ADD  CONSTRAINT [FK_PositionDuty_JobPosting] FOREIGN KEY([PositionDutyId])
REFERENCES [dbo].[JobPosting] ([JobPostingId])
GO
ALTER TABLE [dbo].[PositionDuty] CHECK CONSTRAINT [FK_PositionDuty_JobPosting]
GO
ALTER TABLE [dbo].[PositionDuty]  WITH CHECK ADD  CONSTRAINT [PositionHasManyDuties] FOREIGN KEY([PositionId])
REFERENCES [dbo].[EmploymentPosition] ([EmploymentPositionId])
GO
ALTER TABLE [dbo].[PositionDuty] CHECK CONSTRAINT [PositionHasManyDuties]
GO
ALTER TABLE [dbo].[Qualification]  WITH CHECK ADD  CONSTRAINT [FK_Qualification_JobPosting] FOREIGN KEY([JobPostingId])
REFERENCES [dbo].[JobPosting] ([JobPostingId])
GO
ALTER TABLE [dbo].[Qualification] CHECK CONSTRAINT [FK_Qualification_JobPosting]
GO
ALTER TABLE [dbo].[RequiredDocument]  WITH CHECK ADD  CONSTRAINT [FK_RequiredDocument_JobPosting] FOREIGN KEY([JobPostingId])
REFERENCES [dbo].[JobPosting] ([JobPostingId])
GO
ALTER TABLE [dbo].[RequiredDocument] CHECK CONSTRAINT [FK_RequiredDocument_JobPosting]
GO
ALTER TABLE [dbo].[SkillOrSpeciality]  WITH CHECK ADD  CONSTRAINT [PersonResumeCanHaveOneOrMoreSpecialtiesOrSkills] FOREIGN KEY([PersonResumeId])
REFERENCES [dbo].[PersonResume] ([PersonResumeId])
GO
ALTER TABLE [dbo].[SkillOrSpeciality] CHECK CONSTRAINT [PersonResumeCanHaveOneOrMoreSpecialtiesOrSkills]
GO
ALTER TABLE [dbo].[UserAccountProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserAccountProfile_Person] FOREIGN KEY([UserId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[UserAccountProfile] CHECK CONSTRAINT [FK_UserAccountProfile_Person]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Phones Inclde Mobile, Home, Office etc..' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhoneNumber', @level2type=N'CONSTRAINT',@level2name=N'PersonHasOneOrMorePhoneNumbers'
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_PersonEmail]
    ON [dbo].[Person]([EmailAddress] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'the idea is the a resume can be a parent of many children resumes', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PersonResume', @level2type = N'CONSTRAINT', @level2name = N'FK_PersonResume_PersonResume';

