namespace Repository.ArchievumRepositories
{
    public interface IArchiveRepository
    {
        public Task<Archive> ArchivePost(ReturnFileDTO dto, string path, User user);
    }
}
    