using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesPart2.DRYApplied
{
    public class UserModel
    {
        // USER PROPERTIES
    }
    public class OrderModel
    {
        // ORDER PROPERTIES
    }

    public class EmailUtil
    {
        public static void SendWithMailMessage(MailMessage message)
        {
            SmtpClient smtpClient = new SmtpClient("",587);
            smtpClient.Send(message);
        }
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
                EmailUtil.SendWithMailMessage(new MailMessage("noreply@system.com", "admin@system.com","",""));
                
            }
            catch (Exception ex)
            {
                EmailUtil.SendWithMailMessage(new MailMessage("issueoccured@system.com", "support@system.com")); 
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
                EmailUtil.SendWithMailMessage(new MailMessage("noreply@system.com", "admin@system.com", "Order Placed", ""));
               
            }
            catch (Exception ex)
            {
                EmailUtil.SendWithMailMessage(new MailMessage("issueoccured@system.com", "support@system.com"));
            }
        }
    }
}
