namespace Plugin.Toolkit.Fonts.Inter;

public static class FontExtensions
{
    /// <summary>
    /// Add font to global. using: FontFamily="Regular" *(Italic, Medium, SemiBold, Bold, etc..)
    /// </summary>
    public static IFontCollection AddInterFonts(this IFontCollection fonts)
    {
        var thisAssembly = typeof(FontExtensions).Assembly;
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-Regular.ttf", FontAliases.InterRegular);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-Italic.ttf", FontAliases.InterItalic);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-Medium.ttf", FontAliases.InterMedium);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-MediumItalic.ttf", FontAliases.InterMediumItalic);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-SemiBold.ttf", FontAliases.InterSemiBold);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-SemiBoldItalic.ttf", FontAliases.InterSemiBoldItalic);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-Bold.ttf", FontAliases.InterBold);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-BoldItalic.ttf", FontAliases.InterBoldItalic);
        return fonts;
    }

    /// <summary>
    /// Add font to partial. using: FontFamily="InterRegular" *(InterItalic, InterMedium, InterSemiBold, InterBold, etc..)
    /// </summary>
    public static IFontCollection AddInterFontsPartial(this IFontCollection fonts)
    {
        var thisAssembly = typeof(FontExtensions).Assembly;
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-Regular.ttf", FontAliases.Name + FontAliases.InterRegular);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-Italic.ttf", FontAliases.Name + FontAliases.InterItalic);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-Medium.ttf", FontAliases.Name + FontAliases.InterMedium);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-MediumItalic.ttf", FontAliases.Name + FontAliases.InterMediumItalic);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-SemiBold.ttf", FontAliases.Name + FontAliases.InterSemiBold);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-SemiBoldItalic.ttf", FontAliases.Name + FontAliases.InterSemiBoldItalic);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-Bold.ttf", FontAliases.Name + FontAliases.InterBold);
        fonts.AddEmbeddedResourceFont(thisAssembly, "Inter-BoldItalic.ttf", FontAliases.Name + FontAliases.InterBoldItalic);
        return fonts;
    }
}
