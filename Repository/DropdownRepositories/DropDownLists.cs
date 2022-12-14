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
            return  _context.Agents.ToList();
        }

        public async Task<List<AgreementConcluder>> GetAgreementConcluder()
        {
            return  _context.AgreementConcluders.ToList();
        }

        public async Task<List<Citizenship>> GetCitizenship()
        {
           return  _context.Citizenships.ToList();
        }

        public async Task<List<City>> GetCityList()
        {
            return _context.City.ToList();
        }

        public async Task<List<PassportType>> GetPassportType()
        {
            return _context.PassportTypes.ToList();
        }

        public async Task<List<PartialPaymentOrder>> GetPartialPaymentOrder()
        {
            return  _context.PartialPaymentOrderNames.ToList();
        }

        public async Task<PaymentOrderDTO> GetPaymentOrder()
        {
            return new PaymentOrderDTO
            {
                 PaymentOrder =  _context.PaymentOrders.ToList(),
                 PaymentTerm =  _context.PaymentTerms.ToList()
            };
        }

        public async Task<List<RendedServicesVariations>> GetRendedServicesVariations()
        {
            return  _context.RendedServicesVariations.ToList();
        }

        public async Task<List<Services>> GetService()
        {
            return  _context.Services.ToList();
        }

        public async Task<List<StructuralSubdivision>> GetStructuralSubdivision()
        {
            return  _context.StructuralSubdivisions.ToList();
        }

        public async Task<List<TrustieFoundation>> GetTrustieFoundation()
        {
            return  _context.TrustieFoundations.ToList();
        }

        public async Task<List<ActVariationsOfCompletion>> GetActVariationsOfCompletions()
        {
            return  _context.ActVariationsOfCompletions.ToList();
        }

        public async Task<List<AgreementEntity>> GetAgreementEntities()
        {
            return  _context.AgreementEntities.ToList();
        }
    }
}
