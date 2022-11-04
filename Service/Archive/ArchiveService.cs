namespace Service
{
    public class ArchiveService : IArchiveService
    {
        private readonly IArchiveRepository _archive;

        public ArchiveService(IArchiveRepository archive)
        {
            _archive = archive;
        }

        public async Task<Response> ReturnFile(ReturnFileDTO fileDto, string path, User user)
        {
            try
            {
                //if (!Directory.Exists(path))
                //    Directory.CreateDirectory(path);


                //DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(path);
                //FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + fileDto.GUID + "*.*");
                //string fullName = default;
                //foreach (FileInfo foundFile in filesInDir)
                //{   
                //    var route = foundFile.FullName.Contains("\\") ? foundFile.FullName.Split('\\').ToArray().LastOrDefault().Split(" ").LastOrDefault().Replace(".rtf", "") :
                //                                                     foundFile.FullName.Split('/').ToArray().LastOrDefault().Split(" ").LastOrDefault().Replace(".rtf", "");

                //    if (route == fileDto.GUID)
                //        fullName = foundFile.FullName;
                //}

                ////var fileName = Path.Combine(path, fileDto.ContractName + ".rtf");
                //var output = fullName.Replace(".rtf", "");

                //var fileRoute = ConvertTo(fileDto.format, fullName, output);
                ////var fileRoute = ConvertTo(fileDto.format, fileName, Path.Combine(path, fileDto.ContractName));
                var fullPath = Path.Combine(path, fileDto.file.FileName);
                using (Stream fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                    fileDto.file.CopyTo(fileStream);
                await _archive.ArchivePost(fileDto, fullPath, user);

                LogProvider.GetInstance().Info( new Response { StatusCode = System.Net.HttpStatusCode.OK }.ToString(), "Successfull process!");
                return new Response { StatusCode = System.Net.HttpStatusCode.OK };
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(new Response { StatusCode = System.Net.HttpStatusCode.BadRequest }.ToString(), ex.Message.ToString());
                return null;
            }
        
        }
        //public async Task<Response> ConvertTo(string format, string input, string output)
        //{
        //    string path = default;
        //    try
        //    {
        //        Application application = new Application();
        //        Document doc = application.Documents.Open(input);
        //        if (format.Contains("docx"))
        //        {
        //            output = output.Replace(output.Split(" ").ToArray().LastOrDefault(), "");
        //            doc.SaveAs2(output, WdSaveFormat.wdFormatXMLDocument);
        //            path = String.Concat(output, ".docx");
        //        }
        //        else if (format.Contains("pdf"))
        //        {
        //            output = output.Replace(output.Split(" ").ToArray().LastOrDefault(), "");
        //            doc.SaveAs2(output, WdSaveFormat.wdFormatPDF);
        //            path = String.Concat(output, ".pdf");
        //        }
        //        else if (format.Contains("rtf"))
        //        {
        //            output = output.Replace(output.Split(" ").ToArray().LastOrDefault(), "");
        //            doc.SaveAs2(output, WdSaveFormat.wdFormatRTF);
        //            path = String.Concat(output, ".rtf");
        //        }
        //        doc.Close();
        //        application.Quit();
        //    }
        //    catch (Exception ex)
        //    {
        //        LogProvider.GetInstance().Error(new Response { StatusCode = System.Net.HttpStatusCode.BadRequest, Message = ex.Message }.ToString());
        //        return new Response { StatusCode = System.Net.HttpStatusCode.BadRequest, Message = ex.Message };
        //    }
        //    finally
        //    {
        //        LogProvider.GetInstance().Info(new Response { StatusCode = System.Net.HttpStatusCode.OK }.ToString());
        //    }
        //    return new Response { StatusCode = System.Net.HttpStatusCode.OK, Message = path };
        //}
    }
}
