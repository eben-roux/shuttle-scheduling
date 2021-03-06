IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schedule]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Schedule](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](120) NOT NULL,
	[InboxWorkQueueUri] [varchar](130) NOT NULL,
	[CronExpression] [varchar](25) NOT NULL,
	[NextNotification] [datetime] NOT NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Schedule]') AND name = N'IX_Schedule')
CREATE NONCLUSTERED INDEX [IX_Schedule] ON [dbo].[Schedule]
(
	[Name] ASC,
	[InboxWorkQueueUri] ASC,
	[CronExpression] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
