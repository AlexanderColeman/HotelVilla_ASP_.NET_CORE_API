using HotelVillaAPI.Models;
using HotelVillaAPI.Models.Dto;

namespace HotelVillaAPI.Repository.IRepository
{
	public interface IUserRepository
	{
		bool IsUniqueUser(string username);
		Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
		Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);
	}
}
