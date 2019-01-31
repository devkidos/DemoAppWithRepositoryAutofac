CREATE TABLE [dbo].[Country] (
    [CountryId]        UNIQUEIDENTIFIER NOT NULL,
    [CountryName]      NVARCHAR (50)    NOT NULL,
    [CountryCode]      NVARCHAR (5)     NULL,
    [CountryPhoneCode] NVARCHAR (7)     NULL,
    [Status]           NVARCHAR (10)    NOT NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]      DATETIME         CONSTRAINT [DF_Country_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [UpdatedBy]        UNIQUEIDENTIFIER NULL,
    [UpdatedDate]      DATETIME         CONSTRAINT [DF_Country_UpdatedDate] DEFAULT (getdate()) NOT NULL,
    [IP]               NVARCHAR (50)    NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([CountryId] ASC)
);

