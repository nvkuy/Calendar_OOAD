USE CalendarOOAD;

CREATE TABLE NUser (
	idUser int primary key identity(1, 1),
	gmail varchar(111) unique not null,
	name nvarchar(111),
);

CREATE TABLE Meeting (
	idMeeting int primary key identity(1, 1),
	name nvarchar(111),
	location nvarchar(111),
	startTime datetime default current_timestamp,
	endTime datetime default current_timestamp,
	remind int,
	host int foreign key references NUser(idUser)
);

CREATE TABLE User_Meeting (
	idUser int foreign key references NUser(idUser),
	idMeeting int foreign key references Meeting(idMeeting),
	constraint pkUserMeeting primary key (idUser, idMeeting)
);