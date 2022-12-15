using Core.ItemFilter;

namespace Core.Model
{
    public class Filter : IEquatable<Filter>
    {
        public TypeCinemaFilter TypeFilter { get; set; } = TypeCinemaFilter.AllCinema;

        public WatchCinemaFilter WatchFilter { get; set; } = WatchCinemaFilter.AllCinema;

        public Filter()
        {
        }

        public Filter(TypeCinemaFilter typeFilter, WatchCinemaFilter watchFilter)
        {
            TypeFilter = typeFilter;
            WatchFilter = watchFilter;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TypeFilter, WatchFilter);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Filter);
        }

        public bool Equals(Filter? other)
        {
            if (other == null)
                return false;

            return TypeFilter == other.TypeFilter && WatchFilter == other.WatchFilter;
        }
    }
}
