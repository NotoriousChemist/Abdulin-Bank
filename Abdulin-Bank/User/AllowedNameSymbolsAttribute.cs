public class AllowedNameSymbolsAttribute : RegularExpressionAttribute
{
    public AllowedNameSymbolsAttribute() 
        : base(@"^[a-zA-Zа-яА-Я0-9\s]+$") // Регулярка из примера
    {
        ErrorMessage = "Запрещены спецсимволы (кроме букв, цифр и пробелов)";
    }
}