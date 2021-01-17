

CREATE TABLE [dbo].[Customers_Cats] (
    [Cat_Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Cat_Name]        NVARCHAR (50) NOT NULL,
    [Cat_Description] TEXT          NULL,
    CONSTRAINT [PK_Customers_Cats] PRIMARY KEY CLUSTERED ([Cat_Id] ASC)
);



CREATE TABLE [dbo].[Customers] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (100) NOT NULL,
    [Email]  NVARCHAR (255) NOT NULL,
    [Cat_id] INT            NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customers_Customers_Cats] FOREIGN KEY ([Cat_id]) REFERENCES [dbo].[Customers_Cats] ([Cat_Id])
);





CREATE TABLE [dbo].[Jobs] (
    [Job_Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Job_State]       NVARCHAR (10)  NOT NULL,
    [Job_Title]       NVARCHAR (100) NOT NULL,
    [Job_Start]       DATETIME       NOT NULL,
    [Job_End]         DATETIME       NOT NULL,
    [Job_Description] TEXT           NULL,
    [Customer_Id]     INT            NOT NULL,
    CONSTRAINT [PK_Jobs] PRIMARY KEY CLUSTERED ([Job_Id] ASC),
    CONSTRAINT [FK_Jobs_Customers] FOREIGN KEY ([Customer_Id]) REFERENCES [dbo].[Customers] ([Id])
);





CREATE TABLE [dbo].[Quotes] (
    [Quote_Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Quote_State]        NVARCHAR (10) NOT NULL,
    [Quote_Date]         DATE          NOT NULL,
    [Quote_Amount]       INT           NOT NULL,
    [Quote_Final_Date]   DATE          NOT NULL,
    [Quote_Final_Amount] INT           NOT NULL,
    [Job_id]             INT           NOT NULL,
    CONSTRAINT [PK_Quotes] PRIMARY KEY CLUSTERED ([Quote_Id] ASC),
    CONSTRAINT [FK_Quotes_Jobs] FOREIGN KEY ([Job_id]) REFERENCES [dbo].[Jobs] ([Job_Id])
);
