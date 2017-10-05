
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/05/2017 14:11:19
-- Generated from EDMX file: D:\Documents\ITstep\Dropbox (Личный)\Develop\ItStep\WinForms\WF_Exam\WF_Exam\TestModel1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
--USE [TestDB];
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

-- Creating table 'AnswerSet'
CREATE TABLE [dbo].[AnswerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [IsCorrect] bit  NOT NULL,
    [QuestionId] int  NOT NULL,
    [TestResultId] int  NOT NULL
);
GO

-- Creating table 'QuestionSet'
CREATE TABLE [dbo].[QuestionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Type] int  NOT NULL,
    [TestId] int  NOT NULL
);
GO

-- Creating table 'TestSet'
CREATE TABLE [dbo].[TestSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [TestResult_Id] int  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Login] nvarchar(50)  NOT NULL,
    [Password] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'TestResultSet'
CREATE TABLE [dbo].[TestResultSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AnswerSet'
ALTER TABLE [dbo].[AnswerSet]
ADD CONSTRAINT [PK_AnswerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'QuestionSet'
ALTER TABLE [dbo].[QuestionSet]
ADD CONSTRAINT [PK_QuestionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestSet'
ALTER TABLE [dbo].[TestSet]
ADD CONSTRAINT [PK_TestSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestResultSet'
ALTER TABLE [dbo].[TestResultSet]
ADD CONSTRAINT [PK_TestResultSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [QuestionId] in table 'AnswerSet'
ALTER TABLE [dbo].[AnswerSet]
ADD CONSTRAINT [FK_QuestionAnswer]
    FOREIGN KEY ([QuestionId])
    REFERENCES [dbo].[QuestionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_QuestionAnswer'
CREATE INDEX [IX_FK_QuestionAnswer]
ON [dbo].[AnswerSet]
    ([QuestionId]);
GO

-- Creating foreign key on [TestId] in table 'QuestionSet'
ALTER TABLE [dbo].[QuestionSet]
ADD CONSTRAINT [FK_TestQuestion]
    FOREIGN KEY ([TestId])
    REFERENCES [dbo].[TestSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestQuestion'
CREATE INDEX [IX_FK_TestQuestion]
ON [dbo].[QuestionSet]
    ([TestId]);
GO

-- Creating foreign key on [UserId] in table 'TestResultSet'
ALTER TABLE [dbo].[TestResultSet]
ADD CONSTRAINT [FK_UserTestResult]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTestResult'
CREATE INDEX [IX_FK_UserTestResult]
ON [dbo].[TestResultSet]
    ([UserId]);
GO

-- Creating foreign key on [TestResult_Id] in table 'TestSet'
ALTER TABLE [dbo].[TestSet]
ADD CONSTRAINT [FK_TestResultTest]
    FOREIGN KEY ([TestResult_Id])
    REFERENCES [dbo].[TestResultSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestResultTest'
CREATE INDEX [IX_FK_TestResultTest]
ON [dbo].[TestSet]
    ([TestResult_Id]);
GO

-- Creating foreign key on [TestResultId] in table 'AnswerSet'
ALTER TABLE [dbo].[AnswerSet]
ADD CONSTRAINT [FK_TestResultAnswer]
    FOREIGN KEY ([TestResultId])
    REFERENCES [dbo].[TestResultSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestResultAnswer'
CREATE INDEX [IX_FK_TestResultAnswer]
ON [dbo].[AnswerSet]
    ([TestResultId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------