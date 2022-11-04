namespace IDropDownListService
{
    public interface IDropDowns
    {
        public Task<List<City>> GetCityList();
        public Task<List<StructuralSubdivision>> GetStructuralSubdivision();
        public Task<List<TrustieFoundation>> GetTrustieFoundation();
        public Task<List<Citizenship>> GetCitizenship();
        public Task<List<PassportType>> GetPassportTypes();
        public Task<List<AgreementConcluder>> GetAgreementConcluder();
        public Task<List<Services>> GetService();
        public Task<PaymentOrderDTO> GetPaymentOrder();   
        public Task<List<PartialPaymentOrder>> GetPartialPaymentOrder();
        public Task<List<Agent>> GetAgent();
        public Task<List<RendedServicesVariations>> GetRendedServicesVariations();
        public Task<List<ActVariationsOfCompletion>> GetActVariationsOfCompletions();
        public Task<List<AgreementEntity>> GetAgreementEntities();
    }
}
