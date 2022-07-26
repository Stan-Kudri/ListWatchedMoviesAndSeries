using System.Text.Json.Serialization;

namespace ListWatchedMoviesAndSeries.Models.Item
{
    public class WatchDetail
    {
        private const string WatchCinema = "+";
        private const string NotWatchCinema = "-";

        [JsonPropertyName("DateWatch")]
        public DateTime? DateWatch { get; set; }

        [JsonPropertyName("Grade")]
        public string? Grade { get; set; } = null;

        [JsonIgnore]
        public string Watch => DateWatch == null ? NotWatchCinema : WatchCinema;

        public WatchDetail()
        {
        }

        public WatchDetail(DateTime? dateWatch, decimal? grade) : this(dateWatch, dateWatch != null ? grade.ToString() : string.Empty)
        {
        }

        private WatchDetail(DateTime? dateWatch, string? grade)
        {
            Grade = grade;
            DateWatch = dateWatch;
        }

        public string GetWatchData() => DateWatch?.ToString("dd.MM.yyyy") ?? string.Empty;

        public bool ValidDateField() => DateWatch != null && Watch == WatchCinema;

        public override int GetHashCode()
        {
            return HashCode.Combine(DateWatch, Grade, Watch);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WatchDetail);
        }

        public bool Equals(WatchDetail? other)
        {
            if (other == null)
                return false;

            return Watch == other.Watch
                && DateWatch == other.DateWatch
                && Grade == other.Grade;
        }

        public WatchDetail Clone() => new WatchDetail(DateWatch, Grade);
    }
}
