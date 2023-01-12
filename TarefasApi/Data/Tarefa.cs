using Dapper.Contrib.Extensions;

namespace TarefasApi.Data;

[Table("Tarefas")]
public record Tarefa(int Id, string Atividade, string Status)
{
}
