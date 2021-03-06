--PART 2
--IN CASE THE TABLE NEEDS TO BE DELETED TO REDO THE CREATION.
DROP TABLE FACT
DROP TABLE PILOTDIM
DROP TABLE MODELDIM
DROP TABLE TIMEDIM
DROP TABLE STAGING

--PILOT DIMENSION TABLE
CREATE TABLE PILOTDIM(
PILOT_ID INT NOT NULL IDENTITY (1,1),
EMP_NUM INT,
EMP_LNAME VARCHAR(15),
EMP_FNAME VARCHAR(15),
PIL_LICENSE VARCHAR(25),
PIL_RATINGS VARCHAR(30),
PIL_MED_TYPE VARCHAR(1),
PIL_MED_DATE DATETIME,
PIL_PT135_DATE DATETIME
)

--MODEL DIMENSION TABLE
CREATE TABLE MODELDIM (
MODEL_ID INT NOT NULL IDENTITY(1,1),
MOD_CODE VARCHAR(10),
MOD_MANUFACTURER VARCHAR(15),
MOD_NAME VARCHAR(20),
MOD_SEATS FLOAT(8),
MOD_CHG_MILE FLOAT(8),
)

--TIME DIMENSION TABLE
CREATE TABLE TIMEDIM (
TIME_ID INT NOT NULL IDENTITY(1,1),
CHAR_DATE DATETIME,
CHAR_YEAR INT,
CHAR_MONTH INT,
)

--FACT TABLE 
CREATE TABLE FACT (
TIME_ID INT NOT NULL ,
MODEL_ID INT NOT NULL ,
PILOT_ID INT NOT NULL,
CHAR_FUEL_GALLONS FLOAT(8),
CHAR_DISTANCE FLOAT(8),
REVENUE NUMERIC
)

--CONSTRAINTS
ALTER TABLE TIMEDIM
ADD CONSTRAINT PK_TIMEDIM PRIMARY KEY (TIME_ID)

ALTER TABLE MODELDIM
ADD CONSTRAINT PK_MODELDIM PRIMARY KEY (MODEL_ID)

ALTER TABLE PILOTDIM 
ADD CONSTRAINT PK_PILOTDIM PRIMARY KEY (PILOT_ID)

ALTER TABLE FACT
ADD CONSTRAINT PK_FACT PRIMARY KEY (TIME_ID, MODEL_ID, PILOT_ID),
	CONSTRAINT FK_FACT_TIMEDIM FOREIGN KEY (TIME_ID) REFERENCES TIMEDIM,
	CONSTRAINT FK_FACT_MODELDIM FOREIGN KEY (MODEL_ID) REFERENCES MODELDIM,
	CONSTRAINT FK_FACT_PILOTDIM FOREIGN KEY (PILOT_ID) REFERENCES PILOTDIM



--STAGING TABLE
CREATE TABLE STAGING (
EMP_NUM INT,
MOD_CODE VARCHAR(10),
CHAR_DATE DATETIME, 
CHAR_DISTANCE FLOAT(8),
CHAR_FUEL_GALLONS FLOAT(8),
REVENUE NUMERIC,
TIME_ID INT,
MODEL_ID INT,
PILOT_ID INT
)


