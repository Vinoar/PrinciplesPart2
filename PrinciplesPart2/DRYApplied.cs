using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

/*
 Use Case Overview:

Our use case involves the automated sending of emails under specific conditions. Whenever user details are saved or updated in the database, an email should be sent to the Admin Team. In case of any exceptions during this process, the Tech Support Team should also be notified via email. Similarly, when an order is placed, the Admin Team should be informed to initiate order processing, and any exceptions related to orders should trigger an email notification to the Tech Support Team.
mplementing the DRY Principle:

We've taken steps to adhere to the DRY (Don't Repeat Yourself) principle in our codebase. To achieve this, we've introduced a new class called "EmailUtil." This class is responsible for handling email sending operations through a static method called "SendWithMailMessage." This method accepts a parameter of type MailMessage for email content and delivery.

By adopting this approach, we've successfully reduced code duplication in our existing business logic. This change not only enhances maintainability but also aligns with the Single Responsibility Principle (SRP). Furthermore, we're working towards extending this design to support the Open-Closed Principle (OCP) and the Interface Segregation Principle (ISP) in the future.
 
 */
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
