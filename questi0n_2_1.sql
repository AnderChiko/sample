/****** Script for SelectTopNRows command from SSMS  ******/
GO

ALTER  PROCEDURE [dbo].[GetScheduledCampaignMessageText]
        @scheduleDate DATE,
        @scheduleTime TIME,
		@searchText NVARCHAR(100)

AS 
BEGIN 

SET NOCOUNT ON

  SELECT C.Code, C.[Name],S.Start_Time,ISNULL(S.Number_Contacts,0)[Number_Contacts],MC.Message_Text  
  FROM  [dbo].[Message] M (NOLOCK)
      INNER JOIN [dbo].[MessageContent] MC (NOLOCK) ON MC.FK_Message = M.Code
      INNER JOIN [dbo].[Campaign] C (NOLOCK) on C.FK_Message =  M.Code
      INNER JOIN [dbo].[Schedule] S (NOLOCK) ON S.FK_Campaign = C.Code
  WHERE S.[Start_Date] = @scheduleDate 
        AND  CAST(S.Start_Time AS VARCHAR(5)) =  CAST(@scheduleTime AS VARCHAR(5))
		AND MC.Message_Text LIKE '%' + @searchText + '%'
  ORDER BY C.[Name], S.Start_Time

END

GO

exec [dbo].[GetScheduledCampaignMessageText] '','',''