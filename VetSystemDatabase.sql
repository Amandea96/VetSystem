CREATE DATABASE [VetSystemDatabase]
 
GO
USE [VetSystemDatabase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 31.03.2020 19:58:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [varchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[id_inst] [int] NULL,
	[address] [nvarchar](max) NULL,
	[education] [varchar](50) NULL,
 CONSTRAINT [PK_Vet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genus]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genus](
	[id_genus] [int] IDENTITY(1,1) NOT NULL,
	[name_genus] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Genus] PRIMARY KEY CLUSTERED 
(
	[id_genus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Institution]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institution](
	[id_inst] [int] IDENTITY(1,1) NOT NULL,
	[address_inst] [nvarchar](100) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[postcode] [nchar](10) NOT NULL,
	[inter_list] [nvarchar](max) NULL,
	[phNumInst] [nchar](10) NOT NULL,
	[emailInst] [varchar](100) NOT NULL,
	[name_inst] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Institution] PRIMARY KEY CLUSTERED 
(
	[id_inst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id_patient] [int] IDENTITY(1,1) NOT NULL,
	[id_owner] [nvarchar](450) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[age] [date] NOT NULL,
	[weight] [float] NULL,
	[breed] [nvarchar](50) NULL,
	[sex] [nvarchar](50) NOT NULL,
	[id_genus] [int] NOT NULL,
	[sterilized_castration] [nvarchar](max) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[id_patient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientInstitution]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientInstitution](
	[id_patient] [int] NOT NULL,
	[id_inst] [int] NOT NULL,
 CONSTRAINT [PK_PatientInstitution] PRIMARY KEY CLUSTERED 
(
	[id_patient] ASC,
	[id_inst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit]    Script Date: 31.03.2020 19:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[id_visit] [int] IDENTITY(1,1) NOT NULL,
	[id_patient] [int] NOT NULL,
	[dateVisit] [datetime2](7) NOT NULL,
	[purpose] [nvarchar](max) NOT NULL,
	[decrDisActions] [nvarchar](max) NOT NULL,
	[id_vet] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Vis] PRIMARY KEY CLUSTERED 
(
	[id_visit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200328070542_init', N'3.1.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200331170706_database', N'3.1.2')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'16fef5ae-74be-41b3-b55a-e27f4920560a', N'BossVet', N'BOSSVET', N'4fda496c-7344-48c0-bc7a-608d34a6639e')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9eac30ca-9ba9-4d14-8607-37c7585b1d86', N'Admin', N'ADMIN', N'90ab3ef0-c429-429c-9cea-cd32e440e64d')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036', N'Owner', N'OWNER', N'fdb4ffbf-6f42-4068-832f-b53833d70251')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'fc228bda-6636-4b3b-b136-ee15c9dc9ee5', N'Vet', N'VET', N'6d17d6d1-f5a6-4c16-9670-7e89606f5fcb')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5', N'16fef5ae-74be-41b3-b55a-e27f4920560a')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7163fcd7-2e42-4e34-8a9a-2d5a03ed7b0d', N'16fef5ae-74be-41b3-b55a-e27f4920560a')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3c851ecd-ff40-4855-aa0b-ca54a2597cea', N'9eac30ca-9ba9-4d14-8607-37c7585b1d86')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ebc5704-94aa-4084-909d-1cc71a4d7810', N'9eac30ca-9ba9-4d14-8607-37c7585b1d86')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'139bb1f6-e02a-4915-885d-6c47d9302af0', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1a41d97d-828e-4642-960a-15ded7e697a0', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1b269a84-39dd-4acf-8bca-03fd79a4d6df', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1f11a0ee-94bd-4ab4-b8cd-f86906cfc0d1', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5acfe14c-885e-4242-9885-2118acd40338', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5dda782f-54da-4ad1-a8ca-99336a815ed2', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bab04094-0af0-4905-a167-24f38521594e', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c6b6c733-3b99-4a7a-8418-3ae20af50fd8', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ce9ca8ab-b3cb-4981-b10a-76e790cb4d11', N'cde05489-bd0a-4bcb-9d1b-4ddc0c6ab036')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4604a90a-89d0-4ffe-97de-bad12d1d3966', N'fc228bda-6636-4b3b-b136-ee15c9dc9ee5')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'139bb1f6-e02a-4915-885d-6c47d9302af0', N'alKo1@gmail.com', N'ALKO1@GMAIL.COM', N'alKo1@gmail.com', N'ALKO1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKpxU/xOg8t8zzKofYLgHPRWvgaXhPEvwaeKnMAe+rAvCeEwOzdf/VnpzcrBRGEbOg==', N'CYS5HUPT5VY5ZY56XVQ6ISL7PF6JEOKU', N'6b62d412-6dd2-408b-9ac5-183c2447b2c8', N'3141141414', 0, 0, NULL, 1, 0, N'Aldona', N'Kowalska', NULL, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'1a41d97d-828e-4642-960a-15ded7e697a0', N'teKo1@gmail.com', N'TEKO1@GMAIL.COM', N'teKo1@gmail.com', N'TEKO1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAED8aGlvK+PEfuBhqYFzVwLaxGFb9s3viXUtudd6II8ReP3zkn6VFLZIngFuUDAF7bA==', N'UU5YTISC6LS6YER7RGGNUEONCOFS326B', N'8c3a6a0f-6d9d-4b77-8bb5-ed86862886da', N'890009765', 0, 0, NULL, 1, 0, N'Teodor', N'Kowalski', NULL, N'Wojska Polskiego 1 Jasło', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'1b269a84-39dd-4acf-8bca-03fd79a4d6df', N'raKo1@gmail.com', N'RAKO1@GMAIL.COM', N'raKo1@gmail.com', N'RAKO1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKo6Koqe25M8TgsajeYL2pKRkAOSaTw9XVpQslPGF6Zc/DJU8CrMW9n8cMj/T1KhSQ==', N'76RGNWC3W4MMO4DQQK545HVDU2IIZOXC', N'77f74f3d-8d02-42a3-8fd9-c3d2c3c08a28', N'567098887', 0, 0, NULL, 1, 0, N'Rafał', N'Kostecki', NULL, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'1f11a0ee-94bd-4ab4-b8cd-f86906cfc0d1', N'alKi1@gmail.com', N'ALKI1@GMAIL.COM', N'alKi1@gmail.com', N'ALKI1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAED27mwgtWc6/0Ibmx10q10qqZM4AX1/Y0wuXV9tteENEoGQRsPGQXld4HR8BcOMCZA==', N'BLFTRPJPC643N4BCOKMX4P3MY6SDNY7G', N'e988e04a-f3ee-4915-b08f-a4124246ef64', N'654665098', 0, 0, NULL, 1, 0, N'Aldona', N'Kisielewska', NULL, N'Piłsudskiego 7 Krosno', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'3c851ecd-ff40-4855-aa0b-ca54a2597cea', N'mandy.96@windowslive.com', N'MANDY.96@WINDOWSLIVE.COM', N'mandy.96@windowslive.com', N'MANDY.96@WINDOWSLIVE.COM', 1, N'AQAAAAEAACcQAAAAEIUQAE/ppjkCzwJiCRQqe0okJe/e8jOqZB0N91yENzMF9jfgbwIQEn95SGxnEO+UwQ==', N'MMS4TOBDYQ25A4B7KJNQYMKEXRLVL4OH', N'b04bc1cb-2b6f-43d6-b83b-1f12d4580933', NULL, 0, 0, NULL, 1, 0, N'Amanda', N'Knol', NULL, N'Sikorskiego 5 Krosno', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'4604a90a-89d0-4ffe-97de-bad12d1d3966', N'maMa1@gmail.com', N'MAMA1@GMAIL.COM', N'maMa1@gmail.com', N'MAMA1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEH1cJv2azaCuRRmXOt79dqVVFE3x1C1e/lFYuKL0PfHS1PYk1u8hF/99yvdCtibuzA==', N'RPBDXBCZCG4XNN3LC5VCS4M2ATEA4LWH', N'27a4056d-0125-40ff-89c5-7f0679743c4d', N'987654543', 0, 0, NULL, 1, 0, N'Magdalena', N'Marchewka', 1, N'Czajkowskiego 19 Krosno', N'Lekarz weterynarii')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'5acfe14c-885e-4242-9885-2118acd40338', N'kaJa1@gmail.com', N'KAJA1@GMAIL.COM', N'kaJa1@gmail.com', N'KAJA1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOMzgW9q8PaUcDZj27f5vHx7R33KEcyJtFhs+8omdWwaGRhRF28mOu6TB/BGMAJKyg==', N'WIAAQPDE2FY4W4OIF7IKRJEE6VORRSE6', N'4096db81-da08-4826-a5fb-48a08fd3f6e0', N'987654109', 0, 0, NULL, 1, 0, N'Karol', N'Jaskółka', NULL, N'Krościenko Wyżne Polna1', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'5dda782f-54da-4ad1-a8ca-99336a815ed2', N'saGl1@gmail.com', N'SAGL1@GMAIL.COM', N'saGl1@gmail.com', N'SAGL1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENebf1lreD5004jwWRJcHA8K6dMPIojuve5EqVK1drJ4rqpPcTOn5t/iflTuPyGB1Q==', N'RQAP3IJU6RVSJWY7HJMFHUXPVW7EJPIX', N'281e40f0-ed08-400b-9e7b-cdb95dcd060f', N'890009532', 0, 0, NULL, 1, 0, N'Samantha', N'Głowacka', NULL, N'Wojska Polskiego 1 Jasło', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5', N'roCi90@gmail.com', N'ROCI90@GMAIL.COM', N'roCi90@gmail.com', N'ROCI90@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJdlCIEqAp9IFESmHSp+8zOTPBlw5P1zpdZscrnSMn07RkNpjkOTuzT+XZbNzsTMyw==', N'3GKBWGNLCBXIE2V2ICMD3ARRZULYMOPD', N'7b3e593b-cb8e-45b4-846b-d5c56bc8451d', N'987876235', 0, 0, NULL, 1, 0, N'Roksana', N'Cichocka', 1, N'Sienkiewicza 15 Rzeszów', N'Lekarz weterynarii')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'7163fcd7-2e42-4e34-8a9a-2d5a03ed7b0d', N'weKo1@gmail.com', N'WEKO1@GMAIL.COM', N'weKo1@gmail.com', N'WEKO1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENefpKPkH5x5w9FK3+DiCX+msbKnjUPf+UL/g5zEla/vqfuSKVeUQ98ipr5Fdb6Atw==', N'VRXJWJJMIQWUSESMNSK6A2HMTHHJKBQG', N'0744231c-5a00-4d94-b1da-99d9c8370df2', N'987654987', 0, 0, NULL, 1, 0, N'Weronika', N'Kowalska', 4, N'Wojska Polskiego 10 Krosno', N'Lekarz weterynarii')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'9ebc5704-94aa-4084-909d-1cc71a4d7810', N'roMa1@gmail.com', N'ROMA1@GMAIL.COM', N'roMa1@gmail.com', N'ROMA1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEI5BYQ3mv/dWDbI/8TZOh711sIDGqHKk2/e6riwdTqbFe9AVupuT8MtdP2fVHNcixQ==', N'WECKFAHRIAJIXD3AZY3RTQFP5KD5S57N', N'eb6ecc83-a035-4c48-8e1b-0b76a17c366c', NULL, 0, 0, NULL, 1, 0, N'Roman', N'Marchewka', NULL, N'Wojska Polskiego 16 Jasło', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'bab04094-0af0-4905-a167-24f38521594e', N'kaZa1@gmail.com', N'KAZA1@GMAIL.COM', N'kaZa1@gmail.com', N'KAZA1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOXxx1nI8lHimrkMqswaF9SmDlhI1fdp7Wa6FExtqi8Y6+oX7fFxE6jAa5QhQPw5ZA==', N'UPXQLZTNF5KDFZYEN5NAPXVMNTYCEGWZ', N'40aec2a9-63c0-46b6-b7f2-134e72a006b0', N'987654170', 0, 0, NULL, 1, 0, N'Karolina', N'Zajdel', NULL, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'c6b6c733-3b99-4a7a-8418-3ae20af50fd8', N'jaCi1@gmail.com', N'JACI1@GMAIL.COM', N'jaCi1@gmail.com', N'JACI1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEEfvGNOWTJkBzpX2g2bZ/VV/5HZOOo13zvgUZKHJfplbdwk/9WZz/g88c5jsDTZ2sA==', N'GDFTM54JYHW5CF7SZVRHWC7FDWIBJ6LT', N'd2ee9919-cfb1-43a9-beea-cda328c832e0', N'654098876', 0, 0, NULL, 1, 0, N'Jarosław', N'Cichocki', NULL, N'Krościenko Niżne Polna 10', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [name], [surname], [id_inst], [address], [education]) VALUES (N'ce9ca8ab-b3cb-4981-b10a-76e790cb4d11', N'kaKo1@gmail.com', N'KAKO1@GMAIL.COM', N'kaKo1@gmail.com', N'KAKO1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEAdKyAJ0vPyNYjPekKw4QbDaYXdcegNdrq9Qi0CZifqkHLDZSjyayxh4vWB9WkvVng==', N'CJAWI4XT2OJB63ITB5AH67B7VZA6QCNJ', N'b73aa18f-0145-4f62-b02e-b0d0415ffb14', N'564765098', 0, 0, NULL, 1, 0, N'Karolina', N'Kowalska', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Genus] ON 

INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (1, N'Kot')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (2, N'Pies')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (3, N'Jeż')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (4, N'Królik')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (5, N'Wąż')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (6, N'Papuga')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (7, N'Mysz')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (8, N'Krowa')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (9, N'Świnia')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (10, N'Fretka')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (11, N'Żółw')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (12, N'Chomik')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (13, N'Świnka morska')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (14, N'Inny')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (15, N'Gęś')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (16, N'Szop')
INSERT [dbo].[Genus] ([id_genus], [name_genus]) VALUES (17, N'Kanarek')
SET IDENTITY_INSERT [dbo].[Genus] OFF
SET IDENTITY_INSERT [dbo].[Institution] ON 

INSERT [dbo].[Institution] ([id_inst], [address_inst], [city], [postcode], [inter_list], [phNumInst], [emailInst], [name_inst]) VALUES (1, N'Targowa 6', N'Rzeszów', N'35-065    ', N'Badania: krwi, pielęgnacja.
Godziny przyjęć: pon.-pt.: 9:00-17:00, sob.:12:00-15:00.
', N'345760980 ', N'reks@gmail.com', N'Reksio')
INSERT [dbo].[Institution] ([id_inst], [address_inst], [city], [postcode], [inter_list], [phNumInst], [emailInst], [name_inst]) VALUES (2, N'Kościószki 15', N'Poznań', N'61-139    ', NULL, N'676540091 ', N'soVET@gmail.com', N'SoVET')
INSERT [dbo].[Institution] ([id_inst], [address_inst], [city], [postcode], [inter_list], [phNumInst], [emailInst], [name_inst]) VALUES (3, N'Piłsudskiego 2', N'Poznań', N'61-246    ', NULL, N'676540002 ', N'pet@gmail.com', N'PetSalon')
INSERT [dbo].[Institution] ([id_inst], [address_inst], [city], [postcode], [inter_list], [phNumInst], [emailInst], [name_inst]) VALUES (4, N'Wojska Polskiego 10', N'Krosno', N'38-400    ', NULL, N'788654098 ', N'paZu@gmail.com', N'Pazur')
INSERT [dbo].[Institution] ([id_inst], [address_inst], [city], [postcode], [inter_list], [phNumInst], [emailInst], [name_inst]) VALUES (5, N'Bartycka 55', N'Warszawa', N'00-713    ', NULL, N'345760095 ', N'hoVet@gmail.com', N'HorseVet')
INSERT [dbo].[Institution] ([id_inst], [address_inst], [city], [postcode], [inter_list], [phNumInst], [emailInst], [name_inst]) VALUES (6, N'Sienkiewicza 6', N'Sosnowiec', N'41-200    ', NULL, N'883657098 ', N'ereaVet@gmail.com', N'EreaVET')
INSERT [dbo].[Institution] ([id_inst], [address_inst], [city], [postcode], [inter_list], [phNumInst], [emailInst], [name_inst]) VALUES (7, N'Mickiewicza 20', N'Katowice', N'40-092    ', NULL, N'998546887 ', N'vetmin@gmail.com', N'VetMin')
SET IDENTITY_INSERT [dbo].[Institution] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (1, N'5dda782f-54da-4ad1-a8ca-99336a815ed2', N'Xandria', CAST(N'2018-03-09' AS Date), 28, N'Owczarek niemiecki', N'Samica', 2, N'kastrowana')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (2, N'5dda782f-54da-4ad1-a8ca-99336a815ed2', N'Temil', CAST(N'2020-01-10' AS Date), 4, N'Bengalski', N'Samiec', 1, N'brak')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (3, N'1a41d97d-828e-4642-960a-15ded7e697a0', N'Rea', CAST(N'2019-08-30' AS Date), 7, N'Szop pracz', N'Samiec', 16, N'kastrowany')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (4, N'1a41d97d-828e-4642-960a-15ded7e697a0', N'Roma', CAST(N'2019-11-15' AS Date), 1.4, N'Angor miniaturka', N'Samica', 4, N'brak')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (5, N'c6b6c733-3b99-4a7a-8418-3ae20af50fd8', N'Roksi', CAST(N'2019-12-07' AS Date), 0.12, N'Kameleon lamparci', N'Samica', 14, N'brak')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (6, N'5acfe14c-885e-4242-9885-2118acd40338', N'Temina', CAST(N'2019-10-03' AS Date), 0.025, N'Syjamski', N'Samica', 12, N'brak')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (7, N'1b269a84-39dd-4acf-8bca-03fd79a4d6df', N'Sara', CAST(N'2019-11-09' AS Date), 5, N'Bengalski', N'Samica', 1, N'kastrowany')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (8, N'bab04094-0af0-4905-a167-24f38521594e', N'Gregory', CAST(N'2019-06-20' AS Date), 0.14, N'Kameleon lamparci', N'Samiec', 14, N'brak')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (9, N'1a41d97d-828e-4642-960a-15ded7e697a0', N'Kubuś', CAST(N'2019-10-11' AS Date), 0.01, N'Harceński', N'Samiec', 17, N'brak')
INSERT [dbo].[Patient] ([id_patient], [id_owner], [name], [age], [weight], [breed], [sex], [id_genus], [sterilized_castration]) VALUES (10, N'1a41d97d-828e-4642-960a-15ded7e697a0', N'Gregoria', CAST(N'2019-09-05' AS Date), 28, N'Labrador retriever', N'Samica', 2, N'kastrowana')
SET IDENTITY_INSERT [dbo].[Patient] OFF
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (1, 1)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (2, 1)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (3, 1)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (4, 1)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (5, 1)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (9, 1)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (10, 1)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (1, 2)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (1, 3)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (2, 3)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (6, 4)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (7, 4)
INSERT [dbo].[PatientInstitution] ([id_patient], [id_inst]) VALUES (8, 4)
SET IDENTITY_INSERT [dbo].[Visit] ON 

INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (1, 1, CAST(N'2020-03-28T08:34:13.0349546' AS DateTime2), N'Brak chęci do zabawy, zmniejszone łaknienie, prawdopodobnie podwyższona temperatura.', N'Pies ma gorączkę (40 stopni) i jest nieco odwodniony. Podanie antybiotyku.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (2, 2, CAST(N'2020-03-28T08:42:40.6096325' AS DateTime2), N'Kot zaczepia pazurami o wszystko.', N'Obcinanie pazurków.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (3, 1, CAST(N'2020-03-28T09:08:44.7190366' AS DateTime2), N'Zaplanowany zabieg kastracji.', N'Wykonanie zabiegu. Stan pacjenta oceniam na dobry.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (4, 1, CAST(N'2020-03-28T09:10:36.2808940' AS DateTime2), N'Sprawdzenia stanu zdrowia po zabiegu. ', N'Zwierzę czuje się bardzo dobrze. Rana goi się dobrze. Nie widzę żadnych nieprawidłowości.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (5, 1, CAST(N'2020-03-28T09:57:25.6350554' AS DateTime2), N'Sprawdzenie stanu rany oraz wyciągnięcie szwów.', N'Ściągnięcie szwów. Po ranie zostało niewielkie krwawienie. Przepisanie maści do nacierania rany.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (6, 1, CAST(N'2020-03-28T09:59:54.9447808' AS DateTime2), N'Wizyta kontrolna.', N'Rana już nie krwawi.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (7, 3, CAST(N'2020-03-28T10:49:30.5508108' AS DateTime2), N'Właściciel znalazł zwierzę na zewnątrz i postanowił je przygarnąć. Chęć sprawdzenia stanu zdrowia i czy nie posiada już właściciela.', N'Zalecane odrobaczanie i kąpiel. Przypisanie tabletek na odrobaczenie.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (8, 3, CAST(N'2020-03-28T11:47:03.2544330' AS DateTime2), N'Odbiór zwierzęcia od właściciela w celu wykonania zabiegu.', N'Podania narkozy oraz wykonanie zabiegu kastracji.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (9, 3, CAST(N'2020-03-28T11:58:34.0484228' AS DateTime2), N'Wizyta kontrolna.', N'Zwierzę czuje się dobrze.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (10, 4, CAST(N'2020-03-28T12:01:05.4341250' AS DateTime2), N'Pielęgnacja.', N'Przycinanie sierści, obcinanie pazurków.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (11, 4, CAST(N'2020-03-28T12:06:35.5203391' AS DateTime2), N'Królik oczekuje potomstwa. Sprawdzenie stanu zdrowia.', N'Nie widzę żadnych nieprawidłowości. Zwierzę jest nieco odwodnione.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (12, 3, CAST(N'2020-03-29T00:52:12.7877504' AS DateTime2), N'Rutynowe szczepienie.', N'Podanie szczepionki przeciw wściekliźnie.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (13, 5, CAST(N'2020-03-29T16:11:41.1418424' AS DateTime2), N'Zwierzę ma zmniejszony apetyt, obserwowane są zmiany naskórka.', N'Kameleon ma awitaminozę. Zalecane podanie witaminy A.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (14, 6, CAST(N'2020-03-29T19:52:33.1519132' AS DateTime2), N'Zwierzę ma mniej energii, często leży nieruchomo.', N'Podejrzewam odwodnienie. Zalecam nacieranie futra wodą oraz zwiększenie podaży wody.', N'7163fcd7-2e42-4e34-8a9a-2d5a03ed7b0d')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (15, 7, CAST(N'2020-03-29T19:56:20.7556609' AS DateTime2), N'Pielęgnacja.', N'Przycinanie pazurów.', N'7163fcd7-2e42-4e34-8a9a-2d5a03ed7b0d')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (16, 8, CAST(N'2020-03-29T20:04:54.0617440' AS DateTime2), N'Zmiany na naskórku.', N'Podejrzewam grzybicę. Zalecam zmniejszenie wilgoci w terrarium.', N'7163fcd7-2e42-4e34-8a9a-2d5a03ed7b0d')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (17, 8, CAST(N'2020-03-29T20:08:47.1891562' AS DateTime2), N'Sprawdzenie stanu zdrowia.', N'Zwierzę ma mniej przebarwień na naskórku. ', N'7163fcd7-2e42-4e34-8a9a-2d5a03ed7b0d')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (18, 9, CAST(N'2020-03-29T20:19:31.1951460' AS DateTime2), N'Pacjent ma biegunki.', N'Zalecenia dotyczące diety. Gdy stan pacjenta nie poprawi się - ponowna wizyta.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (19, 9, CAST(N'2020-03-29T20:24:17.5331364' AS DateTime2), N'Sprawdzenie stanu zdrowia.', N'Właściciel zastosował się do zaleceń i stan pacjenta polepszył się. Polecam zwiększenie podaży wody.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (20, 2, CAST(N'2020-03-31T17:02:37.9780394' AS DateTime2), N'Zwierzę nie je od 3 dni, jest mniej aktywne..', N'Sprawdzenie temperatury. Kot ma zwiększoną temperaturę, podano antybiotyk. Umówiono wizytę za 2 dni.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (21, 10, CAST(N'2020-03-31T17:09:45.0552745' AS DateTime2), N'Zwierzę nie je od 3 dni, jest mniej aktywne.', N'Sprawdzenie temperatury. Pies ma gorączkę (40 st. Celsjusza), podano antybiotyk. Umówiono wizytę za 3 dni.', N'6bc5d7c4-36dc-42db-bf3a-bb2f76d056d5')
INSERT [dbo].[Visit] ([id_visit], [id_patient], [dateVisit], [purpose], [decrDisActions], [id_vet]) VALUES (22, 10, CAST(N'2020-03-31T17:12:16.2091770' AS DateTime2), N'Wizyta kontrolna.', N'Pacjent ma zwiększony apetyt, jest bardziej aktywny. Temperatura w normie.', N'4604a90a-89d0-4ffe-97de-bad12d1d3966')
SET IDENTITY_INSERT [dbo].[Visit] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 31.03.2020 19:58:24 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUsers_id_inst]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_id_inst] ON [dbo].[AspNetUsers]
(
	[id_inst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 31.03.2020 19:58:24 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Patient_id_genus]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_Patient_id_genus] ON [dbo].[Patient]
(
	[id_genus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Patient_id_owner]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_Patient_id_owner] ON [dbo].[Patient]
(
	[id_owner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PatientInstitution_id_inst]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_PatientInstitution_id_inst] ON [dbo].[PatientInstitution]
(
	[id_inst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Visit_id_patient]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_Visit_id_patient] ON [dbo].[Visit]
(
	[id_patient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Visit_id_vet]    Script Date: 31.03.2020 19:58:24 ******/
CREATE NONCLUSTERED INDEX [IX_Visit_id_vet] ON [dbo].[Visit]
(
	[id_vet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_Vet_Institution] FOREIGN KEY([id_inst])
REFERENCES [dbo].[Institution] ([id_inst])
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_Vet_Institution]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Genus] FOREIGN KEY([id_genus])
REFERENCES [dbo].[Genus] ([id_genus])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Genus]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Vet] FOREIGN KEY([id_owner])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Vet]
GO
ALTER TABLE [dbo].[PatientInstitution]  WITH CHECK ADD  CONSTRAINT [FK_PatientInstitution_Institution] FOREIGN KEY([id_inst])
REFERENCES [dbo].[Institution] ([id_inst])
GO
ALTER TABLE [dbo].[PatientInstitution] CHECK CONSTRAINT [FK_PatientInstitution_Institution]
GO
ALTER TABLE [dbo].[PatientInstitution]  WITH CHECK ADD  CONSTRAINT [FK_PatientInstitution_Patient] FOREIGN KEY([id_patient])
REFERENCES [dbo].[Patient] ([id_patient])
GO
ALTER TABLE [dbo].[PatientInstitution] CHECK CONSTRAINT [FK_PatientInstitution_Patient]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Patient] FOREIGN KEY([id_patient])
REFERENCES [dbo].[Patient] ([id_patient])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Patient]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Vet] FOREIGN KEY([id_vet])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Vet]

GO
ALTER DATABASE [VetSystemDatabase] SET  READ_WRITE 
GO
