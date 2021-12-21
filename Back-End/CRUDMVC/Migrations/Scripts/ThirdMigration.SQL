IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clientes] (
    [idCliente] int NOT NULL IDENTITY,
    [nome] nvarchar(255) NOT NULL,
    [cpf] char(11) NOT NULL,
    [rg] char(14) NOT NULL,
    [endereco] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([idCliente])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211215192526_FirstMigration', N'5.0.13');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Destinos] (
    [idDestino] int NOT NULL IDENTITY,
    [endereco] nvarchar(255) NOT NULL,
    [nome] nvarchar(255) NOT NULL,
    [preco] float NOT NULL,
    [qtdVagas] int NOT NULL,
    CONSTRAINT [PK_Destinos] PRIMARY KEY ([idDestino])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211216204408_SecondMigration', N'5.0.13');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Agencias] (
    [idAgencia] int NOT NULL IDENTITY,
    [cnpj] char(14) NOT NULL,
    [endereco] nvarchar(255) NOT NULL,
    [telefone] char(15) NOT NULL,
    [email] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_Agencias] PRIMARY KEY ([idAgencia])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211218172514_ThirdMigration', N'5.0.13');
GO

COMMIT;
GO

