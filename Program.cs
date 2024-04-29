


using OpenQA.Selenium.IE;

public class Program
{
    public static void Main(string[] args)
    {
        var ieOptions = new InternetExplorerOptions();
        ieOptions.AttachToEdgeChrome = true;
        ieOptions.InitialBrowserUrl = "https://bing.com";
        //change the path accordingly
        ieOptions.EdgeExecutablePath = "C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe";

        var driver = new InternetExplorerDriver(ieOptions);
       
    }
}