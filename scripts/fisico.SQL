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

CREATE TABLE [clientes] (
    [Id_cliente] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Endereco] nvarchar(max) NOT NULL,
    [Telefone] nvarchar(max) NOT NULL,
    [CPF] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_clientes] PRIMARY KEY ([Id_cliente])
);
GO

CREATE TABLE [contatos] (
    [Id_Contato] int NOT NULL IDENTITY,
    [Email] nvarchar(max) NOT NULL,
    [Mensagem] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_contatos] PRIMARY KEY ([Id_Contato])
);
GO

CREATE TABLE [voos] (
    [Id_Voo] int NOT NULL IDENTITY,
    [Data_Partida] datetime2 NOT NULL,
    [Data_Retorno] datetime2 NOT NULL,
    [Destino] nvarchar(max) NOT NULL,
    [Id_cliente] int NOT NULL,
    CONSTRAINT [PK_voos] PRIMARY KEY ([Id_Voo]),
    CONSTRAINT [FK_voos_clientes_Id_cliente] FOREIGN KEY ([Id_cliente]) REFERENCES [clientes] ([Id_cliente]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_voos_Id_cliente] ON [voos] ([Id_cliente]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211216223204_BancoAgencia', N'6.0.1');
GO

COMMIT;
GO

