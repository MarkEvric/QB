CREATE PROCEDURE [dbo].[QBcreate]
    @QBName NVARCHAR(50), 
    @QBGradeYearLevel NVARCHAR(50), 
    @QBReasonForAdmission NVARCHAR(50), 
    @QBDate NVARCHAR(50), 
    @QBTime NVARCHAR(50)
AS
BEGIN
INSERT INTO[dbo].[QBTable]
(QBName,QBGradeYearLevel,QBReasonForAdmission,QBDate,QBTime)
VALUES(@QBName,
       @QBGradeYearLevel,
       @QBReasonForAdmission,
       @QBDate,
       @QBTime)
END
