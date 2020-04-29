IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Extract] (
    [Id] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    [Date] datetime2 NOT NULL,
    [Amount] float NOT NULL,
    CONSTRAINT [PK_Extract] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Transfer] (
    [Id] int NOT NULL IDENTITY,
    [Date] datetime2 NOT NULL,
    [Amount] float NOT NULL,
    [From] int NOT NULL,
    [To] int NOT NULL,
    CONSTRAINT [PK_Transfer] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [User] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Account] int NOT NULL,
    [Password] int NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200429050719_InitialCreate', N'2.1.14-servicing-32113');

GO

