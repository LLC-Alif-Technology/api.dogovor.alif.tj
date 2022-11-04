namespace api.dogovor.alif.tj.Controllers
{
    public class ListsController : ControllerBase
    {
        private readonly IDropDowns _list;

        public ListsController(IDropDowns list)
        {
            _list = list;
        }

        /// <summary>
        /// Выберите агента
        /// </summary>
        [HttpGet("AgentList")]
        public async Task<IActionResult> GetAgentList()
        {
            return Ok(await _list.GetAgent());
        }

        /// <summary>
        /// Договор заключает
        /// </summary>
        [HttpGet("AgreementConcluderList")]
        public async Task<IActionResult> GetAgreementConcluderList()
        {
            return Ok(await _list.GetAgreementConcluder());
        }

        /// <summary>
        /// Гражданство получателя
        /// </summary>
        [HttpGet("CitizenshipList")]
        public async Task<IActionResult> CitizenshipList()
        {
            return Ok(await _list.GetCitizenship());
        }

        /// <summary>
        /// Место заключения
        /// </summary>
        [HttpGet("CitiesList")]
        public async Task<IActionResult> CitiesList()
        {
            return Ok(await _list.GetCityList());
        }

        /// <summary>
        /// Оплата в порядке частями
        /// </summary>
        [HttpGet("PartialPaymentOrderList")]
        public async Task<IActionResult> PartialPaymentOrderList()
        {
            return Ok(await _list.GetPartialPaymentOrder());
        }

        /// <summary>
        /// Документ контрагента
        /// </summary>
        [HttpGet("PassportTypesList")]
        public async Task<IActionResult> PassportTypesList()
        {
            return Ok(await _list.GetPassportTypes());
        }

        /// <summary>
        /// Порядок оплаты налично
        /// </summary>
        [HttpGet("PaymentOrdersList")]
        public async Task<IActionResult> GetPaymentOrdersList()
        {
            return Ok(await _list.GetPaymentOrder());
        }

        [HttpGet("RendedServicesVariationsList")]
        public async Task<IActionResult> GetRendedServicesVariationsList()
        {
            return Ok(await _list.GetRendedServicesVariations());
        }


        /// <summary>
        /// Предмет договора
        /// </summary>
        [HttpGet("ServiceList")]
        public async Task<IActionResult> GetServiceList()
        {
            return Ok(await _list.GetService());
        }

        /// <summary>
        /// Варианты результатов оказанных услуг
        /// </summary>
        [HttpGet("GetAgreementEntities")]
        public async Task<IActionResult> GetAgreementEntities()
        {
            return Ok(await _list.GetAgreementEntities());
        }

        /// <summary>
        /// О структурном подразделении Банка, которое заключает договор
        /// </summary>
        [HttpGet("StructuralSubdivisionList")]
        public async Task<IActionResult> GetStructuralSubdivisionList()
        {
            return Ok(await _list.GetStructuralSubdivision());
        }

        //[HttpGet("GetAgreementConcluder")]
        //public async Task<IActionResult> GetAgreementConcluder()
        //{
        //    return Ok(await _list.GetAgreementConcluder());
        //}


        ///// <summary>
        ///// Договор заключает
        ///// </summary>
        //[HttpGet("AgreementEntitiesList")]
        //public async Task<IActionResult> GetAgreementEntitiesList()
        //{
        //    return Ok(await _list.GetAgreementEntities());
        //}

    }
}
