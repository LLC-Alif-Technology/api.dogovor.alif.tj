

namespace Domain.Entities
{
    public class ArchivePostDto
    {
        public string ContractName { get; set; }
        public string DocumentName { get; set; }
        public string format { get; set; }  
        public string GUID { get; set; }
        public string path { get; set; }
        public Domain.User.User user { get; set; }
    }
}   
