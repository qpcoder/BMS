USE qpBMS
GO

--TABLE Countries
INSERT INTO dbo.Countries( ID ,Code ,Name ,[Description] ,DateCreated ,DateUpdated ,[Status])
VALUES  ( '1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f' , -- ID - uniqueidentifier
          N'VN' , -- Code - nvarchar(max)
          N'Viet Name' , -- Name - nvarchar(max)
          N'Cộng hòa Xã hội Chủ nghĩa Việt Nam' , -- Description - nvarchar(max)
          GETDATE() , -- DateCreated - datetime
          GETDATE() , -- DateUpdated - datetime
          1  -- Status - bit
        )
GO

--TABLE Provinces
INSERT INTO dbo.Provinces( ID ,CountryID ,Code ,Name ,[Description] ,DateCreated ,DateUpdated ,[Status])
VALUES  ( 'dc1321b2-c376-4a68-a50a-f9a8471ca407' , -- ID - uniqueidentifier
          '1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f' , -- CountryID - uniqueidentifier
          N'AG' , -- Code - nvarchar(max)
          N'An Giang' , -- Name - nvarchar(max)
          N'An Giang' , -- Description - nvarchar(max)
          GETDATE() , -- DateCreated - datetime
          GETDATE() , -- DateUpdated - datetime
          1  -- Status - bit
        ),
		('a7aa2f91-6fae-4e87-b8de-b3df699d4e2d','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bà Rịa - Vũng Tàu','',GETDATE(),GETDATE(),1),
		('e893a2ce-72c5-4e5c-894e-5175a636f063','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bắc Cạn','',GETDATE(),GETDATE(),1),
		('1a6df553-00b0-4d21-899e-13aff8f168bb','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bắc Giang','',GETDATE(),GETDATE(),1),
		('88d15254-23ec-44a3-a4f6-00435d780ebd','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bạc Liêu','',GETDATE(),GETDATE(),1),
		('4e89e604-fb8a-4bfb-b87f-2006f3fa711a','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bắc Ninh','',GETDATE(),GETDATE(),1),
		('decbc2a1-8923-4bf2-a973-b1e66c4eaeea','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bến Tre','',GETDATE(),GETDATE(),1),
		('3d54cb36-5726-4426-ae80-8bdcf8b0b351','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bình Định','',GETDATE(),GETDATE(),1),
		('a4b27a16-7705-4f2f-b3cc-7df76acbb872','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bình Dương','',GETDATE(),GETDATE(),1),
		('3c20c65c-5739-46f4-b4c6-e3b0dd7cbd4d','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bình Phước','',GETDATE(),GETDATE(),1),
		('6cc1bf4f-8fd2-4c00-b839-3ee2a1feb09e','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Bình Thuận','',GETDATE(),GETDATE(),1),
		('f9c54467-4256-477d-bbd5-4a221e093e88','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Cà Mau','',GETDATE(),GETDATE(),1),
		('2ea6f43d-fb15-4e09-af1c-a64b75a93f3e','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Cao Bằng','',GETDATE(),GETDATE(),1),
		('36935b8b-4f74-4dde-ae22-5b4f4ae6cc69','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Đắk Lắk','',GETDATE(),GETDATE(),1),
		('ad2e3f90-4947-4d50-a1f2-667359654df8','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Đắk Nông','',GETDATE(),GETDATE(),1),
		('ae0d2c6c-b6b2-4273-b906-c0653be4bf47','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Điện Biên','',GETDATE(),GETDATE(),1),
		('34395434-c83a-4ac5-9d45-21034c5ee3c2','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Đồng Nai','',GETDATE(),GETDATE(),1),
		('fbe7fa6c-1833-4e5c-9f42-e2a73af3c47d','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Đồng Tháp','',GETDATE(),GETDATE(),1),
		('a2f3a1f9-476c-4725-94e9-944f49de3d24','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Gia Lai','',GETDATE(),GETDATE(),1),
		('078ec50d-58ea-44a7-8168-db05920d2d58','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Hà Giang','',GETDATE(),GETDATE(),1),
		('1789d58d-8f46-43c8-b7e3-4697e5f04429','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Hà Nam','',GETDATE(),GETDATE(),1),
		('3b426a43-2200-4319-86a0-2083c5e62652','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Hà Tĩnh','',GETDATE(),GETDATE(),1),
		('73e90974-923d-4d02-a008-a1221d5322d0','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Hải Dương','',GETDATE(),GETDATE(),1),
		('f5204cd9-c03b-4f6d-b494-7c6c65e6fb84','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Hậu Giang','',GETDATE(),GETDATE(),1),
		('caba847e-bf08-4561-9b5d-39230b4284c8','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Hoà Bình','',GETDATE(),GETDATE(),1),
		('68d9522a-797d-45c4-90c0-8e2ad1a15701','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Hưng Yên','',GETDATE(),GETDATE(),1),
		('9c1749ce-3ded-4f92-9b9a-fb1359692ec9','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Khánh Hoà','',GETDATE(),GETDATE(),1),
		('657ba897-41d9-4f45-ad51-46e11aba8148','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Kiên Giang','',GETDATE(),GETDATE(),1),
		('474f00a6-4bc2-4c74-ac77-5e5a1c3a5400','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Kon Tum','',GETDATE(),GETDATE(),1),
		('adbe8a09-9f7d-4d35-b1b6-a96203750765','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Lai Châu','',GETDATE(),GETDATE(),1),
		('88ecc702-03e5-4b91-b3db-0c31c032dfa9','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Lâm Đồng','',GETDATE(),GETDATE(),1),
		('44ea7d74-24ea-4f2d-b042-da8ac105280b','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Lạng Sơn','',GETDATE(),GETDATE(),1),
		('a57a12b4-9b7f-4b73-a4a6-bc3c816b4293','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Lào Cai','',GETDATE(),GETDATE(),1),
		('644b0d92-6a3f-45d4-80bc-cdd6b983e4d8','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Long An','',GETDATE(),GETDATE(),1),
		('749434ec-7537-441d-a698-5c83dcce8eb7','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Nam Định','',GETDATE(),GETDATE(),1),
		('d89ae97f-43c8-44f1-9adf-766f11204920','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Nghệ An','',GETDATE(),GETDATE(),1),
		('001092d8-1b3b-461b-a971-af1cc4b9a3fa','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Ninh Bình','',GETDATE(),GETDATE(),1),
		('56980340-2fdb-42b0-8666-5027291e3512','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Ninh Thuận','',GETDATE(),GETDATE(),1),
		('8bbceb33-26fc-4304-9e4c-606b0b4d980e','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Phú Thọ','',GETDATE(),GETDATE(),1),
		('9b0d6fde-6224-4f18-b25f-4feb272e8f45','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Phú Yên','',GETDATE(),GETDATE(),1),
		('45301a82-ad3a-4b6b-af1b-a2cf0ae11cb4','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Quảng Bình','',GETDATE(),GETDATE(),1),
		('d792c43f-735b-46de-b884-c994f686329e','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Quảng Nam','',GETDATE(),GETDATE(),1),
		('afb83363-7812-4b0b-92f0-16ed3da0e3d8','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Quảng Ngãi','',GETDATE(),GETDATE(),1),
		('795995d7-830a-4c30-bb45-7707da8ec5bc','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Quảng Ninh','',GETDATE(),GETDATE(),1),
		('3a64d50f-e34c-442f-b04a-538eddc985ed','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Quảng Trị','',GETDATE(),GETDATE(),1),
		('1ad98d6a-6620-4ee3-8613-6c258f8ae9ae','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Sóc Trăng','',GETDATE(),GETDATE(),1),
		('f818d3e2-1def-461c-bfed-709c73510e84','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Sơn La','',GETDATE(),GETDATE(),1),
		('336a32f1-01dc-4b61-bb79-38b77521a638','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Tây Ninh','',GETDATE(),GETDATE(),1),
		('7ccb9394-613a-4ca7-a7c2-dd423c86527d','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Thái Bình','',GETDATE(),GETDATE(),1),
		('934df7d5-0432-4cf6-a116-89aa2f5bc74a','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Thái Nguyên','',GETDATE(),GETDATE(),1),
		('0c922bb7-caa3-4d69-988d-90a5df6e6f35','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Thanh Hoá','',GETDATE(),GETDATE(),1),
		('7508639b-141b-44e7-8cdc-a1ae5e01a44f','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Tiền Giang','',GETDATE(),GETDATE(),1),
		('0905b9e9-da93-4648-b162-e01ca2d19bf3','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Tp. Cần Thơ','',GETDATE(),GETDATE(),1),
		('9926f340-184b-4de6-9a42-b058e03e86dc','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Tp. Đà Nẵng','',GETDATE(),GETDATE(),1),
		('27229aa3-d21c-4018-8fb6-41153ea17940','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Tp. Hà Nội','',GETDATE(),GETDATE(),1),
		('53c974f9-4ec7-40a2-8d45-ca09af5ab650','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Tp. Hải Phòng','',GETDATE(),GETDATE(),1),
		('8a7e903e-220d-4d6e-8de1-5e9545141440','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Tp. Hồ Chí Minh','',GETDATE(),GETDATE(),1),
		('bbf50672-4406-41e9-831e-f93d37630dc7','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Trà Vinh','',GETDATE(),GETDATE(),1),
		('7ad6a056-28d4-4d38-8ba8-271a6132d0c5','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','TT-Huế','',GETDATE(),GETDATE(),1),
		('c4734736-fed8-45c7-a69c-569051208b50','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Tuyên Quang','',GETDATE(),GETDATE(),1),
		('92a95fd2-863f-4974-9f0c-d9f89e410bcc','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Vĩnh Long','',GETDATE(),GETDATE(),1),
		('f9fd7a47-9654-4b17-9394-6d584a7ef95f','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Vĩnh Phúc','',GETDATE(),GETDATE(),1),
		('1c65472d-4e3b-42dc-bcf8-90b51972fd46','1f7a0fe9-f5ff-48ef-a9dc-8f2a5f66f78f','','Yên Bái','',GETDATE(),GETDATE(),1)
GO

--TABLE Districts
INSERT INTO dbo.Districts( ID ,Name ,Code ,[Description] ,ProvinceID ,DateCreated ,DateUpdated ,[Status])
VALUES  ( '6846ca1b-d69d-4cd3-a097-7160ee7cd6a7' , -- ID - uniqueidentifier
          N'Huyện A Lưới' , -- Name - nvarchar(max)
          N'' , -- Code - nvarchar(max)
          N'' , -- Description - nvarchar(max)
          '8a7e903e-220d-4d6e-8de1-5e9545141440' , -- ProvinceID - uniqueidentifier
          GETDATE() , -- DateCreated - datetime
          GETDATE() , -- DateUpdated - datetime
          1  -- Status - bit
        ),
		('d6713b7f-ffbe-46c8-a165-415f30e3c832','Huyện Hóc Môn','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('8d1e0b90-054f-4965-b182-6181d7e63eb5','Huyện Hương Trà','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('aafb7555-540a-4295-a285-76d406120655','Huyện Nam Đông','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('1d667591-852d-4d48-95b0-b9e71cdace62','Huyện Nhà Bè','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('90173235-dfc9-464e-ba10-79432ba776a9','Quận 1','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('01cb0426-0a0d-476b-aa99-2cf6733348ca','Quận 10','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('2cb9f1e7-d651-4ba4-b6ad-520519c2038c','Quận 11','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('86a6a8a5-ca79-4130-8a2e-1787e487d4c1','Quận 12','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('10e68499-0758-4cfb-a174-5bf490bc3f16','Quận 2','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('64c21033-bcc4-416e-b6cd-99df5945d563','Quận 3','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('5a884109-b312-4c65-b1fc-3cc63b2c8e07','Quận 4','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('868d1014-0740-438f-8b37-8c7b5581c141','Quận 5','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('f76a6597-b864-476e-92a8-4c7cbde5286f','Quận 6','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('6da35f69-e348-402a-b4da-8c8a2d9d576e','Quận 7','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('0b47adb9-ef7a-4a32-98a6-39fdcaccacc5','Quận 8','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('1fb6e1df-e612-407f-b3ef-3f311f07761c','Quận 9','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('e8c30589-9eb5-4a27-b565-5ae117633afe','Quận Bình Tân','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('f73a8c2f-22e8-444e-ae7c-f312c611caec','Quận Bình Thạnh','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('8bf18ed8-f957-4f20-afc5-9b6c988fe186','Quận Gò Vấp','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('9b99b2ef-77d4-4b82-95b9-c2d01741e1ad','Quận Phú Nhuận','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('54d534bb-0c99-4fc2-874a-f5e59b6f5da0','Quận Tân Bình','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('e9a1e650-73d7-4016-91d0-553172e5ffdf','Quận Tân Phú','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1),
		('cfe5ebef-8986-4b99-bd8b-868d32472a16','Quận Thủ Đức','','','8a7e903e-220d-4d6e-8de1-5e9545141440',GETDATE(),GETDATE(),1)
GO

