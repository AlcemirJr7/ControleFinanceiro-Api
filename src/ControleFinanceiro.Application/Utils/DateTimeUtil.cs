namespace ControleFinanceiro.Application.Utils
{
    public static class DateTimeUtil
    {
        public static DateTime GetDateTime()
        {
            return DateTime.Now.AddHours(-3);

        }

        public static string GetDateTimeStr()
        {
            return DateTime.Now.AddHours(-3).ToString();
        }

        public static string GetIsoDateTimeStr()
        {            
            return DateTime.Now.AddHours(-3).ToString("s");
        }
    }
}
