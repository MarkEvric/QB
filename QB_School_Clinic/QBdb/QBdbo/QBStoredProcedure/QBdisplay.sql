CREATE PROCEDURE [dbo].[QBdisplay]
AS
BEGIN
IF(SELECT COUNT(*)FROM[dbo].[QBTable])=0
BEGIN
	INSERT INTO[dbo].[QBTable]
(QBName,QBGradeYearLevel,QBReasonForAdmission,QBDate,QBTime)
VALUES(N'Mark Evric Quinones',
       N'BSIT-3A',
       N'Lovesick',
       N'Araw-araw',
       N'Tuwing Wala Sya'),
       (N'Christene Joy Burata',
       N'BSIT-3A',
       N'Broken',
       N'Gabi-gabi',
       N'24 Hours')
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
