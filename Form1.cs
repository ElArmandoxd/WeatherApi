using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using wheatherApi.Model;

namespace wheatherApi
{
    public partial class Form1 : Form
    {
        string apiKey = "690bbcc6922e57b3e678d14d258a077d";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=Mexico%20City&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        public async Task<string> getHttp(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        public void getJson(string json)
        {
            var response = JsonConvert.DeserializeObject<cityWeatherApi>(json);
            titleTxt.Text = string.Format(response.name);
            lblGrados.Text = string.Format(Math.Round(response.main.temp - 273.15).ToString()+"°");
            lblWeather.Text = string.Format(response.weather[0].main);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=Mexico%20City&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=Tokyo&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=New%20York&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=washington&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=seoul&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=rio%20de%20janeiro&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=paris&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=berlin&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=madrid&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            string direccionApi = "http://api.openweathermap.org/data/2.5/weather?q=vancouver&appid=690bbcc6922e57b3e678d14d258a077d";
            string respuesta = await getHttp(direccionApi);
            getJson(respuesta);
        }
    }
}
