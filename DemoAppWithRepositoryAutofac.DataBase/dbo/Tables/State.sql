CREATE TABLE [dbo].[State] (
    [StateId]     UNIQUEIDENTIFIER NOT NULL,
    [CountryId]   UNIQUEIDENTIFIER NOT NULL,
    [StateName]   NVARCHAR (50)    NOT NULL,
    [StateCode]   NVARCHAR (5)     NULL,
    [Status]      NVARCHAR (10)    NOT NULL,
    [CreatedBy]   UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME         CONSTRAINT [DF_State_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [UpdatedBy]   UNIQUEIDENTIFIER NULL,
    [UpdatedDate] DATETIME         CONSTRAINT [DF_State_UpdatedDate] DEFAULT (getdate()) NOT NULL,
    [IP]          NVARCHAR (50)    NULL,
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([StateId] ASC),
    CONSTRAINT [FK_State_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId])
);

