using System.Text.Json.Serialization;
using Ardalis.SmartEnum.SystemTextJson;
using ListWatchedMoviesAndSeries.Models.Item;

namespace ListWatchedMoviesAndSeries.Models
{
    public class WatchItem
    {
        public const int NumberTypeAllCinema = 0;
        public const int NumberTypeMove = 1;
        public const int NumberTypeSeries = 2;

        public const string WatchCinema = "+";
        public const string NotWatchCinema = "-";

        private Guid _id;

        [JsonPropertyName("Id")]
        public Guid? Id
        {
            get => _id;
            set => _id = (Guid)value;
        }

        [JsonPropertyName("Name")]
        public string? Name { get; set; } = null;

        [JsonPropertyName("Detail")]
        public WatchDetail? Detail { get; set; } = null;

        [JsonPropertyName("Type")]
        [JsonConverter(typeof(SmartEnumValueConverter<TypeCinema, int>))]
        public TypeCinema? Type { get; set; } = null;

        [JsonPropertyName("NumberSequel")]
        public decimal? NumberSequel { get; set; } = null;

        public WatchItem()
        {
        }

        public WatchItem(string name, decimal? numberSequel, TypeCinema? type) : this(name, numberSequel, null, null, type, Guid.NewGuid().ToString())
        {
        }

        public WatchItem(string name, decimal? numberSequel, TypeCinema? type, string Id) : this(name, numberSequel, null, null, type, Id)
        {
        }

        public WatchItem(string name, decimal? numberSequel, DateTime? date, decimal? grade, TypeCinema? type) : this(name, numberSequel, date, grade, type, Guid.NewGuid().ToString())
        {
        }

        public WatchItem(string name, decimal? numberSequel, DateTime? date, decimal? grade, TypeCinema? type, string Id)
        {
            if (name == null)
                throw new ArgumentException("Name cinema not null", "Exception");

            _id = Id != string.Empty ? Guid.Parse(Id) : Guid.NewGuid();
            Name = name;
            Detail = new WatchDetail(date, grade);
            NumberSequel = numberSequel;
            Type = type != null ? type : TypeCinema.Unknown;
        }

        public string GetView() => Detail?.DateWatch == null ? NotWatchCinema : WatchCinema;

        public string GetTypeSequel() => Type == TypeCinema.Movie ? TypeCinema.Movie.Name : TypeCinema.Series.Name;

        public void InstallationType(int numberType)
        {
            if (numberType == NumberTypeMove)
                Type = TypeCinema.Movie;
            else if (numberType == NumberTypeSeries)
                Type = TypeCinema.Series;
            else
                Type = TypeCinema.Unknown;
        }
    }
}