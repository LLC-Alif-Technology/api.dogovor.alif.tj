using Domain.Entities;
using System.Data.Entity;

namespace Repository
{
    public class DropDownLists : IDropDownLists
    {
        private readonly AppDbСontext _context;

        public DropDownLists(AppDbСontext context)
        {
            _context = context;
        }

        public async Task<List<Agent>> GetAgent()
        {
            return await _context.Agents.ToListAsync();
        }

        public async Task<List<AgreementConcluder>> GetAgreementConcluder()
        {
            return await _context.AgreementConcluders.ToListAsync();
        }

        public async Task<List<Citizenship>> GetCitizenship()
        {
           return await _context.Citizenships.ToListAsync();
        }

        public async Task<List<City>> GetCityList()
        {
            return await _context.City.ToListAsync();
        }

        public async Task<List<PassportType>> GetPassportType()
        {
            return await _context.PassportTypes.ToListAsync();
        }

        public async Task<List<PartialPaymentOrder>> GetPartialPaymentOrder()
        {
            return await _context.PartialPaymentOrderNames.ToListAsync();
        }

        public async Task<PaymentOrderDTO> GetPaymentOrder()
        {
            return new PaymentOrderDTO
            {
                 PaymentOrder = await _context.PaymentOrders.ToListAsync(),
                 PaymentTerm = await _context.PaymentTerms.ToListAsync()
            };
        }

        public async Task<List<RendedServicesVariations>> GetRendedServicesVariations()
        {
            return await _context.RendedServicesVariations.ToListAsync();
        }

        public async Task<List<Services>> GetService()
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<List<StructuralSubdivision>> GetStructuralSubdivision()
        {
            return await _context.StructuralSubdivisions.ToListAsync();
        }

        public async Task<List<TrustieFoundation>> GetTrustieFoundation()
        {
            return await _context.TrustieFoundations.ToListAsync();
        }

        public async Task<List<ActVariationsOfCompletion>> GetActVariationsOfCompletions()
        {
            return await _context.ActVariationsOfCompletions.ToListAsync();
        }

        public async Task<List<AgreementEntity>> GetAgreementEntities()
        {
            return await _context.AgreementEntities.ToListAsync();
        }
    }
}
