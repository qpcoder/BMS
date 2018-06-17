USE qpBMS
GO

--TABLE Countries
SET IDENTITY_INSERT dbo.Countries ON 
GO	
INSERT INTO dbo.Countries( ID ,Code ,Name ,[Description] ,DateCreated ,DateUpdated ,[Status])
VALUES  ( 1 , -- ID - uniqueidentifier
          N'84' , -- Code - nvarchar(max)
          N'Việt Nam' , -- Name - nvarchar(max)
          N'Cộng hòa Xã hội Chủ nghĩa Việt Nam' , -- Description - nvarchar(max)
          GETDATE() , -- DateCreated - datetime
          GETDATE() , -- DateUpdated - datetime
          1  -- Status - bit
        )
GO
SET IDENTITY_INSERT dbo.Countries OFF
GO	

--TABLE Provinces
SET IDENTITY_INSERT dbo.Provinces ON	
GO 
INSERT INTO dbo.Provinces( ID ,CountryID ,Code ,Name ,[Description] ,DateCreated ,DateUpdated ,[Status])
VALUES  ( 1 , -- ID - uniqueidentifier
          1 , -- CountryID - uniqueidentifier
          N'51' , -- Code - nvarchar(max)
          N'An Giang' , -- Name - nvarchar(max)
          N'An Giang' , -- Description - nvarchar(max)
          GETDATE() , -- DateCreated - datetime
          GETDATE() , -- DateUpdated - datetime
          1  -- Status - bit
        ),
		(2,1,'52',N'Bà Rịa - Vũng Tàu','',GETDATE(),GETDATE(),1),
		(3,1,'11',N'Bắc Cạn','',GETDATE(),GETDATE(),1),
		(4,1,'18',N'Bắc Giang','',GETDATE(),GETDATE(),1),
		(5,1,'60',N'Bạc Liêu','',GETDATE(),GETDATE(),1),
		(6,1,'19',N'Bắc Ninh','',GETDATE(),GETDATE(),1),
		(7,1,'56',N'Bến Tre','',GETDATE(),GETDATE(),1),
		(8,1,'37',N'Bình Định','',GETDATE(),GETDATE(),1),
		(9,1,'44',N'Bình Dương','',GETDATE(),GETDATE(),1),
		(10,1,'43',N'Bình Phước','',GETDATE(),GETDATE(),1),
		(11,1,'47',N'Bình Thuận','',GETDATE(),GETDATE(),1),
		(12,1,'61',N'Cà Mau','',GETDATE(),GETDATE(),1),
		(13,1,'06',N'Cao Bằng','',GETDATE(),GETDATE(),1),
		(14,1,'40',N'Đắk Lắk','',GETDATE(),GETDATE(),1),
		(15,1,'63',N'Đắk Nông','',GETDATE(),GETDATE(),1),
		(16,1,'62',N'Điện Biên','',GETDATE(),GETDATE(),1),
		(17,1,'48',N'Đồng Nai','',GETDATE(),GETDATE(),1),
		(18,1,'50',N'Đồng Tháp','',GETDATE(),GETDATE(),1),
		(19,1,'38',N'Gia Lai','',GETDATE(),GETDATE(),1),
		(20,1,'05',N'Hà Giang','',GETDATE(),GETDATE(),1),
		(21,1,'24',N'Hà Nam','',GETDATE(),GETDATE(),1),
		(22,1,'30',N'Hà Tĩnh','',GETDATE(),GETDATE(),1),
		(23,1,'21',N'Hải Dương','',GETDATE(),GETDATE(),1),
		(24,1,'64',N'Hậu Giang','',GETDATE(),GETDATE(),1),
		(25,1,'23',N'Hoà Bình','',GETDATE(),GETDATE(),1),
		(26,1,'22',N'Hưng Yên','',GETDATE(),GETDATE(),1),
		(27,1,'41',N'Khánh Hoà','',GETDATE(),GETDATE(),1),
		(28,1,'54',N'Kiên Giang','',GETDATE(),GETDATE(),1),
		(29,1,'36',N'Kon Tum','',GETDATE(),GETDATE(),1),
		(30,1,'07',N'Lai Châu','',GETDATE(),GETDATE(),1),
		(31,1,'42',N'Lâm Đồng','',GETDATE(),GETDATE(),1),
		(32,1,'10',N'Lạng Sơn','',GETDATE(),GETDATE(),1),
		(33,1,'08',N'Lào Cai','',GETDATE(),GETDATE(),1),
		(34,1,'49',N'Long An','',GETDATE(),GETDATE(),1),
		(35,1,'25',N'Nam Định','',GETDATE(),GETDATE(),1),
		(36,1,'29',N'Nghệ An','',GETDATE(),GETDATE(),1),
		(37,1,'27',N'Ninh Bình','',GETDATE(),GETDATE(),1),
		(38,1,'45',N'Ninh Thuận','',GETDATE(),GETDATE(),1),
		(39,1,'15',N'Phú Thọ','',GETDATE(),GETDATE(),1),
		(40,1,'39',N'Phú Yên','',GETDATE(),GETDATE(),1),
		(41,1,'31',N'Quảng Bình','',GETDATE(),GETDATE(),1),
		(42,1,'34',N'Quảng Nam','',GETDATE(),GETDATE(),1),
		(43,1,'35',N'Quảng Ngãi','',GETDATE(),GETDATE(),1),
		(44,1,'17',N'Quảng Ninh','',GETDATE(),GETDATE(),1),
		(45,1,'32',N'Quảng Trị','',GETDATE(),GETDATE(),1),
		(46,1,'59',N'Sóc Trăng','',GETDATE(),GETDATE(),1),
		(47,1,'14',N'Sơn La','',GETDATE(),GETDATE(),1),
		(48,1,'46',N'Tây Ninh','',GETDATE(),GETDATE(),1),
		(49,1,'26',N'Thái Bình','',GETDATE(),GETDATE(),1),
		(50,1,'12',N'Thái Nguyên','',GETDATE(),GETDATE(),1),
		(51,1,'28',N'Thanh Hoá','',GETDATE(),GETDATE(),1),
		(52,1,'53',N'Tiền Giang','',GETDATE(),GETDATE(),1),
		(53,1,'55',N'Tp. Cần Thơ','',GETDATE(),GETDATE(),1),
		(54,1,'04',N'Tp. Đà Nẵng','',GETDATE(),GETDATE(),1),
		(55,1,'01',N'Tp. Hà Nội','',GETDATE(),GETDATE(),1),
		(56,1,'03',N'Tp. Hải Phòng','',GETDATE(),GETDATE(),1),
		(57,1,'02',N'Tp. Hồ Chí Minh','',GETDATE(),GETDATE(),1),
		(58,1,'58',N'Trà Vinh','',GETDATE(),GETDATE(),1),
		(59,1,'33',N'Thừa Thiên Huế','',GETDATE(),GETDATE(),1),
		(60,1,'09',N'Tuyên Quang','',GETDATE(),GETDATE(),1),
		(61,1,'57',N'Vĩnh Long','',GETDATE(),GETDATE(),1),
		(62,1,'16',N'Vĩnh Phúc','',GETDATE(),GETDATE(),1),
		(63,1,'13',N'Yên Bái','',GETDATE(),GETDATE(),1)
GO
SET IDENTITY_INSERT dbo.Provinces OFF
GO 

--TABLE Districts
SET IDENTITY_INSERT dbo.Districts ON 
GO 
INSERT INTO dbo.Districts( ID ,Name ,Code ,[Description] ,ProvinceID ,DateCreated ,DateUpdated ,[Status])
VALUES  ( 1 , -- ID - uniqueidentifier
          N'Huyện A Lưới' , -- Name - nvarchar(max)
          N'09' , -- Code - nvarchar(max)
          N'' , -- Description - nvarchar(max)
          59 , -- ProvinceID - uniqueidentifier
          GETDATE() , -- DateCreated - datetime
          GETDATE() , -- DateUpdated - datetime
          1  -- Status - bit
        ),
		(24,N'Huyện Hóc Môn','22','',57,GETDATE(),GETDATE(),1),
		(2,N'Huyện Hương Trà','04','',59,GETDATE(),GETDATE(),1),
		(3,N'Huyện Nam Đông','08','',59,GETDATE(),GETDATE(),1),
		(4,N'Huyện Nhà Bè','23','',57,GETDATE(),GETDATE(),1),
		(5,N'Quận 1','01','',57,GETDATE(),GETDATE(),1),
		(6,N'Quận 10','10','',57,GETDATE(),GETDATE(),1),
		(7,N'Quận 11','11','',57,GETDATE(),GETDATE(),1),
		(8,N'Quận 12','12','',57,GETDATE(),GETDATE(),1),
		(9,N'Quận 2','02','',57,GETDATE(),GETDATE(),1),
		(10,N'Quận 3','03','',57,GETDATE(),GETDATE(),1),
		(11,N'Quận 4','04','',57,GETDATE(),GETDATE(),1),
		(12,N'Quận 5','05','',57,GETDATE(),GETDATE(),1),
		(13,N'Quận 6','06','',57,GETDATE(),GETDATE(),1),
		(14,N'Quận 7','07','',57,GETDATE(),GETDATE(),1),
		(15,N'Quận 8','08','',57,GETDATE(),GETDATE(),1),
		(16,N'Quận 9','09','',57,GETDATE(),GETDATE(),1),
		(17,N'Quận Bình Tân','19','',57,GETDATE(),GETDATE(),1),
		(18,N'Quận Bình Thạnh','16','',57,GETDATE(),GETDATE(),1),
		(19,N'Quận Gò Vấp','13','',57,GETDATE(),GETDATE(),1),
		(20,N'Quận Phú Nhuận','17','',57,GETDATE(),GETDATE(),1),
		(21,N'Quận Tân Bình','14','',57,GETDATE(),GETDATE(),1),
		(22,N'Quận Tân Phú','15','',57,GETDATE(),GETDATE(),1),
		(23,N'Quận Thủ Đức','18','',57,GETDATE(),GETDATE(),1)
GO
SET IDENTITY_INSERT dbo.Districts OFF
GO

--TABLE Roles
SET IDENTITY_INSERT dbo.Roles ON 
GO 
INSERT INTO dbo.Roles( ID, Name, Code, [Description], [Status] )
VALUES  ( 1, -- ID - int
          N'Administrator', -- Name - nvarchar(max)
          N'admin', -- Code - nvarchar(max)
          N'Quản trị viên', -- Description - nvarchar(max)
          1  -- Status - bit
          )
GO 
SET IDENTITY_INSERT dbo.Roles OFF
GO

--TABLE Accounts
--SET IDENTITY_INSERT Accounts OFF
--GO
INSERT INTO dbo.Accounts
        ( ID ,UserName ,[Password] ,FirstName ,MiddleName ,LastName ,NickName ,DisplayNamePublic ,Gender ,GraderID ,
          MSSV ,Specialized ,GraduationYear ,BirthDay ,[Address] ,Email ,Phone ,Website ,FaceBook ,Twitter ,Zalo ,Youtube ,
		  Evernote ,GooglePlus ,Linkedin ,Instagram ,Flickr ,Permalink ,DateCreated ,DateUpdated ,IsStudent ,RoleID ,
		  IsActivitied ,PostCount ,CommentCount ,[Status])
VALUES  ( 'a7165be2-f0e8-4f28-84e4-617f960cc917' , -- ID - uniqueidentifier
          N'admin' , -- UserName - nvarchar(max)
          N'admin' , -- Password - nvarchar(max)
          N'Quý' , -- FirstName - nvarchar(max)
          N'Hữu' , -- MiddleName - nvarchar(max)
          N'Nguyễn' , -- LastName - nvarchar(max)
          N'qpCoders' , -- NickName - nvarchar(max)
          N'Nguyễn Quý' , -- DisplayNamePublic - nvarchar(max)
          N'Male' , -- Gender - nvarchar(max)
          NULL , -- GraderID - uniqueidentifier
          N'1451120132' , -- MSSV - nvarchar(max)
          N'Công nghệ phần mềm' , -- Specialized - nvarchar(max)
          GETDATE() , -- GraduationYear - datetime
          GETDATE() , -- BirthDay - datetime
          N'600/1 Quang Trung, P.11, ' , -- Address - nvarchar(max)
          N'qpcoders@gmail.com' , -- Email - nvarchar(max)
          N'0974691005' , -- Phone - nvarchar(max)
          N'www.qpcoders.com' , -- Website - nvarchar(max)
          N'nguyen.quy.0710' , -- FaceBook - nvarchar(max)
          N'dev_nguyenquy' , -- Twitter - nvarchar(max)
          N'0974691005' , -- Zalo - nvarchar(max)
          N'/c/devnguyenquy' , -- Youtube - nvarchar(max)
          N'' , -- Evernote - nvarchar(max)
          N'+devnguyenquy' , -- GooglePlus - nvarchar(max)
          N'' , -- Linkedin - nvarchar(max)
          N'' , -- Instagram - nvarchar(max)
          N'' , -- Flickr - nvarchar(max)
          N'' , -- Permalink - nvarchar(max)
          GETDATE() , -- DateCreated - datetime
          GETDATE() , -- DateUpdated - datetime
          1 , -- IsStudent - bit
          1 , -- RoleID - uniqueidentifier
          NULL , -- IsActivitied - bit
          0 , -- PostCount - int
          0 , -- CommentCount - int
          1  -- Status - bit
        )
GO
--SET IDENTITY_INSERT Accounts OFF
--GO