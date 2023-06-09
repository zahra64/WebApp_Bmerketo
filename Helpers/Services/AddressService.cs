using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using WebApp.Helpers.Repositories;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Services;

public class AddressService
{
    private readonly AddressRepository _addressRepository;
    private readonly UserAddressRepository _useraddressRepository;

    public AddressService(AddressRepository addressRepository, UserAddressRepository useraddressRepository)
    {
        _addressRepository = addressRepository;
        _useraddressRepository = useraddressRepository;
    }

    public async Task<AddressEntity> GetOrCreateAsync(AddressEntity entity)
    {
        var _entity = await _addressRepository.GetAsync(x => x.StreetName == entity.StreetName && x.PostalCode == entity.PostalCode && x.City == entity.City);
        if (_entity == null)
            _entity = await _addressRepository.AddAsync(entity);
        return _entity;
    }

    public async Task<bool> AddUserAddress (string userId, int addressId)
    {
        try
        {
            var entity = await _useraddressRepository.AddAsync(new UserAddressEntity
            {
                UserId = userId,
                AddressId = addressId
            });

            if (entity != null)
                return true;

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}
