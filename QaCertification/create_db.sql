CREATE TABLE [dbo].[email] (
    [id]       INT       IDENTITY (1, 1) NOT NULL,
    [QA_ID_fk] INT       NOT NULL,
    [email]    CHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([QA_ID_fk]) REFERENCES [dbo].[QA_Personal] ([QAID])
);
CREATE TABLE [dbo].[person_qal] (
    [Q_Id]      INT NOT NULL,
    [QA_ID_FK]  INT NOT NULL,
    [Qul_Id_FK] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Q_Id] ASC),
    FOREIGN KEY ([Qul_Id_FK]) REFERENCES [dbo].[qualifications] ([Qul_Id]),
    FOREIGN KEY ([QA_ID_FK]) REFERENCES [dbo].[QA_Personal] ([QAID])
);
CREATE TABLE [dbo].[QA_Personal] (
    [QAID]    INT        NOT NULL,
    [Name]    CHAR (20)  NOT NULL,
    [Address] CHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([QAID] ASC)
);

CREATE TABLE [dbo].[qualifications] (
    [Qul_Id]   INT       NOT NULL,
    [Qul_name] CHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Qul_Id] ASC)
);
