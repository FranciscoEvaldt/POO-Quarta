using aula12_ef_test.csproj;

var db = new DataContext();
Console.WriteLine($"Database path: {db.DbPath}.");