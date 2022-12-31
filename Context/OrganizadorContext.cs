using Microsoft.EntityFrameworkCore;
using trilha_net_MVC_desafio_Entity.Models;

namespace trilha_net_MVC_desafio_Entity.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}