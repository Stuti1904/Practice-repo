/*EXTRA ASSIGNMENT*/

/*CREATING STUDENT TABLE*/
CREATE TABLE STUDENT
(
STUDENTID INT PRIMARY KEY,
NAME VARCHAR(10),
ADDRESS VARCHAR(100),
BOARD VARCHAR(10)
)

INSERT INTO STUDENT VALUES(1, 'A', 'AHMEDABAD', 'CBSE'),
(2, 'B', 'CALCUTTA', 'STATE'),
(3, 'C', 'DELHI', 'STATE'),
(4, 'D', 'AHMEDABAD', 'CBSE')

/*CREATING TABLE MARKS*/
CREATE TABLE MARKS
(
STUDENTID INT,
SCIENCE INT,
MATH INT,
ENGLISH INT,
AVERAGE INT,
GRADE CHAR(3)
)

INSERT INTO MARKS VALUES(1, 34, 90, 56, 67.5,'C'),
(2,45,89,59, 70.5, 'B'),
(3,56,95,62,77,'B'),
(1,33,56,65,52.5, 'C'),
(2,66,34,68,50.5, 'C'),
(3,44,36,71,46.75, 'D'),
(4, 34,38,74, 46, 'D'),
(4, 23, 40, 77, 45, 'D')



