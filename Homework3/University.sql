create table Student(
	Id int identity(1,1) constraint PK_Student primary key,
	Name nvarchar(100)
)
create table Groups(
	Id int identity(1,1) constraint PK_Group primary key,
	Name nvarchar(100)
)
create table StudentInGroup(
	StudentId int constraint FK_StudentInGroups_Student references Student(Id),
	GroupId int constraint FK_StudentInGroups_Groups references Groups(Id)
)
select * from Student
select * from Groups
select * from StudentInGroup