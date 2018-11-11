	--103
	SELECT M.Movie_Title, M.Movie_Year, M.Movie_Genre
	FROM MOVIE M 

	--104
	SELECT M.Movie_Year, M.Movie_Title, M.Movie_Cost
	FROM MOVIE M
	ORDER BY M.Movie_Year DESC

	--105
	SELECT M.Movie_Title, M.Movie_Year, M.Movie_Genre
	FROM MOVIE M
	ORDER BY M.Movie_Genre ASC, M.Movie_Year DESC

	--106
	SELECT M.Movie_Num, M.Movie_Title, M.Price_Code
	FROM MOVIE M
	WHERE M.Movie_Title LIKE 'R%'

	--107
	SELECT M.Movie_Title, M.Movie_Year, M.Movie_Cost
	FROM MOVIE M
	WHERE M.Movie_Title LIKE '%hope%'

	--108
	SELECT M.Movie_Title, M.Movie_Year, M.Movie_Genre
	FROM MOVIE M
	WHERE M.Movie_Genre = 'ACTION'

	--109
	SELECT M.Movie_Num, M.Movie_Title, M.Movie_Cost
	FROM MOVIE M
	WHERE M.Movie_Cost >40

	--110
	SELECT M.Movie_Num, M.Movie_Title, M.Movie_Cost, M.Movie_Genre
	FROM MOVIE M
	WHERE M.Movie_Cost <50 AND
	(M.Movie_Genre ='ACTION' 
	OR M.Movie_Genre= 'COMEDY')
	ORDER BY M.Movie_Genre ASC


	--111
	SELECT ME.Mem_Num, ME.Mem_FName, ME.Mem_LName, ME.Mem_Street,  ME.Mem_State, ME.Mem_Balance
	FROM MEMBERSHIP ME
	WHERE ME.Mem_State= 'TN'
	AND (ME.Mem_Balance <5)
	AND (ME.Mem_Street LIKE '% AVENUE')


	--112
	SELECT DISTINCT M.Movie_Genre,COUNT (M.Movie_Genre) AS [Number of Movies]
	FROM MOVIE M
	GROUP BY M.Movie_Genre


	--113
	SELECT AVG(M.Movie_Cost) AS [Average Movie Cost]
	FROM MOVIE M

	--114

	SELECT DISTINCT M.Movie_Genre, AVG(M.Movie_Cost) AS [Average Cost]
	FROM MOVIE M
	GROUP BY M.Movie_Genre



	--115
	SELECT M.Movie_Title, M.Movie_Genre, P.Price_Description, P.Price_RentFee
	FROM MOVIE M Inner Join PRICE P ON M.Price_Code = P.Price_Code
	WHERE M.Price_Code IS NOT NULL
	


	--116
	SELECT DISTINCT M.Movie_Genre, AVG(P.Price_RentFee) AS [Average Rental Fee]
	FROM MOVIE M Inner Join PRICE P ON M.Price_Code = P.Price_Code
	GROUP BY M.Movie_Genre


	--117
	 SELECT M.Movie_Title,  M.Movie_Cost / P.Price_RentFee AS[Breakeven Rentals]
	 FROM MOVIE M, PRICE P WHERE M.Price_Code = P.Price_Code

	--118

	SELECT M.Movie_Title, M.Movie_Year
	FROM MOVIE M
	WHERE M.Price_Code IS NOT NULL



	--119
	SELECT M.Movie_Title, M.Movie_Genre,M.Movie_Cost
	FROM MOVIE M
	WHERE M.Movie_Cost >= 44.99
	AND M.Movie_Cost <= 49.99


	--120
	SELECT M.Movie_Title, P.Price_Description, P.Price_RentFee, M.Movie_Genre
	FROM MOVIE M Inner Join PRICE P ON M.Price_Code = P.Price_Code
	WHERE M.Movie_Genre IN( 'FAMILY', 'COMEDY', 'DRAMA')

	--121
	SELECT ME.Mem_Num, ME.Mem_FName, ME.Mem_LName, ME.Mem_Balance
	FROM MEMBERSHIP ME
	WHERE ME.Mem_Num IN
	(SELECT R.Mem_Num 
		FROM RENTAL R)



	--122
	SELECT MIN (ME.Mem_Balance) AS [Minimum Balance],
			MAX (ME.Mem_Balance) AS [Maximum Balance],
			AVG (ME.Mem_Balance) AS [Average Balance]
	FROM MEMBERSHIP ME 
	WHERE ME.Mem_Num IN
	(SELECT R.Mem_Num
	FROM RENTAL R)

	--123
	SELECT R.Rent_Num, R.Rent_Date, V.Vid_Num, M.Movie_Title, D.Detail_DueDate, D.Detail_ReturnDate
	FROM RENTAL R Inner Join DETAILRENTAL D ON R.Rent_Num = D.Rent_Num Inner Join 
	VIDEO V ON V.Vid_Num = D.Vid_Num Inner Join 
	MOVIE M  ON V.Movie_Num = M.Movie_Num
	WHERE D.Detail_ReturnDate > D.Detail_DueDate
	ORDER BY R.Rent_Num, M.Movie_Title


	--124
	SELECT R.Rent_Num, R.Rent_Date, M.Movie_Title, D.Detail_Fee
	FROM RENTAL R, DETAILRENTAL D, VIDEO V, MOVIE M
	WHERE R.Rent_Num = D.Rent_Num 
	AND D.Vid_Num = V.Vid_Num 
	AND V.Movie_Num = M.Movie_Num 
	AND D.Detail_ReturnDate <= D.Detail_DueDate

	--125

	SELECT Movie_Num, M.Movie_Genre, M.[Average Cost], M1.Movie_Cost,
	(M1.Movie_Cost-M.[Average Cost])/ (M.[Average Cost]) *100 [Percent Difference]
	FROM MOVIE M1 JOIN 
	(SELECT Movie_Genre, AVG(Movie_Cost) AS [Average Cost]
	FROM MOVIE 
	GROUP BY Movie_Genre) M on M.Movie_Genre = M1.Movie_Genre


	




	
	
	

