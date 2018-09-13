#r "SendGrid"

using SendGrid.Helpers.Mail;
using System.Text;
using System.Text.RegularExpressions;

public static void Run(string blob, string filename, TraceWriter log, out Mail mail)
{
    var email = Regex.Match(blob, @"^Email\:\ (.+)$", RegexOptions.Multiline).Groups[1].Value;
    
    log.Info($"[EmailLicenceBlobTrigger]");
    log.Info($"Email: {email}, File: {filename}");
    
    var personalisation = new Personalization();
    personalisation.AddTo(new Email(email));

    var bytes = Encoding.UTF8.GetBytes(blob);

    Attachment attach = new Attachment();
    attach.Content = Convert.ToBase64String(bytes);
    attach.Type = "text/plain";
    attach.Filename = "licence.lic";
    attach.Disposition = "attachment";
    attach.ContentId = "Licence File";

    var msg = new Content("text/html", "Your licence file is attached");

    mail = new Mail();
    mail.AddAttachment(attach);
    mail.AddContent(msg);
    mail.AddPersonalization(personalisation);
    mail.Subject = "Thanks for your order";
    mail.From = new Email("mike@test.com");
}
