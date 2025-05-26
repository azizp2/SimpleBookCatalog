using Microsoft.JSInterop;
using SimpleBookCatalog.Application.Interfaces;

namespace SimpleBookCatalog.Infrastructure.Services
{
    public class SweetAlertService: ISweetAlertService
    {
        private readonly IJSRuntime _js;
        public SweetAlertService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<bool> ConfirmDeleteAsync(string itemName)
        {
            return await _js.InvokeAsync<bool>("showDeleteConfirm", itemName);
        }
    }
}
