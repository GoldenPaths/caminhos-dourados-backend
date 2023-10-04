CREATE TABLE [Address] (
    [Id] uniqueidentifier NOT NULL,
    [PostalCode] nvarchar(max) NULL,
    [StreetName] nvarchar(max) NULL,
    [StreetNumber] nvarchar(max) NULL,
    [Neighborhood] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [Region] nvarchar(max) NULL,
    [Country] nvarchar(max) NULL,
    [Phone] nvarchar(max) NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [DemandStatus] (
    [Id] uniqueidentifier NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_DemandStatus] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [DemandType] (
    [Id] uniqueidentifier NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_DemandType] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [User] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [BirthDay] datetime2 NOT NULL,
    [RegisterDate] datetime2 NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Place] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Latitude] nvarchar(max) NULL,
    [Longitude] nvarchar(max) NULL,
    [AddressId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Place] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Place_Address_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Address] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [Demand] (
    [Id] int NOT NULL IDENTITY,
    [Descrption] nvarchar(max) NULL,
    [MyProperty] int NOT NULL,
    [RegisterDate] datetime2 NOT NULL,
    [SolutionDate] datetime2 NULL,
    [PlaceId] uniqueidentifier NOT NULL,
    [DemandTypeId] uniqueidentifier NOT NULL,
    [DemandStatusId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Demand] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Demand_DemandStatus_DemandStatusId] FOREIGN KEY ([DemandStatusId]) REFERENCES [DemandStatus] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Demand_DemandType_DemandTypeId] FOREIGN KEY ([DemandTypeId]) REFERENCES [DemandType] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Demand_Place_PlaceId] FOREIGN KEY ([PlaceId]) REFERENCES [Place] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [DemandUser] (
    [DemandsId] int NOT NULL,
    [UsersId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_DemandUser] PRIMARY KEY ([DemandsId], [UsersId]),
    CONSTRAINT [FK_DemandUser_Demand_DemandsId] FOREIGN KEY ([DemandsId]) REFERENCES [Demand] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DemandUser_User_UsersId] FOREIGN KEY ([UsersId]) REFERENCES [User] ([Id]) ON DELETE CASCADE
);
GO


CREATE INDEX [IX_Demand_DemandStatusId] ON [Demand] ([DemandStatusId]);
GO


CREATE INDEX [IX_Demand_DemandTypeId] ON [Demand] ([DemandTypeId]);
GO


CREATE UNIQUE INDEX [IX_Demand_PlaceId] ON [Demand] ([PlaceId]);
GO


CREATE INDEX [IX_DemandUser_UsersId] ON [DemandUser] ([UsersId]);
GO


CREATE UNIQUE INDEX [IX_Place_AddressId] ON [Place] ([AddressId]);
GO


