 -- [1] 테이블: 비디오 테이블: 강좌에 대한 리스트 제공
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
