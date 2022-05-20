using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 本地化语言
/// </summary>
public class LocalizedString
{
    #region ISO 639-1 代码表

    /// <summary>
    /// Afar
    /// </summary>
    [JsonProperty(PropertyName = "aa")]
    public string? Afar { get; set; }

    /// <summary>
    /// Abkhazian
    /// </summary>
    [JsonProperty(PropertyName = "ab")]
    public string? Abkhazian { get; set; }

    /// <summary>
    /// Avestan
    /// </summary>
    [JsonProperty(PropertyName = "ae")]
    public string? Avestan { get; set; }

    /// <summary>
    /// Afrikaans
    /// </summary>
    [JsonProperty(PropertyName = "af")]
    public string? Afrikaans { get; set; }

    /// <summary>
    /// Akan
    /// </summary>
    [JsonProperty(PropertyName = "ak")]
    public string? Akan { get; set; }

    /// <summary>
    /// Amharic
    /// </summary>
    [JsonProperty(PropertyName = "am")]
    public string? Amharic { get; set; }

    /// <summary>
    /// Aragonese
    /// </summary>
    [JsonProperty(PropertyName = "an")]
    public string? Aragonese { get; set; }

    /// <summary>
    /// Arabic
    /// </summary>
    [JsonProperty(PropertyName = "ar")]
    public string? Arabic { get; set; }

    /// <summary>
    /// Assamese
    /// </summary>
    [JsonProperty(PropertyName = "as")]
    public string? Assamese { get; set; }

    /// <summary>
    /// Avaric
    /// </summary>
    [JsonProperty(PropertyName = "av")]
    public string? Avaric { get; set; }

    /// <summary>
    /// Aymara
    /// </summary>
    [JsonProperty(PropertyName = "ay")]
    public string? Aymara { get; set; }

    /// <summary>
    /// Azerbaijani
    /// </summary>
    [JsonProperty(PropertyName = "az")]
    public string? Azerbaijani { get; set; }

    /// <summary>
    /// Bashkir
    /// </summary>
    [JsonProperty(PropertyName = "ba")]
    public string? Bashkir { get; set; }

    /// <summary>
    /// Belarusian
    /// </summary>
    [JsonProperty(PropertyName = "be")]
    public string? Belarusian { get; set; }

    /// <summary>
    /// Bulgarian
    /// </summary>
    [JsonProperty(PropertyName = "bg")]
    public string? Bulgarian { get; set; }

    /// <summary>
    /// Biharilanguages
    /// </summary>
    [JsonProperty(PropertyName = "bh")]
    public string? Biharilanguages { get; set; }

    /// <summary>
    /// Bislama
    /// </summary>
    [JsonProperty(PropertyName = "bi")]
    public string? Bislama { get; set; }

    /// <summary>
    /// Bambara
    /// </summary>
    [JsonProperty(PropertyName = "bm")]
    public string? Bambara { get; set; }

    /// <summary>
    /// Bengali
    /// </summary>
    [JsonProperty(PropertyName = "bn")]
    public string? Bengali { get; set; }

    /// <summary>
    /// Tibetan
    /// </summary>
    [JsonProperty(PropertyName = "bo")]
    public string? Tibetan { get; set; }

    /// <summary>
    /// Breton
    /// </summary>
    [JsonProperty(PropertyName = "br")]
    public string? Breton { get; set; }

    /// <summary>
    /// Bosnian
    /// </summary>
    [JsonProperty(PropertyName = "bs")]
    public string? Bosnian { get; set; }

    /// <summary>
    /// CatalanValencian
    /// </summary>
    [JsonProperty(PropertyName = "ca")]
    public string? CatalanValencian { get; set; }

    /// <summary>
    /// Chechen
    /// </summary>
    [JsonProperty(PropertyName = "ce")]
    public string? Chechen { get; set; }

    /// <summary>
    /// Chamorro
    /// </summary>
    [JsonProperty(PropertyName = "ch")]
    public string? Chamorro { get; set; }

    /// <summary>
    /// Corsican
    /// </summary>
    [JsonProperty(PropertyName = "co")]
    public string? Corsican { get; set; }

    /// <summary>
    /// Cree
    /// </summary>
    [JsonProperty(PropertyName = "cr")]
    public string? Cree { get; set; }

    /// <summary>
    /// Czech
    /// </summary>
    [JsonProperty(PropertyName = "cs")]
    public string? Czech { get; set; }

    /// <summary>
    /// Church
    /// </summary>
    [JsonProperty(PropertyName = "cu")]
    public string? Church { get; set; }

    /// <summary>
    /// Chuvash
    /// </summary>
    [JsonProperty(PropertyName = "cv")]
    public string? Chuvash { get; set; }

    /// <summary>
    /// Welsh
    /// </summary>
    [JsonProperty(PropertyName = "cy")]
    public string? Welsh { get; set; }

    /// <summary>
    /// Danish
    /// </summary>
    [JsonProperty(PropertyName = "da")]
    public string? Danish { get; set; }

    /// <summary>
    /// German
    /// </summary>
    [JsonProperty(PropertyName = "de")]
    public string? German { get; set; }

    /// <summary>
    /// DivehiDhivehiMaldivian
    /// </summary>
    [JsonProperty(PropertyName = "dv")]
    public string? DivehiDhivehiMaldivian { get; set; }

    /// <summary>
    /// Dzongkha
    /// </summary>
    [JsonProperty(PropertyName = "dz")]
    public string? Dzongkha { get; set; }

    /// <summary>
    /// Ewe
    /// </summary>
    [JsonProperty(PropertyName = "ee")]
    public string? Ewe { get; set; }

    /// <summary>
    /// Greek,Modern(1453-)
    /// </summary>
    [JsonProperty(PropertyName = "el")]
    public string? GreekModern { get; set; }

    /// <summary>
    /// English
    /// </summary>
    [JsonProperty(PropertyName = "en")]
    public string? English { get; set; }

    /// <summary>
    /// Esperanto
    /// </summary>
    [JsonProperty(PropertyName = "eo")]
    public string? Esperanto { get; set; }

    /// <summary>
    /// 西班牙语
    /// </summary>
    [JsonProperty(PropertyName = "es")]
    public string? Spanish { get; set; }

    /// <summary>
    /// 拉丁美洲西班牙语
    /// </summary>
    [JsonProperty(PropertyName = "es-la")]
    public string? LatinAmericanSpanish { get; set; }

    /// <summary>
    /// Estonian
    /// </summary>
    [JsonProperty(PropertyName = "et")]
    public string? Estonian { get; set; }

    /// <summary>
    /// Basque
    /// </summary>
    [JsonProperty(PropertyName = "eu")]
    public string? Basque { get; set; }

    /// <summary>
    /// Persian
    /// </summary>
    [JsonProperty(PropertyName = "fa")]
    public string? Persian { get; set; }

    /// <summary>
    /// Fulah
    /// </summary>
    [JsonProperty(PropertyName = "ff")]
    public string? Fulah { get; set; }

    /// <summary>
    /// Finnish
    /// </summary>
    [JsonProperty(PropertyName = "fi")]
    public string? Finnish { get; set; }

    /// <summary>
    /// Fijian
    /// </summary>
    [JsonProperty(PropertyName = "fj")]
    public string? Fijian { get; set; }

    /// <summary>
    /// Faroese
    /// </summary>
    [JsonProperty(PropertyName = "fo")]
    public string? Faroese { get; set; }

    /// <summary>
    /// French
    /// </summary>
    [JsonProperty(PropertyName = "fr")]
    public string? French { get; set; }

    /// <summary>
    /// WesternFrisian
    /// </summary>
    [JsonProperty(PropertyName = "fy")]
    public string? WesternFrisian { get; set; }

    /// <summary>
    /// Irish
    /// </summary>
    [JsonProperty(PropertyName = "ga")]
    public string? Irish { get; set; }

    /// <summary>
    /// GaelicScomttishGaelic
    /// </summary>
    [JsonProperty(PropertyName = "gd")]
    public string? GaelicScomttishGaelic { get; set; }

    /// <summary>
    /// Galician
    /// </summary>
    [JsonProperty(PropertyName = "gl")]
    public string? Galician { get; set; }

    /// <summary>
    /// Guarani
    /// </summary>
    [JsonProperty(PropertyName = "gn")]
    public string? Guarani { get; set; }

    /// <summary>
    /// Gujarati
    /// </summary>
    [JsonProperty(PropertyName = "gu")]
    public string? Gujarati { get; set; }

    /// <summary>
    /// Manx
    /// </summary>
    [JsonProperty(PropertyName = "gv")]
    public string? Manx { get; set; }

    /// <summary>
    /// Hausa
    /// </summary>
    [JsonProperty(PropertyName = "ha")]
    public string? Hausa { get; set; }

    /// <summary>
    /// Hebrew
    /// </summary>
    [JsonProperty(PropertyName = "he")]
    public string? Hebrew { get; set; }

    /// <summary>
    /// Hindi
    /// </summary>
    [JsonProperty(PropertyName = "hi")]
    public string? Hindi { get; set; }

    /// <summary>
    /// HiriMotu
    /// </summary>
    [JsonProperty(PropertyName = "ho")]
    public string? HiriMotu { get; set; }

    /// <summary>
    /// Croatian
    /// </summary>
    [JsonProperty(PropertyName = "hr")]
    public string? Croatian { get; set; }

    /// <summary>
    /// HaitianHaitianCreole
    /// </summary>
    [JsonProperty(PropertyName = "ht")]
    public string? HaitianHaitianCreole { get; set; }

    /// <summary>
    /// Hungarian
    /// </summary>
    [JsonProperty(PropertyName = "hu")]
    public string? Hungarian { get; set; }

    /// <summary>
    /// Armenian
    /// </summary>
    [JsonProperty(PropertyName = "hy")]
    public string? Armenian { get; set; }

    /// <summary>
    /// Herero
    /// </summary>
    [JsonProperty(PropertyName = "hz")]
    public string? Herero { get; set; }

    /// <summary>
    /// Interlingua(InternationalAuxiliaryLanguageAssociation)
    /// </summary>
    [JsonProperty(PropertyName = "ia")]
    public string? Interlingua { get; set; }

    /// <summary>
    /// Indonesian
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public string? Indonesian { get; set; }

    /// <summary>
    /// InterlingueOccidental
    /// </summary>
    [JsonProperty(PropertyName = "ie")]
    public string? InterlingueOccidental { get; set; }

    /// <summary>
    /// Igbo
    /// </summary>
    [JsonProperty(PropertyName = "ig")]
    public string? Igbo { get; set; }

    /// <summary>
    /// SichuanYiNuosu
    /// </summary>
    [JsonProperty(PropertyName = "ii")]
    public string? SichuanYiNuosu { get; set; }

    /// <summary>
    /// Inupiaq
    /// </summary>
    [JsonProperty(PropertyName = "ik")]
    public string? Inupiaq { get; set; }

    /// <summary>
    /// Ido
    /// </summary>
    [JsonProperty(PropertyName = "io")]
    public string? Ido { get; set; }

    /// <summary>
    /// Icelandic
    /// </summary>
    [JsonProperty(PropertyName = "is")]
    public string? Icelandic { get; set; }

    /// <summary>
    /// Italian
    /// </summary>
    [JsonProperty(PropertyName = "it")]
    public string? Italian { get; set; }

    /// <summary>
    /// Inuktitut
    /// </summary>
    [JsonProperty(PropertyName = "iu")]
    public string? Inuktitut { get; set; }

    /// <summary>
    /// 日语
    /// </summary>
    [JsonProperty(PropertyName = "ja")]
    public string? Japanese { get; set; }

    /// <summary>
    /// 罗马化的日语
    /// </summary>
    [JsonProperty(PropertyName = "ja-ro")]
    public string? RomanizedJapanese { get; set; }

    /// <summary>
    /// Javanese
    /// </summary>
    [JsonProperty(PropertyName = "jv")]
    public string? Javanese { get; set; }

    /// <summary>
    /// Georgian
    /// </summary>
    [JsonProperty(PropertyName = "ka")]
    public string? Georgian { get; set; }

    /// <summary>
    /// Kongo
    /// </summary>
    [JsonProperty(PropertyName = "kg")]
    public string? Kongo { get; set; }

    /// <summary>
    /// KikuyuGikuyu
    /// </summary>
    [JsonProperty(PropertyName = "ki")]
    public string? KikuyuGikuyu { get; set; }

    /// <summary>
    /// KuanyamaKwanyama
    /// </summary>
    [JsonProperty(PropertyName = "kj")]
    public string? KuanyamaKwanyama { get; set; }

    /// <summary>
    /// Kazakh
    /// </summary>
    [JsonProperty(PropertyName = "kk")]
    public string? Kazakh { get; set; }

    /// <summary>
    /// KalaallisutGreenlandic
    /// </summary>
    [JsonProperty(PropertyName = "kl")]
    public string? KalaallisutGreenlandic { get; set; }

    /// <summary>
    /// CentralKhmer
    /// </summary>
    [JsonProperty(PropertyName = "km")]
    public string? CentralKhmer { get; set; }

    /// <summary>
    /// Kannada
    /// </summary>
    [JsonProperty(PropertyName = "kn")]
    public string? Kannada { get; set; }

    /// <summary>
    /// 韩语
    /// </summary>
    [JsonProperty(PropertyName = "ko")]
    public string? Korean { get; set; }

    /// <summary>
    /// 罗马化的韩语
    /// </summary>
    [JsonProperty(PropertyName = "ko-ro")]
    public string? RomanizedKorean { get; set; }

    /// <summary>
    /// Kanuri
    /// </summary>
    [JsonProperty(PropertyName = "kr")]
    public string? Kanuri { get; set; }

    /// <summary>
    /// Kashmiri
    /// </summary>
    [JsonProperty(PropertyName = "ks")]
    public string? Kashmiri { get; set; }

    /// <summary>
    /// Kurdish
    /// </summary>
    [JsonProperty(PropertyName = "ku")]
    public string? Kurdish { get; set; }

    /// <summary>
    /// Komi
    /// </summary>
    [JsonProperty(PropertyName = "kv")]
    public string? Komi { get; set; }

    /// <summary>
    /// Cornish
    /// </summary>
    [JsonProperty(PropertyName = "kw")]
    public string? Cornish { get; set; }

    /// <summary>
    /// KirghizKyrgyz
    /// </summary>
    [JsonProperty(PropertyName = "ky")]
    public string? KirghizKyrgyz { get; set; }

    /// <summary>
    /// Latin
    /// </summary>
    [JsonProperty(PropertyName = "la")]
    public string? Latin { get; set; }

    /// <summary>
    /// 卢森堡语
    /// </summary>
    [JsonProperty(PropertyName = "lb")]
    public string? LuxembourgishLetzeburgesch { get; set; }

    /// <summary>
    /// Ganda
    /// </summary>
    [JsonProperty(PropertyName = "lg")]
    public string? Ganda { get; set; }

    /// <summary>
    /// LimburganLimburgerLimburgish
    /// </summary>
    [JsonProperty(PropertyName = "li")]
    public string? LimburganLimburgerLimburgish { get; set; }

    /// <summary>
    /// Lingala
    /// </summary>
    [JsonProperty(PropertyName = "ln")]
    public string? Lingala { get; set; }

    /// <summary>
    /// Lao
    /// </summary>
    [JsonProperty(PropertyName = "lo")]
    public string? Lao { get; set; }

    /// <summary>
    /// Lithuanian
    /// </summary>
    [JsonProperty(PropertyName = "lt")]
    public string? Lithuanian { get; set; }

    /// <summary>
    /// Luba-Katanga
    /// </summary>
    [JsonProperty(PropertyName = "lu")]
    public string? LubaKatanga { get; set; }

    /// <summary>
    /// Latvian
    /// </summary>
    [JsonProperty(PropertyName = "lv")]
    public string? Latvian { get; set; }

    /// <summary>
    /// Malagasy
    /// </summary>
    [JsonProperty(PropertyName = "mg")]
    public string? Malagasy { get; set; }

    /// <summary>
    /// Marshallese
    /// </summary>
    [JsonProperty(PropertyName = "mh")]
    public string? Marshallese { get; set; }

    /// <summary>
    /// Maori
    /// </summary>
    [JsonProperty(PropertyName = "mi")]
    public string? Maori { get; set; }

    /// <summary>
    /// Macedonian
    /// </summary>
    [JsonProperty(PropertyName = "mk")]
    public string? Macedonian { get; set; }

    /// <summary>
    /// Malayalam
    /// </summary>
    [JsonProperty(PropertyName = "ml")]
    public string? Malayalam { get; set; }

    /// <summary>
    /// Mongolian
    /// </summary>
    [JsonProperty(PropertyName = "mn")]
    public string? Mongolian { get; set; }

    /// <summary>
    /// Marathi
    /// </summary>
    [JsonProperty(PropertyName = "mr")]
    public string? Marathi { get; set; }

    /// <summary>
    /// Malay
    /// </summary>
    [JsonProperty(PropertyName = "ms")]
    public string? Malay { get; set; }

    /// <summary>
    /// Maltese
    /// </summary>
    [JsonProperty(PropertyName = "mt")]
    public string? Maltese { get; set; }

    /// <summary>
    /// Burmese
    /// </summary>
    [JsonProperty(PropertyName = "my")]
    public string? Burmese { get; set; }

    /// <summary>
    /// Nauru
    /// </summary>
    [JsonProperty(PropertyName = "na")]
    public string? Nauru { get; set; }

    /// <summary>
    /// Bokmål,NorwegianNorwegianBokmål
    /// </summary>
    [JsonProperty(PropertyName = "nb")]
    public string? BokmalNorwegianNorwegianBokmal { get; set; }

    /// <summary>
    /// Ndebele,NorthNorthNdebele
    /// </summary>
    [JsonProperty(PropertyName = "nd")]
    public string? NdebeleNorthNorthNdebele { get; set; }

    /// <summary>
    /// Nepali
    /// </summary>
    [JsonProperty(PropertyName = "ne")]
    public string? Nepali { get; set; }

    /// <summary>
    /// Ndonga
    /// </summary>
    [JsonProperty(PropertyName = "ng")]
    public string? Ndonga { get; set; }

    /// <summary>
    /// DutchFlemish
    /// </summary>
    [JsonProperty(PropertyName = "nl")]
    public string? DutchFlemish { get; set; }

    /// <summary>
    /// NorwegianNynorskNynorsk,Norwegian
    /// </summary>
    [JsonProperty(PropertyName = "nn")]
    public string? NorwegianNynorskNynorskNorwegian { get; set; }

    /// <summary>
    /// Norwegian
    /// </summary>
    [JsonProperty(PropertyName = "no")]
    public string? Norwegian { get; set; }

    /// <summary>
    /// Ndebele,SouthSouthNdebele
    /// </summary>
    [JsonProperty(PropertyName = "nr")]
    public string? NdebeleSouthSouthNdebele { get; set; }

    /// <summary>
    /// NavajoNavaho
    /// </summary>
    [JsonProperty(PropertyName = "nv")]
    public string? NavajoNavaho { get; set; }

    /// <summary>
    /// ChichewaChewaNyanja
    /// </summary>
    [JsonProperty(PropertyName = "ny")]
    public string? ChichewaChewaNyanja { get; set; }

    /// <summary>
    /// Occitan(post1500)
    /// </summary>
    [JsonProperty(PropertyName = "oc")]
    public string? Occitan { get; set; }

    /// <summary>
    /// Ojibwa
    /// </summary>
    [JsonProperty(PropertyName = "oj")]
    public string? Ojibwa { get; set; }

    /// <summary>
    /// Oromo
    /// </summary>
    [JsonProperty(PropertyName = "om")]
    public string? Oromo { get; set; }

    /// <summary>
    /// Oriya
    /// </summary>
    [JsonProperty(PropertyName = "or")]
    public string? Oriya { get; set; }

    /// <summary>
    /// OssetianOssetic
    /// </summary>
    [JsonProperty(PropertyName = "os")]
    public string? OssetianOssetic { get; set; }

    /// <summary>
    /// PanjabiPunjabi
    /// </summary>
    [JsonProperty(PropertyName = "pa")]
    public string? PanjabiPunjabi { get; set; }

    /// <summary>
    /// Pali
    /// </summary>
    [JsonProperty(PropertyName = "pi")]
    public string? Pali { get; set; }

    /// <summary>
    /// Polish
    /// </summary>
    [JsonProperty(PropertyName = "pl")]
    public string? Polish { get; set; }

    /// <summary>
    /// PushtoPashto
    /// </summary>
    [JsonProperty(PropertyName = "ps")]
    public string? PushtoPashto { get; set; }

    /// <summary>
    /// 葡萄牙语
    /// </summary>
    [JsonProperty(PropertyName = "pt")]
    public string? Portuguese { get; set; }

    /// <summary>
    /// 巴西葡萄牙语
    /// </summary>
    [JsonProperty(PropertyName = "pt-br")]
    public string? BrazilianPortugese { get; set; }

    /// <summary>
    /// Quechua
    /// </summary>
    [JsonProperty(PropertyName = "qu")]
    public string? Quechua { get; set; }

    /// <summary>
    /// Romansh
    /// </summary>
    [JsonProperty(PropertyName = "rm")]
    public string? Romansh { get; set; }

    /// <summary>
    /// Rundi
    /// </summary>
    [JsonProperty(PropertyName = "rn")]
    public string? Rundi { get; set; }

    /// <summary>
    /// RomanianMoldavianMoldovan
    /// </summary>
    [JsonProperty(PropertyName = "ro")]
    public string? RomanianMoldavianMoldovan { get; set; }

    /// <summary>
    /// Russian
    /// </summary>
    [JsonProperty(PropertyName = "ru")]
    public string? Russian { get; set; }

    /// <summary>
    /// Kinyarwanda
    /// </summary>
    [JsonProperty(PropertyName = "rw")]
    public string? Kinyarwanda { get; set; }

    /// <summary>
    /// Sanskrit
    /// </summary>
    [JsonProperty(PropertyName = "sa")]
    public string? Sanskrit { get; set; }

    /// <summary>
    /// Sardinian
    /// </summary>
    [JsonProperty(PropertyName = "sc")]
    public string? Sardinian { get; set; }

    /// <summary>
    /// Sindhi
    /// </summary>
    [JsonProperty(PropertyName = "sd")]
    public string? Sindhi { get; set; }

    /// <summary>
    /// NorthernSami
    /// </summary>
    [JsonProperty(PropertyName = "se")]
    public string? NorthernSami { get; set; }

    /// <summary>
    /// Sango
    /// </summary>
    [JsonProperty(PropertyName = "sg")]
    public string? Sango { get; set; }

    /// <summary>
    /// SinhalaSinhalese
    /// </summary>
    [JsonProperty(PropertyName = "si")]
    public string? SinhalaSinhalese { get; set; }

    /// <summary>
    /// Slovak
    /// </summary>
    [JsonProperty(PropertyName = "sk")]
    public string? Slovak { get; set; }

    /// <summary>
    /// Slovenian
    /// </summary>
    [JsonProperty(PropertyName = "sl")]
    public string? Slovenian { get; set; }

    /// <summary>
    /// Samoan
    /// </summary>
    [JsonProperty(PropertyName = "sm")]
    public string? Samoan { get; set; }

    /// <summary>
    /// Shona
    /// </summary>
    [JsonProperty(PropertyName = "sn")]
    public string? Shona { get; set; }

    /// <summary>
    /// Somali
    /// </summary>
    [JsonProperty(PropertyName = "so")]
    public string? Somali { get; set; }

    /// <summary>
    /// Albanian
    /// </summary>
    [JsonProperty(PropertyName = "sq")]
    public string? Albanian { get; set; }

    /// <summary>
    /// Serbian
    /// </summary>
    [JsonProperty(PropertyName = "sr")]
    public string? Serbian { get; set; }

    /// <summary>
    /// Swati
    /// </summary>
    [JsonProperty(PropertyName = "ss")]
    public string? Swati { get; set; }

    /// <summary>
    /// Sotho,Southern
    /// </summary>
    [JsonProperty(PropertyName = "st")]
    public string? SothoSouthern { get; set; }

    /// <summary>
    /// Sundanese
    /// </summary>
    [JsonProperty(PropertyName = "su")]
    public string? Sundanese { get; set; }

    /// <summary>
    /// Swedish
    /// </summary>
    [JsonProperty(PropertyName = "sv")]
    public string? Swedish { get; set; }

    /// <summary>
    /// Swahili
    /// </summary>
    [JsonProperty(PropertyName = "sw")]
    public string? Swahili { get; set; }

    /// <summary>
    /// Tamil
    /// </summary>
    [JsonProperty(PropertyName = "ta")]
    public string? Tamil { get; set; }

    /// <summary>
    /// Telugu
    /// </summary>
    [JsonProperty(PropertyName = "te")]
    public string? Telugu { get; set; }

    /// <summary>
    /// Tajik
    /// </summary>
    [JsonProperty(PropertyName = "tg")]
    public string? Tajik { get; set; }

    /// <summary>
    /// Thai
    /// </summary>
    [JsonProperty(PropertyName = "th")]
    public string? Thai { get; set; }

    /// <summary>
    /// Tigrinya
    /// </summary>
    [JsonProperty(PropertyName = "ti")]
    public string? Tigrinya { get; set; }

    /// <summary>
    /// Turkmen
    /// </summary>
    [JsonProperty(PropertyName = "tk")]
    public string? Turkmen { get; set; }

    /// <summary>
    /// Tagalog
    /// </summary>
    [JsonProperty(PropertyName = "tl")]
    public string? Tagalog { get; set; }

    /// <summary>
    /// Tswana
    /// </summary>
    [JsonProperty(PropertyName = "tn")]
    public string? Tswana { get; set; }

    /// <summary>
    /// Tonga(TongaIslands)
    /// </summary>
    [JsonProperty(PropertyName = "to")]
    public string? Tonga { get; set; }

    /// <summary>
    /// Turkish
    /// </summary>
    [JsonProperty(PropertyName = "tr")]
    public string? Turkish { get; set; }

    /// <summary>
    /// Tsonga
    /// </summary>
    [JsonProperty(PropertyName = "ts")]
    public string? Tsonga { get; set; }

    /// <summary>
    /// Tatar
    /// </summary>
    [JsonProperty(PropertyName = "tt")]
    public string? Tatar { get; set; }

    /// <summary>
    /// Twi
    /// </summary>
    [JsonProperty(PropertyName = "tw")]
    public string? Twi { get; set; }

    /// <summary>
    /// Tahitian
    /// </summary>
    [JsonProperty(PropertyName = "ty")]
    public string? Tahitian { get; set; }

    /// <summary>
    /// UighurUyghur
    /// </summary>
    [JsonProperty(PropertyName = "ug")]
    public string? UighurUyghur { get; set; }

    /// <summary>
    /// Ukrainian
    /// </summary>
    [JsonProperty(PropertyName = "uk")]
    public string? Ukrainian { get; set; }

    /// <summary>
    /// Urdu
    /// </summary>
    [JsonProperty(PropertyName = "ur")]
    public string? Urdu { get; set; }

    /// <summary>
    /// Uzbek
    /// </summary>
    [JsonProperty(PropertyName = "uz")]
    public string? Uzbek { get; set; }

    /// <summary>
    /// Venda
    /// </summary>
    [JsonProperty(PropertyName = "ve")]
    public string? Venda { get; set; }

    /// <summary>
    /// Vietnamese
    /// </summary>
    [JsonProperty(PropertyName = "vi")]
    public string? Vietnamese { get; set; }

    /// <summary>
    /// Volapük
    /// </summary>
    [JsonProperty(PropertyName = "vo")]
    public string? Volapuk { get; set; }

    /// <summary>
    /// Walloon
    /// </summary>
    [JsonProperty(PropertyName = "wa")]
    public string? Walloon { get; set; }

    /// <summary>
    /// Wolof
    /// </summary>
    [JsonProperty(PropertyName = "wo")]
    public string? Wolof { get; set; }

    /// <summary>
    /// Xhosa
    /// </summary>
    [JsonProperty(PropertyName = "xh")]
    public string? Xhosa { get; set; }

    /// <summary>
    /// Yiddish
    /// </summary>
    [JsonProperty(PropertyName = "yi")]
    public string? Yiddish { get; set; }

    /// <summary>
    /// Yoruba
    /// </summary>
    [JsonProperty(PropertyName = "yo")]
    public string? Yoruba { get; set; }

    /// <summary>
    /// ZhuangChuang
    /// </summary>
    [JsonProperty(PropertyName = "za")]
    public string? ZhuangChuang { get; set; }

    /// <summary>
    /// 简体中文
    /// </summary>
    [JsonProperty(PropertyName = "zh")]
    public string? SimplifiedChinese { get; set; }

    /// <summary>
    /// 繁体中文
    /// </summary>
    [JsonProperty(PropertyName = "zh-hk")]
    public string? TraditionalChinese { get; set; }

    /// <summary>
    /// 罗马化的中文
    /// </summary>
    [JsonProperty(PropertyName = "zh-ro")]
    public string? RomanizedChinese { get; set; }

    /// <summary>
    /// Zulu
    /// </summary>
    [JsonProperty(PropertyName = "zu")]
    public string? Zulu { get; set; }

    #endregion
}
