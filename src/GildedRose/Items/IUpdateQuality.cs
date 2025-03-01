namespace GildedRoseKata;

/// <summary>
/// Defines the interface for an item that has a quality value that can be updated.
/// </summary>
public interface IUpdateQuality
{
        /// <summary>
        /// Updates the quality value (usually as part of end-of-day processing)
        /// </summary>
        public void UpdateQuality();
}