CREATE TABLE [dbo].[City] (
    [CityId]        UNIQUEIDENTIFIER NOT NULL,
    [StateId]       UNIQUEIDENTIFIER NOT NULL,
    [CityName]      NVARCHAR (50)    NOT NULL,
    [CityCode]      NVARCHAR (5)     NULL,
    [CityPhoneCode] NVARCHAR (7)     NULL,
    [Status]        NVARCHAR (10)    NOT NULL,
    [CreatedBy]     UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]   DATETIME         CONSTRAINT [DF_City_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [UpdatedBy]     UNIQUEIDENTIFIER NULL,
    [UpdatedDate]   DATETIME         CONSTRAINT [DF_City_UpdatedDate] DEFAULT (getdate()) NOT NULL,
    [IP]            NVARCHAR (50)    NULL,
    CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([CityId] ASC),
    CONSTRAINT [FK_City_State] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([StateId])
);

