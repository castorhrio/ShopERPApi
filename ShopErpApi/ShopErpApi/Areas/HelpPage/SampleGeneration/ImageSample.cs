namespace ShopErpApi.Areas.HelpPage
{
    using System;

    /// <summary>
    /// This represents an image sample on the help page. There's a display template named ImageSample associated with this class.
    /// </summary>
    public class ImageSample
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSample"/> class.
        /// </summary>
        /// <param name="src">The URL of an image.</param>
        public ImageSample(string src)
        {
            if (src == null)
            {
                throw new ArgumentNullException("src");
            }
            Src = src;
        }

        /// <summary>
        /// Gets the Src.
        /// </summary>
        public string Src { get; private set; }

        /// <summary>
        /// The Equals.
        /// </summary>
        /// <param name="obj">The obj<see cref="object"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public override bool Equals(object obj)
        {
            ImageSample other = obj as ImageSample;
            return other != null && Src == other.Src;
        }

        /// <summary>
        /// The GetHashCode.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public override int GetHashCode()
        {
            return Src.GetHashCode();
        }

        /// <summary>
        /// The ToString.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public override string ToString()
        {
            return Src;
        }
    }
}
