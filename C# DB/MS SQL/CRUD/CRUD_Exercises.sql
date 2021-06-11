--Find All Information About Departments
SELECT * FROM [Departments];

--Find All Departments Names
SELECT [Name] FROM [Departments];

--Find Salary of Each Employee
SELECT [FirstName],[LastName],[Salary] FROM Employees;

--Find Full Name of Each Employee
SELECT [FirstName],[MiddleName],[LastName] FROM Employees;

--Find Email Address of Each Employee
SELECT FirstName + '.' + LastName + '@softuni.bg' AS [Full Email Address]  
FROM Employees;

--Find All Different Employee's Salaries
SELECT DISTINCT Salary FROM Employees;

--Find All Information About Employees
SELECT * FROM Employees WHERE JobTitle = 'Sales Representative';

--Find Names of All Employees by Salary in Range
SELECT FirstName, LastName, JobTitle
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

--Find Names of All Employees
--write a SQL query to find the full name of all employees whose salary is 25000,14000,12500 or 23600
SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name]
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600);

--Find All Employees Without Manager
SELECT FirstName, LastName 
	FROM Employees
	WHERE ManagerID IS NULL;

--Find All Employees with Salary More Than 50000
SELECT FirstName, LastName, Salary
	FROM Employees
	WHERE Salary > 50000
	ORDER BY Salary DESC;

--Find 5 Best Paid Employees
SELECT TOP(5) FirstName, LastName
	FROM Employees
	ORDER BY Salary DESC;

--Find All Employees Except Marketing
SELECT FirstName,LastName
	FROM Employees
	WHERE DepartmentID != 4

--Sort Employees Table

--sort first by salary in decreasing order
--then by first name alphabetically
--then by last name descending
--then by middle name alphabetically

SELECT * 
	FROM Employees
	ORDER BY Salary DESC, FirstName ASC, LastName DESC, MiddleName ASC

--Create View Employees with Salaries

CREATE VIEW V_EmployeesSalaries AS
SELECT FirstName, LastName, Salary
	FROM Employees

	GO

	SELECT * V_EmployeesSalaries


--Create View Employees with Job Title
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [Full Name], JobTitle
FROM Employees

SELECT [Full Name] FROM V_EmployeeNameJobTitle

--Distinct Job Titles

SELECT DISTINCT JobTitle
FROM Employees


--Find First 10 Started Projects
SELECT TOP(10) *
FROM Projects
ORDER BY StartDate, [Name]


--Last 7 Hired Employees
SELECT TOP(7) FirstName, LastName, HireDate
FROM Employees
ORDER BY HireDate DESC


--Increase Salaries

--write a sql query to increase salaries of all employess that are in the
--Engineering, Tool Design, Marketing or Information Services department by 12%

UPDATE Employees
SET Salary *= 1.12
WHERE DepartmentID IN (1,2,4,11)

SELECT Salary
FROM Employees
	
