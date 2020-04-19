 -- [1] 테이블: 비디오 테이블: 강좌에 대한 리스트 제공
CREATE TABLE [dbo].[Videos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    
    [Title] NVARCHAR(255) NOT NULL,      -- 제목
    [Url] NVARCHAR(MAX) NULL,            -- URL
    [Name] NVARCHAR(50) NULL,            -- 이름
    [Company] NVARCHAR(255) NULL,        -- 회사
	--[Created] DATETIMEOFFSET 
	--	Default(SysDateTimeOffset() AT TIME ZONE 'Korea Standard Time'), 
    [CreatedBy] NVARCHAR(255) NULL,        -- 등록자
    [Created] DateTime Default(GetDate()),     --생성일
    [ModifiedBy] NVARCHAR(255) NULL,        -- 수정자
    [Modified] DateTime Null,     --수정일
)
Go
