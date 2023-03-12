CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- Food Category
-- Account
-- Bill
-- Bill Info

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name Nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên',
	status	NVARCHAR(100) NOT NULL DEFAULT N'Trống',	--trống | Có người
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name Nvarchar(100) NOT NULL DEFAULT N'Chưa dặt tên',
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name Nvarchar(100) NOT NULL DEFAULT N'Chưa dặt tên',
	idCategory	INT NOT NULL,
	price FLOAT NOT NULL,

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckin	DATE NOT NULL DEFAULT GETDATE(),
	DateCheckout	DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 1 : đã thanh toán | 0 : chưa thanh toán
	Discount INT ,
	TotalPrice FLOAT
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

CREATE TABLE Account
(	
	Username NVARCHAR(100) PRIMARY KEY,
	Displayname NVARCHAR(100) NOT NULL DEFAULT N'Chưa dặt tên',
	Password NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0
)
GO

CREATE TABLE NV
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	phone CHAR(20),
)
GO
DELETE dbo.Account
INSERT INTO Account (Username, Displayname, Password, Type) VALUES (N'CongBang', N'Congbang', N'1', 1)
GO
INSERT INTO Account (Username, Displayname, Password, Type) VALUES (N'Admin', N'Admin', N'1', 1)
GO

UPDATE dbo.Bill SET Discount = 0
GO

--DỮ LIỆU FOODCATEGORY
INSERT dbo.FoodCategory(name) VALUES (N'Café')

INSERT dbo.FoodCategory(name) VALUES (N'Nước Ngọt')

INSERT dbo.FoodCategory(name) VALUES (N'Bánh Ngọt')

INSERT dbo.FoodCategory(name) VALUES (N'Sinh Tố')

INSERT dbo.FoodCategory(name) VALUES (N'Trà Sữa');
GO
--DỮ LIỆU FOOD
INSERT dbo.Food(name, idCategory, price ) VALUES (N'Cafe Đá', 1, 10000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'Cafe Sữa Đá', 1, 15000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'sting', 2, 10000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'7Up', 2, 10000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'Snack', 3, 10000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'Bông Lan Trứng Muối', 3, 25000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'Sinh tố dâu', 4, 20000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'Sinh tố xoài', 4, 20000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'Trà sữa truyền thống', 5, 20000)

INSERT dbo.Food(name, idCategory, price ) VALUES (N'Trà sữa thái xanh', 5, 30000)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

CREATE PROC USP_Login
@userName Nvarchar(100), 
@passWord Nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

DECLARE @i INT = 1
WHILE @i <= 20
BEGIN
	INSERT dbo.TableFood (name) VALUES (N'Bàn ' + CAST (@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO


/****** Object:  StoredProcedure [dbo].[USP_GetTableList] ******/
ALTER PROC USP_GetTableList
AS 
SELECT * FROM dbo.TableFood WHERE ID != 21
GO

-- Tạo Procedure 
/****** Object:  StoredProcedure [dbo].[USP_InsertBill] ******/
CREATE PROC USP_InsertBill
@idTable INT
AS 
BEGIN
	INSERT dbo.Bill(DateCheckin, DateCheckout, idTable, status, discount) VALUES (GETDATE(), NULL, @idTable, 0, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo] ******/
CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	
	DECLARE @isExitsBillInfo INT
	DECLARE @FoodCount INT = 1

	SELECT @isExitsBillInfo = id, @FoodCount = count FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	
	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @NewCount INT = @FoodCount + @count
		IF (@NewCount > 0)
			UPDATE dbo.BillInfo SET count = @FoodCount + @count
			WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT dbo.BillInfo(idBill,idFood,count) VALUES (@idBill, @idFood, @count)
	END	
END
GO
/****** Object:  TRIGGER [dbo].[UTG_UpdateBillInfo] ******/
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE  id = @idBill AND status = 0

	UPDATE dbo.TableFood SET status = N'Có Người' WHERE id = @idTable 
END
GO
/****** Object:  TRIGGER [dbo].[UTG_UpdateBill] ******/
CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = id FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE  id = @idBill

	DECLARE @count INT = 0

	SELECT @count =  COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

/****** Object:  StoredProcedure [dbo].[USP_SwitchTable] ******/
CREATE PROC USP_SwitchTable
@idTable1 INT , @idTable2 INT 
AS
BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT

	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1

	SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill(DateCheckin, DateCheckout, idTable, status) VALUES (GETDATE(), NULL, @idTable1, 0)

		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	END

	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	IF (@idSecondBill IS NULL)
	BEGIN
		INSERT dbo.Bill(DateCheckin, DateCheckout, idTable, status) VALUES (GETDATE(), NULL, @idTable2, 0)

		SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	END

	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSecondBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSecondBill

	UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill

	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM dbo.IDBillInfoTable)

	DROP TABLE IDBillInfoTable

	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate] ******/
CREATE PROC USP_GetListBillByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN
	SELECT t.name AS [Tên Bàn] , b.TotalPrice AS [Tổng Tiền], DateCheckin AS [Ngày Vào], DateCheckout AS [Ngày Ra], Discount AS [Giảm Giá]
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckin >= @checkIn AND DateCheckout <= @checkOut AND b.status = 1 AND t.id = b.idTable 
END
GO

ALTER PROC USP_GetReport
@checkIn DATE, @checkOut DATE
AS
BEGIN
	SELECT t.name, b.TotalPrice, DateCheckin, DateCheckout, Discount
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckin >= @checkIn AND DateCheckout <= @checkOut AND b.status = 1 AND t.id = b.idTable 
END
GO

/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount] ******/
CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @passWord NVARCHAR(100), @newPassWord NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0

	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE Username = @userName AND Password = @passWord

	IF (@isRightPass = 1)
	BEGIN
		IF(@newPassWord = NULL OR @newPassWord = '')
		BEGIN
			UPDATE dbo.Account SET Displayname = @displayName WHERE Username = @userName
		END
		ELSE
			UPDATE dbo.Account SET Displayname = @displayName, Password = @newPassWord WHERE Username = @userName
	END
END
GO
/****** Object:  TRIGGER [dbo].[UTG_DeleteBillInfo] ******/
CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillIndfo INT
	DECLARE @idBill INT

	SELECT @idBillIndfo = id, @idBill = deleted.idBill FROM deleted

	DECLARE @idTable INT
 	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill  AND b.status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput IF @strInput = '' 
	RETURN @strInput 
	
	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
			BEGIN 
				IF @COUNTER=1 
					SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
				ELSE 
					SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
					BREAK 
			END 
			SET @COUNTER1 = @COUNTER1 +1 
		END 
		SET @COUNTER = @COUNTER +1 
	END 
	SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
END
GO

/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateAndPage] ******/
CREATE PROC [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.id, t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

/****** Object:  StoredProcedure [dbo].[USP_GetNumBillByDate]******/
CREATE PROC [dbo].[USP_GetNumBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillInfo
SELECT * FROM dbo.Food
SELECT * FROM dbo.FoodCategory
SELECT * FROM dbo.TableFood
GO

DROP TABLE TableFood
DROP TABLE Food
DROP TABLE FoodCategory
DROP TABLE Bill
DROP TABLE BillInfo
DROP TABLE NV
DROP TABLE ACCOUNT
GO

