using fashion_api.Models;
using shared;
using System.Collections.Generic;

namespace fashion_api.Interfaces
{
    public interface IFashionServices
    {
        IEnumerable<FashionQueryResult> GetAll();

        Result Create(FashionCommand request);
    }
}