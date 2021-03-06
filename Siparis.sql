USE [Siparis]
GO
/****** Object:  Table [dbo].[Musteris]    Script Date: 25.12.2021 14:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteris](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](50) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
