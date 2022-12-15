using Ardalis.SmartEnum;

namespace Core.Model.Item
{
    public class StatusCinema : SmartEnum<StatusCinema>
    {
        public static readonly StatusCinema Unknown = new StatusCinema("Umknown", 0);
        public static readonly StatusCinema Watch = new StatusCinema("Watch", 1);
        public static readonly StatusCinema NotWatch = new StatusCinema("Not Watch", 2);

        private StatusCinema(string name, int value) : base(name, value)
        {
        }
    }
}
