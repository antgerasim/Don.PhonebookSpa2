using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Don.PhoneBookSpa2.Localization
{
    public static class PhoneBookSpa2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PhoneBookSpa2Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PhoneBookSpa2LocalizationConfigurer).GetAssembly(),
                        "Don.PhoneBookSpa2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}