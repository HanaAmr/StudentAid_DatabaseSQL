using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace StudentAid
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public object CheckDoctorLogIn(string username, string password)
        {
            string StoredProcedureName = StoredProcedures.CheckDoctorLogIn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable CheckStudentLogIn(string username, string password)
        {
            string StoredProcedureName = StoredProcedures.CheckStudentLogIn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }


        public DataTable CheckSponsorLogIn(string username, string password)
        {
            string StoredProcedureName = StoredProcedures.CheckSponsorLogIn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public object GetStudentNameUsingUsername(string username)

        { 
            string StoredProcedureName = StoredProcedures.GetStudentNameByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username); 
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetDoctorNameByUsername(string username)

        {
            string StoredProcedureName = StoredProcedures.GetDoctorNameByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetSponsorNameByUsername(string username)

        {
            string StoredProcedureName = StoredProcedures.GetSponsorNameByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable GetCoursesOfAStudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetCoursesOfAStudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetCoursesWithGradesOfAStudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetCoursesWithGradesOfAStudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public object GetStudentUsernameFromName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetStudentUsernameFromName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable GetTextbookNameLoadedByASpecificStudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetTextbookNameLoadedByASpecificStudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetProjectTeamNameJoinedByASpecificStudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetProjectTeamNameJoinedByASpecificStudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetContestsNameJoinedByASpecificStudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetContestsNameJoinedByASpecificStudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetAcceptedInternshipsOfAStudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetAcceptedInternshipsOfAStudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetPendingInternshipsOfAStudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetPendingInternshipsOfAStudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetAcceptedBusinessIdeasOfAstudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetAcceptedBusinessIdeasOfAstudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetPendingBusinessIdeaOfAStudentByUsername(string username)
        {
            string StoredProcedureName = StoredProcedures.GetPendingBusinessIdeaOfAStudentByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }


        public DataTable GetAllCoursesNameAndNumbers()
        {
            string StoredProcedureName = StoredProcedures.GetAllCoursesNameAndNumbers;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetInfoOfACourseByName(string coursename)
        {
            string StoredProcedureName = StoredProcedures.GetInfoOfACourseByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", coursename);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

         

        }

        public DataTable GetFeedbacksOfASpecificCourseByName(string coursename)
        {
            string StoredProcedureName = StoredProcedures.GetFeedbacksOfASpecificCourseByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", coursename);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public object GetCourseNumberFromCourseName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetCourseNumberFromCourseName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetStudentIDFromName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetStudentIDFromName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int AddCourseToAStudentProfile(string CourseNo, string StudentID)
        {

            string StoredProcedureName = StoredProcedures.AddCourseToAStudentProfile;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Course_No", CourseNo);
            Parameters.Add("@Student_ID", StudentID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        


        public DataTable GetAllInternshipsNamesAndIDs()
        {
            string StoredProcedureName = StoredProcedures.GetAllInternshipsNamesAndIDs;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetAllInfoOfInternshipByName(string name)
        {
            string StoredProcedureName = StoredProcedures.GetAllInfoOfInternshipByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int AddInternshipToAStudentProfile( string StudentID ,string IntNo)
        {

            string StoredProcedureName = StoredProcedures.AddInternshipToAStudentProfile;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Student_ID", StudentID);
            Parameters.Add("@Internship_ID", IntNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetInternshipIDByName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetInternshipIDByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable GetAllTextbooksNamesAndNumbers()
        {
            string StoredProcedureName = StoredProcedures.GetAllTextbooksNamesAndNumbers;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetAllSeminarsNamesAndNumbers()
        {
            string StoredProcedureName = StoredProcedures.GetAllSeminarsNamesAndNumbers;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetAllRPapersNamesAndNumbers()
        {
            string StoredProcedureName = StoredProcedures.GetAllRPapersNamesAndNumbers;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetAllContestsNamesAndNumbers()
        {
            string StoredProcedureName = StoredProcedures.GetAllContestsNamesAndNumbers;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetAllProjectTeamsNameAndNumbers()
        {
            string StoredProcedureName = StoredProcedures.GetAllProjectTeamsNameAndNumbers;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetAllInfoOfTextbookByNumber(string No)
        {
            string StoredProcedureName = StoredProcedures.GetAllInfoOfTextbookByNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Textbook_No", No);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetAllInfoOfSeminarByNumber(string No)
        {
            string StoredProcedureName = StoredProcedures.GetAllInfoOfSeminarByNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Seminar_No", No);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }


        public DataTable GetAllInfoOfRPaperByNumber(string No)
        {
            string StoredProcedureName = StoredProcedures.GetAllInfoOfRPaperByNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RPaper_No", No);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }


        public DataTable GetInfoOfAContestByNumber(string No)
        {
            string StoredProcedureName = StoredProcedures.GetInfoOfAContestByNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Contest_No", No);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }


        public DataTable GetInfoOfAProjectTeamByNumber(string No)
        {
            string StoredProcedureName = StoredProcedures.GetInfoOfAProjectTeamByNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Team_No", No);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int AddTextbookToAStudentProfile(string StudentID, string TextbookNo)
        {

            string StoredProcedureName = StoredProcedures.AddTextbookToAStudentProfile;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Student_ID", StudentID);
            Parameters.Add("@Textbook_No", TextbookNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddContestToAStudentProfile(string StudentID, string ContestNo)
        {

            string StoredProcedureName = StoredProcedures.AddContestToAStudentProfile;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Student_ID", StudentID);
            Parameters.Add("@Contest_No", ContestNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddProjectTeamToAStudentProfile(string StudentID, string teamNo)
        {

            string StoredProcedureName = StoredProcedures.AddProjectTeamToAStudentProfile;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Student_ID", StudentID);
            Parameters.Add("@Team_No", teamNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetEmailOfStudentByName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetEmailOfStudentByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int AddProjectTeam(int teamNo, string TeamName, string description, string TeamLeaderID)
        {
            string StoredProcedureName = StoredProcedures.AddProjectTeam;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Team_No", teamNo);
            Parameters.Add("@Name", TeamName);
            Parameters.Add("@Description", description);
            Parameters.Add("@TeamLeader_ID", TeamLeaderID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddProjectTeamrequirements(int teamNo, string Req)
        {
            string StoredProcedureName = StoredProcedures.AddProjectTeamrequirements;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TeamNo", teamNo);
            Parameters.Add("@Requirements", Req);           
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetCountOfProjectTeam()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfProjectTeam;            
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountOfBusinessIdea()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfBusinessIdea;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int AddBusinessIdeaa(int IdeaNo, string Descrip , int StudID)
        {
            string StoredProcedureName = StoredProcedures.AddBusinessIdeaa;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Idea_No", IdeaNo);
            Parameters.Add("@Description", Descrip);
            Parameters.Add("@Student_ID", StudID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetCountOfFeedback()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfFeedback;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int AddFeedback(int feedbackNo,string CourseNo, int Rate, string descrip)
        {
            string StoredProcedureName = StoredProcedures.AddFeedback;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Feedback_No", feedbackNo);
            Parameters.Add("@Course_No", CourseNo);
            Parameters.Add("@Rating", Rate);
            Parameters.Add("@Description", descrip);           
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddCourses(int CourseNo, string name , string link, int level)
        {
            string StoredProcedureName = StoredProcedures.AddCourses;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Course_No", CourseNo);
            Parameters.Add("@Name", name);
            Parameters.Add("@Link", link);
            Parameters.Add("@Level", level);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddTextbook(int textbookNo, string name, string link, string publisher)
        {
            string StoredProcedureName = StoredProcedures.AddTextbook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Textbook_No", textbookNo);
            Parameters.Add("@Name", name);
            Parameters.Add("@Link", link);
            Parameters.Add("@Publisher", publisher);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddSeminars(int SeminarNo, string name, string link, string presenter)
        {
            string StoredProcedureName = StoredProcedures.AddSeminars;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Seminar_No", SeminarNo);
            Parameters.Add("@Name", name);
            Parameters.Add("@Link", link);
            Parameters.Add("@Presenter", presenter);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddRPapers(int RpaperNo, string name, string link, string publisher)
        {
            string StoredProcedureName = StoredProcedures.AddRPapers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RPaper_No", RpaperNo);
            Parameters.Add("@Name", name);
            Parameters.Add("@Link", link);
            Parameters.Add("@Publisher", publisher);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetCountOfCourses()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfCourses;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountOfTextbook()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfTextbook;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountOfSeminars()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfSeminars;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountOfRPapers()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfRPapers;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountOfContests()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfContests;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountOfInternships()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfInternships;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetSponsorIDFromName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetSponsorIDFromName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int AddInterships(int InternID, string name, string link, string start, string end, string sponsorId)
        {
            string StoredProcedureName = StoredProcedures.AddInterships;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Internship_ID", InternID);
            Parameters.Add("@Name", name);
            Parameters.Add("@Link", link);
            Parameters.Add("@Start", start);
            Parameters.Add("@End", end);
            Parameters.Add("@Sponsor_ID", sponsorId);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddContests(int ContestNo, string name, string link, string loc, string time, string prize, string theme, string sponsorId)
        {
            string StoredProcedureName = StoredProcedures.AddContests;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Contest_No", ContestNo);
            Parameters.Add("@Name", name);
            Parameters.Add("@Link", link);
            Parameters.Add("@Location", loc);
            Parameters.Add("@Time", time);
            Parameters.Add("@Prize", prize);
            Parameters.Add("@Theme", theme);
            Parameters.Add("@Sponsor_ID", sponsorId);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetInternshipsOfASpecificSponsorUsingName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetInternshipsOfASpecificSponsorUsingName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetCoursesOfASpecificDoctorByName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetCoursesOfASpecificDoctorByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public object GetCourseNameFromNumber(string no)

        {
            string StoredProcedureName = StoredProcedures.GetCourseNameFromNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@No", no);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable GetAllStudentsInaSpecificCourseWithGrades(string name)

        {
            string StoredProcedureName = StoredProcedures.GetAllStudentsInaSpecificCourseWithGrades;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddgradeToAStudentInACourse(string DocNo, string StudNo, string CourseNo, string grade)
        {
            string StoredProcedureName = StoredProcedures.AddgradeToAStudentInACourse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DocID", DocNo);
            Parameters.Add("@StudID", StudNo);
            Parameters.Add("@CourseNo", CourseNo);
            Parameters.Add("@Grade", grade);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetUngradedStudentsInASpecificCourse(string coursename)

        {
            string StoredProcedureName = StoredProcedures.GetUngradedStudentsInASpecificCourse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CourseName", coursename);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public object GetDoctorIDFromName(string name)

        {
            string StoredProcedureName = StoredProcedures.GetDoctorIDFromName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable GetAllNonAcceptedBusinessideas()

        {
            string StoredProcedureName = StoredProcedures.GetAllNonAcceptedBusinessideas;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int AcceptStudentBusinessIdeas(string SponsorID, string IdeaNo)
        {
            string StoredProcedureName = StoredProcedures.AcceptStudentBusinessIdeas;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sponsor_ID", SponsorID);
            Parameters.Add("@IdeaNo", IdeaNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllQuestions()

        {
            string StoredProcedureName = StoredProcedures.GetAllQuestions;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int AddPost(int PostNo, string text )
        {
            string StoredProcedureName = StoredProcedures.AddPost;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Post_No", PostNo);
            Parameters.Add("@Text", text);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetCountOfPosts()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfPosts;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int StudentAddPost(string studentID, int postno)
        {
            string StoredProcedureName = StoredProcedures.StudentAddPost;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Student_ID", studentID);
            Parameters.Add("@PostNo", postno);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllRepliesOnASpecificPost(string PostNo)

        {
            string StoredProcedureName = StoredProcedures.GetAllRepliesOnASpecificPost;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Post_No", PostNo);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int StudentAddReply(string studentID, string postno, int ReplyNo)
        {
            string StoredProcedureName = StoredProcedures.StudentAddReply;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Student_ID", studentID);
            Parameters.Add("@PostNo", postno);
            Parameters.Add("@ReplyNo", ReplyNo);        
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SponsorAddReply(string SponsorID, string postno, int ReplyNo)
        {
            string StoredProcedureName = StoredProcedures.SponsorAddReply;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sponsor_ID", SponsorID);
            Parameters.Add("@PostNo", postno);
            Parameters.Add("@ReplyNo", ReplyNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DoctorAddReply(string DocID, string postno, int ReplyNo)
        {
            string StoredProcedureName = StoredProcedures.DoctorAddReply;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_ID", DocID);
            Parameters.Add("@PostNo", postno);
            Parameters.Add("@ReplyNo", ReplyNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetCountReplyPosts_Doctors()

        {
            string StoredProcedureName = StoredProcedures.GetCountReplyPosts_Doctors;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountReplyPosts_Sponsor()

        {
            string StoredProcedureName = StoredProcedures.GetCountReplyPosts_Sponsor;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountReplyPosts_Student()

        {
            string StoredProcedureName = StoredProcedures.GetCountReplyPosts_Student;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public DataTable GetAllAcceptedStudentsInASpecificInternship(string InternID)

        {
            string StoredProcedureName = StoredProcedures.GetAllAcceptedStudentsInASpecificInternship;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Intern_ID", InternID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetAllNonAcceptedStudentsInAnIntern(string InternID)

        {
            string StoredProcedureName = StoredProcedures.GetAllNonAcceptedStudentsInAnIntern;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@InternID", InternID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AcceptStudentIntern(string SponsorID, string StudID, string IntID)
        {
            string StoredProcedureName = StoredProcedures.AcceptStudentIntern;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sponsor_ID", SponsorID);
            Parameters.Add("@Student_ID", StudID);
            Parameters.Add("@IntID", IntID);            
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int StudentChangePassword(string username, string newpass)
        {
            string StoredProcedureName = StoredProcedures.StudentChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Newpass", newpass);          
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DoctorChangePassword(string username, string newpass)
        {
            string StoredProcedureName = StoredProcedures.DoctorChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Newpass", newpass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SponsorChangePassword(string username, string newpass)
        {
            string StoredProcedureName = StoredProcedures.SponsorChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Newpass", newpass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddStudent(int id, string name, string username, string pass,string email)
        {
            string StoredProcedureName = StoredProcedures.AddStudent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Name", name);
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", pass);
            Parameters.Add("@Email", email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddDoctors(int id, string name, string username, string pass, string email)
        {
            string StoredProcedureName = StoredProcedures.AddDoctors;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Name", name);
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", pass);
            Parameters.Add("@Email", email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddSponsors(int id, string name, string username, string pass, string email)
        {
            string StoredProcedureName = StoredProcedures.AddSponsors;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Name", name);
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", pass);
            Parameters.Add("@Email", email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetCountOfDoctors()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfDoctors;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountOfStudent()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfStudent;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object GetCountOfSponsors()

        {
            string StoredProcedureName = StoredProcedures.GetCountOfSponsors;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }



































    }
}
