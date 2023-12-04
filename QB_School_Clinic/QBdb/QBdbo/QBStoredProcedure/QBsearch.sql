CREATE PROCEDURE [dbo].[QBsearch]
	@QBkeyword NVARCHAR(50)
AS
BEGIN
SELECT
[QBId] as QBId,
[QBName] as QBName,
[QBGradeYearLevel] as QBGradeYearLevel,
[QBReasonForAdmission] as QBReasonForAdmission,
[QBDate] as QBDate,
[QBTime] as QBTime

FROM[dbo].[QBTable]WHERE
[QBId] like @QBkeyword or
[QBName] like @QBkeyword or
[QBGradeYearLevel] like @QBkeyword or
[QBReasonForAdmission] like @QBkeyword or
[QBDate] like @QBkeyword or
[QBTime] like @QBkeyword 
ORDER BY [QBName]
END
