#pragma warning disable CA2227

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Simkl history container.
    /// </summary>
    public class SimklHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimklHistory"/> class.
        /// </summary>
        public SimklHistory()
        {
            Movies = new List<SimklMovie>();
            Shows = new List<SimklShow>();
            Episodes = new List<SimklEpisode>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimklHistory"/> class.
        /// </summary>
        /// <param name="movies">A list of movies included in the history. Cannot be null.</param>
        /// <param name="shows">A list of shows included in the history. Cannot be null.</param>
        /// <param name="episodes">A list of episodes included in the history. Cannot be null.</param>
        [JsonConstructor]
        public SimklHistory(List<SimklMovie> movies, List<SimklShow> shows, List<SimklEpisode> episodes)
        {
            Movies = movies;
            Shows = shows;
            Episodes = episodes;
        }

        /// <summary>
        /// Gets or sets list of movies.
        /// </summary>
        [JsonPropertyName("movies")]
        public List<SimklMovie> Movies { get; set; }

        /// <summary>
        /// Gets or sets the list of shows.
        /// </summary>
        [JsonPropertyName("shows")]
        public List<SimklShow> Shows { get; set; }

        /// <summary>
        /// Gets or sets the list of episodes.
        /// </summary>
        [JsonPropertyName("episodes")]
        public List<SimklEpisode> Episodes { get; set; }
    }
}