/*MULTI LINE TABLE VALUE FUNCTIONS*/

CREATE FUNCTION FINDREPORTS(@INEMPID INT)
RETURNS @RET TABLE
(
EMPLOYEEID INT PRIMARY KEY NOT NULL,
FIRSTNAME NVARCHAR(255) NOT NULL,
LASTNAME NVARCHAR(255) NOT NULL,
JOBTITLE NVARCHAR(50) NOT NULL,
RECURSIONLEVEL INT NOT NULL
)
AS
BEGIN 
WITH EMP_CTE(EMPLOYEEID, ORGANIZATIONNODE, FIRSTNAME, LASTNAME,JOBTITLE, RECURSIONLEVEL)
AS
(
SELECT E.BUSINESSENTITYID, E.ORGANIZATIONNODE, P.FIRSTNAME, P.LASTNAME, E.JOBTITLE, 0
FROM HumanResources.Employee E
INNER JOIN Person.PersoN P ON P.BusinessEntityID=E.BusinessEntityID
WHERE E.BusinessEntityID= @INEMPID
UNION ALL
SELECT E.BUSINESSENTITYID, E.OrganizationNode, P.FIRSTNAME, P.LASTNAME, E.JOBTITLE, RECURSIONLEVEL+1
 FROM HumanResources.Employee e
            INNER JOIN EMP_cte
            ON e.OrganizationNode.GetAncestor(1) = EMP_cte.OrganizationNode
INNER JOIN Person.Person p
ON p.BusinessEntityID = e.BusinessEntityID
)
INSERT @RET
SELECT EMPLOYEEID, FIRSTNAME, LASTNAME, JOBTITLE, RECURSIONLEVEL
FROM EMP_CTE
RETURN
END

/*CALLING THE MULTILINE VALUE FUNCTION*/
SELECT EMPLOYEEID, FIRSTNAME, LASTNAME, JOBTITLE, RECURSIONLEVEL FROM DBO.FINDREPORTS(1)