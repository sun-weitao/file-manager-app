
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/03/2020 19:10:28
-- Generated from EDMX file: I:\workspace\file-manager-app\file-manager-app\Models\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirstDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(32)  NOT NULL,
    [password] nvarchar(32)  NOT NULL,
    [createtime] datetime  NOT NULL,
    [issuperadmin] bit  NOT NULL
);
GO

-- Creating table 'File'
CREATE TABLE [dbo].[File] (
    [id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(max)  NOT NULL,
    [url] nvarchar(max)  NOT NULL,
    [type] nvarchar(max)  NOT NULL,
    [mark] nvarchar(max)  NOT NULL,
    [isshared] bit  NOT NULL,
    [createtime] datetime  NOT NULL,
    [User_id] int  NOT NULL,
    [Folder_id] int  NOT NULL
);
GO

-- Creating table 'Folder'
CREATE TABLE [dbo].[Folder] (
    [id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(max)  NOT NULL,
    [isshared] bit  NOT NULL,
    [createtime] datetime  NOT NULL,
    [User_id] int  NOT NULL,
    [Folder_id] int  NOT NULL
);
GO

-- Creating table 'Log'
CREATE TABLE [dbo].[Log] (
    [id] int IDENTITY(1,1) NOT NULL,
    [action] nvarchar(max)  NOT NULL,
    [createtime] datetime  NOT NULL,
    [User_id] int  NOT NULL
);
GO

-- Creating table 'FolderFolder'
CREATE TABLE [dbo].[FolderFolder] (
    [Folder1_id] int  NOT NULL,
    [Folder2_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'File'
ALTER TABLE [dbo].[File]
ADD CONSTRAINT [PK_File]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Folder'
ALTER TABLE [dbo].[Folder]
ADD CONSTRAINT [PK_Folder]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Log'
ALTER TABLE [dbo].[Log]
ADD CONSTRAINT [PK_Log]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Folder1_id], [Folder2_id] in table 'FolderFolder'
ALTER TABLE [dbo].[FolderFolder]
ADD CONSTRAINT [PK_FolderFolder]
    PRIMARY KEY CLUSTERED ([Folder1_id], [Folder2_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_id] in table 'File'
ALTER TABLE [dbo].[File]
ADD CONSTRAINT [FK_UserFile]
    FOREIGN KEY ([User_id])
    REFERENCES [dbo].[User]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFile'
CREATE INDEX [IX_FK_UserFile]
ON [dbo].[File]
    ([User_id]);
GO

-- Creating foreign key on [Folder_id] in table 'File'
ALTER TABLE [dbo].[File]
ADD CONSTRAINT [FK_FolderFile]
    FOREIGN KEY ([Folder_id])
    REFERENCES [dbo].[Folder]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FolderFile'
CREATE INDEX [IX_FK_FolderFile]
ON [dbo].[File]
    ([Folder_id]);
GO

-- Creating foreign key on [User_id] in table 'Folder'
ALTER TABLE [dbo].[Folder]
ADD CONSTRAINT [FK_UserFolder]
    FOREIGN KEY ([User_id])
    REFERENCES [dbo].[User]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFolder'
CREATE INDEX [IX_FK_UserFolder]
ON [dbo].[Folder]
    ([User_id]);
GO

-- Creating foreign key on [Folder1_id] in table 'FolderFolder'
ALTER TABLE [dbo].[FolderFolder]
ADD CONSTRAINT [FK_FolderFolder_Folder]
    FOREIGN KEY ([Folder1_id])
    REFERENCES [dbo].[Folder]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Folder2_id] in table 'FolderFolder'
ALTER TABLE [dbo].[FolderFolder]
ADD CONSTRAINT [FK_FolderFolder_Folder1]
    FOREIGN KEY ([Folder2_id])
    REFERENCES [dbo].[Folder]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FolderFolder_Folder1'
CREATE INDEX [IX_FK_FolderFolder_Folder1]
ON [dbo].[FolderFolder]
    ([Folder2_id]);
GO

-- Creating foreign key on [User_id] in table 'Log'
ALTER TABLE [dbo].[Log]
ADD CONSTRAINT [FK_UserLog]
    FOREIGN KEY ([User_id])
    REFERENCES [dbo].[User]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLog'
CREATE INDEX [IX_FK_UserLog]
ON [dbo].[Log]
    ([User_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------