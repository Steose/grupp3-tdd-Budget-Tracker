using BudgetTracker.Core.Data; // Import DbContext.
using Microsoft.EntityFrameworkCore; // Import EF Core APIs.
using Microsoft.EntityFrameworkCore.Design; // Import design-time factory.
using Microsoft.Extensions.Configuration; // Import configuration.

namespace BudgetTracker.Api.Data; // Define API data namespace.

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BudgetTrackerDbContext> // Provide design-time context.
{ // Open the class block.
    public BudgetTrackerDbContext CreateDbContext(string[] args) // Create DbContext for tooling.
    { // Open the method block.
        var configuration = new ConfigurationBuilder() // Create configuration builder.
            .SetBasePath(Directory.GetCurrentDirectory()) // Set base path.
            .AddJsonFile("appsettings.json", optional: false) // Load appsettings.
            .AddJsonFile("appsettings.Development.json", optional: true) // Load dev appsettings.
            .AddEnvironmentVariables() // Load environment variables.
            .Build(); // Build configuration.

        var connectionString = configuration.GetConnectionString("Default") ?? "Data Source=budgettracker.db"; // Resolve connection string.

        var optionsBuilder = new DbContextOptionsBuilder<BudgetTrackerDbContext>(); // Create options builder.
        optionsBuilder.UseSqlite(connectionString); // Configure SQLite provider.

        return new BudgetTrackerDbContext(optionsBuilder.Options); // Return DbContext.
    } // Close the method block.
} // Close the class block.
