using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

/*
 Use Case Overview:

Our use case involves the automated sending of emails under specific conditions. 
Whenever user details are saved or updated in the database, an email should be sent to the Admin Team. In case of any exceptions during this process, 
the Tech Support Team should also be notified via email. Similarly, when an order is placed, the Admin Team should be informed to initiate order processing,
and any exceptions related to orders should trigger an email notification to the Tech Support Team.

Challenges:

One significant issue we face is redundancy in our codebase. For each of these business logic scenarios, we've written separate code segments to send emails.
This redundancy has led to a total of 14 lines of code, and the duplication percentage exceeds 100%.

 */
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
