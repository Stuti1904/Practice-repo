/* ASSIGNMENT 2*/

/*CREATING A TABLE NAMED PLANETSID*/
CREATE TABLE [dbo].[PlanetsID](
[ID] [int] NOT NULL,
[Item] [int] NOT NULL,
[Value] [int] NOT NULL
) ON [PRIMARY]
GO

/*INSERTING VALUES INO A TABLE*/
INSERT INTO PlanetsID VALUES (4, 23, 66)
INSERT INTO PlanetsID VALUES (1, 12, 59)
INSERT INTO PlanetsID VALUES (3, 66, 24)
SELECT * FROM PlanetsID
GO
/*CREATING A CLUSTERED INDEX*/
CREATE CLUSTERED INDEX[CI_ID] ON PlanetsID
(
ID
)