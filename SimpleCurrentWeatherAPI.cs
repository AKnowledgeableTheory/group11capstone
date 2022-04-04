var url = "https://api.openweathermap.org/data/2.5/weather?appid={openweathermap_apikey}&q=phoenix";

var httpRequest = (HttpWebRequest)WebRequest.Create(url);

httpRequest.Accept = "application/json";


var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
{
   var result = streamReader.ReadToEnd();
}

Console.WriteLine(httpResponse.StatusCode);