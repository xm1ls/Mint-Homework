namespace Chamomile_UI.States
{
    public class AddBrandState
    {
        public event Action? BrandAdded;

        public bool IsAddBrand { get; set; } = false;

        public void AddBrand(bool addBrand)
        {
            IsAddBrand = addBrand;
            BrandAdded?.Invoke();
        }
    }
}
