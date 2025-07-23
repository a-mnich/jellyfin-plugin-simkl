using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Simkl Ids.
    /// </summary>
    public class SimklIds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimklIds"/> class.
        /// </summary>
        /// <param name="providerIds">The provider ids.</param>
        public SimklIds(Dictionary<string, string> providerIds)
        {
            foreach (var (key, value) in providerIds)
            {
                if (key.Equals(nameof(Simkl), StringComparison.OrdinalIgnoreCase))
                {
                    Simkl = Convert.ToInt32(value, CultureInfo.InvariantCulture);
                }
                else if (key.Equals(nameof(Anidb), StringComparison.OrdinalIgnoreCase))
                {
                    Anidb = Convert.ToInt32(value, CultureInfo.InvariantCulture);
                }
                else if (key.Equals(nameof(Imdb), StringComparison.OrdinalIgnoreCase))
                {
                    Imdb = value;
                }
                else if (key.Equals(nameof(Tvdb), StringComparison.OrdinalIgnoreCase))
                {
                    Tvdb = value;
                }
                else if (key.Equals(nameof(Slug), StringComparison.OrdinalIgnoreCase))
                {
                    Slug = value;
                }
                else if (key.Equals(nameof(Netflix), StringComparison.OrdinalIgnoreCase))
                {
                    Netflix = value;
                }
                else if (key.Equals(nameof(Tmdb), StringComparison.OrdinalIgnoreCase))
                {
                    Tmdb = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimklIds"/> class with the specified identifiers.
        /// </summary>
        /// <param name="simkl">The unique Simkl identifier. Can be <see langword="null"/> if not available.</param>
        /// <param name="imdb">The IMDb identifier for the item. Can be <see langword="null"/> if not available.</param>
        /// <param name="slug">The Simkl slug for the item. Can be <see langword="null"/> if not available.</param>
        /// <param name="netflix">The Netflix identifier for the item. Can be <see langword="null"/> if not available.</param>
        /// <param name="tmdb">The TMDb (The Movie Database) identifier for the item. Can be <see langword="null"/> if not available.</param>
        /// <param name="tvdb">The TVDb (TheTVDB.com) identifier for the item. Can be <see langword="null"/> if not available.</param>
        /// <param name="anidb">The AniDB (Anime Database) identifier for the item. Can be <see langword="null"/> if not available.</param>
        [JsonConstructor]
        public SimklIds(int? simkl, string? imdb, string? slug, string? netflix, string? tmdb, string? tvdb, int? anidb)
        {
            Simkl = simkl;
            Imdb = imdb;
            Slug = slug;
            Netflix = netflix;
            Tmdb = tmdb;
            Tvdb = tvdb;
            Anidb = anidb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimklIds"/> class.
        /// </summary>
        public SimklIds()
        {
        }

        /// <summary>
        /// Gets or sets the simkl id.
        /// </summary>
        [JsonPropertyName("simkl")]
        public int? Simkl { get; set; }

        /// <summary>
        /// Gets or sets the imdb id.
        /// </summary>
        [JsonPropertyName("imdb")]
        public string? Imdb { get; set; }

        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Gets or sets the netflix id.
        /// </summary>
        [JsonPropertyName("netflix")]
        public string? Netflix { get; set; }

        /// <summary>
        /// Gets or sets the TMDb id.
        /// </summary>
        [JsonPropertyName("tmdb")]
        public string? Tmdb { get; set; }

        /// <summary>
        /// Gets or sets the TVDB id.
        /// </summary>
        [JsonPropertyName("tvdb")]
        public string? Tvdb { get; set; }

        /// <summary>
        /// Gets or sets the AniDB id.
        /// </summary>
        [JsonPropertyName("anidb")]
        public int? Anidb { get; set; }
    }
}