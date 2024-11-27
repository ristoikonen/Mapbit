using Mapbit.Abstractions.Queries;
using Mapbit.DTOs;
using Mapbit.Queries;
using System.Drawing;

namespace Mapbit.Handlers
{
    //TODO: Add MediatoR and clarify this Handler + Query
    public class GetMessageHandler : IQuery<GetMessageQuery, MapbitDto> //IQuery<MapbitDto> //IQuery<GetMessageQuery, MapbitDto>
    {
        //private readonly FakeDataStore _fakeDataStore;
        //public GetProductsHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<MapbitDto> Handle(GetMessageQuery request,
            CancellationToken cancellationToken) => /*await*/ new MapbitDto("", "", 0, 0, Color.Black); //_fakeDataStore.GetAllProducts();
    }
}
