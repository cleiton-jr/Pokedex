using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokedex.Models;

namespace Pokedex.Services
{
    public interface IPokeService
    {
        List<Pokemon> GetPokemons();
        List<Tipo> GetTipos();
        Pokemon GetPokemon(int Numero);
        PokedexDto GetPokedexDto();
        DetailDto GetDetailedPokemon(int Numero);
        Tipo GetTipo(string Nome);
    }
}