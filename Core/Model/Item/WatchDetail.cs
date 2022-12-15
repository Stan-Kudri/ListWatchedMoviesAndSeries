using System.Text.Json.Serialization;

namespace ListWatchedMoviesAndSeries.Models.Item
{
    public class WatchDetail : IEquatable<WatchDetail>
    {
        [JsonPropertyName("DateWatch")]
        public DateTime? DateWatch { get; set; }

        [JsonPropertyName("Grade")]
        public string? Grade { get; set; } = null;

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

        public bool HasWatchDate() => DateWatch != null;

        public override int GetHashCode()
        {
            return HashCode.Combine(DateWatch, Grade);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WatchDetail);
        }

        public bool Equals(WatchDetail? other)
        {
            if (other == null)
                return false;

            return DateWatch == other.DateWatch
                && Grade == other.Grade;
        }

        public WatchDetail Clone() => new WatchDetail(DateWatch, Grade);
    }
}
