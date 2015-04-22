CREATE TABLE [dbo].[PersonResumeType] (
    [ResumeTypeId]          SMALLINT      IDENTITY (1, 1) NOT NULL,
    [ResumeTypeTitle]       VARCHAR (15)  NOT NULL,
    [ResumeTypeDescription] VARCHAR (400) NOT NULL,
    CONSTRAINT [PK_PersonResumeType] PRIMARY KEY CLUSTERED ([ResumeTypeId] ASC)
);

