

using APIAlura.Entity;
using APIAlura.Interfaces;
using System.Data.SqlClient;

namespace APIAlura.Repository
{
    public class UsuarioRepository : DapperRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public override void Cadastrar(Usuario entidade)
        {
           
        }

        public override void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Editar(Usuario entidade)
        {
             using (var dbConnection = new SqlConnection(ConnectionString))
            {
                var query = " UPDATE Usuario Set Nome = @Nome WHERE Id = @Id";
                dbConnection.Query(query, entidade);
            }
        }

        public override Usuario ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override IList<Usuario> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
