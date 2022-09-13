create table ObjectType(
TypeID int identity(1,1) PRIMARY KEY,
TypeName varchar(100)
)
Insert Into ObjectType VALUES('Subscription Type')
INSERT INTO ObjectType VALUES ('Payment Status')
INSERT INTO ObjectType VALUES ('Movies')
INSERT INTO ObjectType VALUES ('Shows')
Insert into ObjectType VALUES ('Gender')

create table Objects(
ObjectID int identity(1,1) PRIMARY KEY,
ObjectName varchar(100),
ObjectTypeID int FOREIGN KEY REFERENCES ObjectType(TypeID)
)



Insert INTO Objects Values( 'Super', 1),
('Premium', 1)

INSERT INTO Objects VALUES ('Success', 2),
('Payment failed',2),
('Insuffiecient balance', 2),
('OnHold', 2)

INSERT INTO Objects VALUES ('Bollywood', 3),
('Drama', 3),
('Hollywood', 3),
('Thriller', 3),
('Action',3)

INSERT INTO Objects VALUES ('Drama', 4),
('Kids', 4),
('Mythology', 4)

INSERT INTO Objects VALUES('Male',5),
('Female',5)


create table Roles(
RoleID int identity(1,1) PRIMARY KEY,
RoleName varchar(100),
IsActive bit,
CreatedDate date
)

INSERT INTO Roles VALUES ('Admin', 1, '2022-08-16'),
('Consumer', 1, '2022-08-16')

create table Users(
UserID int identity(1,1) PRIMARY KEY,
UserName varchar(100) NOT NULL,
Age int,
Gender int FOREIGN KEY REFERENCES Objects(ObjectID),
Email varchar(100),
Phone varchar(10),
Password varchar(100),
IsActive bit,
CreatedDate date,
ModifiedDate date,
ModifiedBy int FOREIGN KEY REFERENCES Users(UserID),
IsSubscribed bit,
SubscriptionType int FOREIGN KEY REFERENCES Objects(ObjectID),
RoleID int FOREIGN KEY REFERENCES Roles(RoleID),
ValidationOtp int
)

INSERT INTO Users VALUES ('USER1', 21,16,'user111@gmail.com',  '9106754761', 'hhyy@123', 1, '2022-08-16', null, null, 0, null, 1, 1990),
('USER2', 21,16,'user2221@gmail.com',  '9106754761', 'hhyy@123', 1, '2022-08-16', null, null, 1, 2, 2, 1990)

create table Payment(
PaymentID int identity(1,1) PRIMARY KEY,
UserID int FOREIGN KEY REFERENCES Users(UserID),
IsActive bit,
PaymentDate date,
ValidTill date,
UPIPhoneNumber varchar(10),
PaymentStatus int FOREIGN KEY REFERENCES Objects(ObjectID)
)
INSERT INTO Payment VALUES(3, 1, '2022-08-16', '2023-08-16', '9106754761',3)

create table Resources(
ResourceID int identity(1,1) PRIMARY KEY,
Url varchar(225),
IsActive bit,
CreatedDate date,
CreatedBy int FOREIGN KEY REFERENCES Users(UserID)
)

INSERT INTO Resources VALUES ('https://www.hotstar.com/in/movies/mission-mangal/1260011536/watch', 1, '2022-08-16', 2),
('https://www.hotstar.com/in/mission-mangal-trailer/1260012108', 1, '2022-08-16', 2)

INSERT INTO Resources VALUES ('https://www.hotstar.com/in/tv/devon-ke-dev-mahadev/12/daksh-punishes-sati/1000000041', 1, '2022-08-16',2)


create table Content(
ContentID int identity(1,1) PRIMARY KEY,
Title varchar(225),
Language varchar(50),
ReleasedDate date,
Description varchar(1000),
ContentType int FOREIGN KEY REFERENCES ObjectType(TypeID),
Genre int FOREIGN KEY REFERENCES Objects(ObjectID),
ResourceID int FOREIGN KEY REFERENCES Resources(ResourceID),
IsActive bit,
CreatedDate date,
CreatedBY int FOREIGN KEY REFERENCES Users(UserID),
ModifiedDate date,
ModifiedBY int FOREIGN KEY REFERENCES Users(UserID),
Cast varchar(1000),
LengthInMinutes int
)

INSERT INTO Content VALUES ('Mission Mangal', 'Hindi', '2019-08-13', 'Based on the true story of India`s finest scientists who rose above hardships and failures to make us the only country to reach Mars in its first attempt.', 3, 8,5, 1, '2022-08-16', 2, null, null, 'Akshay Kumar, Vidhya Balan, Tapeese Panu, Sonakshi Sinha', 130 )

INSERT INTO Content VALUES ('Devo Ke Dev.... Mahadev', 'Hindi', '2016-12-18', 'He is the supreme being and the destroyer of evil. Witness lord Shiva`s story, his avatars, and a union that shaped the universe - his marriage to Parvati.', 4, 14, 5,1, '2022-08-16',2, null, null, 'Mohit Raina, Mouni Roy, Sourabh Raaj Jain, Sonarika Bhadoria', null)

create table Episode(
EpisodeID int identity(1,1) PRIMARY KEY,
ContentID int FOREIGN KEY REFERENCES Content(ContentID),
Title varchar(225),
Language varchar(50),
ReleasedDate date,
Description varchar(1000),
ResourceID int FOREIGN KEY REFERENCES Resources(ResourceID),
IsActive bit,
CreatedDate date,
CreatedBy int FOREIGN KEY REFERENCES Users(UserID),
ModifiedDate date,
ModifiedBY  int FOREIGN KEY REFERENCES Users(UserID)
)

INSERT INTO Episode VALUES (2, 'Daksh Punishes Sati', 'Hindi', '2016-12-18', 'Sati, who is the daughter of Prajapati Daksh, finds a rudraksh while drawing water from river along with her sisters. Prajapati Daksh, an opposer of Lord Shiv, dares to place Vishnus incomplete idol in the temple. Prajapati Daksh performs Narayani Yagna to please Lord Vishnu as the statue was not entering the temple. Sati loses her way while collecting Parijat flowers in the forest. Sati gets visions of the solution for the statue enterting the temple in Rishi Dadhichis ashram, whom she meets while finding her way back home. Accordingly, Sati places Shivs idol in the incomplete Vishnus statue and the statue enters the temple. Sati becomes emotional when she sees Lord Shiv for the first time.', 5, 1, '2022-08-16', 2, null, null)

Create table Playlist(
PlaylistID int identity(1,1) PRIMARY KEY,
UserID int FOREIGN KEY REFERENCES Users(UserID),
ContentID int FOREIGN KEY REFERENCES Content(ContentID),
EpisodeID int FOREIGN KEY REFERENCES Episode(EpisodeID),
CreatedDate date,
CreatedBy int FOREIGN KEY REFERENCES Users(UserID),
ModifiedDate date,
ModifiedBy int FOREIGN KEY REFERENCES Users(UserID)
)


create TRIGGER soft_delete ON Content
INSTEAD OF DELETE
AS
UPDATE Content
SET IsActive=0 where ContentID in(select ContentID from deleted)

UPDATE Content
SET ModifiedDate= GETDATE() where ContentID in(select ContentID from deleted)


alter table Content
add isPaid bit

DELETE FROM Content WHERE IsActive=0
SELECT *FROM Content

create view GeneralInfo
as
Select c.ContentID, c.Title, c.Language, o.ObjectName, c.views, c.Description, r.Url, Year(c.ReleasedDate) as year, ot.TypeName as contentType, c.isPaid  from Content as c join Objects as O on c.Genre=o.ObjectID
join Resources as R on c.ResourceID=r.ResourceID 
join ObjectType as ot on c.ContentType=ot.TypeID
where c.IsActive=1


select * from generalInfo

alter table Content
add likes int,
dislikes int

alter table Content
add views int

create table Comments(
CommentId int identity(1,1) PRIMARY KEY,
UserId int FOREIGN KEY REFERENCES USERS(USERID),
ContentID int FOREIGN KEY REFERENCES CONTENT(CONTENTID),
Comment varchar(1000),
CreatedDate date
)

Insert into Comments VALUES(3,2, 'PROUD INDIAN', '2022-08-16'),
(3, 3, 'HAR HAR MAHADEV', '2022-09-01'),
(4, 2, 'AKSHAY SLAYED!', '2021-08-15'),
(9, 3, 'har har mahadev! perfect show!', '2022-09-04')


alter table Content
add HorizontalImage varchar(225),
VerticalImage varchar(225)