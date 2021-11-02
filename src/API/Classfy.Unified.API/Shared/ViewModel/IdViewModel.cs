namespace Classfy.Unified.API.Shared.ViewModel
{
    internal class IdViewModel
    {
        public IdViewModel(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
