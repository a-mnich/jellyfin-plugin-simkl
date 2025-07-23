using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Simkl show ids.
    /// </summary>
    public class SimklShowIds : SimklIds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimklShowIds"/> class.
        /// </summary>
        /// <param name="providerMovieIds">The provider movie ids.</param>
        public SimklShowIds(Dictionary<string, string> providerMovieIds)
            : base(providerMovieIds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimklShowIds"/> class with the specified external service
        /// identifiers.
        /// </summary>
        /// <param name="mal">The MyAnimeList (MAL) identifier for the show. Can be <see langword="null"/> if not applicable.</param>
        /// <param name="hulu">The Hulu identifier for the show. Can be <see langword="null"/> if not applicable.</param>
        /// <param name="crunchyroll">The Crunchyroll identifier for the show. Can be <see langword="null"/> if not applicable.</param>
        /// <param name="zap2It">The Zap2It identifier for the show. Can be <see langword="null"/> if not applicable.</param>
        public SimklShowIds(int? mal, int? hulu, int? crunchyroll, string? zap2It)
        {
            Mal = mal;
            Hulu = hulu;
            Crunchyroll = crunchyroll;
            Zap2It = zap2It;
        }

        /// <summary>
        /// Gets or sets mal.
        /// </summary>
        [JsonPropertyName("mal")]
        public int? Mal { get; set; }

        /// <summary>
        /// Gets or sets hulu.
        /// </summary>
        [JsonPropertyName("hulu")]
        public int? Hulu { get; set; }

        /// <summary>
        /// Gets or sets crunchyroll.
        /// </summary>
        [JsonPropertyName("crunchyroll")]
        public int? Crunchyroll { get; set; }

        /// <summary>
        /// Gets or sets zap2it.
        /// </summary>
        [JsonPropertyName("zap2It")]
        public string? Zap2It { get; set; }
    }
}