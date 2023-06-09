using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using WebApp.Helpers.Repositories;
using WebApp.Helpers.Services;
using WebApp.Models.Entities;
using WebApp.Models.ViewModels;

namespace WebApp.Helpers.Services
{
    public class AuthenticationService
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly AddressService _addressService;

        public AuthenticationService(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, AddressService addressService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _addressService = addressService;
        }

        public async Task<bool> RegisterAsync(RegisterViewModel viewModel)
        {
            try
            {
                //create user
                var result = await _userManager.CreateAsync(viewModel, viewModel.Password);
                if (result.Succeeded)
                {
                    //add user to role
                    var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email);
                    await _userManager.AddToRoleAsync(user!, "user");

                    //create address and add address to user
                    var address = await _addressService.GetOrCreateAsync(viewModel);    
                    return await _addressService.AddUserAddress(user!.Id, address.Id);

                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }



        public async Task<bool> LoginAsync(LoginViewModel viewModel)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);
                return result.Succeeded;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }


        public async Task<bool> LogoutAsync(ClaimsPrincipal user)
        {
            try
            {
                await _signInManager.SignOutAsync();
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }
        
    }
}

//        public async Task<bool> RegisterUserAsync(RegisterViewModel viewModel)
//{
//    try
//    {
//        //create user
//        var result = await _userManager.CreateAsync(viewModel, viewModel.Password);
//        if (result.Succeeded)
//        {
//            //create address
//            var address = await _addressService.GetOrCreateAsync(viewModel);
//            if (address != null)
//            {

//                //add address to user
//                var user = _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email)
//                        if (user != null)
//                {
//                    var userAddress = await _userAddressRepository.AddAsync(new UserAddressEntity
//                    {
//                        UserId = user.Id.ToString(),
//                        AddressId = address.Id,
//                    });

//                    if (userAddress != null)
//                        return true;
//                }

//            }
//        }
//    }
//    catch (Exception ex) { Debug.WriteLine(ex.Message); }
//    return false;
//}
