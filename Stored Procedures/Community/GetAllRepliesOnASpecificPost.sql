

CREATE PROCEDURE GetAllRepliesOnASpecificPost @Post_No int
AS
BEGIN

Select C.Text
from Post_Community as C
where C.Post_No in (
SELECT P.Post_No 
FROM Post_Community as P join Student_Replies_Community_ToAPost as S on P.Post_No=S.Reply_Post_No
WHERE S.Post_No=@Post_No

union

SELECT P.Post_No
FROM Post_Community as P join Sponsor_Replies_Community_ToAPost as S on P.Post_No=S.Reply_Post_No
WHERE S.Post_No=@Post_No

union

SELECT P.Post_No 
FROM Post_Community as P join Doctor_Replies_Community_ToAPost as S on P.Post_No=S.Reply_Post_No
WHERE S.Post_No=@Post_No
)

END
GO