using Synopsis.Models;

namespace Synopsis.Api.MockData
{
    public class MockMovieCategories
    {
        private List<MovieCategory> _categories;

        public MockMovieCategories()
        {
            _categories = new List<MovieCategory>()
            {
                new MovieCategory(1, "Action"),
                new MovieCategory(2, "Drama"),
                new MovieCategory(3, "Sci-Fi")
            };

        }

        public List<MovieCategory> GetMockMovieCategories()
        {
            return _categories;
        }

        public MovieCategory GetMovieCategory(int id)
        {
            var category = _categories.Find(c => c.Id == id);
            if (category == null)
            {
                return null;
            }

            return category;
        }

        public MovieCategory GetMovieCategory(string name)
        {
            var category = _categories.Find(c => c.Name.ToLower() == name.ToLower());
            if (category == null)
            {
                return null;
            }

            return category;
        }


    }
}
