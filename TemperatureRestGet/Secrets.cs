namespace TemperatureRestGet
{
    // ConnectionString to AzureDatabase: Secret wont be uploaded -This is for security purposes. 
    public class Secrets
    {
        public static readonly string ConnectionString = @"Server=tcp:teamcool.database.windows.net,1433;Initial Catalog=TeamCool;Persist Security Info=False;User ID=X;Password=X;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}
