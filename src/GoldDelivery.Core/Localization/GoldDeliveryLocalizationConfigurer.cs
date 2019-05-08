using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace GoldDelivery.Localization
{
    public static class GoldDeliveryLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GoldDeliveryConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GoldDeliveryLocalizationConfigurer).GetAssembly(),
                        "GoldDelivery.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
