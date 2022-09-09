using HotelVilla_Utility;
using HotelVilla_Web.Models;
using HotelVilla_Web.Models.Dto;
using HotelVilla_Web.Services.IServices;

namespace HotelVilla_Web.Services
{
	public class AuthService :BaseService, IAuthService
	{
        private readonly IHttpClientFactory _cleintFacotry;
        private string villaUrl;

    public AuthService(IHttpClientFactory cleintFacotry, IConfiguration configuration) : base(cleintFacotry)
    {
        _cleintFacotry = cleintFacotry;
        villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
    }
	
		public Task<T> LoginAsync<T>(LoginRequestDTO obj)
		{
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                Url = villaUrl + "/api/UsersAuth/login"
            });
        }

		public Task<T> RegisterAsync<T>(RegistrationRequestDTO obj)
		{
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                Url = villaUrl + "/api/UsersAuth/register"
            });
        }
	}
}
