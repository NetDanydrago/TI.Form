

namespace TI.Form.Presenters
{
    public class CreatePresenter : ICreatePresenter
    {
        public int Id { get; private set; }

        public ValueTask Handle(int id)
        {
            Id = id;
            return ValueTask.CompletedTask;
        }
    }
}
