using System.Collections.Generic;
using System.Text.Json.Serialization;
using MediaBrowser.Model.Dto;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Simkl show.
    /// </summary>
    public class SimklShow : SimklMediaObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimklShow"/> class.
        /// </summary>
        /// <param name="mediaInfo">The media info.</param>
        public SimklShow(BaseItemDto mediaInfo)
        {
            Title = mediaInfo.SeriesName;
            Ids = new SimklShowIds(mediaInfo.ProviderIds);
            Year = mediaInfo.ProductionYear;
            Seasons = new[]
            {
                new Season
                {
                    Number = mediaInfo.ParentIndexNumber,
                    Episodes = new[]
                    {
                        new ShowEpisode
                        {
                            Number = mediaInfo.IndexNumber
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimklShow"/> class with the specified title, year, and seasons.
        /// </summary>
        /// <param name="title">The title of the show. Cannot be null or empty.</param>
        /// <param name="year">The release year of the show, or <see langword="null"/> if the year is unknown.</param>
        /// <param name="seasons">A list of seasons associated with the show. Cannot be null, but can be empty if no seasons are available.</param>
        [JsonConstructor]
        public SimklShow(string title, int? year, IReadOnlyList<Season>? seasons)
        {
            Title = title;
            Year = year;
            Seasons = seasons ?? new List<Season>();
        }

        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets year.
        /// </summary>
        [JsonPropertyName("year")]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or sets seasons.
        /// </summary>
        [JsonPropertyName("seasons")]
        public IReadOnlyList<Season> Seasons { get; set; }
    }
}