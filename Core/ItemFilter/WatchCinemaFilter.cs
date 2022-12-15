using Ardalis.SmartEnum;
using Core.Model.Item;

namespace Core.ItemFilter
{
    public sealed class WatchCinemaFilter : SmartEnum<WatchCinemaFilter>
    {
        private readonly StatusCinema _status;

        public StatusCinema Status => _status;

        public static readonly WatchCinemaFilter AllCinema = new WatchCinemaFilter("All", 0, StatusCinema.Unknown);
        public static readonly WatchCinemaFilter WatchCinema = new WatchCinemaFilter("Watch Cinema", 1, StatusCinema.Watch);
        public static readonly WatchCinemaFilter NotWatchCinema = new WatchCinemaFilter("Not Watch Cinema", 2, StatusCinema.NotWatch);

        private WatchCinemaFilter(string name, int value, StatusCinema status) : base(name, value)
        {
            _status = status;
        }
    }
}
