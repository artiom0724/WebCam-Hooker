﻿using System;
using System.Net.Mail;

namespace WebCam
{
    class EmailManager
    {
        private readonly SmtpClient _smtpClient;
        private const string Sender = "artiom0724@gmail.com";
        private const string Password = "xtkjdtr1998";

        private const string Host = "smtp.gmail.com";
        private const int Port = 587;

        public EmailManager()
        {
            _smtpClient = new SmtpClient(Host, Port)
            {
                Credentials = new System.Net.NetworkCredential(Sender, Password),
                EnableSsl = true
            };
        }

        public void SendEmail(string receiver, string topic, string filePath)
        {
            try
            {
                var mail = new MailMessage(Sender, receiver, topic, string.Empty);
                using (var attachment = new Attachment(filePath))
                {
                    mail.Attachments.Add(attachment);
                    _smtpClient.Send(mail);
                }
            }catch (Exception)
            {}
        }
    }
}
