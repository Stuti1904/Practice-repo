/*MULTIPLE CTES*/

WITH  cte_one(FirstName) AS
(
SELECT FirstName from person.person),

cte_two(LastName) AS
(
SELECT LastName from person.person)

select firstname, lastname from cte_one
join
 cte_two on firstname is not null

