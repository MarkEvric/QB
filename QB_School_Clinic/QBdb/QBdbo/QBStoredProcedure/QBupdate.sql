CREATE PROCEDURE [dbo].[QBupdate]
    @QBId INT,
    @QBName NVARCHAR(50), 
    @QBGradeYearLevel NVARCHAR(50), 
    @QBReasonForAdmission NVARCHAR(50), 
    @QBDate NVARCHAR(50), 
    @QBTime NVARCHAR(50)
AS
BEGIN
UPDATE[dbo].[QBTable]
set
[QBName]=coalesce(@QBName,[QBName]),
[QBGradeYearLevel]=coalesce(@QBGradeYearLevel,[QBGradeYearLevel]),
[QBReasonForAdmission]=coalesce(@QBReasonForAdmission,[QBReasonForAdmission]),
[QBDate]=coalesce(@QBDate,[QBDate]),
[QBTime]=coalesce(@QBTime,[QBTime])
WHERE [QBId]=@QBId
END
