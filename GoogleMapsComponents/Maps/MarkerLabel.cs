﻿namespace GoogleMapsComponents.Maps
{
    /// <summary>
    /// These options specify the appearance of a marker label. A marker label is a single character of text which will appear inside the marker. 
    /// If you are using it with a custom marker, you can reposition it with the labelOrigin property in the Icon class.
    /// </summary>
    public class MarkerLabel
    {
        /// <summary>
        /// The color of the label text. Default color is black.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The font family of the label text (equivalent to the CSS font-family property).
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// The font size of the label text (equivalent to the CSS font-size property). 
        /// Default size is 14px.
        /// </summary>
        public string FontSize { get; set; }

        /// <summary>
        /// The font weight of the label text (equivalent to the CSS font-weight property).
        /// </summary>
        public string FontWeight { get; set; }

        /// <summary>
        /// The text to be displayed in the label.
        /// </summary>
        public string Text { get; set; }
    }
}
