using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Q_Network.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[Route("")]
        //public ActionResult MainPage()
        //{
        //    var session = _httpcontextaccessor.HttpContext.Session;
        //    string key_access = _config.GetValue<string>("Access_session");
        //    string json = session.GetString(key_access);
        //    if (json != null)
        //    {
        //        var user = JsonConvert.DeserializeObject<User>(json);
        //        if (user != null)
        //        {
        //            ViewBag.CurrentUser = 1;
        //        }
        //    }
        //    List<Question> listQuestion = new List<Question>();
        //    using (SqlConnection con = new SqlConnection(Startup.connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("GetListQuestion", con))
        //        {
        //            {
        //                try
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    con.Open();
        //                    SqlDataReader dr = cmd.ExecuteReader();

        //                    while (dr.Read())
        //                    {
        //                        Question question = new Question();
        //                        question.QuestionID = dr.IsDBNull("QuestionID") == true ? 0 : (int)dr["QuestionID"];
        //                        question.QuestionTitle = dr.IsDBNull("QuestionTitle") == true ? "" : (string)dr["QuestionTitle"];
        //                        question.QuestionBody = dr.IsDBNull("QuestionBody") == true ? "" : (string)dr["QuestionBody"];
        //                        question.QuestionTimeAbout = dr.IsDBNull("QuestionTime") == true ? null : Multis.Multis.DateToStringAbout((DateTime?)dr["QuestionTime"]);

        //                        question.Vote = dr.IsDBNull("Vote") == true ? 0 : (int)dr["Vote"];
        //                        question.answer = dr.IsDBNull("Answer") == true ? 0 : (int)dr["Answer"];
        //                        question.View = dr.IsDBNull("Views") == true ? 0 : (int)dr["Views"];
        //                        question.User = new User();
        //                        question.listTag = new List<Tag>();
        //                        question.User.ProfileImg = dr.IsDBNull("ProfileImg") == true ? "" : (string)dr["ProfileImg"];
        //                        question.User.UserName = dr.IsDBNull("UserName") == true ? "" : (string)dr["UserName"];
        //                        listQuestion.Add(question);
        //                    }



        //                }
        //                catch (Exception e)
        //                {
        //                    throw e;
        //                }

        //                con.Close();
        //            }


        //        }
        //        return View(listQuestion);
        //    }

        //}
        //}
    } 
}
