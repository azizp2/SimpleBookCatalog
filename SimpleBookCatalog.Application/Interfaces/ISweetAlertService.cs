namespace SimpleBookCatalog.Application.Interfaces
{
    public interface ISweetAlertService
    {
        Task<bool> ConfirmDeleteAsync(string itemName);
    }
}
