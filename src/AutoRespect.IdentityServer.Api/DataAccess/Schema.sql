drop table if EXISTS dbo.[User]
create table dbo.[User] (
    Id int not null IDENTITY(1,1),
    Login varchar(64) not null,
    Password varchar(32) not null
)

drop table if exists dbo.[Token]
create table dbo.[Token] (
    Id int not null IDENTITY(1,1),
    AccessToken varchar(max) not null,
    Type int not null,
    RefreshToken varchar(max),
    ExpiresIn bigint
)