using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using _418FinalProject;
using _418FinalProject.Models;

namespace _418FinalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<Models.QuesitonContext>();
                    context.Database.Migrate();
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        /*using System;
          using System.Data.SqlClient;
          using System.Text;

          namespace sqltest
          {
              class Program
              {
                  static void Main(string[] args)
                  {
                      try 
                      { 
                          SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                          builder.DataSource = "<server>.database.windows.net"; 
                          builder.UserID = "<username>";            
                          builder.Password = "<password>";     
                          builder.InitialCatalog = "<database>";

                          builder.DataSource = "testtaker.database.windows.net";
                          builder.UserID = "user";
                          builder.Password = "Password1";
                          builder.InitialCatalog = "TestTaker";

                          using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                          {
                              Console.WriteLine("\nQuery data example:");
                              Console.WriteLine("=========================================\n");

                              connection.Open();       
                              StringBuilder sb = new StringBuilder();
                              sb.Append("SELECT TOP 20 pc.Name as CategoryName, p.name as ProductName ");
                              sb.Append("FROM [SalesLT].[ProductCategory] pc ");
                              sb.Append("JOIN [SalesLT].[Product] p ");
                              sb.Append("ON pc.productcategoryid = p.productcategoryid;");
                              String sql = sb.ToString();

                              using (SqlCommand command = new SqlCommand(sql, connection))
                              {
                                  using (SqlDataReader reader = command.ExecuteReader())
                                  {
                                      while (reader.Read())
                                      {
                                          Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                                      }
                                  }
                              }                    
                          }
                      }
                      catch (SqlException e)
                      {
                          Console.WriteLine(e.ToString());
                      }
                      Console.ReadLine();
                  }
              }
          }*/

    }
}
