using ListWatchedMoviesAndSeries.Models.Item;

namespace EqualsTest
{
    public class EqualsWatchDetailTest
    {
        [Theory]
        [InlineData(2000, 10, 10, 8)]
        [InlineData(2022, 7, 19, 6)]
        public void Equals_Two_Element_With_Same_Fields(int year, int month, int day, int grade)
        {
            // Arrange
            var firstWatch = new WatchDetail(
                                    new DateTime(year, month, day),
                                    grade);

            var secondWatch = new WatchDetail(
                                    new DateTime(year, month, day),
                                    grade);

            // Act
            var comparison = firstWatch.Equals(secondWatch);

            // Assert
            Assert.True(comparison);
        }

        [Theory]
        [InlineData(2000, 10, 10, 8)]
        [InlineData(2022, 7, 19, 6)]
        public void Equals_Two_Element_Not_With_Same_Fields(int year, int month, int day, int grade)
        {
            // Arrange
            var firstWatch = new WatchDetail(
                                    new DateTime(year, month, day),
                                    grade);

            var newDay = (day - 1) > 0 ? day - 1 : day + 1;
            var secondWatch = new WatchDetail(
                                    new DateTime(year, month, newDay),
                                    grade);

            // Act
            var comparison = firstWatch.Equals(secondWatch);

            // Assert
            Assert.False(comparison);
        }

        [Theory]
        [InlineData(2000, 10, 10, 8)]
        [InlineData(2022, 7, 19, 6)]
        public void Non_Equality_Of_Two_Elements_With_One_Non_Identical_Null_Field(int year, int month, int day, int grade)
        {
            // Arrange
            var firstWatch = new WatchDetail(
                                    new DateTime(year, month, day),
                                    grade);

            var secondWatch = new WatchDetail(
                                    new DateTime(year, month, day),
                                    null);

            // Act
            var comparison = firstWatch.Equals(secondWatch);

            // Assert
            Assert.False(comparison);
        }

        [Theory]
        [InlineData(2000, 10, 10)]
        [InlineData(2022, 7, 19)]
        public void Equality_Two_Elements_With_Null_Field(int year, int month, int day)
        {
            // Arrange
            var firstWatch = new WatchDetail(
                                    new DateTime(year, month, day),
                                    null);

            var secondWatch = new WatchDetail(
                                    new DateTime(year, month, day),
                                    null);

            // Act
            var comparison = firstWatch.Equals(secondWatch);

            // Assert
            Assert.True(comparison);
        }

        [Fact]
        public void Compare_Elements_With_Null_Object()
        {
            // Arrange
            var watchDetail = new WatchDetail(
                                    new DateTime(2000, 10, 10),
                                    7);

            var nullDetail = (WatchDetail?)null;

            // Act
            var comparison = watchDetail.Equals(nullDetail);

            // Assert
            Assert.False(comparison);
        }
    }
}
