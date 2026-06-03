USE [DVLD]
GO

/****** Object:  Table [dbo].[LicenseClasses]    Script Date: 6/3/2026 4:32:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LicenseClasses](
	[LicenseClassID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](50) NOT NULL,
	[ClassDescription] [nvarchar](500) NOT NULL,
	[MinimumAllowedAge] [tinyint] NOT NULL,
	[DefaultValidityLength] [tinyint] NOT NULL,
	[ClassFees] [smallmoney] NOT NULL,
 CONSTRAINT [PK_LicenseClasses] PRIMARY KEY CLUSTERED 
(
	[LicenseClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LicenseClasses] ADD  CONSTRAINT [DF_LicenseClasses_Age]  DEFAULT ((18)) FOR [MinimumAllowedAge]
GO

ALTER TABLE [dbo].[LicenseClasses] ADD  CONSTRAINT [DF_LicenseClasses_DefaultPeriodLength]  DEFAULT ((1)) FOR [DefaultValidityLength]
GO

ALTER TABLE [dbo].[LicenseClasses] ADD  CONSTRAINT [DF_LicenseClasses_ClassFees]  DEFAULT ((0)) FOR [ClassFees]
GO

ALTER TABLE [dbo].[LicenseClasses]  WITH CHECK ADD  CONSTRAINT [CK_LicenseClasses_ClassFeesLargerThanOrEqualZero] CHECK  (([ClassFees]>=(0)))
GO

ALTER TABLE [dbo].[LicenseClasses] CHECK CONSTRAINT [CK_LicenseClasses_ClassFeesLargerThanOrEqualZero]
GO

ALTER TABLE [dbo].[LicenseClasses]  WITH CHECK ADD  CONSTRAINT [CK_LicenseClasses_PositiveMinimumAllowedAge] CHECK  (([MinimumAllowedAge]>(0)))
GO

ALTER TABLE [dbo].[LicenseClasses] CHECK CONSTRAINT [CK_LicenseClasses_PositiveMinimumAllowedAge]
GO

ALTER TABLE [dbo].[LicenseClasses]  WITH CHECK ADD  CONSTRAINT [CK_LicenseClasses_PositiveValidityLength] CHECK  (([DefaultValidityLength]>(0)))
GO

ALTER TABLE [dbo].[LicenseClasses] CHECK CONSTRAINT [CK_LicenseClasses_PositiveValidityLength]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Minmum age allowed to apply for this license' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LicenseClasses', @level2type=N'COLUMN',@level2name=N'MinimumAllowedAge'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'How many years the licesnse will be valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LicenseClasses', @level2type=N'COLUMN',@level2name=N'DefaultValidityLength'
GO


