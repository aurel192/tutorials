http://sqlbolt.com/lesson

http://www.tutorialspoint.com/execute_sql_online.php

###	SQL Lesson 2: Queries with constraints (Pt. 1)

|Id	|Title		|Director	|Year	|Length_minutes|
|-------|---------------|---------------|-------|--------------|
|1	|Toy Story	|John Lasseter	|1995	|81|
|2	|A Bug's Life	|John Lasseter	|1998	|95|
|3	|Toy Story 2	|John Lasseter	|1999	|93|
|4	|Monsters, Inc.	|Pete Docter	|2001	|92|
|5	|Finding Nemo	|Andrew Stanton	|2003	|107|
|6	|The Incredibl	|Brad Bird	|2004	|116|
|7	|Cars		|John Lasseter  |2006	|117|
|8	|Ratatouille	|Brad Bird	|2007	|115|
|9	|WALL-E		|Andrew Stanton	|2008	|104|
|10	|Up		|Pete Docter	|2009	|101|
|11	|Toy Story 3	|Lee Unkrich	|2010	|103|
|12	|Cars 2		|John Lasseter	|2011	|120|
|13	|Brave		|Brenda Chapman	|2012	|102|
|14	|Monsters Uni.	|Dan Scanlon	|2013	|110|

1. Find the movie with a row id of 6
SELECT * FROM movies
WHERE Id = 6

2. Find the movies released in the years between 2000 and 2010
SELECT * FROM movies
WHERE Year BETWEEN 2000 and 2010

3. Find the movies not released in the years between 2000 and 2010
SELECT * FROM movies
WHERE Year NOT BETWEEN 2000 and 2010

4. Find the first 5 Pixar movies and their release year
SELECT title,year FROM movies
ORDER BY year
LIMIT 5

###	SQL Lesson 3: Queries with constraints (Pt. 2)

1. Find all the Toy Story movies
SELECT * FROM movies
WHERE Title LIKE "Toy%"

2. Find all the movies directed by John Lasseter
SELECT * FROM movies
WHERE director = "John Lasseter"

3. Find all the movies (and director) not directed by John Lasseter
SELECT Title, Director FROM movies
WHERE director != "John Lasseter"

4. Find all the WALL-* movies
SELECT * FROM movies
WHERE title LIKE "WALL%"

###	SQL Lesson 4: Filtering and sorting Query results

1. List all directors of Pixar movies (alphabetically), without duplicates
SELECT DISTINCT director FROM movies
ORDER BY director

2. List the last four Pixar movies released (ordered from most recent to least)
SELECT title FROM movies
ORDER BY Year DESC
LIMIT 4 

3. List the first five Pixar movies sorted alphabetically
SELECT title FROM movies
ORDER BY title 
LIMIT 5
 
4. List the next five Pixar movies sorted alphabetically
SELECT title FROM movies
ORDER BY title ASC
LIMIT 5 OFFSET 5

###	SQL Lesson 5:  SQL Review: Simple SELECT Queries

City		Country		Population	Latitude	Longitude
Guadalajara	Mexico		1500800		20.659699	-103.349609
Toronto		Canada		2795060		43.653226	-79.383184
Houston		United States	2195914		29.760427	-95.369803
New York	United States	8405837		40.712784	-74.005941
Philadelphia	United States	1553165		39.952584	-75.165222
Havana		Cuba		2106146		23.05407	-82.345189
Mexico City	Mexico		8555500		19.432608	-99.133208
Phoenix		United States	1513367		33.448377	-112.074037
Los Angeles	United States	3884307		34.052234	-118.243685
Ecatepec de M.	Mexico		1742000		19.601841	-99.050674
Montreal	Canada		1717767		45.501689	-73.567256
Chicago		United States	2718782		41.878114	-87.629798

1. List all the Canadian cities and their populations
SELECT City,Population FROM North_american_cities
WHERE Country = "Canada"

2. Order all the cities in the United States by their latitude from north to south 
SELECT * FROM North_american_cities
WHERE Country = "United States"
ORDER BY Latitude DESC

3. List all the cities west of Chicago, ordered from west to east
SELECT city, longitude FROM north_american_cities
WHERE longitude < -87.629798
ORDER BY longitude ASC

4. List the two largest cities in Mexico (by population)
SELECT * FROM north_american_cities
WHERE Country = "Mexico"
ORDER BY Population DESC
LIMIT 2

5. List the third and fourth largest cities (by population) in the United States and their population
SELECT City,Population FROM north_american_cities
WHERE Country = "United States"
ORDER BY Population DESC
LIMIT 2 OFFSET 2

###	SQL Lesson 6: Multi-table queries with JOINs

Movie_id	Rating	Domestic_sales	International_sales
5		8.2	380843261	555900000
14		7.4	268492764	475066843
8		8	206445654	417277164
12		6.4	191452396	368400000
3		7.9	245852179	239163000
6		8	261441092	370001000
9		8.5	223808164	297503696
11		8.4	415004880	648167031
1		8.3	191796233	170162503
7		7.2	244082982	217900167
10		8.3	293004164	438338580
4		8.1	289916256	272900000
2		7.2	162798565	200600000
13		7.2	237283207	301700000

SELECT column, another_table_column, …
FROM mytable
INNER JOIN another_table 
    ON mytable.id = another_table.id
WHERE condition(s)
ORDER BY column, … ASC/DESC
LIMIT num_limit OFFSET num_offset;

1. Find the domestic and international sales for each movie
SELECT Title,Domestic_sales,International_sales
FROM Movies
INNER JOIN Boxoffice
    ON Movies.Id = Boxoffice.Movie_id

2. Show the sales numbers for each movie that did better internationally rather than domestically
SELECT Title,Domestic_sales,International_sales
FROM Movies
INNER JOIN Boxoffice
    ON Movies.Id = Boxoffice.Movie_id
WHERE International_sales > Domestic_sales

3. List all the movies by their ratings in descending order
SELECT Title, Rating
FROM Movies
INNER JOIN Boxoffice
    ON Movies.Id = Boxoffice.Movie_id
ORDER BY Rating DESC
    
###	SQL Lesson 7: OUTER JOINs

Building_name	Capacity
1e		        24
1w		        32
2e		        16
2w		        20

Role		Name		Building	Years_employed
Engineer	Becky A.	1e		    4
Engineer	Dan B.		1e		    2
Engineer	Sharon F.	1e		    6
Engineer	Dan M.		1e		    4
Engineer	Malcom S.	1e		    1
Artist		Tylar S.	2w		    2
Artist		Sherman D.	2w		    8
Artist		Jakob J.	2w		    6
Artist		Lillia A.	2w		    7
Artist		Brandon J.	2w		    7
Manager		Scott K.	1e		    9
Manager		Shirlee M.	1e		    3
Manager		Daria O.	2w		    6

http://i.stack.imgur.com/1UKp7.png

####     	SQL Joins

 ____  ____                 ____  ____
/A   \/   B\               /A   \/   B\
|****/\    |               |    /\****| 
|***|**|   |               |   |**|***|
|****\/    |               |    \/****|
\____/\____/               \____/\____/
SELECT <select_list>       SELECT <select_list>        
FROM A                     FROM A 
LEFT JOIN B                RIGHT JOIN B      
ON A.Key = B.Key           ON A.Key = B.Key     

 ____  ____                 ____  ____
/A   \/   B\               /A   \/   B\
|****/\    |               |    /\****| 
|***|  |   |               |   |  |***|
|****\/    |               |    \/****|
\____/\____/               \____/\____/                
SELECT <select_list>       SELECT <select_list>        
FROM A                     FROM A
LEFT JOIN B                RIGHT JOIN B       
WHERE B.Key IS NULL        ON A.Key = B.Key

 ____  ____                 ____  ____                 ____  ____
/A   \/   B\               /A   \/   B\               /A   \/   B\
|****/\****|               |****/\****|               |    /\    | 
|***|**|***|               |***|  |***|               |   |**|   |
|****\/****|               |****\/****|               |    \/    |
\____/\____/               \____/\____/               \____/\____/    
SELECT <select_list>       SELECT <select_list>       SELECT <select_list>
FROM A                     FROM A                     FROM A
FULL OUTER JOIN B          FULL OUTER JOIN B          INNER JOIN B  
ON A.Key = B.Key           ON A.Key = B.Key           ON A.Key = B.Key  
                           WHERE A.Key IS NULL
                           OR    B.Key IS NULL


SELECT column, another_column, …
FROM mytable
INNER/LEFT/RIGHT/FULL JOIN another_table 
    ON mytable.id = another_table.matching_id
WHERE condition(s)
ORDER BY column, … ASC/DESC
LIMIT num_limit OFFSET num_offset;

1. Find the list of all buildings that have employees
SELECT DISTINCT building FROM employees

2. Find the list of all buildings and their capacity
SELECT * FROM Buildings

3. List all buildings and the distinct employee roles in each building (including empty buildings)
SELECT DISTINCT building_name, role 
FROM buildings 
  LEFT JOIN employees
    ON building_name = building;

###	SQL Lesson 8: A short note on NULLs

1. Find the name and role of all employees who have not been assigned to a building
SELECT name,role FROM employees
WHERE building IS NULL

2. Find the names of the buildings that hold no employees
SELECT Building_name FROM Buildings
LEFT JOIN Employees
ON Building_name = Building
WHERE building IS NULL

###	SQL Lesson 9: Queries with expressions

1. List all movies and their combined sales in millions of dollars
SELECT Title, (Domestic_sales+International_sales)/1000000 as Income
FROM Movies INNER JOIN Boxoffice
WHERE Movies.Id = Boxoffice.Movie_id

2. List all movies and their ratings in percent
SELECT Title,Rating*10 as Rating
FROM Movies INNER JOIN Boxoffice
WHERE Movies.Id = Boxoffice.Movie_id

3. List all movies that were released on even number years
SELECT * FROM Movies
WHERE Year%2==0
   
###	SQL Lesson 10: Queries with aggregates (Pt. 1)
    
1. Find the longest time that an employee has been at the studio
SELECT Name,MAX(Years_employed) FROM employees

2. For each role, find the average number of years employed by employees in that role
SELECT role, AVG(years_employed) as Average_years_employed
FROM employees
GROUP BY role

3. Find the total number of employee years worked in each building
SELECT Building,SUM(Years_employed) FROM Employees
GROUP BY Building

###	SQL Lesson 11: Queries with aggregates (Pt. 2)
    
1. Find the number of Artists in the studio (without a HAVING clause)
SELECT Count(Role)  FROM employees
WHERE Role IS "Artist"

2. Find the number of Employees of each role in the studio
SELECT Role,COUNT(Role) FROM employees
GROUP BY Role

3. Find the total number of years employed by all Engineers
SELECT SUM(Years_employed) FROM employees
WHERE Role IS "Engineer"


###	SQL Lesson 12: Order of execution of a Query
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

