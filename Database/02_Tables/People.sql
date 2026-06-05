USE [DVLDSystemDb]
GO

/****** Object:  Table [dbo].[People]    Script Date: 6/4/2026 4:20:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[NationalNo] [nvarchar](20) CHECK (NationalNo LIKE REPLICATE('[0-9]', 14)) UNIQUE NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[SecondName] [nvarchar](20) NOT NULL,
	[ThirdName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Gender] [tinyint] NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[Phone] [nvarchar](20) CHECK (Phone LIKE '01[0125][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') UNIQUE NOT NULL,
	[Email] [nvarchar](50) NULL,
	[NationalityCountryID] [int] NOT NULL,
	[ImagePath] [nvarchar](250) NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_NationalNo] UNIQUE NONCLUSTERED 
(
	[NationalNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Phone] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[People] ADD  CONSTRAINT [DF_People_Gendor]  DEFAULT ((0)) FOR [Gender]
GO

ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Countries1] FOREIGN KEY([NationalityCountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO

ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Countries1]
GO

ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [CK_People_Email] CHECK  (([Email] like '%@%.%'))
GO

ALTER TABLE [dbo].[People] CHECK CONSTRAINT [CK_People_Email]
GO

ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [CK_People_ImagePath] CHECK  (([ImagePath] like '%.jpg' OR [ImagePath] like '%.jpeg' OR [ImagePath] like '%.png' OR [ImagePath] like '%.gif'))
GO

ALTER TABLE [dbo].[People] CHECK CONSTRAINT [CK_People_ImagePath]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 Male , 1 Femail , 2 Other' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'People', @level2type=N'COLUMN',@level2name=N'Gender'
GO


