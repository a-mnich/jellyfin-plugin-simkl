using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Simkl movie ids.
    /// </summary>
    public class SimklMovieIds : SimklIds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimklMovieIds"/> class.
        /// </summary>
        /// <param name="providerMovieIds">the provider movie ids.</param>
        public SimklMovieIds(Dictionary<string, string> providerMovieIds)
            : base(providerMovieIds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimklMovieIds"/> class with the specified external service
        /// identifiers.
        /// </summary>
        /// <param name="mal">The MyAnimeList (MAL) identifier for the movie. Can be <see langword="null"/> if not applicable.</param>
        /// <param name="hulu">The Hulu identifier for the movie. Can be <see langword="null"/> if not applicable.</param>
        /// <param name="crunchyroll">The Crunchyroll identifier for the movie. Can be <see langword="null"/> if not applicable.</param>
        /// <param name="moviedb">The Movie Database (TMDb) identifier for the movie. Can be <see langword="null"/> if not applicable.</param>
        [JsonConstructor]
        public SimklMovieIds(int? mal, int? hulu, int? crunchyroll, string? moviedb)
        {
            Mal = mal;
            Hulu = hulu;
            Crunchyroll = crunchyroll;
            Moviedb = moviedb;
        }

        /// <summary>
        /// Gets or sets the mal id.
        /// </summary>
        [JsonPropertyName("mal")]
        public int? Mal { get; set; }

        /// <summary>
        /// Gets or sets the hulu id.
        /// </summary>
        [JsonPropertyName("hulu")]
        public int? Hulu { get; set; }

        /// <summary>
        /// Gets or sets the crunchyroll id.
        /// </summary>
        [JsonPropertyName("crunchyroll")]
        public int? Crunchyroll { get; set; }

        /// <summary>
        /// Gets or sets the movie db id.
        /// </summary>
        [JsonPropertyName("moviedb")]
        public string? Moviedb { get; set; }
    }
}