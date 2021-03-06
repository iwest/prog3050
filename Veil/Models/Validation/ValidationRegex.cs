﻿/* ValidationRegex.cs
 * Purpose: A class to hold all the input validation regex patterns used within Veil
 * 
 * Revision History:
 *      Drew Matheson, 2015.11.04: Created
 */ 

namespace Veil.DataModels.Validation
{
    /// <summary>
    ///     Regex pattern constants for input validation within Veil
    /// </summary>
    public static class ValidationRegex
    {
        /// <summary>
        ///     Pattern for input phone numbers
        /// </summary>
        /// <example>
        ///     <b>Examples:</b>
        ///     (800)555-0199
        ///     800-555-0199
        ///     (800)555-0199, ext. 5555
        ///     800-555-0199, ext. 5555
        /// </example>
        public const string INPUT_PHONE = @"^(\(?\d{3}(\)|-)\d{3}-\d{4}(, (EXT|ext). \d{1,4})?)$";

        /// <summary>
        ///     Pattern for persisted phone numbers
        /// </summary>
        /// <example>
        ///     <b>Examples:</b>
        ///     800-555-0199
        ///     800-555-0199, ext. 5555    
        /// </example>
        public const string STORED_PHONE = @"^(\d{3}-\d{3}-\d{4}(, ext. \d{1,4})?)$";

        /// <summary>
        ///     Pattern for Used SKUs of Physical Game Products
        /// </summary>
        public const string PHYSICAL_GAME_PRODUCT_USED_SKU = @"^1\d{12}$";

        /// <summary>
        ///     Pattern for New SKUs of Physical Game Products
        /// </summary>
        public const string PHYSICAL_GAME_PRODUCT_NEW_SKU = @"^0\d{12}$";

        /// <summary>
        ///     Pattern which matches either <see cref="POSTAL_CODE"/> or <see cref="ZIP_CODE"/>
        /// </summary>
        public const string POSTAL_ZIP_CODE = "(" + POSTAL_CODE + ")|(" + ZIP_CODE + ")";

        /// <summary>
        ///     Pattern which matches Canadian postal codes
        /// </summary>
        public const string POSTAL_CODE = @"^(?i)(?!.*[DFIOQU])[A-VXY]\d[A-Z](-| )?\d[A-Z]\d$";

       /// <summary>
        ///     Pattern which matches American zip codes
        /// </summary>
        public const string ZIP_CODE = @"^\d{5}(?:(?:-| )\d{4})?$";

        /// <summary>
        ///     Pattern for persisted postal codes
        /// </summary>
        public const string STORED_POSTAL_CODE = @"(?:^(?!.*[DFIOQU])[A-VXY]\d[A-Z] \d[A-Z]\d$)|(?:^\d{5}(?:-\d{4})?$)";

        /// <summary>
        ///     Pattern for Youtube embed links.
        /// </summary>
        /// <remarks>
        ///     UrlAttribute should be used along with this to ensure it really is a valid Url.
        ///     This simply ensures it is a Youtube Embed url
        /// </remarks>
        public const string YOUTUBE_EMBED_LINK = @"^[hH][tT]{2}[pP][sS]?://(?:[wW]{3}\.)?youtube.com/embed/[^\&\?\/]+";
    }
}