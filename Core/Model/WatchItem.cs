using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using Core.Model.Item;
using ListWatchedMoviesAndSeries.Models.Item;

namespace ListWatchedMoviesAndSeries.Models
{
    public class WatchItem : IEquatable<WatchItem>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public WatchDetail Detail { get; set; }

        [JsonPropertyName("TypeCinema")]
        public TypeCinema Type { get; set; }

        [JsonPropertyName("StatusCinema")]
        public StatusCinema Status { get; set; }

        public decimal? NumberSequel { get; set; }

        // EF core
        private WatchItem() : this(string.Empty, null, StatusCinema.Unknown, TypeCinema.Unknown, null, new WatchDetail())
        {
        }

        public WatchItem(string name, decimal? numberSequel, StatusCinema status, TypeCinema type, Guid? id, WatchDetail detail)
        {
            Id = id ?? Guid.NewGuid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Detail = detail;
            NumberSequel = numberSequel;
            Type = type;
            Status = status;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Detail, Status, Type, NumberSequel);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WatchItem);
        }

        public bool Equals(WatchItem? other)
        {
            if (other == null)
                return false;

            return Id == other.Id
                && Name == other.Name
                && Detail.Equals(other.Detail)
                && Status == other.Status
                && Type == other.Type
                && NumberSequel == other.NumberSequel;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });
        }
    }
}
