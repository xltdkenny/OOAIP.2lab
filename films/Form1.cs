using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace films
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> movieLinks = new Dictionary<string, string>();
        private ChromiumWebBrowser browser;

        private HomeTheaterFacade homeTheater;
        public Form1()
        {
            InitializeComponent();
            homeTheater = new HomeTheaterFacade(txtOutput);
            LoadMoviesFromFile();
            InitializeMovieLinks();

            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            browser = new ChromiumWebBrowser("");
            // Добавление ChromiumWebBrowser в Panel
            panel1.Controls.Add(browser);
        }

        private void InitializeMovieLinks()
        {
            movieLinks.Add("Рикролл", "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            movieLinks.Add("Дымок", "https://www.youtube.com/watch?v=0vgnaXn0zAI");
            movieLinks.Add("Сегодня поиграю я в майнкрафт", "https://www.youtube.com/watch?v=H5m2SIzjVr0&ab_channel=cookies");
            movieLinks.Add("Luis Fonsi - Despacito ft. Daddy Yankee", "https://www.youtube.com/watch?v=kJQP7kiw5Fk&ab_channel=LuisFonsiVEVO");
            movieLinks.Add("Ed Sheeran - Shape of You", "https://www.youtube.com/watch?v=JGwWNGJdvx8&ab_channel=EdSheeran");
            movieLinks.Add("Wiz Khalifa - See You Again ft. Charlie Puth", "https://www.youtube.com/watch?v=RgKAFK5djSk&ab_channel=WizKhalifaMusic");
            movieLinks.Add("PSY - GANGNAM STYLE(강남스타일) M/V", "https://www.youtube.com/watch?v=9bZkp7q19f0&ab_channel=officialpsy");
            movieLinks.Add("Justin Bieber - Sorry", "https://www.youtube.com/watch?v=fRh_vgS2dFE&ab_channel=JustinBieberVEVO");
            movieLinks.Add("Maroon 5 - Sugar", "https://www.youtube.com/watch?v=09R8_2nJtjg&ab_channel=Maroon5VEVO");
            movieLinks.Add("Katy Perry - Roar", "https://www.youtube.com/watch?v=CevxZvSJLk8&ab_channel=KatyPerryVEVO");
            movieLinks.Add("OneRepublic - Counting Stars", "https://www.youtube.com/watch?v=hT_nvWreIhg&ab_channel=OneRepublicVEVO");
            movieLinks.Add("Ed Sheeran - Thinking Out Loud", "https://www.youtube.com/watch?v=lp-EO5I60KA&ab_channel=EdSheeran");
            movieLinks.Add("Mark Ronson - Uptown Funk ft. Bruno Mars", "https://www.youtube.com/watch?v=OPf0YbXqDm0&ab_channel=MarkRonsonVEVO");
            movieLinks.Add("Звёздное Лето | Atomic Heart", "https://www.youtube.com/watch?v=5otKEvycSN4&ab_channel=VMusic");
            movieLinks.Add("Basshunter - Vi sitter i ventrilo och spelar DotA", "https://www.youtube.com/watch?v=aTJncWndUB8&ab_channel=ExtensiveMusicUnderground");
            movieLinks.Add("The Weeknd - Save Your Tears", "https://www.youtube.com/watch?v=XXYlFuWEuKI&list=PL3buMC19cqNQRRN2u10abyxa5dtMSqaJT&index=2&ab_channel=TheWeekndVEVO");
            movieLinks.Add("O-Zone - Dragostea Din Tei", "https://www.youtube.com/watch?v=YnopHCL1Jk8&list=RDaTJncWndUB8&index=2&ab_channel=TimeRecords");
        }

        private void LoadMoviesFromFile()
        {
            try
            {
                //каждый фильм находится на новой строке в файле movies.txt
                string[] movies = System.IO.File.ReadAllLines("E:\\movies.txt");
                cmbMovieNames.Items.AddRange(movies);
                MessageBox.Show($"К просмотру доступно: {movies.Length} клипов");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить список клипов: {ex.Message}");
            }
        }

        private void btnWatchMovie_Click(object sender, EventArgs e)
        {
            if (cmbMovieNames.SelectedIndex != -1) // Проверяем, выбран ли элемент
            {
                string movie = cmbMovieNames.SelectedItem.ToString();
                if(movieLinks.TryGetValue(movie,out string link))
                {
                    browser.Load(link);
                    homeTheater.WatchMovie(movie);
                }
                else
                {
                    MessageBox.Show("Ссылка на видео не найдена");
                    homeTheater.WatchMovie(movie);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клип из предложенного списка.");
            }
            
        }

        private void btnEndMovie_Click(object sender, EventArgs e)
        {
            browser.Load("about:blank");//остановка воспроизведения
            homeTheater.EndMovie();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            browser.Load("about:blank");//остановка воспроизведения
            txtOutput.Clear();
        }

        private void chromiumWebBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }
    }

    //сам фасад
    public class HomeTheaterFacade
    {
        private Television tv;
        private Player Player;
        private SoundSystem soundSystem;
        private Download download;
        public HomeTheaterFacade(TextBox output)
        {
            tv = new Television(output);
            Player = new Player(output);
            soundSystem = new SoundSystem(output);
            download = new Download(output);
           
        }
        public void WatchMovie(string movie)
        {
            tv.TurnOn();
            soundSystem.TurnOn();
            soundSystem.SetVolume(100);
            Player.TurnOn();
            download.TurnOn();
            Player.Play(movie);
        }

        public void EndMovie()
        {
            download.TurnOff();
            Player.TurnOff();
            soundSystem.TurnOff();
            tv.TurnOff();
        }
        
    }

    public class Television
    {
        private TextBox output;
        public Television(TextBox output) { this.output = output; }
        public void TurnOn() => output.AppendText("TV включен. \r\n");
        public void TurnOff() => output.AppendText("TV выключен. \r\n");
    }

    public class Player
    {
        private TextBox output;
        public Player(TextBox output) { this.output = output; }
        public void TurnOn() => output.AppendText("Player включен.\r\n");
        public void TurnOff() => output.AppendText("Player выключен.\r\n");
        public void Play(string movie) => output.AppendText($"Playing \"{movie}\".\r\n");
    }

    public class SoundSystem
    {
        private TextBox output;
        public SoundSystem(TextBox output) { this.output = output; }
        public void TurnOn() => output.AppendText("Sound System включена.\r\n");
        public void TurnOff() => output.AppendText("Sound System выключена.\r\n");
        public void SetVolume(int volume) => output.AppendText($"Volume set to {volume}.\r\n");
    }

    public class Download
    {
        private TextBox output;
        public Download(TextBox output) { this.output = output; }
        public void TurnOn() => output.AppendText("Загрузка клипа произошла успешно\r\n");
        public void TurnOff() => output.AppendText("Клип выключен\r\n");
    }
}
