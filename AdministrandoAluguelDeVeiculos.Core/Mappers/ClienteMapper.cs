using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Mappers;

public static class ClienteMapper
{
    public static ClienteViewModel ToViewModel(this Cliente cliente)
    {
        return new ClienteViewModel(
            cliente.IdCliente,
            cliente.ClienteNome,
            cliente.ClienteEmail,
            cliente.ClienteContato);
    }
}