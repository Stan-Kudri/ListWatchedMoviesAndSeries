using Ardalis.SmartEnum;
using ListWatchedMoviesAndSeries.Models.Item;

namespace Core.ItemFilter
{
    public sealed class TypeCinemaFilter : SmartEnum<TypeCinemaFilter>
    {
        private readonly TypeCinema _typeCinema = TypeCinema.Unknown;

        public TypeCinema Type => _typeCinema;

        public static readonly TypeCinemaFilter AllCinema = new TypeCinemaFilter("All Cinema", 0, TypeCinema.Unknown);
        public static readonly TypeCinemaFilter Movie = new TypeCinemaFilter("Movie", 1, TypeCinema.Movie);
        public static readonly TypeCinemaFilter Series = new TypeCinemaFilter("Series", 2, TypeCinema.Series);
        public static readonly TypeCinemaFilter Anime = new TypeCinemaFilter("Anime", 3, TypeCinema.Anime);
        public static readonly TypeCinemaFilter Cartoon = new TypeCinemaFilter("Cartoon", 4, TypeCinema.Cartoon);

        private TypeCinemaFilter(string name, int value, TypeCinema typeCinema) : base(name, value)
        {
            _typeCinema = typeCinema;
        }
    }
}
