/****** Object:  Database [hd_emenu]    Script Date: 2/14/2016 11:58:46 AM ******/
CREATE DATABASE [hd_emenu]
GO

/****** Object:  Table [dbo].[category]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_image] [nvarchar](50) NULL,
	[category_icon] [nvarchar](50) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[category_language]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category_language](
	[category_id] [int] NOT NULL,
	[language_id] [int] NOT NULL,
	[category_name] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[country]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[country](
	[country_id] [int] IDENTITY(1,1) NOT NULL,
	[country_name] [nvarchar](50) NOT NULL,
	[country_code] [nvarchar](5) NOT NULL,
	[country_is_active] [bit] NOT NULL,
 CONSTRAINT [PK_country_code] PRIMARY KEY CLUSTERED 
(
	[country_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[customer]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_first_name] [nvarchar](50) NOT NULL,
	[customer_last_name] [nvarchar](50) NOT NULL,
	[customer_email] [nvarchar](50) NOT NULL,
	[country_code_id] [int] NOT NULL,
	[customer_phone] [nvarchar](10) NOT NULL,
	[customer_gender] [nvarchar](50) NOT NULL,
	[customer_birthday] [date] NOT NULL,
	[customer_password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[language]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[language](
	[language_id] [int] IDENTITY(1,1) NOT NULL,
	[language_name] [nvarchar](50) NOT NULL,
	[language_short_name] [nvarchar](5) NOT NULL,
	[language_flag] [nvarchar](50) NOT NULL,
	[language_active] [bit] NOT NULL,
 CONSTRAINT [PK_language] PRIMARY KEY CLUSTERED 
(
	[language_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[order]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[table_id] [int] NOT NULL,
	[billing_number] [nvarchar](50) NOT NULL,
	[order_date_created] [datetime] NOT NULL,
	[order_is_verified] [bit] NULL,
	[order_is_completed] [bit] NOT NULL,
	[order_total] [float] NOT NULL,
	[order_discount_type] [int] NOT NULL,
	[order_discount] [float] NOT NULL,
	[order_tax] [float] NOT NULL,
	[order_grand_total] [float] NOT NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[order_details]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_details](
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_image] [nvarchar](50) NULL,
	[product_is_veg] [bit] NOT NULL,
	[product_is_active] [bit] NOT NULL,
	[product_price] [float] NOT NULL,
	[product_discount_type] [int] NOT NULL,
	[product_discount] [float] NOT NULL,
	[product_final_price] [float] NOT NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product_category]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_category](
	[product_id] [int] NOT NULL,
	[category_id] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product_language]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_language](
	[product_id] [int] NOT NULL,
	[language_id] [int] NOT NULL,
	[product_name] [nvarchar](50) NOT NULL,
	[product_description] [nvarchar](1000) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[table]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table](
	[table_id] [int] IDENTITY(1,1) NOT NULL,
	[table_number] [int] NOT NULL,
	[table_password] [nvarchar](50) NULL,
	[table_is_occupied] [bit] NOT NULL,
 CONSTRAINT [PK_table] PRIMARY KEY CLUSTERED 
(
	[table_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tax]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tax](
	[tax_id] [int] IDENTITY(1,1) NOT NULL,
	[tax_amount] [float] NOT NULL,
 CONSTRAINT [PK_tax] PRIMARY KEY CLUSTERED 
(
	[tax_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_categories]    Script Date: 2/14/2016 11:58:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT [dbo].[category] ON 

GO
INSERT [dbo].[category] ([category_id], [category_image], [category_icon]) VALUES (1, N'image_appetizers.png', N'icon_appetizers.png')
GO
INSERT [dbo].[category] ([category_id], [category_image], [category_icon]) VALUES (2, N'image_soups.png', N'icon_soups.png')
GO
SET IDENTITY_INSERT [dbo].[category] OFF
GO
INSERT [dbo].[category_language] ([category_id], [language_id], [category_name]) VALUES (1, 1, N'Appetizers')
GO
INSERT [dbo].[category_language] ([category_id], [language_id], [category_name]) VALUES (1, 2, N'Apéritifs')
GO
INSERT [dbo].[category_language] ([category_id], [language_id], [category_name]) VALUES (2, 1, N'Soups')
GO
INSERT [dbo].[category_language] ([category_id], [language_id], [category_name]) VALUES (2, 2, N'Soupes')
GO
SET IDENTITY_INSERT [dbo].[country] ON 

GO
INSERT [dbo].[country] ([country_id], [country_name], [country_code], [country_is_active]) VALUES (1, N'Canada', N'+1', 1)
GO
INSERT [dbo].[country] ([country_id], [country_name], [country_code], [country_is_active]) VALUES (2, N'India', N'+91', 0)
GO
SET IDENTITY_INSERT [dbo].[country] OFF
GO
SET IDENTITY_INSERT [dbo].[language] ON 

GO
INSERT [dbo].[language] ([language_id], [language_name], [language_short_name], [language_flag], [language_active]) VALUES (1, N'English', N'EN', N'flag_english.png', 1)
GO
INSERT [dbo].[language] ([language_id], [language_name], [language_short_name], [language_flag], [language_active]) VALUES (2, N'French', N'FR', N'flag_french.png', 0)
GO
SET IDENTITY_INSERT [dbo].[language] OFF
GO
SET IDENTITY_INSERT [dbo].[table] ON 

GO
INSERT [dbo].[table] ([table_id], [table_number], [table_password], [table_is_occupied]) VALUES (2, 1, N'1234', 0)
GO
INSERT [dbo].[table] ([table_id], [table_number], [table_password], [table_is_occupied]) VALUES (3, 2, N'1234', 1)
GO
SET IDENTITY_INSERT [dbo].[table] OFF
GO
ALTER TABLE [dbo].[customer]  WITH CHECK ADD  CONSTRAINT [FK_customer_country_code] FOREIGN KEY([country_code_id])
REFERENCES [dbo].[country] ([country_id])
GO
ALTER TABLE [dbo].[customer] CHECK CONSTRAINT [FK_customer_country_code]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[customer] ([customer_id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_customer]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_table] FOREIGN KEY([table_id])
REFERENCES [dbo].[table] ([table_id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_table]
GO
ALTER TABLE [dbo].[order_details]  WITH CHECK ADD  CONSTRAINT [FK_order_details_order] FOREIGN KEY([order_id])
REFERENCES [dbo].[order] ([order_id])
GO
ALTER TABLE [dbo].[order_details] CHECK CONSTRAINT [FK_order_details_order]
GO
ALTER TABLE [dbo].[order_details]  WITH CHECK ADD  CONSTRAINT [FK_order_details_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[order_details] CHECK CONSTRAINT [FK_order_details_product]
GO
ALTER TABLE [dbo].[product_category]  WITH CHECK ADD  CONSTRAINT [FK_product_category_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([category_id])
GO
ALTER TABLE [dbo].[product_category] CHECK CONSTRAINT [FK_product_category_category]
GO
ALTER TABLE [dbo].[product_category]  WITH CHECK ADD  CONSTRAINT [FK_product_category_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[product_category] CHECK CONSTRAINT [FK_product_category_product]
GO
ALTER DATABASE [hd_emenu] SET  READ_WRITE 
GO
