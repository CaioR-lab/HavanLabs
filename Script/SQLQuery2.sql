USE [HavanLabs]
GO

/****** Object:  Table [dbo].[Produto]    Script Date: 12/07/2021 14:12:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](150) NULL
) ON [PRIMARY]
GO


