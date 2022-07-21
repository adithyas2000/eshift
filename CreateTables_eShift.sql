CREATE TABLE [dbo].[admin_items](
	[itemCode] [int] NOT NULL,
	[itemName] [varchar](50) NOT NULL,
	[unitCost] [float] NOT NULL,
	[imgUrl] [nvarchar](50) NULL,
	[state] [nchar](10) NOT NULL
)

CREATE TABLE [dbo].[admin_table](
	[email] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[fname] [varchar](50) NULL,
 CONSTRAINT [PK_admin_table] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
)

CREATE TABLE [dbo].[city_table](
	[cityName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_city_table] PRIMARY KEY CLUSTERED 
(
	[cityName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
)

CREATE TABLE [dbo].[job_table](
	[jobid] [int] NOT NULL,
	[usermail] [varchar](50) NOT NULL,
	[fromLoc] [nvarchar](50) NOT NULL,
	[toLoc] [nvarchar](50) NOT NULL,
	[date] [varchar](50) NOT NULL,
	[status] [varchar](50) NULL
)

CREATE TABLE [dbo].[user_table](
	[email] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
 CONSTRAINT [PK_user_table] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
)

