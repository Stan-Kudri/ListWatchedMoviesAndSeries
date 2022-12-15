using Core.Model.Item;
using ListWatchedMoviesAndSeries.Models.Item;

namespace ListWatchedMoviesAndSeries.Models
{
    public class CinemaModel : ModelBase
    {
        private Guid _id;
        private string _name;
        private WatchDetail _detail;
        private TypeCinema _type;
        private decimal? _numberSequel;
        private StatusCinema _status;

        public CinemaModel(string name, decimal? numberSequel, StatusCinema status, TypeCinema type)
            : this(name, numberSequel, null, null, status, type, Guid.NewGuid())
        {
        }

        public CinemaModel(string name, decimal? numberSequel, StatusCinema status, TypeCinema type, Guid? id)
            : this(name, numberSequel, null, null, status, type, id)
        {
        }

        public CinemaModel(string name, decimal? numberSequel, DateTime? date, decimal? grade, StatusCinema status, TypeCinema type)
            : this(name, numberSequel, date, grade, status, type, Guid.NewGuid())
        {
        }

        public CinemaModel(string name, decimal? numberSequel, DateTime? date, decimal? grade, StatusCinema status, TypeCinema type, Guid? id)
        {
            _id = id ?? Guid.NewGuid();
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _detail = new WatchDetail(date, grade);
            _numberSequel = numberSequel;
            _type = type;
            _status = status;
        }

        public Guid Id
        {
            get => _id;
            set => SetField(ref _id, value);
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public WatchDetail Detail
        {
            get => _detail;
            set => SetField(ref _detail, value);
        }

        public TypeCinema Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        public StatusCinema Status
        {
            get => _status;
            set => SetField(ref _status, value);
        }

        public decimal? NumberSequel
        {
            get => _numberSequel;
            set => SetField(ref _numberSequel, value);
        }

        public WatchItem ToWatchItem()
        {
            return new WatchItem(Name, NumberSequel, Status, Type, Id, Detail.Clone());
        }
    }
}
