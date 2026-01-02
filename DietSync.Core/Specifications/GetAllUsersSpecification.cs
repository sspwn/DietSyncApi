using DietSync.Core.Entities.Filters;
using DietSync.Core.Entities;
using System.Linq.Expressions;

namespace DietSync.Core.Specifications
{
    public class GetAllUsersSpecification : BaseSpecification<User>
    {
        public GetAllUsersSpecification(UserFilter filter)
        {
            if (!string.IsNullOrWhiteSpace(filter.Name))
                AddCriteria(u => u.Name.Contains(filter.Name));

            if (!string.IsNullOrWhiteSpace(filter.Email))
                AddCriteria(u => u.Email == filter.Email);

            if (!string.IsNullOrWhiteSpace(filter.Sexo))
                AddCriteria(u => u.Sexo == filter.Sexo);

            if (!string.IsNullOrWhiteSpace(filter.Meta))
                AddCriteria(u => u.Meta == filter.Meta);

            if (filter.Peso > 0)
                AddCriteria(u => u.Peso == filter.Peso);

            if (filter.Altura > 0)
                AddCriteria(u => u.Altura == filter.Altura);

            //AddInclude(u => u.Treinos);
            //AddInclude(u => u.Dietas);
            //AddInclude(u => u.Evolucoes);
            //AddInclude(u => u.Receitas);
        }
    }
}
