CREATE PROCEDURE [dbo].[QBdisplay]
AS
BEGIN
IF(SELECT COUNT(*)FROM[dbo].[QBTable])=0
BEGIN
	INSERT INTO[dbo].[QBTable]
(QBName,QBGradeYearLevel,QBReasonForAdmission,QBDate,QBTime)
VALUES(N'Mark Evric Quinones',
       N'BSIT-3',
       N'HIV',
       N'12-4-2023',
       N'12:59 AM'),
       (N'Christene Joy Burata',
       N'BSIT-3',
       N'kalibanga',
       N'12-4-2023',
       N'8:00 AM')
END

SELECT
[QBId] as QBId,
[QBName] as QBName,
[QBGradeYearLevel] as QBGradeYearLevel,
[QBReasonForAdmission] as QBReasonForAdmission,
[QBDate] as QBDate,
[QBTime] as QBTime

FROM[dbo].[QBTable]

END
