using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace MovieTime
{
    class Program
    {
        private const string TimeFormat = @"hh\:mm\:ss";
        static void Main(string[] args)
        {
            var movies = new Dictionary<string, List<KeyValuePair<string,TimeSpan>>>();
            string wifesFavGenre = Console.ReadLine();
            string favDuration = Console.ReadLine();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "POPCORN!")
            {
                string[] input = command.Split('|');

                string name = input[0];
                string genre = input[1];
                string duration = input[2];

                if (!movies.ContainsKey(genre))
                {
                    movies[genre] = new List<KeyValuePair<string, TimeSpan>>();


                }
                TimeSpan movieDuration = TimeSpan.ParseExact(input[2], TimeFormat, CultureInfo.InvariantCulture);

                var movie = new KeyValuePair<string, TimeSpan>
                    (name, movieDuration);
                movies[genre].Add(movie);
            }
            bool prefersShortMovie = favDuration == "Short";
            var potentialMovies = movies[wifesFavGenre]
                .OrderBy(x => prefersShortMovie ? x.Value : -x.Value)
                .ThenBy(x => x.Key)
                .ToArray();

            int index = -1;
            string reaction = "No";

            while (reaction != "Yes")
            {
                index++;
                Console.WriteLine(potentialMovies[index].Key);

                reaction = Console.ReadLine();
            }
            string chosenMovie = potentialMovies[index].Key;
            string chosenMovieDuration = potentialMovies[index].Value
                .ToString(TimeFormat,CultureInfo.CurrentCulture);

            Console.WriteLine($"We're watching {chosenMovie} - {chosenMovieDuration}");
            long totalPlaylistTicks = movies.Sum(genre => genre.Value.Sum(
                movie => movie.Value.Ticks));
            TimeSpan totalTimeSpan = new TimeSpan(totalPlaylistTicks);
            string totalPlaylistDuration = totalTimeSpan.ToString
                (TimeFormat, CultureInfo.CurrentCulture);

            Console.WriteLine($"Total Playlist Duration: {totalPlaylistDuration}");
        }

        
    }
}
