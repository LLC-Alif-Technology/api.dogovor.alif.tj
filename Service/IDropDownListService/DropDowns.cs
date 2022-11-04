namespace Service.IDropDownListService
{
    public class DropDowns : IDropDowns
    {
        private readonly IDropDownLists _list;

        public DropDowns(IDropDownLists list)
        {
            _list = list;
        }

        public async Task<List<Agent>> GetAgent()
        {
            var lst = new List<Agent>();
            try
            {
                lst = await _list.GetAgent();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<AgreementConcluder>> GetAgreementConcluder()
        {
            var lst = new List<AgreementConcluder>();
            try
            {
                lst = await _list.GetAgreementConcluder();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<Citizenship>> GetCitizenship()
        {
            var lst = new List<Citizenship>();
            try
            {
                lst = await _list.GetCitizenship();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<City>> GetCityList()
        {
            var lst = new List<City>();
            try
            {
                lst = await _list.GetCityList();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<PassportType>> GetPassportTypes()
        {
            var lst = new List<PassportType>();
            try
            {
                lst = await _list.GetPassportType();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<PartialPaymentOrder>> GetPartialPaymentOrder()
        {
            var lst = new List<PartialPaymentOrder>();
            try
            {
                lst = await _list.GetPartialPaymentOrder();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<PaymentOrderDTO> GetPaymentOrder()
        {
            var paymentOrder = new PaymentOrderDTO();
            try
            {
                paymentOrder = await _list.GetPaymentOrder();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return paymentOrder;
        }   

        public async Task<List<RendedServicesVariations>> GetRendedServicesVariations()
        {
            var lst = new List<RendedServicesVariations>();
            try
            {
                lst = await _list.GetRendedServicesVariations();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<Services>> GetService()
        {
            var lst = new List<Services>();
            try
            {
                lst = await _list.GetService();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<StructuralSubdivision>> GetStructuralSubdivision()
        {
            var lst = new List<StructuralSubdivision>();
            try
            {
                lst = await _list.GetStructuralSubdivision();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.OK.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<TrustieFoundation>> GetTrustieFoundation()
        {
            var lst = new List<TrustieFoundation>();
            try
            {
                lst = await _list.GetTrustieFoundation();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of TrustieFoundations");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<ActVariationsOfCompletion>> GetActVariationsOfCompletions()
        {
            var lst = new List<ActVariationsOfCompletion>();
            try
            {
                lst = await _list.GetActVariationsOfCompletions();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }

        public async Task<List<AgreementEntity>> GetAgreementEntities()
        {
            var lst = new List<AgreementEntity>();
            try
            {
                lst = await _list.GetAgreementEntities();
                LogProvider.GetInstance().Info(System.Net.HttpStatusCode.OK.ToString(), "Got the list of Agents");
            }
            catch (Exception ex)
            {
                LogProvider.GetInstance().Error(System.Net.HttpStatusCode.BadRequest.ToString(), ex.Message.ToString());
            }
            return lst;
        }
    }
}
