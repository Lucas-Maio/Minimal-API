using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidade;

namespace Minimal_API.Dominio.Entidades.Interfaces
{
    public interface IVeiculoServico
    {
        List<Veiculo> Todos(int? pagina, string? nome = null, string? marca = null);
        Veiculo? BuscaPorId(int id);
        void Atualizar(Veiculo veiculo);
        void Apagar(Veiculo veiculo);
        void Incluir(Veiculo veiculo);
    }
}