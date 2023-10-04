using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesPart2.DRYNotApplied
{

    public class UserModel
    {
        // USER PROPERTIES
    }
    public class OrderModel
    {
        // ORDER PROPERTIES
    }
    public class UserBusinessLogic
    {
        public UserBusinessLogic()
        {

        }

        public void SaveUpdateUserDetails(UserModel userModel)
        {
            try
            {
                // Save or Update User details in the Database.

                // Send Mail to Admin
                MailMessage mailMessage = new MailMessage("noreply@system.com", "admin@system.com");
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MailMessage mailMessage = new MailMessage("issueoccured@system.com", "support@system.com");
                mailMessage.Body = ex.Message;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Send(mailMessage);
            }
        }
    }
    public class OrderBusinessLogic
    {
        public OrderBusinessLogic()
        {

        }
        public void OrderUpdate(OrderModel orderModel)
        {
            try
            {
                // Update details in the Database.

                // Send Mail to Admin
                MailMessage mailMessage = new MailMessage("noreply@system.com", "admin@system.com","Order Placed","");
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MailMessage mailMessage = new MailMessage("issueoccured@system.com", "support@system.com");
                mailMessage.Body = ex.Message;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Send(mailMessage);
            }
        }
    }
}
