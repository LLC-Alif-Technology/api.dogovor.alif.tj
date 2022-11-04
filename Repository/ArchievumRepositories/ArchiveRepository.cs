using AutoMapper;
using Repository.Mapper;

namespace Repository.ArchievumRepositories
{
    public class ArchiveRepository : IArchiveRepository
    {
        private readonly AppDbСontext _context;
        private readonly IMapper _mapper;

        public ArchiveRepository(AppDbСontext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Archive> ArchivePost(ReturnFileDTO dto, string path, User user)
        {
            var map = _mapper.Map<Archive>(dto);
            map.ExecutorsFullName = String.Concat(user.FirstName, " ", user.LastName);
            map.FilePath = path;    map.ExecutorsEmail = user.EmailAddress;
            map.DocumentType = dto.ContractName;

            await _context.Archives.AddAsync(map);
            await _context.SaveChangesAsync();
            return map;
        }
    } 
}
