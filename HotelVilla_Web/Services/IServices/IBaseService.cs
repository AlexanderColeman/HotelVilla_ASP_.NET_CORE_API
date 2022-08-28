using HotelVilla_Web.Models;

namespace HotelVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse reponseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
