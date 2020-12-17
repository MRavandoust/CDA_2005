CREATE TABLE [dbo].[Fournisseurs] (
    [id_F]         INT           NOT NULL IDENTITY,
    [nom]          VARCHAR (100) NOT NULL,
    [vile]         VARCHAR (80)  NOT NULL,
    [contact]      VARCHAR (100) NOT NULL,
    [satisfaction] SMALLINT      NULL,
    [num_rue]      INT           NOT NULL,
    [nom_rue]      VARCHAR (100) NOT NULL,
    [code_postal]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id_F] ASC)
);

