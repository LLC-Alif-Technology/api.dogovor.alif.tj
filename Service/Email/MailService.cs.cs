using Domain.Enum;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Service;
//using System.Net.Mail;

namespace Repository.Email
{
    public class MailService : IMailService
    {
        private readonly MailAppParams _settings;

        public MailService(IOptions<MailAppParams> options)
        {
            _settings = options.Value;
        }

        public async Task<Response> SendEmailAsync(MailParameters dto, ExecutionWay method)
        {
            try
            {   
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_settings.Mail);
                email.To.Add(MailboxAddress.Parse(dto.toEmail));
                var builder = new BodyBuilder();

                if (method.Equals(ExecutionWay.SendFile))
                {
                    var finalPath = Path.Combine(dto.FilePath, dto.file.FileName);
                    using (Stream fileStream = new FileStream(finalPath, FileMode.Create, FileAccess.Write))
                        dto.file.CopyTo(fileStream);

                    builder.Attachments.Add(finalPath);
                }
                #region
                //if (path != "" && path != null)
                //{

                //    DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(path);
                //    FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*.*");
                //    string fullPath = default;

                //    var route = String.Empty;
                //    foreach (FileInfo foundFile in filesInDir)
                //    {
                //        route = foundFile.FullName.Contains("\\") ? foundFile.FullName.Split('\\').ToArray().LastOrDefault().Split(" ").LastOrDefault().Replace(".rtf", "") :
                //                                                         foundFile.FullName.Split('/').ToArray().LastOrDefault().Split(" ").LastOrDefault().Replace(".rtf", "");

                //        if (route == dto.GUID)
                //            fullPath = foundFile.FullName;
                //    }

                //    var fileName = fullPath.Split("\\").ToArray().LastOrDefault().Replace(dto.GUID,"").Replace(".rtf","");
                //    //var fileRemovedExtention = Path.Combine(path, fileName);

                //    //var convertFile = await _archiveService.ConvertTo("pdf", fullPath, fileRemovedExtention);

                //    fullPath = path.Replace("rtf", "pdf");
                //    var filePath = path.Split('/').ToArray().LastOrDefault().Split('\\').LastOrDefault();

                //    if (dto.Subject == "")
                //        email.Subject = fileName;

                //    DirectoryInfo directory = new DirectoryInfo(fullPath);
                //    foreach (FileInfo files in directory.GetFiles(fileName + ".pdf"))
                //    {
                //        if (files.Exists)
                //        {
                //            builder.Attachments.Add(files.FullName);
                //        }
                //    }
                //}
                //else


                //using (Stream fileStream = new FileStream(dto.FilePath, FileMode.OpenOrCreate))
                //{
                //    await dto.file.CopyToAsync(fileStream);
                //    //builder.Attachments.Add(file.FileName);
                //}
                //foreach (IFormFile file in dto.file)
                //{
                //    if (file.Length > 0)
                //    {
                //        string filePath = Path.Combine(Path, file.FileName);
                //        using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                //        {
                //            file.CopyTo(fileStream);
                //        }
                //    }
                //}
                #endregion

                
                email.Subject = dto.Subject;
                builder.HtmlBody = dto.htmlBody;
                email.Body = builder.ToMessageBody();

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect(_settings.Host, _settings.Port, SecureSocketOptions.StartTls);
                    smtp.Authenticate(_settings.Mail, _settings.Password);
                    await smtp.SendAsync(email);
                    smtp.Disconnect(true);
                }

                return new Response { StatusCode = System.Net.HttpStatusCode.OK };
            }
            catch (Exception ex)
            {
                return new Response { StatusCode = System.Net.HttpStatusCode.BadRequest, Message = ex.Message.ToString() };
            }
        }
    }
}
