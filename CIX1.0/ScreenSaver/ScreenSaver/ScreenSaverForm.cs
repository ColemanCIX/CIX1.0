using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using System.Net;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;


namespace ScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        //creates a new struct called NewsItem
        //a NewsItem consists of a title, description, link and date
        public struct NewsItem
        {
            private string _title;
            public string title
            {
                get
                {
                    return _title;
                }
                set
                {
                    _title = value;
                }
            }

            private string _link;
            public string link
            {
                get
                {
                    return _link;
                }
                set
                {
                    _link = value;
                }
            }

            private string _description;
            public string description
            {
                get
                {
                    return _description;
                }
                set
                {
                    _description = value;
                }
            }
            private string _date;
            public string date
            {
                get
                {
                    return _date;
                }
                set
                {
                    _date = value;
                }
            }
        }

        public class Conditions
        {
            string dayOfWeek = DateTime.Now.DayOfWeek.ToString();
            string condition = "No Data";
            string tempF = "No Data";
            string wind = "No Data";
            string high = "No Data";
            string low = "No Data";

            public string Condition
            {
                get { return condition; }
                set { condition = value; }
            }

            public string TempF
            {
                get { return tempF; }
                set { tempF = value; }
            }

            public string Wind
            {
                get { return wind; }
                set { wind = value; }
            }

            public string DayOfWeek
            {
                get { return dayOfWeek; }
                set { dayOfWeek = value; }
            }

            public string High
            {
                get { return high; }
                set { high = value; }
            }

            public string Low
            {
                get { return low; }
                set { low = value; }
            }
        }

        //the following imports several Windows APIs for later use
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        //class level variables
        private bool previewMode = false;
        private Random rand = new Random();
        private Point mouseLocation;
        int optionalItemCounter;
        int colemanItemCounter;
        int eventItemCounter;
        List<NewsItem> colemanItems = new List<NewsItem>();
        List<NewsItem> optionalItems = new List<NewsItem>();
        List<NewsItem> eventItems = new List<NewsItem>();


        //constructor that sets the form's bounds
        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        //constructor that accepts the window handle as an argument 
        //uses several Windows API functions
        //used for preview mode, which displays the CIX logo
        public ScreenSaverForm(IntPtr PreviewHandle)
        {
            InitializeComponent();

            //set the preview window as the parent of this window
            SetParent(this.Handle, PreviewHandle);

            //make this a child window so it will close when the parent dialog closes
            //GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            //places our window inside the parent
            Rectangle parentRect;
            GetClientRect(PreviewHandle, out parentRect);
            Size = parentRect.Size;
            Location = new Point(0, 0);

            pnlEvents.Location = new Point(0, 0);
            lblEventsHeader.Visible = false;
            lblEvents1.Visible = false;
            picCixLogo.Visible = true;
            
            previewMode = true;
        }

        //This function creates a regular expression that identifies html markup within RSS elements
        //The markup is erased so that it does not show up in the output
        private string ignoreHTML(string htmlText)
        {
            Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            return reg.Replace(htmlText, string.Empty);
        }

        //Reads and returns the XML file from the specified URL
        private Stream getOptionalNews()
        {
             //gets the channel's URL configured in the settings by the user
             Microsoft.Win32.RegistryKey stringKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo_ScreenSaver");
            
             string optionalUrl2;
             try
             {
                 optionalUrl2 = (string)stringKey.GetValue("channel2Url");
             }
             catch (Exception o)
             {
                 optionalUrl2 = "http://www.utsandiego.com/rss/headlines/metro/";
             }

            //prepare the web page we will be asking for
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(optionalUrl2);

            //execute the request
            HttpWebResponse response = (HttpWebResponse)
                request.GetResponse();

            //read data via the response stream
            Stream optionalStream = response.GetResponseStream();
            
            //return the xml data in the form of a stream
            return optionalStream;
        }

        //read XML file
        private void readOptionalNews()
        {
            string title;
            string link;
            string description;
            
            //creates a new XmlTextReader object called reader using stream returned by getNews()
            XmlTextReader reader = new XmlTextReader(getOptionalNews());
           
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "title":
                            title = reader.ReadString();
                            break;
                        case "link":
                            link = reader.ReadString();
                            break;
                        case "description":
                            description = reader.ReadString();
                            break;
                    }
                }

                if (reader.Name == "item")
                {
                    //create a new item to be added to the List of NewsItems
                    NewsItem item = new NewsItem();
                    while (!((reader.Name == "item") &&
                                (reader.NodeType == XmlNodeType.EndElement)) &&
                                    reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            //populate item's title, description and link properties
                            switch (reader.Name.ToLower())
                            {
                                case "title":
                                    item.title = ignoreHTML(reader.ReadString());
                                    break;
                                case "description":
                                    item.description = ignoreHTML(reader.ReadString());
                                    break;
                                case "link":
                                    item.link = ignoreHTML(reader.ReadString());
                                    break;
                            }
                        }
                    }
                    //add item to the List of NewsItems
                    optionalItems.Add(item); 
                }
            }

            //display the title and description of the first index
            //the most recent items are placed at the beginning of the List items
            lblTitle2.Text = optionalItems[optionalItemCounter].title.ToString();
            lblDescription2.Text = optionalItems[optionalItemCounter].description.ToString();
            optionalItemCounter = 1;
        }

        //gets and returns the XML file from the Events channel
        private Stream getEvents()
        {
                //prepare the web page we will be asking for
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create("http://172.16.25.167:8080/datafiles/Events.xml");

            //execute the request
            HttpWebResponse response = (HttpWebResponse)
                request.GetResponse();

            //read data via the response stream
            Stream eventsStream = response.GetResponseStream();

            //return the xml data in the form of a stream
            return eventsStream;
        }

        //reads the Events XML file
        private void readEvents()
        {
            string title;
            string link;
            string description;
            string date;

            //creates a new XmlTextReader object called reader using stream returned by getNews()
            XmlTextReader reader = new XmlTextReader(getEvents());

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "title":
                            title = reader.ReadString();
                            break;
                        case "link":
                            link = reader.ReadString();
                            break;
                        case "description":
                            description = reader.ReadString();
                            break;
                        case "pubDate":
                            date = reader.ReadString();
                            break;
                    }
                }

                if (reader.Name == "item")
                {
                    //create a new item to be added to the List of NewsItems
                    NewsItem item = new NewsItem();
                    while (!((reader.Name == "item") &&
                                (reader.NodeType == XmlNodeType.EndElement)) &&
                                    reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            //populate item's title, description and link properties
                            switch (reader.Name.ToLower())
                            {
                                case "title":
                                    item.title = ignoreHTML(reader.ReadString());
                                    break;
                                case "description":
                                    item.description = ignoreHTML(reader.ReadString());
                                    break;
                                case "link":
                                    item.link = ignoreHTML(reader.ReadString());
                                    break;
                                case "pubDate":
                                    item.date = ignoreHTML(reader.ReadString());
                                    break;
                            }
                        }
                    }
                    //add item to the List of NewsItems
                    eventItems.Add(item);
                }
            }
            //display the description of the first three articles
            //the most recent items are placed at the beginning of the collection
            lblEvents1.Text = "* "+ eventItems[eventItemCounter].description.ToString();
            eventItemCounter = 1;
            lblEvents2.Text = "* " + eventItems[eventItemCounter].description.ToString();
            eventItemCounter = 2;
            lblEvents3.Text = "* " + eventItems[eventItemCounter].description.ToString();
            eventItemCounter = 3;
            
        }

        //Gets and returns the XML file from the specified URL
        private Stream getColemanNews()
        {
            //gets the channel's URL configured in the settings by the user
            Microsoft.Win32.RegistryKey stringKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo_ScreenSaver");
            string colemanUrl1;
            try
            {
                colemanUrl1 = (string)stringKey.GetValue("channelUrl");
            }
            catch (Exception c)
            {
                colemanUrl1 = "http://172.16.25.167:8080/datafiles/StudentChannel.xml";
            }
           

            //prepare the web page we will be asking for
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(colemanUrl1);

            //execute the request
            HttpWebResponse response = (HttpWebResponse)
                request.GetResponse();

            //read data via the response stream
            Stream colemanStream = response.GetResponseStream();

            //return the xml data in the form of a stream
            return colemanStream;
        }

        //read XML file
        private void readColemanNews()
        {
            string title;
            string link;
            string description;
            string date;

            //creates a new XmlTextReader object called reader using stream returned by getNews()
            XmlTextReader reader = new XmlTextReader(getColemanNews());

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "title":
                            title = reader.ReadString();
                            break;
                        case "link":
                            link = reader.ReadString();
                            break;
                        case "description":
                            description = reader.ReadString();
                            break;
                        case "pubDate":
                            date = (string)reader.ReadString();
                            break;
                    }
                }

                if (reader.Name == "item")
                {
                    //create a new item to be added to the List of NewsItems
                    NewsItem item = new NewsItem();
                    while (!((reader.Name == "item") &&
                                (reader.NodeType == XmlNodeType.EndElement)) &&
                                    reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            //populate item's title, description and link properties
                            switch (reader.Name.ToLower())
                            {
                                case "title":
                                    item.title = ignoreHTML(reader.ReadString());
                                    break;
                                case "description":
                                    item.description = ignoreHTML(reader.ReadString());
                                    break;
                                case "link":
                                    item.link = ignoreHTML(reader.ReadString());
                                    break;
                                case "pubDate":
                                    item.date = ignoreHTML(reader.ReadString());
                                    break;
                            }
                        }
                    }
                    //add item to the List of NewsItems
                    colemanItems.Add(item);
                }
            }

            //display the title and description of the first index
            //the most recent items are placed at the beginning of the List items
            lblTitle1.Text = colemanItems[colemanItemCounter].title.ToString();
            lblDescription1.Text = colemanItems[colemanItemCounter].description.ToString();
            colemanItemCounter = 1;
        }


        //uses an instance of the Conditions class to store the actual values and then returns the instance with the values in it
        public static Conditions GetCurrentConditions()
        {
            Conditions conditions = new Conditions();

            XmlDocument xmlConditions = new XmlDocument();
            xmlConditions.Load("http://www.google.com/ig/api?weather=92123");

            //makes sure the data returned is valid
            if (xmlConditions.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)
            {
                conditions = null;
            }
            else
            {
                conditions.Condition = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/condition").Attributes["data"].InnerText;
                conditions.TempF = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/temp_f").Attributes["data"].InnerText;
                conditions.Wind = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/wind_condition").Attributes["data"].InnerText; 
            }
            return conditions;
        }

        //gets the forecast for a specified location and returns a list of Conditions
        public static List<Conditions> GetForecast()
        {
            List<Conditions> conditions = new List<Conditions>();

            XmlDocument xmlConditions = new XmlDocument();
            xmlConditions.Load("http://www.google.com/ig/api?weather=92123");

            if (xmlConditions.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)
            {
                conditions = null;
            }
            else
            {
                foreach (XmlNode node in xmlConditions.SelectNodes("/xml_api_reply/weather/forecast_conditions"))
                {
                    Conditions condition = new Conditions();
                    condition.Condition = node.SelectSingleNode("condition").Attributes["data"].InnerText;
                    condition.High = node.SelectSingleNode("high").Attributes["data"].InnerText;
                    condition.Low = node.SelectSingleNode("low").Attributes["data"].InnerText;
                    condition.DayOfWeek = node.SelectSingleNode("day_of_week").Attributes["data"].InnerText;
                    conditions.Add(condition);
                }
            }
            return conditions;
        }

        public void getWeather()
        {
            Conditions current = GetCurrentConditions();
            List<Conditions> forecast = GetForecast();
            char degree = (char)176;

            lblWeatherStatus.Text = forecast[0].Condition;
            lblCurrentWeather.Text = "Currently: " + current.TempF + degree;
            lblHigh.Text = "High: " + forecast[0].High + degree;
            lblLow.Text = "Low: " + forecast[0].Low + degree;
            lblTomorrowStatus.Text = forecast[1].Condition;
            lblTomorrowTemps.Text = "High: " + forecast[1].High + degree + " / Low: " + forecast[1].Low + degree;
            
            //match the condition text to a weather icon
            switch (forecast[0].Condition.ToLower())
            {
                case "sunny":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Sunny;
                    break;
                case "mostly sunny":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.MostlySunny;
                    break;
                case "partly cloudy":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.PartlyCloudy;
                    break;
                case "mostly cloudy":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Cloudy;
                    break;
                case "overcast":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Cloudy;
                    break;
                case "chance of storm":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.ChanceOfStorm;
                    break;
                case "rain":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Rain;
                    break;
                case "chance of rain":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.ChanceOfRain;
                    break;
                case "chance of snow":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Flurries;
                    break;
                case "mist":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.MostlySunny;
                    break;
                case "cloudy":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Cloudy;
                    break;
                case "storm":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.ThunderStorm;
                    break;
                case "thunderstorm":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.ThunderStorm;
                    break;
                case "chance of tstorm":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.ChanceOfStorm;
                    break;
                case "chance of thunderstorm":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.ChanceOfStorm;
                    break;
                case "sleet":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Snow;
                    break;
                case "snow":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Snow;
                    break;
                case "icy":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Icy;
                    break;
                case "dust":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Haze;
                    break;
                case "fog":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Haze;
                    break;
                case "smoke":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Haze;
                    break;
                case "haze":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Haze;
                    break;
                case "flurries":
                    picWeatherIcon.Image = ScreenSaver.Properties.Resources.Flurries;
                    break;
            }
            
        }

        //loads the Registry values, hides the cursor and brings the window to the front 
        private void loadSettings()
        {
            analogClock.Enabled = !analogClock.Enabled;
            Cursor.Hide();
            TopMost = true;
            
            picCixLogo.Visible = false;

            //get the interval value stored in the Registry
            Microsoft.Win32.RegistryKey intervalKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo2_ScreenSaver");
            int interval;
            try
            {
                interval = (int)intervalKey.GetValue("interval");
            }
            catch (Exception i)
            {
                intervalKey.SetValue("interval", 0);
                interval = (int)intervalKey.GetValue("interval");
            }
            if (interval == -1)
            {
                //default to 30000 milliseconds (30 seconds)
                moveTimer.Interval = 30000;
            }
            else
            {
                //interval holds the selectedIndex of intervalComboBox
                //configuration settings allow user to set rotation speed in 30 second intervals, so
                //add 1 to the index and multiply by 30000 to get the desired number of milliseconds
               moveTimer.Interval = 30000 * (interval + 1);
            }
            try
            {
                lblEventsHeader.Visible = true;
                lblEvents1.Visible = true;
                lblEvents2.Visible = true;
                lblEvents3.Visible = true;
                readEvents();
            }
            catch (Exception ev)
            {
                lblEvents1.Text = "Error connecting to the Events feed. \nPlease check back later.";
                lblEvents2.Visible = false;
                lblEvents3.Visible = false;
            }
            try
            {
                lblTitle2.Visible = true;
                readOptionalNews();
            }
            catch (Exception of)
            {
                lblDescription2.Text = "Error connecting to this news feed. \nPlease check back later.";
                lblTitle2.Visible = false;
            }
            try
            {
                lblTitle1.Visible = true;
                readColemanNews();
            }
            catch (Exception cf)
            {
                lblDescription1.Text = "Error connecting to this news feed. \nPlease check back later.";
                lblTitle1.Visible = false;
            }
            try
            {
                grpTomorrow.Visible = true;
                lblHigh.Visible = true;
                lblLow.Visible = true;
                getWeather();
            }
            catch (Exception w)
            {
                lblWeatherStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                lblWeatherStatus.Text = "Error connecting to Weather.";
                lblCurrentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                lblCurrentWeather.Text = "We're going to guess it's sunny...";
                grpTomorrow.Visible = false;
               
                lblHigh.Visible = false;
                lblLow.Visible = false;
            }
            
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        //rotates to the next article and updates the weather at the specified timer interval
        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            int colemanMaxCount = (colemanItems.Count - 1);
            int otherItemsMaxCount = (optionalItems.Count - 1);
            int eventsMaxCount = (eventItems.Count - 1);

            try
            {
                getWeather();
            }
            catch (Exception w)
            {
                lblWeatherStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                lblWeatherStatus.Text = "Error connecting to Weather";
                lblCurrentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                lblCurrentWeather.Text = "We're going to guess it's sunny...";
                grpTomorrow.Visible = false;

                lblHigh.Visible = false;
                lblLow.Visible = false;
            }

            if (optionalItemCounter > otherItemsMaxCount)
            {
                optionalItemCounter = 0;
            }
            else
            {
                lblTitle2.Text = optionalItems[optionalItemCounter].title.ToString();
                lblDescription2.Text = optionalItems[optionalItemCounter].description.ToString();
                optionalItemCounter++;
            }

            if (colemanItemCounter > colemanMaxCount)
            {
                colemanItemCounter = 0;
            } 
            else
            {
                lblTitle1.Text = colemanItems[colemanItemCounter].title.ToString();
                lblDescription1.Text = colemanItems[colemanItemCounter].description.ToString();
                colemanItemCounter++;
            }

            if (eventItemCounter > eventsMaxCount)
            {
                eventItemCounter = 0;
            }
            else
            {
                lblEvents1.Text = "* " + eventItems[eventItemCounter].description.ToString();
                eventItemCounter++;
            }
            if (eventItemCounter > eventsMaxCount)
            {
                eventItemCounter = 0;
            }
            else
            {
                lblEvents2.Text = "* " + eventItems[eventItemCounter].description.ToString();
                eventItemCounter++;
            }
            if (eventItemCounter > eventsMaxCount)
            {
                eventItemCounter = 0;
            }
            else
            {
                lblEvents3.Text = "* " + eventItems[eventItemCounter].description.ToString();
                eventItemCounter++;
            }


        }

        //terminates the screensaver when the mouse is moved more than 3 points
        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            //only exit the application upon MouseMove if the screensaver is NOT in preview mode
            if (!previewMode)
            {
                if (!mouseLocation.IsEmpty)
                {
                    if (Math.Abs(mouseLocation.X - e.X) > 3 ||
                        Math.Abs(mouseLocation.Y - e.Y) > 3)
                        Application.Exit();
                }
                // Update current mouse location
                mouseLocation = e.Location;
            }
        }

        //terminates the screensaver when the mouse is clicked (if the screensaver
        //is not in preview mode)
        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
            {
                Application.Exit();
            }
        }

        //terminates the screensaver when a key is pressed (if the screensaver
        //is not in preview mode)
        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
            {
                Application.Exit();
            }
        }    
    }
}