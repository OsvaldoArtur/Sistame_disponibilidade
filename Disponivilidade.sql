USE [master]
GO
/****** Object:  Database [Gesviaturas]    Script Date: 24/10/2018 21:40:21 ******/
CREATE DATABASE [Gesviaturas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gesviaturas', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Gesviaturas.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Gesviaturas_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Gesviaturas_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Gesviaturas] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gesviaturas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gesviaturas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gesviaturas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gesviaturas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gesviaturas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gesviaturas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gesviaturas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gesviaturas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gesviaturas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gesviaturas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gesviaturas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gesviaturas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gesviaturas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gesviaturas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gesviaturas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gesviaturas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gesviaturas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gesviaturas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gesviaturas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gesviaturas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gesviaturas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gesviaturas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gesviaturas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gesviaturas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gesviaturas] SET  MULTI_USER 
GO
ALTER DATABASE [Gesviaturas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gesviaturas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gesviaturas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gesviaturas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Gesviaturas', N'ON'
GO
USE [Gesviaturas]
GO
/****** Object:  Table [dbo].[Abastecimento_tb]    Script Date: 24/10/2018 21:40:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abastecimento_tb](
	[idAbastecimento] [int] IDENTITY(1,1) NOT NULL,
	[idVeiculo] [int] NULL,
	[DataAbastecimento] [date] NULL,
	[DataRegisto] [datetime] NULL,
	[Litros] [decimal](10, 2) NULL,
	[KmInicio] [bigint] NULL,
	[KmFinais] [bigint] NULL,
	[KmPercorridos] [bigint] NULL,
	[Consumo] [decimal](10, 2) NULL,
	[PrecoLitro] [decimal](10, 2) NULL,
	[Total] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Abastecimento_tb] PRIMARY KEY CLUSTERED 
(
	[idAbastecimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente_tb](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](max) NULL,
	[DataNascimento] [date] NULL,
	[DataRegistro] [datetime] NULL,
	[RegistradoPor] [int] NULL,
	[ActualizadoPor] [int] NULL,
	[Telefone] [varchar](500) NULL,
	[EnderecoResidencia] [varchar](500) NULL,
	[Email] [varchar](500) NULL,
	[Observacoes] [text] NULL,
	[Foto] [image] NULL,
 CONSTRAINT [PK_Cliente_tb] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empresa_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa_tb](
	[idEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[NomeEmpresa] [varchar](500) NULL,
	[Endereco] [varchar](500) NULL,
	[Nuit] [varchar](50) NULL,
	[Telefone] [varchar](500) NULL,
	[Email] [varchar](500) NULL,
	[LogoTipo] [image] NULL,
 CONSTRAINT [PK_Empresa_tb] PRIMARY KEY CLUSTERED 
(
	[idEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntradaViatura_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaViatura_tb](
	[idEntrada] [int] IDENTITY(1,1) NOT NULL,
	[DataRegistro] [datetime] NULL,
	[RegistradoPor] [int] NULL,
	[idSaida] [int] NULL,
	[ActualizadoPor] [int] NULL,
 CONSTRAINT [PK_EntradaViatura_tb] PRIMARY KEY CLUSTERED 
(
	[idEntrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fluidos_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fluidos_tb](
	[idFluido] [int] IDENTITY(1,1) NOT NULL,
	[NomeFluido] [varchar](50) NULL,
	[UnidadeMedida] [varchar](50) NULL,
 CONSTRAINT [PK_Fluidos_tb] PRIMARY KEY CLUSTERED 
(
	[idFluido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FluidosManutencao_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FluidosManutencao_tb](
	[idFluidoManutencao] [int] IDENTITY(1,1) NOT NULL,
	[idFluido] [int] NULL,
	[Quantidade] [int] NULL,
	[ValorUnitario] [decimal](10, 2) NULL,
	[ValorTotal] [decimal](10, 2) NULL,
	[idManutencao] [int] NULL,
 CONSTRAINT [PK_FluidosManutencao_tb] PRIMARY KEY CLUSTERED 
(
	[idFluidoManutencao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Manutencao_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Manutencao_tb](
	[idManutencao] [int] IDENTITY(1,1) NOT NULL,
	[idVeiculo] [int] NULL,
	[idServico] [int] NULL,
	[TipoManutencao] [varchar](50) NULL,
	[DataRegisto] [datetime] NULL,
	[DataManutencao] [date] NULL,
	[KilometragemManutencao] [varchar](50) NULL,
	[ValorManutencao] [decimal](10, 2) NULL,
	[HoraInicio] [varchar](50) NULL,
	[HoraFim] [varchar](50) NULL,
	[NivelTanque] [varchar](50) NULL,
	[Observacoes] [text] NULL,
	[idCliente] [int] NULL,
 CONSTRAINT [PK_Manutencao_tb] PRIMARY KEY CLUSTERED 
(
	[idManutencao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marca_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marca_tb](
	[idMarca] [int] IDENTITY(1,1) NOT NULL,
	[NomeMarca] [varchar](max) NULL,
	[DataRegistro] [datetime] NULL,
	[RegistradoPor] [int] NULL,
	[ActualizadoPor] [int] NULL,
 CONSTRAINT [PK_Marca_tb] PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PecasManutencao_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PecasManutencao_tb](
	[idPeca] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Quantidade] [int] NULL,
	[ValorUnitario] [decimal](10, 2) NULL,
	[ValorTotal] [decimal](10, 2) NULL,
	[idManutencao] [int] NULL,
 CONSTRAINT [PK_PecasManutencao_tb] PRIMARY KEY CLUSTERED 
(
	[idPeca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SaidaViatura_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaidaViatura_tb](
	[idSaida] [int] IDENTITY(1,1) NOT NULL,
	[DataSaida] [date] NULL,
	[DataDevolucao] [date] NULL,
	[DataRegistro] [datetime] NULL,
	[RegistradoPor] [int] NULL,
	[ActualizadoPor] [int] NULL,
	[Diasdealerta] [int] NULL,
	[idCliente] [int] NULL,
	[idViatura] [int] NULL,
 CONSTRAINT [PK_SaidaViatura_tb] PRIMARY KEY CLUSTERED 
(
	[idSaida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Servicos_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Servicos_tb](
	[idServicos] [int] IDENTITY(1,1) NOT NULL,
	[NomeServico] [varchar](50) NULL,
	[DescricaoServico] [text] NULL,
 CONSTRAINT [PK_Servicos_tb] PRIMARY KEY CLUSTERED 
(
	[idServicos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario_tb](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Senha] [varchar](50) NULL,
	[DataNascimento] [date] NULL,
	[Contacto] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario_tb] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Viatura_tb]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Viatura_tb](
	[idViaturas] [int] IDENTITY(1,1) NOT NULL,
	[ModeloViatura] [varchar](max) NULL,
	[AnoFabrico] [varchar](50) NULL,
	[Matricula] [varchar](max) NULL,
	[Estado] [varchar](max) NULL,
	[DataRegistro] [datetime] NULL,
	[RegistradoPor] [int] NULL,
	[ActualizadoPor] [int] NULL,
	[idMarca] [int] NULL,
	[idFluido] [int] NULL,
	[KmCadastro] [varchar](500) NULL,
	[DestinoUso] [text] NULL,
	[Foto] [image] NULL,
	[EstadoViatura] [varchar](50) NULL,
 CONSTRAINT [PK_Viatura_tb] PRIMARY KEY CLUSTERED 
(
	[idViaturas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_Abastecimento]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Abastecimento]
AS
SELECT        dbo.Viatura_tb.idViaturas, dbo.Viatura_tb.Matricula, dbo.Fluidos_tb.NomeFluido, dbo.Abastecimento_tb.idAbastecimento, dbo.Abastecimento_tb.DataAbastecimento, dbo.Abastecimento_tb.DataRegisto, 
                         dbo.Abastecimento_tb.Litros, dbo.Abastecimento_tb.KmInicio, dbo.Abastecimento_tb.KmFinais, dbo.Abastecimento_tb.KmPercorridos, dbo.Abastecimento_tb.Consumo, dbo.Abastecimento_tb.PrecoLitro, 
                         dbo.Abastecimento_tb.Total
FROM            dbo.Abastecimento_tb INNER JOIN
                         dbo.Viatura_tb ON dbo.Abastecimento_tb.idVeiculo = dbo.Viatura_tb.idViaturas INNER JOIN
                         dbo.Fluidos_tb ON dbo.Viatura_tb.idFluido = dbo.Fluidos_tb.idFluido

GO
/****** Object:  View [dbo].[View_CarroMarca]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_CarroMarca]
AS
SELECT        dbo.Marca_tb.idMarca, dbo.Viatura_tb.idViaturas, dbo.Marca_tb.NomeMarca, dbo.Viatura_tb.ModeloViatura, dbo.Viatura_tb.AnoFabrico, dbo.Viatura_tb.Matricula, dbo.Viatura_tb.Estado, 
                         dbo.Viatura_tb.DataRegistro
FROM            dbo.Marca_tb INNER JOIN
                         dbo.Viatura_tb ON dbo.Marca_tb.idMarca = dbo.Viatura_tb.idMarca

GO
/****** Object:  View [dbo].[View_FluidosManutencao]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_FluidosManutencao]
AS
SELECT        dbo.Fluidos_tb.NomeFluido, dbo.Fluidos_tb.UnidadeMedida, dbo.FluidosManutencao_tb.idFluidoManutencao, dbo.FluidosManutencao_tb.Quantidade, dbo.FluidosManutencao_tb.ValorUnitario, 
                         dbo.FluidosManutencao_tb.ValorTotal, dbo.FluidosManutencao_tb.idManutencao, dbo.Fluidos_tb.idFluido
FROM            dbo.Fluidos_tb INNER JOIN
                         dbo.FluidosManutencao_tb ON dbo.Fluidos_tb.idFluido = dbo.FluidosManutencao_tb.idFluido

GO
/****** Object:  View [dbo].[View_Manutencao]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Manutencao]
AS
SELECT        dbo.Servicos_tb.idServicos, dbo.Servicos_tb.NomeServico, dbo.Manutencao_tb.idManutencao, dbo.Manutencao_tb.idVeiculo, dbo.Manutencao_tb.TipoManutencao, dbo.Manutencao_tb.DataRegisto, 
                         dbo.Manutencao_tb.DataManutencao, dbo.Manutencao_tb.KilometragemManutencao, dbo.Manutencao_tb.ValorManutencao, dbo.Manutencao_tb.HoraInicio, dbo.Manutencao_tb.HoraFim, dbo.Manutencao_tb.NivelTanque, 
                         dbo.Manutencao_tb.Observacoes, dbo.Cliente_tb.idCliente, dbo.Cliente_tb.NomeCliente
FROM            dbo.Manutencao_tb INNER JOIN
                         dbo.Servicos_tb ON dbo.Manutencao_tb.idServico = dbo.Servicos_tb.idServicos INNER JOIN
                         dbo.Cliente_tb ON dbo.Manutencao_tb.idCliente = dbo.Cliente_tb.idCliente

GO
/****** Object:  View [dbo].[View_Saida]    Script Date: 24/10/2018 21:40:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Saida]
AS
SELECT        dbo.SaidaViatura_tb.idSaida, dbo.Viatura_tb.idViaturas, dbo.Cliente_tb.idCliente, dbo.Marca_tb.idMarca, dbo.SaidaViatura_tb.DataSaida, dbo.SaidaViatura_tb.DataDevolucao, dbo.Cliente_tb.NomeCliente, 
                         dbo.Marca_tb.NomeMarca, dbo.Viatura_tb.ModeloViatura, dbo.Viatura_tb.AnoFabrico, dbo.Viatura_tb.Matricula
FROM            dbo.Cliente_tb INNER JOIN
                         dbo.SaidaViatura_tb ON dbo.Cliente_tb.idCliente = dbo.SaidaViatura_tb.idCliente INNER JOIN
                         dbo.Viatura_tb ON dbo.SaidaViatura_tb.idViatura = dbo.Viatura_tb.idViaturas INNER JOIN
                         dbo.Marca_tb ON dbo.Viatura_tb.idMarca = dbo.Marca_tb.idMarca

GO
ALTER TABLE [dbo].[Abastecimento_tb]  WITH CHECK ADD  CONSTRAINT [FK_Abastecimento_tb_Viatura_tb] FOREIGN KEY([idVeiculo])
REFERENCES [dbo].[Viatura_tb] ([idViaturas])
GO
ALTER TABLE [dbo].[Abastecimento_tb] CHECK CONSTRAINT [FK_Abastecimento_tb_Viatura_tb]
GO
ALTER TABLE [dbo].[EntradaViatura_tb]  WITH CHECK ADD  CONSTRAINT [FK_EntradaViatura_tb_SaidaViatura_tb] FOREIGN KEY([idSaida])
REFERENCES [dbo].[SaidaViatura_tb] ([idSaida])
GO
ALTER TABLE [dbo].[EntradaViatura_tb] CHECK CONSTRAINT [FK_EntradaViatura_tb_SaidaViatura_tb]
GO
ALTER TABLE [dbo].[FluidosManutencao_tb]  WITH CHECK ADD  CONSTRAINT [FK_FluidosManutencao_tb_Fluidos_tb] FOREIGN KEY([idFluido])
REFERENCES [dbo].[Fluidos_tb] ([idFluido])
GO
ALTER TABLE [dbo].[FluidosManutencao_tb] CHECK CONSTRAINT [FK_FluidosManutencao_tb_Fluidos_tb]
GO
ALTER TABLE [dbo].[FluidosManutencao_tb]  WITH CHECK ADD  CONSTRAINT [FK_FluidosManutencao_tb_Manutencao_tb] FOREIGN KEY([idManutencao])
REFERENCES [dbo].[Manutencao_tb] ([idManutencao])
GO
ALTER TABLE [dbo].[FluidosManutencao_tb] CHECK CONSTRAINT [FK_FluidosManutencao_tb_Manutencao_tb]
GO
ALTER TABLE [dbo].[Manutencao_tb]  WITH CHECK ADD  CONSTRAINT [FK_Manutencao_tb_Cliente_tb] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente_tb] ([idCliente])
GO
ALTER TABLE [dbo].[Manutencao_tb] CHECK CONSTRAINT [FK_Manutencao_tb_Cliente_tb]
GO
ALTER TABLE [dbo].[Manutencao_tb]  WITH CHECK ADD  CONSTRAINT [FK_Manutencao_tb_Servicos_tb] FOREIGN KEY([idServico])
REFERENCES [dbo].[Servicos_tb] ([idServicos])
GO
ALTER TABLE [dbo].[Manutencao_tb] CHECK CONSTRAINT [FK_Manutencao_tb_Servicos_tb]
GO
ALTER TABLE [dbo].[PecasManutencao_tb]  WITH CHECK ADD  CONSTRAINT [FK_PecasManutencao_tb_Manutencao_tb] FOREIGN KEY([idManutencao])
REFERENCES [dbo].[Manutencao_tb] ([idManutencao])
GO
ALTER TABLE [dbo].[PecasManutencao_tb] CHECK CONSTRAINT [FK_PecasManutencao_tb_Manutencao_tb]
GO
ALTER TABLE [dbo].[SaidaViatura_tb]  WITH CHECK ADD  CONSTRAINT [FK_SaidaViatura_tb_Cliente_tb] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente_tb] ([idCliente])
GO
ALTER TABLE [dbo].[SaidaViatura_tb] CHECK CONSTRAINT [FK_SaidaViatura_tb_Cliente_tb]
GO
ALTER TABLE [dbo].[SaidaViatura_tb]  WITH CHECK ADD  CONSTRAINT [FK_SaidaViatura_tb_Viatura_tb] FOREIGN KEY([idViatura])
REFERENCES [dbo].[Viatura_tb] ([idViaturas])
GO
ALTER TABLE [dbo].[SaidaViatura_tb] CHECK CONSTRAINT [FK_SaidaViatura_tb_Viatura_tb]
GO
ALTER TABLE [dbo].[Viatura_tb]  WITH CHECK ADD  CONSTRAINT [FK_Viatura_tb_Fluidos_tb] FOREIGN KEY([idFluido])
REFERENCES [dbo].[Fluidos_tb] ([idFluido])
GO
ALTER TABLE [dbo].[Viatura_tb] CHECK CONSTRAINT [FK_Viatura_tb_Fluidos_tb]
GO
ALTER TABLE [dbo].[Viatura_tb]  WITH CHECK ADD  CONSTRAINT [FK_Viatura_tb_Marca_tb] FOREIGN KEY([idMarca])
REFERENCES [dbo].[Marca_tb] ([idMarca])
GO
ALTER TABLE [dbo].[Viatura_tb] CHECK CONSTRAINT [FK_Viatura_tb_Marca_tb]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Abastecimento_tb"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 204
               Right = 231
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Viatura_tb"
            Begin Extent = 
               Top = 6
               Left = 269
               Bottom = 211
               Right = 439
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Fluidos_tb"
            Begin Extent = 
               Top = 6
               Left = 477
               Bottom = 143
               Right = 650
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Abastecimento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Abastecimento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Marca_tb"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Viatura_tb"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_CarroMarca'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_CarroMarca'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Fluidos_tb"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 159
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FluidosManutencao_tb"
            Begin Extent = 
               Top = 6
               Left = 249
               Bottom = 136
               Right = 448
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FluidosManutencao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FluidosManutencao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Manutencao_tb"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 211
               Right = 269
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Servicos_tb"
            Begin Extent = 
               Top = 6
               Left = 307
               Bottom = 206
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cliente_tb"
            Begin Extent = 
               Top = 6
               Left = 523
               Bottom = 136
               Right = 717
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Manutencao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Manutencao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Cliente_tb"
            Begin Extent = 
               Top = 0
               Left = 27
               Bottom = 130
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SaidaViatura_tb"
            Begin Extent = 
               Top = 4
               Left = 245
               Bottom = 134
               Right = 415
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Viatura_tb"
            Begin Extent = 
               Top = 70
               Left = 529
               Bottom = 200
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Marca_tb"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Saida'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Saida'
GO
USE [master]
GO
ALTER DATABASE [Gesviaturas] SET  READ_WRITE 
GO
