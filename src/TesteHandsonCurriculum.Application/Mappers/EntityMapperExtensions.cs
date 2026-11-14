using System.Collections.Generic;
using System.Linq;
using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Application.Mappers
{
    public static class EntityMapperExtensions
    {
        public static ArmaViewModel ToViewModel(this Arma entity)
        {
            if (entity == null) return null;
            return new ArmaViewModel
            {
                ArmaCod = entity.ArmaCod,
                ArmaNome = entity.ArmaNome
            };
        }

        public static IEnumerable<ArmaViewModel> ToViewModel(this IEnumerable<Arma> entities)
        {
            return entities?.Select(e => e.ToViewModel()).ToList() ?? Enumerable.Empty<ArmaViewModel>();
        }

        public static Arma ToDomain(this ArmaViewModel viewModel)
        {
            if (viewModel == null) return null;
            return new Arma
            {
                ArmaCod = viewModel.ArmaCod,
                ArmaNome = viewModel.ArmaNome
            };
        }

        public static LocalViewModel ToViewModel(this Local entity)
        {
            if (entity == null) return null;
            return new LocalViewModel
            {
                LocalCod = entity.LocalCod,
                LocalNome = entity.LocalNome
            };
        }

        public static IEnumerable<LocalViewModel> ToViewModel(this IEnumerable<Local> entities)
        {
            return entities?.Select(e => e.ToViewModel()).ToList() ?? Enumerable.Empty<LocalViewModel>();
        }

        public static Local ToDomain(this LocalViewModel viewModel)
        {
            if (viewModel == null) return null;
            return new Local
            {
                LocalCod = viewModel.LocalCod,
                LocalNome = viewModel.LocalNome
            };
        }

        public static SuspeitoViewModel ToViewModel(this Suspeito entity)
        {
            if (entity == null) return null;
            return new SuspeitoViewModel
            {
                SuspeitoCod = entity.SuspeitoCod,
                SuspeitoNome = entity.SuspeitoNome
            };
        }

        public static IEnumerable<SuspeitoViewModel> ToViewModel(this IEnumerable<Suspeito> entities)
        {
            return entities?.Select(e => e.ToViewModel()).ToList() ?? Enumerable.Empty<SuspeitoViewModel>();
        }

        public static Suspeito ToDomain(this SuspeitoViewModel viewModel)
        {
            if (viewModel == null) return null;
            return new Suspeito
            {
                SuspeitoCod = viewModel.SuspeitoCod,
                SuspeitoNome = viewModel.SuspeitoNome
            };
        }
    }
}
