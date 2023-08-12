using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using MailKit;
using MimeKit;
using System.Windows.Forms;
using Twilio.TwiML.Messaging;

namespace SEN371_Project
{
    internal class API_handler
    {

        public static void sendMessageClient(string JobID, string Date, string ClientPhone)
        {
            try
            {
                string accountSid = "SID_HERE";
                string authToken = "TOKEN_HERE";


                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: string.Format("\n\nA technician has been scheduled for you\nJobID: {0}\nDate: {1}}", JobID, Date),
                    from: new Twilio.Types.PhoneNumber("INSER YOUR TWILIO NUMBER HERE"),
                    to: new Twilio.Types.PhoneNumber(ClientPhone)
                );

            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Error");
            }

        }

        public static void sendMessageEmployee(string JobID, string ClientID, string Date, string EmployeePhone)
        {
            try
            {
                string accountSid = "SID_HERE";
                string authToken = "TOKEN_HERE";


                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: string.Format("\n\nYou have been scheduled \nJobID: {0}\nClient: {1}\nDate: {2}", JobID, ClientID, Date),
                    from: new Twilio.Types.PhoneNumber("INSERT_TWILIO_PROVIDED_NUMBER_HERE"),
                    to: new Twilio.Types.PhoneNumber(EmployeePhone)
                );

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }

        }

    }
}
