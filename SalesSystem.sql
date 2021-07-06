create database SalesSystem
go

use SalesSystem
go 

create table Customer(
CustomerID int identity(1000, 1) not null,
FName varchar(30) not null, 
LName varchar(40) not null, 
Email varchar(30) not null, 
UserName varchar(40) not null, 
CustomerPassword varchar(40) not null
constraint [PK_Customer] primary key (CustomerID),
constraint [UNQ_Username] unique (UserName)
);

create table Account(
AccountID int identity(100, 1) not null, 
CustomerID int not null, 
Balance decimal(10,2) default(0.0), 
constraint [PK_Account] primary key (AccountID),
constraint [FK_AccountCust] foreign key (CustomerID)
	references Customer(CustomerID)
);

create table Item(
ItemID int not null, 
ItemName varchar(35) not null, 
Units int not null, 
Price decimal(5,2) not null
constraint [PK_Item] primary key (ItemID), 
constraint [UNQ_Item] unique (ItemID)
);

create table Orders(
OrderID int identity(10000,1) not null, 
AccountID int not null,
OrderDate date not null, 
constraint [PK_Orders] primary key (OrderID),
constraint [FK_OrderAccount] foreign key (AccountID)
	references Account(AccountID),
);

create table ItemPurchase(
OrderID int not null, 
ItemID int not null, 
Quantity int not null,
QuotedPrice decimal(6,2) not null, 
Subtotal as Quantity * QuotedPrice
constraint [PK_ItemPurchase] primary key (OrderID, ItemID),
constraint [FK_Order] foreign key (OrderID)
	references Orders(OrderID),
constraint [FK_Item] foreign key (ItemID)
	references Item (ItemID)
);

create table Payment (
PaymentID int identity(5000, 1) not null,
AccountID int not null,
PaymentAmount decimal(6,2) not null,
PaymentDate date not null,
constraint [PK_Payment] primary key (PaymentID),
constraint [FK_PayAccount] foreign key (AccountID)
	references Account (AccountID)
);

go
USE [SalesSystem]
GO
/****** Object:  Trigger [dbo].[CreateCustomerAccount]    Script Date: 5/10/2021 8:56:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tehila Raful 
-- Create date: 5/3/2021
-- Description:	Creates an account for customer when new customer is added 
-- =============================================
CREATE TRIGGER [dbo].[CreateCustomerAccount] 
   ON  [dbo].[Customer]
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	declare @CustomerID int; 

	if exists (select * from inserted)
	BEGIN 
		select @CustomerID = CustomerID
		from inserted

		insert into Account (CustomerID) values (@CustomerID)
	END 
END
go

USE [SalesSystem]
GO
/****** Object:  Trigger [dbo].[UpdatePartsInv]    Script Date: 5/10/2021 8:46:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[UpdatePartsInv]
   ON  [dbo].[ItemPurchase]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   Declare @ItemID int;
   Declare @qtyBuy int;
   Declare @qtyAvail int;
    if exists (select * from inserted)
    begin   --process an insert of a record
    if exists (select * from deleted)  --this is really an update
      begin       -- add the qty back to units on hand
       select @ItemID = ItemID from deleted
       select @qtyBuy = Quantity from deleted
       update Item
         set Units = Units + @qtyBuy
         where ItemID = @ItemID
         
     end
      --continue to process the insert 
      select @ItemID = ItemID from inserted
      select @qtyBuy =  Quantity from inserted
   
      select @qtyAvail = units from Item
          where ItemID = @ItemID
      --check if have enough inventory
      if @qtyAvail < @qtyBuy
          begin;
             throw 50010,'insufficient inventory',1
             
          end     
       else
         --modify the part table
          update Item
            set units = units - @qtyBuy
             where ItemID = @ItemID   
    end   --process an insert or update
    else --just processing a delete
      begin
        select @ItemID = ItemID from deleted
        select @qtyBuy = Quantity from deleted
        update Item
         set units = units + @qtyBuy
         where ItemID = @ItemID
      end  

END
go
USE [SalesSystem]
GO
/****** Object:  Trigger [dbo].[UpdateBalanceAfterPayment]    Script Date: 5/10/2021 8:57:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[UpdateBalanceAfterPayment] 
   ON  [dbo].[Payment]
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @acctID int; 
	declare @amount decimal; 

    if exists (select * from inserted)
	BEGIN
		select @acctID = AccountID
		from inserted

		select @amount = PaymentAmount
		from inserted 

		update Account 
		set Balance -= @amount
		where AccountID = @acctID; 
	END

END
go

USE [SalesSystem]
GO
/****** Object:  Trigger [dbo].[UpdateAccountBalancePurchase]    Script Date: 5/10/2021 8:58:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[UpdateBalanceAfterPurchase] 
   ON  [dbo].[ItemPurchase] 
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @acctID int; 
	declare @itemID int; 
	declare @quant decimal; 

    if exists (select * from inserted)
	BEGIN
		--get account, price of item and total 
		select @acctID = AccountID
		from inserted
		inner join Orders
		on orders.OrderID = inserted.OrderID

		select @itemID = ItemID
		from inserted

		select @quant = Quantity
		from inserted

		-- add the balance to account 
		update Account 
		set Balance += (select Price
						from Item
						where ItemId = @itemID) * @quant
		where AccountID = @acctID; 
		
	END

END

GO
insert into Customer values ('Jane', 'Smith', 'jsmith@gmail.com' , 'jsmith' ,'jane100!')
insert into Customer values ('Amy', 'Cohen', 'amy@gmail.com' , 'acohen' ,'amy456')
insert into Customer values ('Max', 'Levy', 'levy101@gmail.com' , 'mlevy01' ,'paula1995')
insert into Customer values ('John', 'Smith', 'johnsmith@gmail.com' , 'jsmith01' ,'john100!')
insert into Customer values ('Harry', 'Potter', 'hp@gmail.com' , 'hpotter' ,'platform934')
insert into Customer values ('Tehila', 'Raful', 'tr@gmail.com' , 'traful' ,'raful567')

insert into Item values (1234, 'Napkins', 75, 5.89)
insert into Item values (5637, 'Tissues', 23, 7.99)
insert into Item values (7492, 'Lemons', 132, 1.00)
insert into Item values (8534, 'Pencils', 56, 4.89)
insert into Item values (4783, 'Gum', 34, 2.95)

insert into Orders(AccountID, OrderDate) values (104 , GETDATE());
insert into Orders(AccountID, OrderDate) values (103 , GETDATE());
insert into Orders(AccountID, OrderDate) values (102 , GETDATE());

insert into ItemPurchase values (10001, 1234, 3, 5.89); 
insert into ItemPurchase values (10001, 5637, 1, 7.99); 
insert into ItemPurchase values (10002, 4783, 4, 2.95); 
insert into ItemPurchase values (10000, 1234, 6, 5.89); 
insert into ItemPurchase values (10000, 7492, 9, 1.00); 