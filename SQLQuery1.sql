USE HandsOnAspNET
GO
----------------------------------------------------------------------
CREATE TABLE [dbo].[suspeitos](
	[suspeito_cod] [int] NOT NULL,
	[suspeito_nome] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[suspeito_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
----------------------------------------------------------------------
CREATE TABLE [dbo].[armas](
	[arma_cod] [int] NOT NULL,
	[arma_nome] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[arma_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
----------------------------------------------------------------------
CREATE TABLE [dbo].[locais](
	[local_cod] [int] NOT NULL,
	[local_nome] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[local_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
----------------------------------------------------------------------
INSERT INTO suspeitos (suspeito_cod,suspeito_nome) VALUES (1,'Esqueleto') 
INSERT INTO suspeitos (suspeito_cod,suspeito_nome) VALUES (2,'Khan') 
INSERT INTO suspeitos (suspeito_cod,suspeito_nome) VALUES (3,'Darth vader') 
INSERT INTO suspeitos (suspeito_cod,suspeito_nome) VALUES (4,'Sideshow Bob') 
INSERT INTO suspeitos (suspeito_cod,suspeito_nome) VALUES (5,'Coringa') 
INSERT INTO suspeitos (suspeito_cod,suspeito_nome) VALUES (6,'Duende Verde') 
----------------------------------------------------------------------
INSERT INTO armas (arma_cod,arma_nome) VALUES (1 ,'Cajado Devastador') 
INSERT INTO armas (arma_cod,arma_nome) VALUES (2 ,'Phaser') 
INSERT INTO armas (arma_cod,arma_nome) VALUES (3 ,'Peixeira') 
INSERT INTO armas (arma_cod,arma_nome) VALUES (4 ,'Trezoitão') 
INSERT INTO armas (arma_cod,arma_nome) VALUES (5 ,'Sabre de Luz') 
INSERT INTO armas (arma_cod,arma_nome) VALUES (6 ,'Bomba') 
----------------------------------------------------------------------
INSERT INTO locais (local_cod,local_nome) VALUES (1 ,'Etérnia') 
INSERT INTO locais (local_cod,local_nome) VALUES (2 ,'Vulcano') 
INSERT INTO locais (local_cod,local_nome) VALUES (3 ,'Tatooine') 
INSERT INTO locais (local_cod,local_nome) VALUES (4 ,'Springfield') 
INSERT INTO locais (local_cod,local_nome) VALUES (5 ,'Gotham') 
INSERT INTO locais (local_cod,local_nome) VALUES (6 ,'Nova York') 
INSERT INTO locais (local_cod,local_nome) VALUES (7 ,'Sibéria') 
INSERT INTO locais (local_cod,local_nome) VALUES (8 ,'Machu Picchu') 
INSERT INTO locais (local_cod,local_nome) VALUES (9 ,'Show do Katinguele') 
INSERT INTO locais (local_cod,local_nome) VALUES (10,'São Paulo') 
----------------------------------------------------------------------
CREATE PROC [dbo].[s_suspeitos]
AS
SET NOCOUNT ON

select suspeito_cod, suspeito_nome
from suspeitos with(nolock)
order by suspeito_cod
GO

GRANT EXEC ON [dbo].[s_suspeitos] to {{usuario_local}}
GO
----------------------------------------------------------------------
CREATE PROC [dbo].[s_armas]
AS
SET NOCOUNT ON

select arma_cod, arma_nome
from armas with(nolock)
order by arma_cod
GO

GRANT EXEC ON [dbo].[s_armas] to {{usuario_local}}
GO
----------------------------------------------------------------------
CREATE PROC [dbo].[s_locais]
AS
SET NOCOUNT ON

select local_cod, local_nome
from locais with(nolock)
order by local_cod
GO

GRANT EXEC ON [dbo].[s_locais] to {{usuario_local}}
GO
----------------------------------------------------------------------
s_suspeitos
s_armas
s_locais
----------------------------------------------------------------------
