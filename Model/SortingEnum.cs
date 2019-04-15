using System.ComponentModel;

namespace Lab04Khomenko.Model
{
    public enum SortingEnum
    {
        [Description("-")]
        Default,
        [Description("Ім'я")]
        Name,
        [Description("Прізвище")]
        Surname,
        [Description("Пошта")]
        Email,
        [Description("Західний знак")]
        SunSign,
        [Description("Китайський знак")]
        ChineseSign
    }
}
