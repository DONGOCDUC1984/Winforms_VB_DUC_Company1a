-- Create Database Winforms_VB_DUC_Company1a
Use Winforms_VB_DUC_Company1a
Go
create table Users
(-- the following line means Id is int ,not null, auto increment 
  UserId int not null identity(1,1),
  UserName varchar(50) not null,
  UserEmail varchar(50) not null,
  UserPassword varchar(500) not null,
  UserRole varchar(50) not null,
primary key (UserId),
);
Go
create table Departments
(-- the following line means DepartmentId is int ,not null, auto increment 
  DepartmentId int not null identity(1,1),
  DepartmentName varchar(50) not null,
  primary key (DepartmentId),
);
INSERT INTO Departments (DepartmentName) VALUES 
('Accounting'),
('Director'),
('IT')
;
Go
create table Positions
(-- the following line means PositionId is int ,not null, auto increment 
  PositionId int not null identity(1,1),
  PositionName varchar(50) not null,
  -- the following line means DepartmentId is int, not null, is the foreign key 
  -- refers to DepartmentId of Departments,deleting,updating Departments =>deleting,updating Positions
  DepartmentId int not null references Departments(DepartmentId) ON DELETE CASCADE ON UPDATE CASCADE,
  DailySalary float not null,
  primary key (PositionId),
);
Go
INSERT INTO Positions (PositionName,DepartmentId,DailySalary) VALUES 
('Cost Accountant',1,10),
('Financial Accountant',1,11),
('Tax Accountant',1,11.5),
('CEO',2,50),
('Secretary',2,11),
('Java Developer',3,20),
('C# .Net Developer',3,20),
('Tester',3,15)
;
Go
create table Employees
(-- the following line means EmpId is int ,not null, auto increment 
  EmpId int not null identity(1,1),
  EmpName varchar(50) not null,
  EmpDOB Date not null,
  EmpGender VARCHAR(50) not null,
  EmpImagePath VARCHAR(200),
  EmpAddress VARCHAR(250) not null,
  -- the following line means DepartmentId is int, not null, is the foreign key 
  -- refers to DepartmentId of Departments,
  DepartmentId int not null references Departments(DepartmentId) ,
  -- the following line means PositionId is int, not null, is the foreign key 
  -- refers to PositionId of Positions,deleting,updating Positions =>deleting,updating Employees
 PositionId int not null references Positions(PositionId) ON DELETE CASCADE ON UPDATE CASCADE,
  primary key (EmpId),
);
Go
create table Profit_2023
(-- the following line means ProfitId is int ,not null, auto increment 
  ProfitId int not null identity(1,1),
  Month varchar(50) not null,
  Profit float not null,
  primary key (ProfitId),
);
INSERT INTO Profit_2023 (Month,Profit) VALUES 
('January',10.2),
('February',8.3),
('March',9),
('April',6),
('May',2.8),
('June',3.9),
('July',12.5),
('August',11),
('September',6),
('October',3),
('November',5),
('December',8)
;

Go
Create Procedure UserCreate
    @UserName varchar(50),
	@UserEmail varchar(50),
    @UserPassword varchar(500),
    @UserRole varchar(50)
As
Insert into Users (UserName,UserEmail,UserPassword, UserRole) values (@UserName,@UserEmail,@UserPassword, @UserRole)
Go
Create Procedure EmployeeCreateOrEdit
      @EmpId int, 
      @EmpName  varchar(50),
	  @EmpDOB  date,
	  @EmpGender  varchar(50),
	  @EmpImagePath  varchar(200),
	  @EmpAddress VARCHAR(250) ,
	  @DepartmentId int,
	  @PositionId int
As
-- Create

if  @EmpId=0 
Begin
Insert into Employees (EmpName,EmpDOB,EmpGender, EmpImagePath,EmpAddress,DepartmentId,PositionId) 
values (@EmpName,@EmpDOB,@EmpGender,@EmpImagePath,@EmpAddress, @DepartmentId, @PositionId)

End
-- Update
else 
Begin
Update Employees
Set  
EmpName=@EmpName,EmpDOB=@EmpDOB,EmpGender=@EmpGender,EmpImagePath=@EmpImagePath ,
EmpAddress=@EmpAddress,DepartmentId=@DepartmentId, PositionId=@PositionId
where EmpId=@EmpId
end
Go
create procedure EmployeeList
as
    select e.EmpId , e.EmpName ,e.EmpDOB ,
	e.EmpGender ,e.EmpImagePath ,e.EmpAddress, 
	e.DepartmentId, e.PositionId ,d.DepartmentName, 
	p.PositionName, p.DailySalary 
	from Employees as e
    inner join
	Positions p on e.PositionId = p.PositionId
	inner join
	Departments d on e.DepartmentId= d.DepartmentId
Go
create procedure GetEmployeeById
 @EmpId int
as
    select e.EmpId , e.EmpName ,e.EmpDOB ,
	e.EmpGender ,e.EmpImagePath ,e.EmpAddress, 
	e.DepartmentId, e.PositionId   ,       d.DepartmentName , 
	p.PositionName, p.DailySalary 
	from Employees as e
    inner join
	Positions p on e.PositionId = p.PositionId
	inner join
	Departments d on e.DepartmentId= d.DepartmentId

  where EmpId =@EmpId 
Go
create procedure GetEmployeeByName
 @searchStr varchar(50)
as
    select e.EmpId , e.EmpName ,e.EmpDOB ,
	e.EmpGender ,e.EmpImagePath ,e.EmpAddress, 
	e.DepartmentId, e.PositionId   ,       d.DepartmentName , 
	p.PositionName, p.DailySalary 
	from Employees as e
    inner join
	Positions p on e.PositionId = p.PositionId
	inner join
	Departments d on e.DepartmentId= d.DepartmentId

  where EmpName LIKE '%'+@searchStr+'%'
Go
create procedure GetEmployeeByDepartmentId
 @DepartmentId int
as
    select e.EmpId , e.EmpName ,e.EmpDOB ,
	e.EmpGender ,e.EmpImagePath ,e.EmpAddress, 
	e.DepartmentId, e.PositionId   ,       d.DepartmentName , 
	p.PositionName, p.DailySalary 
	from Employees as e
    inner join
	Positions p on e.PositionId = p.PositionId
	inner join
	Departments d on e.DepartmentId= d.DepartmentId

  where e.DepartmentId =@DepartmentId 
Go

create procedure EmployeeDelete
 @EmpId int
as
 Delete from Employees
  where EmpId =@EmpId 
Go
create procedure PositionList
as
    SELECT P.PositionId,P.PositionName,P.DepartmentId, 
	P.DailySalary, D.DepartmentName
  FROM Positions as P
  join Departments as D 
  on P.DepartmentId=D.DepartmentId

Go






