--A11
--April 19th 2017


--70
ALTER TABLE VIDEO
	ADD VID_STATUS VARCHAR(4) DEFAULT 'IN' NOT NULL CHECK 
	(VID_STATUS IN ('IN','OUT','LOST'))
	
	--SELECT * FROM VIDEO-- --Checking the change--

--71
UPDATE VIDEO
SET VID_STATUS = 'OUT'
WHERE Vid_Num IN (SELECT Vid_Num FROM DETAILRENTAL WHERE Detail_ReturnDate IS NULL)

--72
ALTER TABLE PRICE
ADD Price_RentDays NUMERIC(2,0) NOT NULL DEFAULT 3


--73
UPDATE PRICE
SET Price_RentDays = 5 WHERE Price_Code IN (1,3)
UPDATE PRICE
SET Price_RentDays = 7 WHERE Price_Code = 4


--78
CREATE PROCEDURE prc_new_detail (@V_Vid_Num INT, @V_Rent_Num INT)
AS
BEGIN
	IF EXISTS (SELECT Vid_Num
			   FROM VIDEO V 
			   WHERE V.Vid_Num = @V_Vid_Num)
	IF EXISTS (SELECT Vid_Num 
			   FROM VIDEO V 
			   WHERE V.Vid_Num = @V_Vid_Num AND V.Movie_Num = 'IN')
BEGIN
INSERT INTO DETAILRENTAL(Rent_Num,Vid_Num,Detail_Fee,Detail_DailyLateFee,Detail_DueDate,Detail_ReturnDate)
SELECT @V_RENT_NUM, @V_VID_NUM, P.Price_RentFee, P.Price_DailyLateFee, 
DATEADD (dd,0, P.Price_RentDays) + DATEADD (s,-1,DATEADD (dd, DATEDIFF (dd, 0, getdate ()), 1)) AS [DueDate], NULL AS [ReturnDate]
FROM PRICE P INNER JOIN Movie M ON P.Price_Code = M.Price_Code
			 INNER JOIN VIDEO V ON M.Movie_Num = V.Movie_Num
WHERE V.Vid_Num = @V_Vid_Num
UPDATE VIDEO 
SET [VID_STATUS] = 'OUT'
WHERE Vid_Num = @V_Vid_Num
END

ELSE
PRINT CONCAT('No video exists with video number ''', @V_Vid_Num, '''')
END


--79
CREATE PROCEDURE prc_return_video (@V_Vid_Num INT)
AS
BEGIN
IF EXISTS (SELECT Vid_Num 
		   FROM VIDEO V 
		   WHERE V.Vid_Num = @V_Vid_Num)
IF (SELECT COUNT(*) 
	FROM DETAILRENTAL D 
	WHERE @V_Vid_Num =D.Vid_Num AND D.Detail_ReturnDate IS NULL) =1
BEGIN
UPDATE VIDEO
SET [VID_STATUS] = 'IN', [Vid_InDate] = getdate()
WHERE Vid_Num = @V_Vid_Num
PRINT CONCAT('Video ''', @V_Vid_Num,''' was sucessfully returned.')
END
ELSE IF
(SELECT COUNT(*) 
 FROM DETAILRENTAL D 
 WHERE @V_Vid_Num = D.Vid_Num AND D.Detail_ReturnDate IS NULL) > 1
PRINT CONCAT('Video ''', @V_Vid_Num,''' has multiple outstanding rentals.')
ELSE 
BEGIN
UPDATE VIDEO
SET [VID_STATUS] = 'IN', [Vid_InDate] = getdate()
WHERE Vid_Num = @V_Vid_Num
PRINT CONCAT('Video ''', @V_Vid_Num, ''' had no outstanding rentals but is now available for rental')
END
ELSE
PRINT CONCAT('No video exists with video number ''', @V_Vid_Num, '''')
END
