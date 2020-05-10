using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentAid
{
    public class StoredProcedures
    {
        public static string CheckDoctorLogIn = "CheckDoctorLogIn";
        public static string CheckSponsorLogIn = "CheckSponsorLogIn";
        public static string CheckStudentLogIn = "CheckStudentLogIn";
        public static string GetStudentNameByUsername = "GetStudentNameByUsername";
        public static string GetDoctorNameByUsername = "GetDoctorNameByUsername";
        public static string GetSponsorNameByUsername = "GetSponsorNameByUsername";
        public static string GetStudentUsernameFromName = "GetStudentUsernameFromName";
        public static string GetCoursesOfAStudentByUsername = "GetCoursesOfAStudentByUsername";
        public static string GetCoursesWithGradesOfAStudentByUsername = "GetCoursesWithGradesOfAStudentByUsername";
        public static string GetTextbookNameLoadedByASpecificStudentByUsername = "GetTextbookNameLoadedByASpecificStudentByUsername";
        public static string GetProjectTeamNameJoinedByASpecificStudentByUsername = "GetProjectTeamNameJoinedByASpecificStudentByUsername";
        public static string GetContestsNameJoinedByASpecificStudentByUsername = "GetContestsNameJoinedByASpecificStudentByUsername";
        public static string GetAcceptedInternshipsOfAStudentByUsername = "GetAcceptedInternshipsOfAStudentByUsername";
        public static string GetPendingInternshipsOfAStudentByUsername = "GetPendingInternshipsOfAStudentByUsername";
        public static string GetAcceptedBusinessIdeasOfAstudentByUsername = "GetAcceptedBusinessIdeasOfAstudentByUsername";
        public static string GetPendingBusinessIdeaOfAStudentByUsername = "GetPendingBusinessIdeaOfAStudentByUsername";
        public static string GetAllCoursesNameAndNumbers = "GetAllCoursesNameAndNumbers";
        public static string GetInfoOfACourseByName = "GetInfoOfACourseByName1";
        public static string GetFeedbacksOfASpecificCourseByName = "GetFeedbacksOfASpecificCourseByNumber";
        public static string GetCourseNumberFromCourseName = "GetCourseNumberFromCourseName";
        public static string GetStudentIDFromName = "GetStudentIDFromName";
        public static string AddCourseToAStudentProfile = "AddCourseToAStudentProfile";
        public static string GetAllInternshipsNamesAndIDs = "GetAllInternshipsNamesAndIDs";
        public static string GetAllInfoOfInternshipByName = "GetAllInfoOfInternshipByName";
        public static string AddInternshipToAStudentProfile = "AddInternshipToAStudentProfile";
        public static string GetInternshipIDByName = "GetInternshipIDByName";
        public static string GetAllTextbooksNamesAndNumbers = "GetAllTextbooksNamesAndNumbers";
        public static string GetAllSeminarsNamesAndNumbers = "GetAllSeminarsNamesAndNumbers";
        public static string GetAllRPapersNamesAndNumbers = "GetAllRPapersNamesAndNumbers";
        public static string GetAllContestsNamesAndNumbers = "GetAllContestsNamesAndNumbers";
        public static string GetAllProjectTeamsNameAndNumbers = "GetAllProjectTeamsNameAndNumbers";
        public static string GetAllInfoOfTextbookByNumber = "GetAllInfoOfTextbookByNumber";
        public static string GetAllInfoOfSeminarByNumber = "GetAllInfoOfSeminarByNumber";
        public static string GetAllInfoOfRPaperByNumber = "GetAllInfoOfRPaperByNumber";
        public static string GetInfoOfAContestByNumber = "GetInfoOfAContestByNumber";
        public static string GetInfoOfAProjectTeamByNumber = "GetInfoOfAProjectTeamByNumber";
        public static string AddTextbookToAStudentProfile = "AddTextbookToAStudentProfile";
        public static string AddContestToAStudentProfile = "AddContestToAStudentProfile";
        public static string AddProjectTeamToAStudentProfile = "AddProjectTeamToAStudentProfile";
        public static string GetEmailOfStudentByName = "GetEmailOfStudentByName";
        public static string AddProjectTeam = "AddProjectTeam";
        public static string AddProjectTeamrequirements = "AddProjectTeamrequirements";
        public static string GetCountOfProjectTeam = "GetCountOfProjectTeam";
        public static string GetCountOfBusinessIdea = "GetCountOfBusinessIdea";
        public static string AddBusinessIdeaa = "AddBusinessIdeaa";
        public static string AddFeedback = "AddFeedback";
        public static string GetCountOfFeedback = "GetCountOfFeedback";
        public static string AddCourses = "AddCourses";
        public static string AddTextbook = "AddTextbook";
        public static string AddSeminars = "AddSeminars";
        public static string AddRPapers = "AddRPapers";
        public static string GetCountOfCourses = "GetCountOfCourses";
        public static string GetCountOfTextbook = "GetCountOfTextbook";
        public static string GetCountOfSeminars = "GetCountOfSeminars";
        public static string GetCountOfRPapers = "GetCountOfRPapers";
        public static string AddInterships = "AddInterships";
        public static string GetSponsorIDFromName = "GetSponsorIDFromName";
        public static string GetCountOfInternships = "GetCountOfInternships";
        public static string GetCountOfContests = "GetCountOfContests";
        public static string AddContests = "AddContests";
        public static string GetInternshipsOfASpecificSponsorUsingName = "GetInternshipsOfASpecificSponsorUsingName";
        public static string GetCoursesOfASpecificDoctorByName = "GetCoursesOfASpecificDoctorByName";
        public static string GetCourseNameFromNumber = "GetCourseNameFromNumber";
        public static string GetAllStudentsInaSpecificCourseWithGrades = "GetAllStudentsInaSpecificCourseWithGrades";
        public static string AddgradeToAStudentInACourse = "AddgradeToAStudentInACourse";
        public static string GetUngradedStudentsInASpecificCourse = "GetUngradedStudentsInASpecificCourse";
        public static string GetDoctorIDFromName = "GetDoctorIDFromName";
        public static string GetAllNonAcceptedBusinessideas = "GetAllNonAcceptedBusinessideas";
        public static string AcceptStudentBusinessIdeas = "AcceptStudentBusinessIdeas";
        public static string GetAllQuestions = "GetAllQuestions";
        public static string AddPost = "AddPost";
        public static string GetCountOfPosts = "GetCountOfPosts";
        public static string StudentAddPost = "StudentAddPost";
        public static string GetAllRepliesOnASpecificPost = "GetAllRepliesOnASpecificPost";
        public static string StudentAddReply = "StudentAddReply";
        public static string SponsorAddReply = "SponsorAddReply";
        public static string DoctorAddReply = "DoctorAddReply";
        public static string GetCountReplyPosts_Doctors = "GetCountReplyPosts_Doctors";
        public static string GetCountReplyPosts_Sponsor = "GetCountReplyPosts_Sponsor";
        public static string GetCountReplyPosts_Student = "GetCountReplyPosts_Student";
        public static string GetAllAcceptedStudentsInASpecificInternship = "GetAllAcceptedStudentsInASpecificInternship";
        public static string GetAllNonAcceptedStudentsInAnIntern = "GetAllNonAcceptedStudentsInAnIntern";
        public static string AcceptStudentIntern = "AcceptStudentIntern";
        public static string StudentChangePassword = "StudentChangePassword";
        public static string DoctorChangePassword = "DoctorChangePassword";
        public static string SponsorChangePassword = "SponsorChangePassword";
        public static string AddStudent = "AddStudent";
        public static string AddDoctors = "AddDoctors";
        public static string AddSponsors = "AddSponsors";
        public static string GetCountOfDoctors = "GetCountOfDoctors";
        public static string GetCountOfStudent = "GetCountOfStudent";
        public static string GetCountOfSponsors = "GetCountOfSponsors";

        
            
            
            
            
            











        ///application.exitThread()



























    }
}
