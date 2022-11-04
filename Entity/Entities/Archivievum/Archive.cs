namespace Domain.Entities.Archivievum
{
    public class Archive
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ContractName { get; set; }
        public string ExecutorsEmail { get; set; }
        public string ExecutorsFullName { get; set; }
        public string DocumentType { get; set; }
        public string FilePath { get; set; }
    }
}
        