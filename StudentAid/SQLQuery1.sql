select (count(D.Reply_Post_No) + count(S.Reply_Post_No)+ count(T.Reply_Post_No)) as sum
from Doctor_Replies_Community_ToAPost as D , Sponsor_Replies_Community_ToAPost as S, Student_Replies_Community_ToAPost as T

where D.Reply_Post_No= 
group by D.Reply_Post_No


