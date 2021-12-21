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

