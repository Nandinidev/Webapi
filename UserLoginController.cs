using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnlineExam.Models;
using OnlineExam.VClasses;
using System.Data.Entity;
using System.Web.Http.Cors;

namespace OnlineExam.Controllers
{
    // [RoutePrefix("Api/login")]
    [EnableCors(origins:"http://localhost:4200",headers:"*",methods:"*")]
    public class UserLoginController : ApiController
    {

        OnlinexamEntities1 entities1 = new OnlinexamEntities1();
        [Route("api/UserLogin/InsertUser")]

        [HttpPost]
        public object InsertUser(Register register)
        {
            try 
            {
                tblUser user = new tblUser();
                user.Full_Name = register.Full_Name;
                user.Email = register.Email;
                user.Mobile_Number = register.Mobile_Number;
                user.Date_of_Birth = register.Date_of_Birth;
                user.City = register.City;
                user.State = register.State;
                user.Qualification = register.Qualification;
                user.Year_of_Completion = register.Year_of_Completion;
                entities1.tblUsers.Add(user);
                entities1.SaveChanges();
                return new Response
                {
                    Status = "Success", Message = "Record SuccessFully Saved."
                };
            }
            catch
            {
                throw;
            }
            return new Response
            {
                Status = "invalid",
                Message = "Record not saved."
            };

        }
        // [Route("Login")]
        [HttpPost]
        public Response Userlogin(Login login)
        {
            OnlinexamEntities1 entities1 = new OnlinexamEntities1();
            proLoginCheck_Result result = entities1.proLoginCheck(login.Email, login.Pwd).FirstOrDefault();

            if (result == null)
            {
                return new Response { Status = "Invalid", Message = "Invalid User." };
            }
            else
            {
                return new Response { Status = "Success", Message = "Login Successfully" };
            }

        }

    }
}
