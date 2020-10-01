using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DoctorsLogic
    {
        DAL.Doctors dal = new DAL.Doctors();
        public string InsertDoctors(Doctor d)
        {
            dal.InsertDoctors(d);
            MailMessage mail;
            SmtpClient smtp;
            //sending mail
            mail = new MailMessage();
            string mailAdress = d.Email;
            mail.To.Add(mailAdress);
            mail.From = new MailAddress("medical333@gmail.com");
            mail.Subject = " Welcome to medical website! ";
            mail.Body ="Hi "+ d.FirstName+ " Welcome to medical website!" + "<br/>" + "<br/>" + "Here is your login information" + "<br/>" + "<br/>" + "User Name: " +d.UserName + 
                "<br/>" +"Password: "+ d.Password;
            mail.IsBodyHtml = true;
            smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("medicalproject333@gmail.com", "medical333");
            string localPath = System.AppDomain.CurrentDomain.BaseDirectory.Substring(0, System.AppDomain.CurrentDomain.BaseDirectory.Length - 11);
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);
                string message = "הרופא נוסף בהצלחה";
                return message;
            }
            catch
            {
                string message = "משהו השתבש בשליחת המייל :(";
                return message;
            }
            //try
            //{
            //    mail.To.Clear();
            //    mail.To.Add(senderMail);
            //    mail.Subject = "תודה על פנייתך לזכרון מנחם:)";
            //    mail.Body = "פנייתך בנושא" + ": " + subject + ", " + " התקבלה בהצלחה!";
            //    smtp.Send(mail);
            //}
            //catch
            //{
            //    ViewBag.Message = "משהו השתבש בשליחת המייל:(";
            //}
        }
        public void RemoveDoctors(int id)
        {
            dal.RemoveDoctors(id);
        }
        public void UpdateDoctors(Doctor doc, int id)
        {
            dal.UpdateDoctors(doc, id);
        }
        public IEnumerable<Doctor> GetDoctors()
        {
            return dal.GetDoctors();
        }
        public Doctor returnDoctor(User user)
        {
            return dal.returnDoctor(user);
        }
    }
}


