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
using Twilio.TwiML.Voice;

namespace SEN371_Project
{
    internal class API_handler
    {

        
        private static string accountSid = "AC6c4b51395cba5e9e13d2bf434836a67d";
        private static string authToken = "3a1289bb592f3eb23754827da7b76886";
        private static string TwilioNumber = "+18147040246";
        public static void sendMessageClient(string JobID, string Date, string ClientPhone)
        {
            try
            {
                TwilioClient.Init(accountSid, authToken);
                var message = MessageResource.Create(
                    body: string.Format("\n\nA technician has been scheduled for you \nJobID: {0}\nDate: {1}", JobID, Date),
                    from: new Twilio.Types.PhoneNumber("+18147040246"),
                    to: new Twilio.Types.PhoneNumber(ClientPhone)
                );

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        public static void sendMessageEmployee(string JobID, string ClientID, string Date, string EmployeePhone)
        {
            try
            {
                TwilioClient.Init(accountSid, authToken);
                var message = MessageResource.Create(
                    body: string.Format("\n\nYou have been scheduled \nJobID: {0}\nClientID: {1}\nDate: {2}", JobID, ClientID, Date),
                    from: new Twilio.Types.PhoneNumber("+18147040246"),
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

















































/*
private static string accountSid = "AC6c4b51395cba5e9e13d2bf434836a67d";
private static string authToken = "d8e39af46e90ad18261198baee4e80f6";
private static string TwilioNumber = "+18147040246";*/
