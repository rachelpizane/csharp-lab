DateTime localTime = DateTime.Now;
DateTime utcTime = DateTime.UtcNow;

Console.WriteLine("Local Time: {0}", localTime);
Console.WriteLine("UTC Time: {0}", utcTime);

Console.WriteLine("Local Date: {0}", localTime.Date);
Console.WriteLine("UTC Date: {0}", utcTime.Date);

TimeSpan interval = localTime - utcTime; // Diferença entre horas

Console.WriteLine(interval);

Console.WriteLine(new DateTime(2020, 12, 25).ToShortDateString()); // Data específica em formato curto (dd/MM/yyyy)
Console.WriteLine(localTime.AddDays(2).ToShortDateString());  // Adiciona 2 dias

// -------------------------------
DateTime data = new DateTime(2020, 8, 12);
String dataFormatadaUS = data.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"));

Console.WriteLine(dataFormatadaUS); // 8/12/2020 12:00:00 AM

Console.WriteLine(data.ToString("dd/MM/yyyy")); // 12/08/2020
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss")); // 12/08/2020 00:00:00
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss.fff")); // 12/08/2020 00:00:00.000
Console.WriteLine(data.ToString("yyyy-MM-dd")); // 2020-08-12
Console.WriteLine(data.ToString("MMMM dd, yyyy")); // August 12, 2020