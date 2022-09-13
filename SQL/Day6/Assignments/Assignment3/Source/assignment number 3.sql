CREATE VIEW ViewFour
AS
SELECT departments.DEPARTMENT_NAME, employees.FIRST_NAME, locations.CITY FROM departments JOIN employees ON departments.MANAGER_ID=employees.EMPLOYEE_ID JOIN locations ON departments.LOCATION_ID=locations.LOCATION_ID

SELECT * FROM ViewFour

CREATE VIEW ViewFive
AS
SELECT departments.DEPARTMENT_NAME, CONCAT(EMPLOYEES.FIRST_NAME, EMPLOYEES.LAST_NAME) AS MANAGER_NAME, employees.HIRE_DATE, employees.SALARY  FROM departments JOIN employees ON departments.MANAGER_ID=employees.EMPLOYEE_ID JOIN job_history ON departments.MANAGER_ID=job_history.EMPLOYEE_ID AND DATEDIFF(YEAR,JOB_HISTORY.START_DATE, job_history.END_DATE)>=15

SELECT * FROM ViewFive

