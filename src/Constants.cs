namespace SelectedWhitespace
{
    /// <summary>
    /// Constants for whitespace visualization.
    /// </summary>
    internal static class Constants
    {
        // Whitespace symbols
        public const char SpaceDot = '·';       // Middle dot for space (U+00B7)
        public const char TabArrow = '→';       // Rightwards arrow for tab (U+2192)
        public const string CrlfSymbol = "␍␊";  // ␍ (U+240D) and ␊ (U+240A)
        public const string LfSymbol = "␍";     // ␍ (U+240D)
        public const string CrSymbol = "␊";     // ␊ (U+240A)

        // Tooltips for line endings
        public const string CrlfTooltip = "CRLF (Windows)";
        public const string LfTooltip = "LF (Unix/macOS)";
        public const string CrTooltip = "CR (Classic Mac)";

        // Default color for whitespace glyphs (medium gray)
        public const byte WhitespaceGrayLevel = 128;
        public const byte LineEndingOpacity = 140;  // More transparent (0-255)
        public const double LineEndingFontSizeOffset = 3.0;  // 3pt bigger
        public const double LineEndingLeftMargin = 10.0;  // Pixels to offset line endings rightwards from selection
        public const double LineEndingTopMargin = 3.0;  // Pixels to offset line endings downwards from selection
    }
}