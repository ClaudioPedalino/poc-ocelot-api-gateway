using electronic_api.Models;
using shared;
using System.Collections.Generic;

namespace electronic_api.Interfaces
{
    public interface IPhoneService
    {
        Result Create(PhoneCommand request);

        IEnumerable<PhoneQueryResult> GetAll();
    }
}