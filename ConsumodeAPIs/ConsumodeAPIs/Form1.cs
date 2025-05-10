using System.Text.Json;
using System.Text.Json.Serialization;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;



namespace ConsumodeAPIs
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            string nombre = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa un nombre de Pokémon.");
                return;
            }

            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{nombre}";
                string respuesta = await _httpClient.GetStringAsync(url);

                var pokemon = JsonSerializer.Deserialize<PokemonResponse>(respuesta);

                lblNombre.Text = $"Nombre: {pokemon.Name.ToUpper()}";
                lblStats.Text = "Estadísticas:\n";

                foreach (var stat in pokemon.Stats)
                {
                    lblStats.Text += $"{stat.Stat.Name}: {stat.BaseStat}\n";
                }

                picPokemon.Load(pokemon.Sprites.FrontDefault);

                GuardarPokemonEnArchivo(pokemon);


            }
            catch (HttpRequestException)
            {
                MessageBox.Show("No se pudo conectar a la API.");
            }
            catch (JsonException)
            {
                MessageBox.Show("No se pudo interpretar la respuesta de la API.");
            }
            catch (Exception)
            {
                MessageBox.Show("El Pokémon no fue encontrado o ocurrió un error.");
            }





        }


        private void GuardarPokemonEnArchivo(PokemonResponse pokemon)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pokemon.txt");

            var sb = new StringBuilder();
            sb.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {pokemon.Name.ToUpper()}");
            sb.AppendLine("Estadísticas:");
            foreach (var stat in pokemon.Stats)
            {
                sb.AppendLine($"{stat.Stat.Name}: {stat.BaseStat}");
            }
            sb.AppendLine(); 

            File.AppendAllText(ruta, sb.ToString());
        }





        private async void btnChuckNorris_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://api.chucknorris.io/jokes/random";
                string respuesta = await _httpClient.GetStringAsync(url);

                var chiste = JsonSerializer.Deserialize<ChuckNorrisJoke>(respuesta);

                lblChuck.Text = $"💬 {chiste.Value}";

               
                picChuck.Load(chiste.IconUrl);

                GuardarChisteEnArchivo(chiste.Value);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("No se pudo conectar a la API de Chuck Norris.");
            }
            catch (JsonException)
            {
                MessageBox.Show("No se pudo interpretar la respuesta de la API.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al obtener el chiste.");
            }
        }


        private void GuardarChisteEnArchivo(string chiste)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chistes.txt");

            string entrada = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {chiste}{Environment.NewLine}";

            File.AppendAllText(ruta, entrada);
        }





        public class ChuckNorrisJoke
        {
            [JsonPropertyName("value")]
            public string Value { get; set; }

            [JsonPropertyName("icon_url")]
            public string IconUrl { get; set; }


        }

        public class PokemonResponse
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("sprites")]
            public Sprites Sprites { get; set; }

            [JsonPropertyName("stats")]
            public StatEntry[] Stats { get; set; }
        }

        public class Sprites
        {
            [JsonPropertyName("front_default")]
            public string FrontDefault { get; set; }
        }

        public class StatEntry
        {
            [JsonPropertyName("base_stat")]
            public int BaseStat { get; set; }

            [JsonPropertyName("stat")]
            public StatName Stat { get; set; }
        }

        public class StatName
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            lblNombre.Text = "";
            lblStats.Text = "";
            picPokemon.Image = null;

           
            lblChuck.Text = "";
            picChuck.Image = null;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}

