using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Dominio.Entidade;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;

namespace MinimalApi.Dominio.Entidades.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
        Administrador? Incluir(Administrador administrador);
        List<Administrador> Todos(int? pagina);
        Administrador? BuscaPorId(int id);
    }
}