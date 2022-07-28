
using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.Controllers
{
    public class CreateController : ICreateController
    {
        readonly ICreateInputPort CreateOrderInputPort;
        readonly ICreatePresenter CreateOrderPresenter;

        public CreateController(ICreateInputPort createOrderInputPort, ICreatePresenter createOrderPresenter)
        {
            CreateOrderInputPort = createOrderInputPort;
            CreateOrderPresenter = createOrderPresenter;
        }

        public async ValueTask<int> CreateOrder(CreateDTO createDTO)
        {
            await CreateOrderInputPort.Handle(createDTO);
            return CreateOrderPresenter.Id;
        }
    }
}
