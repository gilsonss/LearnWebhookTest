

using controleDeVersaoArquivo.Models;
using Microsoft.EntityFrameworkCore;

namespace controleDeVersaoArquivo.Context;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options) { }

    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
}