-- 비디오 테이블
CREATE TABLE [dbo].[Videos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Created] DATETIMEOFFSET 
		Default(SysDateTimeOffset() AT TIME ZONE 'Korea Standard Time'), 
    [Title] NVARCHAR(255) NOT NULL,      -- 제목
    [Url] NVARCHAR(MAX) NULL,            -- URL
    [Name] NVARCHAR(50) NULL,            -- 이름
    [Company] NVARCHAR(255) NULL,        -- 회사
	 
)
Go
