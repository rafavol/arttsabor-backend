using ArttSabor.Domain.Entities;
using ArttSabor.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArttSabor.Persistence.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {

        public async Task<List<Categoria>> Get()
        {
            List<Categoria> categorias = new List<Categoria>();

            for (int i = 1; i <= 10; i++)
            {
                Categoria categoria = new Categoria
                {
                    Id = i,
                    Nome = $"Categoria {i}"
                };
                categorias.Add(categoria);
            }
            return categorias;
        }
    }
}
