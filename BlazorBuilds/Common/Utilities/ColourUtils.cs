using BlazorBuilds.Common.Models;
using BlazorBuilds.Common.Seeds;

namespace BlazorBuilds.Common.Utilities;

public static class ColourUtils
{
    /*
        * Use the following to build a contrast checker component, the sass files has similar code.
        * 
        * 1. Use the HexToRgbColour method to get our RgbColour record (a little model record instead of using and tuples)
        * 2. Pass two of these RgbColour records to the CalculateContrast method to get the contrast value.
        * 
        * Similar ot the Web AIM contrast checker (https://webaim.org/resources/contrastchecker/). 
    */
    public static RgbColour HexToRgbColour(string hexColour)
    {
        if (false == hexColour.StartsWith("#") || hexColour.Length != 7) throw new ArgumentException(GlobalValues.Incorrect_Hex_Value_Exception_Message);

        hexColour = hexColour.TrimStart('#');

        int red   = Convert.ToInt32(hexColour.Substring(0, 2), 16);
        int green = Convert.ToInt32(hexColour.Substring(2, 2), 16);
        int blue  = Convert.ToInt32(hexColour.Substring(4, 2), 16);

        return new RgbColour(red, green, blue);
    }
    public static double RgbColourValueToLinear(int colourValue)
    {
        double normalized = colourValue / 255.0;

        if (normalized <= 0.04045) return normalized / 12.92;
        
        return Math.Pow((normalized + 0.055) / 1.055, 2.4);
    }
    public static double CalculateContrast(RgbColour colourOne, RgbColour colourTwo)
    {
        double luminanceOne  = (0.2126 * RgbColourValueToLinear(colourOne.Red)) + (0.7152 * RgbColourValueToLinear(colourOne.Green)) + (0.0722 * RgbColourValueToLinear(colourOne.Blue));
        double luminanceTwo  = (0.2126 * RgbColourValueToLinear(colourTwo.Red)) + (0.7152 * RgbColourValueToLinear(colourTwo.Green)) + (0.0722 * RgbColourValueToLinear(colourTwo.Blue));
        double contrastRatio = (Math.Max(luminanceOne, luminanceTwo) + 0.05) / (Math.Min(luminanceOne, luminanceTwo) + 0.05);

        return Math.Round(contrastRatio, 2);
    }
}
