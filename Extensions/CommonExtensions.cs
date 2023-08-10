using System.Text;
using System.Text.RegularExpressions;
using Sosoem.FiscalAPI.Dtos.Common;

namespace Sosoem.FiscalAPI.Dtos.Extensions;

public static class CommonExtensions
{
    #region Common

    public static bool IsValidInvoiceDate(string? invoiceDate)
    {
        // Extract ISO date from string
        var extractDateRegex =
            new Regex(
                "(?:\\d{4})-(?:\\d{2})-(?:\\d{2})T(?:\\d{2}):(?:\\d{2}):(?:\\d{2}(?:\\.\\d*)?)(?:(?:-(?:\\d{2}):(?:\\d{2})|Z)?)");
        var extracted = extractDateRegex.Matches(invoiceDate ?? "")
            .Select(m => m.Value)
            .ToArray();

        var isSatFormat = extracted.Any();

        return isSatFormat;
    }

    public static bool ToSucceeded(this string str) => str.ToLower().Trim().Equals(GlobalConstants.Success);

    #endregion

    #region Credentials

    /// <summary>
    /// Encode string to base64
    /// </summary>
    /// <param name="plainText">string to encode</param>
    /// <returns>base64 encoded string</returns>
    public static string EncodeToBase64(this string plainText)
    {
        var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        return Convert.ToBase64String(plainTextBytes);
    }

    /// <summary>
    /// Decode string to plainText
    /// </summary>
    /// <param name="base64EncodedData">base64 encoded data to decode</param>
    /// <returns>plainText</returns>
    public static string DecodeFromBase64(this string base64EncodedData)
    {
        var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
        return Encoding.UTF8.GetString(base64EncodedBytes);
    }

    /// <summary>
    /// Get array bytes from any string
    /// </summary>
    /// <param name="plainText"></param>
    /// <returns>array bytes</returns>
    public static byte[] GetBytes(this string plainText)
    {
        return Encoding.UTF8.GetBytes(plainText);
    }


    /// <summary>
    /// Converts an array of bytes to base64 encode
    /// </summary>
    /// <param name="inArray"></param>
    /// <returns>base64String</returns>
    public static string ToBase64String(this byte[] inArray)
    {
        return Convert.ToBase64String(inArray);
    }

    #endregion


    #region Invoicing

    public static string ToSatFormat(this DateTime dateTime)
    {
        return dateTime.ToString(GlobalConstants.SatDateFormat);
    }

    public static decimal ToSatRounding(this decimal value, int decimalPlaces = 6,
        MidpointRounding roundingStrategy = MidpointRounding.AwayFromZero)
    {
        return Math.Round(value, decimalPlaces, roundingStrategy);
    }

    #endregion



}