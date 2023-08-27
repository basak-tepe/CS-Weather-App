using Newtonsoft.Json;
using System.Net;
using System.Security.Policy;

namespace CSWeatherApp
{

    public partial class condition : Form
    {
        public condition()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();

        }


        string APIKey = "16c18bf01de8fa1e5f16f7c3d67d6f5f";
        void getWeather()
        {
            //we will de-seriealize JSON into our weatherInformation class

            //form a web client

            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);

                //deserialize
                WeatherInformation.root info = JsonConvert.DeserializeObject<WeatherInformation.root>(json);


                //update labels

                weatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                conditionLabel.Text = info.weather[0].main;
                detailsLabel.Text = info.weather[0].description;
                sunsetLabel.Text = convertDateTime(info.sys.sunset).ToShortTimeString();
                sunriseLabel.Text = convertDateTime(info.sys.sunrise).ToShortTimeString();
                windLabel.Text = info.wind.speed.ToString();
                pressureLabel.Text = info.main.pressure.ToString();

            }
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }
    }
}