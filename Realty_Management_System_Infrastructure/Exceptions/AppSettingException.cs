namespace Realty_Management_System_Infrastructure.Exceptions
{
    public static class AppSettingException
    {
       public static class ConnectionStrings
       {
            public static readonly BaseException DefaultConnectionStringNotFound = new(
                "a connection string was not found please set your connection string"
            );
       }
    }
}
