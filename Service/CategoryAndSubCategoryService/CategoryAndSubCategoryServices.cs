using DocumentFormat.OpenXml.Packaging;
using Microsoft.AspNetCore.Http;
using OpenXmlPowerTools;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace Service.ContractServices
{
    public class CategoryAndSubCategoryServices : ICategoryAndSubCategoryServices
    {
        private readonly ICategoryAndSubCategoryRepository _subCategoryRepository;
        private readonly IArchiveService _archiveService;

        public CategoryAndSubCategoryServices(ICategoryAndSubCategoryRepository subCategoryRepository, IArchiveService archiveService)
        {
            _subCategoryRepository = subCategoryRepository;
            _archiveService = archiveService;
        }

        public async Task<Response> CreateCategory(string categoryName)
        {
            try
            {
                var category = await _subCategoryRepository.CreateCategory(categoryName);
                if(category == null)
                    return new Response { StatusCode = System.Net.HttpStatusCode.BadRequest };
               return new Response { StatusCode = System.Net.HttpStatusCode.OK };
            }
            catch (Exception ex)
            {
                return new Response { StatusCode = System.Net.HttpStatusCode.BadRequest, Message = ex.Message  };
            }
        }

        public async Task<Response> CreateSubCategory(SubCategoryDTO dto, string path)
        {
            Semaphore semaphore = new Semaphore(1,1);
            SubCategory subCategory = new SubCategory();
            try
            {
                semaphore.WaitOne();

                string filePath = Path.Combine(path, dto.form.FileName);

                if (!Directory.Exists(path))
                      Directory.CreateDirectory(path);

                var rtfFile = filePath.Replace("docx", "rtf");
                var textFile = filePath.Replace("docx", "txt");

                using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    dto.form.CopyTo(fileStream);


                var htmlText = ConvertIntoHtml(filePath, rtfFile);
  
                //if (File.Exists(filePath))
                //     File.Delete(filePath);

                subCategory = await _subCategoryRepository.CreateSubCategory(dto.SubCategoryName, htmlText, dto.CategoryId);


                if (File.Exists(textFile)) File.Delete(textFile);
                if (File.Exists(filePath))   File.Delete(filePath);
  

                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Successfull process!");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
                return new Response { StatusCode = System.Net.HttpStatusCode.BadRequest, Message = ex.Message };
            }
            finally
            {
                semaphore.Release();
            }
            return new Response { StatusCode = System.Net.HttpStatusCode.OK, Message = subCategory.Id.ToString() };
        }

       
        private string ConvertIntoHtml(string filePath, string fileName)
        {
            FileStream fileStreamPath = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var savefilePath = fileName;
            string strContents = default;
            using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Html))
            {
                MemoryStream stream = new MemoryStream();
                document.Save(stream, FormatType.Html);

                document.Close();
                document.Dispose();
                stream.Position = 0;
                using (Stream fileStream = new FileStream(savefilePath, FileMode.Create, FileAccess.Write))
                    stream.CopyTo(fileStream);

                using (StreamReader sr = System.IO.File.OpenText(savefilePath))
                {
                    strContents = sr.ReadToEnd();
                    sr.Close();
                    sr.Dispose();
                }
                fileStreamPath.Close();
                fileStreamPath.Dispose();
                System.IO.File.Delete(savefilePath);
            }
            return strContents;
        }


        public async Task<Response> GetSubCategory(int Id)
        {
            try
            {
                var subcategory = await _subCategoryRepository.GetSubCategory(Id);
                if (subcategory != null)
                {
                    LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Successfull process!");
                    return new Response { StatusCode = System.Net.HttpStatusCode.OK, Message = subcategory.SampleInstance };
                }
                else return new Response { StatusCode = System.Net.HttpStatusCode.NotFound };
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
                return new Response { StatusCode = System.Net.HttpStatusCode.BadRequest, Message = ex.Message };
            }
        }

        public async Task<Response> GetSubCategoryFile(int Id)
        {
            var fileString = await _subCategoryRepository.GetSubCategoryFile(Id);
            if(fileString == null)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), "File not found!");
                return new Response { StatusCode = System.Net.HttpStatusCode.NotFound, Message = "Sub Category not found! Is it hidin' Somewhere?" };
            }
            LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Successfull process!");
            return new Response { StatusCode = System.Net.HttpStatusCode.OK, Message = fileString };
        }

        public async Task<Response> ReceiveFinalText(string rtfText, string contractName, string path)
        {
            var mutex = new Mutex();
            try
            {
                mutex.WaitOne();

                if (!Directory.Exists(path))  
                    Directory.CreateDirectory(path);

                var directoryInfo = new DirectoryInfo(path);
                FileInfo[] files = directoryInfo.GetFiles($"{contractName}.rtf")
                                     .Where(p => p.Extension == ".rtf").ToArray();
                foreach (var file in files)
                    try
                    {
                        file.Attributes = FileAttributes.Normal;
                        File.Delete(file.FullName);
                    }
                    catch 
                    {
                        LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString());
                        return new Response { StatusCode = System.Net.HttpStatusCode.BadRequest };
                    }
                
                var guid = Guid.NewGuid();

                var fileName = Path.Combine(path, $"{contractName} {guid}.txt");
                if (File.Exists(fileName))
                    File.Delete(fileName);

                var fileStream = File.Create(fileName);
                fileStream.Dispose();

                using (var writer = File.AppendText(fileName))
                    writer.WriteLine(rtfText);

                File.Move(fileName, Path.ChangeExtension(fileName, ".rtf"));

                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Successfull process!");
                return new Response { StatusCode = System.Net.HttpStatusCode.OK, Message = fileName.Replace("txt","rtf"), GuidId = guid.ToString()};
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString());
                return new Response { StatusCode = System.Net.HttpStatusCode.BadRequest, Message = ex.Message };
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
