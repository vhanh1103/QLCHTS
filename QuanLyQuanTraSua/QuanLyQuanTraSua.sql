CREATE DATABASE DatabaseQuanLyQuanTraSua
Go
USE DatabaseQuanLyQuanTraSua
Go
CREATE TABLE TableFood
(
	id Int Identity Primary Key,
	name Nvarchar(100) NOT NULL Default N'Chưa đặt tên',
	status Nvarchar(100) NOT NULL Default N'Trống'
) 
Go
CREATE TABLE Account
(
UserName Nvarchar(100) Primary Key,
	DisplayName Nvarchar(100) NOT NULL,
	PassWord Nvarchar(100) NOT NULL,
	Type Int NOT NULL
)
Go
CREATE TABLE FoodCategory
(
	id Int Identity Primary Key,
	name Nvarchar(100) Default N'Chưa đặt tên'
)
Go
CREATE TABLE Food
(
	id Int Identity Primary Key,
	name Nvarchar(100) NOT NULL Default N'Chưa đặt tên',
	idCategory Int NOT NULL,
	price Float NOT NULL
	Foreign key(idCategory) References dbo.FoodCategory(id)
)
Go

CREATE TABLE Bill
(
	id Int Identity Primary Key,
	DateCheckIn Date NOT NULL Default GetDate(),
	DateCheckOut Date,
	idTable Int NOT NULL,
	status Int NOT NULL 
	
	Foreign key(idTable) References dbo.TableFood(id)
)
Go
CREATE TABLE BillInfo
(
	id Int Identity Primary Key,
	idBill Int NOT NULL,
	idFood Int NOT NULL,
	count Int NOT NULL Default 0
	Foreign key(idBill) References dbo.Bill(id),
	Foreign key(idFood) References dbo.Food(id)
)
Go
--Thêm thông tin bàng Account
INSERT INTO dbo.Account
	( UserName,
	  DisplayName,
	  PassWord,
	  Type
	)
VALUES (N'admin',
		N'Admin',
		N'admin',
		1
		)
		INSERT INTO dbo.Account
	( UserName,
	  DisplayName,
	  PassWord,
	  Type
	)
VALUES (N'khanhngoc',
		N'Trần Khánh Ngọc',
		N'khanhngoc',
		1
		)
INSERT INTO dbo.Account
	( UserName,
	  DisplayName,
	  PassWord,
	  Type
	)
VALUES (N'hoanganh',
		N'Vũ Hoàng Anh',
		N'hoanganh',
		1
		)
INSERT INTO dbo.Account
	( UserName,
	  DisplayName,
	  PassWord,
	  Type
	)
VALUES (N'quoccuong',
		N'Nguyễn Quốc Cường',
		N'quoccuong',
		1
		)
Go
Select*from dbo.Account
Go
--Nhận tài khoản theo tên người dùng
CREATE PROC PSP_GetAccountByUserName
@userName Nvarchar(100)
As
Begin
	Select * from dbo.Account Where UserName=@userName
End
Go
EXEC dbo. PSP_GetAccountByUserName @userName=N'khanhngoc'
Go
Select * from dbo.Account Where UserName =N'khanhngoc' and PassWord=N'khanhngoc'
Go
CREATE PROC PSP_Login
@userName Nvarchar(100), @passWord Nvarchar(100)
As
Begin
	Select * from dbo.Account Where UserName = @userName and PassWord = @passWord
End
Go
--Hiển thị bàn trà sữa
DECLARE @i int = 0
While @i <= 10
Begin
	Insert dbo.TableFood ( name) Values (N'Bàn ' + CAST(@i As nvarchar(100)))
	Set @i = @i + 1
End
Select * from dbo.TableFood
Go
CREATE PROC PSP_GetTableList
As 
	Select * from dbo.TableFood
Go

Go
--Thêm Category
INSERT dbo.FoodCategory
		(name)
VALUES ( N'Đồ uống')
INSERT dbo.FoodCategory
		(name)
VALUES ( N'Thức ăn')
Go
--Thêm nước uống
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Trà sữa truyền thống', 1, 25000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Sữa tươi trân châu đường đen', 1, 25000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Trà sữa matcha', 1, 25000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Matcha đá xay', 1, 25000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Cà phê trứng', 1, 35000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Trà đào', 1, 15000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Hồng trà', 1, 15000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Cà phê đen', 1, 10000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Cà phê sữa', 1, 12000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Bạc xỉu', 1, 12000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Trà chanh', 1, 10000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Trà tắc', 1, 10000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Sinh tố dâu', 1, 30000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Sinh tố mãng cầu', 1, 30000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Sinh tố bơ', 1, 30000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Bánh tráng trộn', 2, 15000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Cá viên chiên', 2, 5000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Xúc xích chiên', 2, 10000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Mỳ cay', 2, 60000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Bò viên', 2, 5000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Hamberger', 2, 25000)
INSERT dbo.Food
		(name,idCategory,price)
VALUES ( N'Sanwish', 2, 20000)
Go

Go
Select * from dbo.BillInfo Where idBill=3
SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND  b.idTable =5


select*from dbo.BillInfo
select*from dbo.Bill
select*from dbo.TableFood

CREATE PROC PSP_InsertBill
@idTable int
As
Begin
	Insert dbo.Bill
			(DateCheckIn,
			 DateCheckOut,
			 idTable,
			 status)
	Values (GETDATE(),
			NULL,
			@idTable,
			0)
End
Go
CREATE PROC PSP_InsertBillInfo
@idBill int, @idFood int, @count int
As
Begin
	Declare @isExitsBillInfo int
	Declare @foodCount int = 1
	Select @isExitsBillInfo = id, @foodCount = Count from dbo.BillInfo Where idBill = @idBill and idFood = @idFood
	IF(@isExitsBillInfo > 0)
	Begin
		Declare @newCount int = @foodCount + @count
		If(@newCount > 0)
			Update dbo.BillInfo Set Count = @foodCount + @count Where idFood = @idFood
		Else
			Delete dbo.BillInfo Where idBill = @idBill and idFood = @idFood
	End
	Else
	Begin
		Insert dbo.BillInfo(idBill,idFood,count)
		Values(@idBill, @idFood, @count)
	End	
End
Go
CREATE TRIGGER PTG_UpdateBillInfo
On dbo.BillInfo for insert, update
As
Begin
	Declare @idBill int
	Select @idBill = idBill from inserted
	Declare @idTable int
	Select @idTable = idTable from dbo.Bill Where id = @idBill and status = 0
	Update dbo.TableFood Set status = N'Có người' Where id = @idTable
End
Go
Create TRIGGER PTG_UpdateBill
On dbo.Bill for update
As
Begin
	Declare @idBill int
	Select @idBill = id from inserted
	Declare @idTable int
	Select @idTable = idTable from dbo.Bill Where id = @idBill 
	Declare @count int = 0
	Select @count = Count(*) from dbo.Bill Where idTable = @idTable and status = 0
	If (@count =0)
		Update dbo.TableFood Set status = N'Trống' where id = @idTable
End
Go
Alter Table dbo.Bill add totalPrice float
Go
CREATE PROC PSP_GetListBillByDate
@checkIn date, @checkOut date
As
Begin
	Select t.name as[Tên bàn], b.totalPrice as[Tổng tiền], DateCheckIn as[Ngày vào], DateCheckOut as[Ngày ra] 
	From dbo.Bill as b, dbo.TableFood as t, dbo.BillInfo as bi, dbo.Food as f
	Where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
End
