using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCounter
{
    public static class PokemonSpriteMapper
    {
        public static Dictionary<string, Dictionary<string, string>> LoadPokemonSprites()
        {
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"shiny");

            var pokemonFiles = new Dictionary<string, Dictionary<string, string>>()
            {
                { "Bulbasaur", new() { { "Base","1.png" } } },
                { "Ivysaur", new() { { "Base", "2.png" } } },
                { "Venusaur", new() { 
                    { "Base", "3.png" },
                    { "Mega", "10033.png" },
                    { "Gigantamax", "10195.png" }
                } },
                { "Charmander", new() { { "Base", "4.png" } } },
                { "Charmeleon", new() { { "Base", "5.png" } } },
                { "Charizard", new() {
                    { "Base", "6.png" },
                    { "MegaX", "10034.png" },
                    { "MegaY", "10035.png" },
                    { "Gigantamax", "10196.png" }
                } },
                { "Squirtle", new() { { "Base", "7.png" } } },
                { "Wartortle", new() { { "Base", "8.png" } } },
                { "Blastoise", new() {
                    { "Base", "9.png" },
                    { "Mega", "10036.png" },
                    { "Gigantamax", "10197.png" }
                } },
                { "Caterpie", new() { { "Base", "10.png" } } },
                { "Metapod", new() { { "Base", "11.png" } } },
                { "Butterfree", new() {
                    { "Base", "12.png" },
                    { "Gigantamax", "10198.png" }                
                } },
                { "Weedle", new() { { "Base", "13.png" } } },
                { "Kakuna", new() { { "Base", "14.png" } } },
                { "Beedrill", new() {
                    { "Base", "15.png" },
                    { "Mega", "10090.png" }
                } },
                { "Pidgey", new() { { "Base", "16.png" } } },
                { "Pidgeotto", new() { { "Base", "17.png" } } },
                { "Pidgeot", new() {
                    { "Kantonian", "18.png" },
                    { "Mega", "10073.png" }
                } },
                { "Rattata", new() {
                    { "Kantonian", "19.png" },
                    { "Alolan", "10091.png" }
                } },
                { "Raticate", new() {
                    { "Kantonian", "20.png" },
                    { "Alolan", "10092.png" }
                } },
                { "Spearow", new() { { "Base", "21.png" } } },
                { "Fearow", new() { { "Base", "22.png" } } },
                { "Ekans", new() { { "Base", "23.png" } } },
                { "Arbok", new() { { "Base", "24.png" } } },
                { "Pikachu", new() { { "Base", "25.png" } } },
                { "Raichu", new() {
                    { "Kantonian", "26.png" },
                    { "Alolan", "10100.png" }
                } },
                { "Sandshrew", new() {
                    { "Kantonian", "27.png" },
                    { "Alolan", "10101.png" }
                } },
                { "Sandslash", new() {
                    { "Kantonian", "28.png" },
                    { "Alolan", "10102.png" }
                } },
                { "Nidoran♀", new() { { "Base", "29.png" } } },
                { "Nidorina", new() { { "Base", "30.png" } } },
                { "Nidoqueen", new() { { "Base", "31.png" } } },
                { "Nidoran♂", new() { { "Base", "32.png" } } },
                { "Nidorino", new() { { "Base", "33.png" } } },
                { "Nidoking", new() { { "Base", "34.png" } } },
                { "Clefairy", new() { { "Base", "35.png" } } },
                { "Clefable", new() { { "Base", "36.png" } } },
                { "Vulpix", new() {
                    { "Kantonian", "37.png" },
                    { "Alolan", "10103.png" }
                } },
                { "Ninetales", new() {
                    { "Kantonian", "38.png" },
                    { "Alolan", "10104.png" }
                } },
                { "Jigglypuff", new() { { "Base", "39.png" } } },
                { "Wigglytuff", new() { { "Base", "40.png" } } },
                { "Zubat", new() { { "Base", "41.png" } } },
                { "Golbat", new() { { "Base", "42.png" } } },
                { "Oddish", new() { { "Base", "43.png" } } },
                { "Gloom", new() { { "Base", "44.png" } } },
                { "Vileplume", new() { { "Base", "45.png" } } },
                { "Paras", new() { { "Base", "46.png" } } },
                { "Parasect", new() { { "Base", "47.png" } } },
                { "Venonat", new() { { "Base", "48.png" } } },
                { "Venomoth", new() { { "Base", "49.png" } } },
                { "Diglett", new() {
                    { "Kantonian", "50.png" },
                    { "Alolan", "10105.png" }
                } },
                { "Dugtrio", new() {
                    { "Kantonian", "51.png" },
                    {"Alolan", "10106.png" }
                } },
                { "Meowth", new() {
                    { "Kantonian", "52.png" },
                    {"Alolan", "10107.png" },
                    {"Galarian", "10161.png" },
                    {"Gigantamax", "10200.png" }
                } },
                { "Persian", new() {
                    { "Kantonian", "53.png" },
                    {"Alolan", "10108.png" }
                } },
                { "Psyduck", new() { { "Base", "54.png" } } },
                { "Golduck", new() { { "Base", "55.png" } } },
                { "Mankey", new() { { "Base", "56.png" } } },
                { "Primeape", new() { { "Base", "57.png" } } },
                { "Growlithe", new() {
                    { "Kantonian", "58.png" },
                    {"Hisuian", "10229.png" }
                } },
                { "Arcanine", new() {
                    { "Kantonian", "59.png" },
                    {"Hisuian", "10230.png" }
                } },
                { "Poliwag", new() { { "Base", "60.png" } } },
                { "Poliwhirl", new() { { "Base", "61.png" } } },
                { "Poliwrath", new() { { "Base", "62.png" } } },
                { "Abra", new() { { "Base", "63.png" } } },
                { "Kadabra", new() { { "Base", "64.png" } } },
                { "Alakazam", new() {
                    { "Base", "65.png" },
                    {"Mega", "10037.png" }
                } },
                { "Machop", new() { { "Base", "66.png" } } },
                { "Machoke", new() { { "Base", "67.png" } } },
                { "Machamp", new() {
                    { "Base", "68.png" },
                    {"Gigantamax", "10201.png" }
                } },
                { "Bellsprout", new() { { "Base", "69.png" } } },
                { "Weepinbell", new() { { "Base", "70.png" } } },
                { "Victreebel", new() { { "Base", "71.png" } } },
                { "Tentacool", new() { { "Base", "72.png" } } },
                { "Tentacruel", new() { { "Base", "73.png" } } },
                { "Geodude", new() {
                    { "Kantonian", "74.png" },
                    { "Alolan", "10109.png" }
                } },
                { "Graveler", new() {
                    { "Kantonian", "75.png" },
                    { "Alolan", "10110.png" }
                } },
                { "Golem", new() {
                    { "Kantonian", "76.png" },
                    { "Alolan", "10111.png" }
                } },
                { "Ponyta", new() {
                    { "Kantonian", "77.png" },
                    { "Galarian", "10162.png" }
                } },
                { "Rapidash", new() {
                    { "Kantonian", "78.png" },
                    { "Galarian", "10163.png" }
                } },
                { "Slowpoke", new() {
                    { "Kantonian", "79.png" },
                    { "Galarian", "10164.png" }
                } },
                { "Slowbro", new() {
                    { "Kantonian", "80.png" },
                    { "Mega", "10038.png" },
                    { "Galarian", "10165.png" }
                } },
                { "Magnemite", new() { { "Base", "81.png" } } },
                { "Magneton", new() { { "Base", "82.png" } } },
                { "Farfetch’d", new() {
                    { "Kantonian", "83.png" },
                    { "Galarian", "10166.png" }
                } },
                { "Doduo", new() { { "Base", "84.png" } } },
                { "Dodrio", new() { { "Base", "85.png" } } },
                { "Seel", new() { { "Base", "86.png" } } },
                { "Dewgong", new() { { "Base", "87.png" } } },
                { "Grimer", new() {
                    { "Kantonian", "88.png" },
                    { "Alolan", "10112.png" }
                } },
                { "Muk", new() {
                    { "Kantonian", "89.png" },
                    { "Alolan", "10113.png" }
                } },
                { "Shellder", new() { { "Base", "90.png" } } },
                { "Cloyster", new() { { "Base", "91.png" } } },
                { "Gastly", new() { { "Base", "92.png" } } },
                { "Haunter", new() { { "Base", "93.png" } } },
                { "Gengar", new() {
                    { "Base", "94.png" },
                    { "Mega", "10038.png" },
                    { "Gigantamax", "10202.png" }
                } },
                { "Onix", new() { { "Base", "95.png" } } },
                { "Drowzee", new() { { "Base", "96.png" } } },
                { "Hypno", new() { { "Base", "97.png" } } },
                { "Krabby", new() { { "Base", "98.png" } } },
                { "Kingler", new() {
                    { "Base", "99.png" },
                    { "Gigantamax", "10203.png" }
                } },
                { "Voltorb", new() {
                    { "Kantoian", "100.png" },
                    { "Hisuian", "10231.png" }
                } },
                { "Electrode", new() {
                    { "Kantonian", "101.png" },
                    { "Hisuian", "10232.png" }
                } },
                { "Exeggcute", new() { { "Base", "102.png" } } },
                { "Exeggutor", new() {
                    { "Kantonian", "103.png" },
                    { "Alolan", "10114.png" }
                } },
                { "Cubone", new() { { "Base", "104.png" } } },
                { "Marowak", new() {
                    { "Kantonian", "105.png" },
                    { "Alolan", "10115.png" }
                } },
                { "Hitmonlee", new() { { "Base", "106.png" } } },
                { "Hitmonchan", new() { { "Base", "107.png" } } },
                { "Lickitung", new() { { "Base", "108.png" } } },
                { "Koffing", new() { { "Base", "109.png" } } },
                { "Weezing", new() {
                    { "Kantonian", "110.png" },
                    { "Galarian", "10167.png" }
                } },
                { "Rhyhorn", new() { { "Base", "111.png" } } },
                { "Rhydon", new() { { "Base", "112.png" } } },
                { "Chansey", new() { { "Base", "113.png" } } },
                { "Tangela", new() { { "Base", "114.png" } } },
                { "Kangaskhan", new() {
                    { "Base", "115.png" },
                    { "Mega", "10039.png" }
                } },
                { "Horsea", new() { { "Base", "116.png" } } },
                { "Seadra", new() { { "Base", "117.png" } } },
                { "Goldeen", new() { { "Base", "118.png" } } },
                { "Seaking", new() { { "Base", "119.png" } } },
                { "Staryu", new() { { "Base", "120.png" } } },
                { "Starmie", new() { { "Base", "121.png" } } },
                { "Mr. Mime", new() {
                    { "Kantonian", "122.png" },
                    { "Galarian", "10168.png" }
                } },
                { "Scyther", new() { { "Base", "123.png" } } },
                { "Jynx", new() { { "Base", "124.png" } } },
                { "Electabuzz", new() { { "Base", "125.png" } } },
                { "Magmar", new() { { "Base", "126.png" } } },
                { "Pinsir", new() {
                    { "Base", "127.png" },
                    { "Mega", "10040.png" }
                } },
                { "Tauros", new() {
                    { "Kantonian", "128.png" },
                    { "Paldean", "10233.png" },
                    { "Combat", "10234.png" },
                    { "Aqua", "10235.png" }
                } },
                { "Magikarp", new() { { "Base", "129.png" } } },
                { "Gyarados", new() {
                    { "Base", "130.png" },
                    { "Mega", "10041.png" }
                } },
                { "Lapras", new() {
                    { "Base", "131.png" },
                    { "Gigantamax", "10204.png" }
                } },
                { "Ditto", new() { { "Base", "132.png" } } },
                { "Eevee", new() {
                    { "Base", "133.png" },
                    { "Gigantamax", "10205.png" }
                } },
                { "Vaporeon", new() { { "Base", "134.png" } } },
                { "Jolteon", new() { { "Base", "135.png" } } },
                { "Flareon", new() { { "Base", "136.png" } } },
                { "Porygon", new() { { "Base", "137.png" } } },
                { "Omanyte", new() { { "Base", "138.png" } } },
                { "Omastar", new() { { "Base", "139.png" } } },
                { "Kabuto", new() { { "Base", "140.png" } } },
                { "Kabutops", new() { { "Base", "141.png" } } },
                { "Aerodactyl", new() {
                    { "Base", "142.png" },
                    { "Mega", "10042.png" }
                } },
                { "Snorlax", new() {
                    { "Base", "143.png" },
                    {"Gigantamax", "10206.png" }
                } },
                { "Articuno", new() {
                    { "Base", "144.png" },
                    {"Galarian", "10169.png" }
                } },
                { "Zapdos", new() {
                    { "Base", "145.png" },
                    {"Galarian", "10170.png" }
                } },
                { "Moltres", new() {
                    { "Base", "146.png" },
                    {"Galarian", "10171.png" }
                } },
                { "Dratini", new() { { "Base", "147.png" } } },
                { "Dragonair", new() { { "Base", "148.png" } } },
                { "Dragonite", new() { { "Base", "149.png" } } },
                { "Mewtwo", new() {
                    { "Base", "150.png" },
                    { "MegaX", "10043.png" },
                    { "MegaY", "10044.png" }
                } },
                { "Mew", new() { { "Base", "151.png" } } },
                { "Chikorita", new() { { "Base", "152.png" } } },
                { "Bayleef", new() { { "Base", "153.png" } } },
                { "Meganium", new() { { "Base", "154.png" } } },
                { "Cyndaquil", new() { { "Base", "155.png" } } },
                { "Quilava", new() { { "Base", "156.png" } } },
                { "Typhlosion", new() {
                    { "Base", "157.png" },
                    { "Hisuian", "10233.png" }
                } },
                { "Totodile", new() { { "Base", "158.png" } } },
                { "Croconaw", new() { { "Base", "159.png" } } },
                { "Feraligatr", new() { { "Base", "160.png" } } },
                { "Sentret", new() { { "Base", "161.png" } } },
                { "Furret", new() { { "Base", "162.png" } } },
                { "Hoothoot", new() { { "Base", "163.png" } } },
                { "Noctowl", new() { { "Base", "164.png" } } },
                { "Ledyba", new() { { "Base", "165.png" } } },
                { "Ledian", new() { { "Base", "166.png" } } },
                { "Spinarak", new() { { "Base", "167.png" } } },
                { "Ariados", new() { { "Base", "168.png" } } },
                { "Crobat", new() { { "Base", "169.png" } } },
                { "Chinchou", new() { { "Base", "170.png" } } },
                { "Lanturn", new() { { "Base", "171.png" } } },
                { "Pichu", new() { { "Base", "172.png" } } },
                { "Cleffa", new() { { "Base", "173.png" } } },
                { "Igglybuff", new() { { "Base", "174.png" } } },
                { "Togepi", new() { { "Base", "175.png" } } },
                { "Togetic", new() { { "Base", "176.png" } } },
                { "Natu", new() { { "Base", "177.png" } } },
                { "Xatu", new() { { "Base", "178.png" } } },
                { "Mareep", new() { { "Base", "179.png" } } },
                { "Flaaffy", new() { { "Base", "180.png" } } },
                { "Ampharos", new() {
                    { "Base", "181.png" },
                    { "Mega", "10045.png" }
                } },
                { "Bellossom", new() { { "Base", "182.png" } } },
                { "Marill", new() { { "Base", "183.png" } } },
                { "Azumarill", new() { { "Base", "184.png" } } },
                { "Sudowoodo", new() { { "Base", "185.png" } } },
                { "Politoed", new() { { "Base", "186.png" } } },
                { "Hoppip", new() { { "Base", "187.png" } } },
                { "Skiploom", new() { { "Base", "188.png" } } },
                { "Jumpluff", new() { { "Base", "189.png" } } },
                { "Aipom", new() { { "Base", "190.png" } } },
                { "Sunkern", new() { { "Base", "191.png" } } },
                { "Sunflora", new() { { "Base", "192.png" } } },
                { "Yanma", new() { { "Base", "193.png" } } },
                { "Wooper", new() {
                    { "Base", "194.png" },
                    { "Paldean", "10253.png" }
                } },
                { "Quagsire", new() { { "Base", "195.png" } } },
                { "Espeon", new() { { "Base", "196.png" } } },
                { "Umbreon", new() { { "Base", "197.png" } } },
                { "Murkrow", new() { { "Base", "198.png" } } },
                { "Slowking", new() {
                    { "Base", "199.png" },
                    { "Galarian", "10172.png" }
                } },
                { "Misdreavus", new() { { "Base", "200.png" } } },
                { "Unown", new() {
                    { "Unown - A", "201.png" },
                    { "Unown - B", "201-b.png" },
                    { "Unown - C", "201-c.png" },
                    { "Unown - D", "201-d.png" },
                    { "Unown - E", "201-e.png" },
                    { "Unown - F", "201-f.png" },
                    { "Unown - G", "201-g.png" },
                    { "Unown - H", "201-h.png" },
                    { "Unown - I", "201-i.png" },
                    { "Unown - J", "201-j.png" },
                    { "Unown - K", "201-k.png" },
                    { "Unown - L", "201-l.png" },
                    { "Unown - M", "201-m.png" },
                    { "Unown - N", "201-n.png" },
                    { "Unown - O", "201-o.png" },
                    { "Unown - P", "201-p.png" },
                    { "Unown - Q", "201-q.png" },
                    { "Unown - R", "201-r.png" },
                    { "Unown - S", "201-s.png" },
                    { "Unown - T", "201-t.png" },
                    { "Unown - U", "201-u.png" },
                    { "Unown - V", "201-v.png" },
                    { "Unown - W", "201-w.png" },
                    { "Unown - X", "201-x.png" },
                    { "Unown - Y", "201-y.png" },
                    { "Unown - Z", "201-z.png" },
                    { "Unown - !", "201-exclamation.png" },
                    { "Unown - ?", "201-question.png" },
                } },
                { "Wobbuffet", new() { { "Base", "202.png" } } },
                { "Girafarig", new() { { "Base", "203.png" } } },
                { "Pineco", new() { { "Base", "204.png" } } },
                { "Forretress", new() { { "Base", "205.png" } } },
                { "Dunsparce", new() { { "Base", "206.png" } } },
                { "Gligar", new() { { "Base", "207.png" } } },
                { "Steelix", new() {
                    { "Base", "208.png" },
                    { "Mega", "10072.png" }
                } },
                { "Snubbull", new() { { "Base", "209.png" } } },
                { "Granbull", new() { { "Base", "210.png" } } },
                { "Qwilfish", new() {
                    { "Base", "211.png" },
                    { "Hisuian", "10234.png" }
                } },
                { "Scizor", new() {
                    { "Base", "212.png" },
                    { "Mega", "10046.png" }
                } },
                { "Shuckle", new() { { "Base", "213.png" } } },
                { "Heracross", new() {
                    { "Base", "214.png" },
                    { "Mega", "10047.png" }
                } },
                { "Sneasel", new() {
                    { "Base", "215.png" },
                    { "Hisuian", "10235.png" }
                } },
                { "Teddiursa", new() { { "Base", "216.png" } } },
                { "Ursaring", new() { { "Base", "217.png" } } },
                { "Slugma", new() { { "Base", "218.png" } } },
                { "Magcargo", new() { { "Base", "219.png" } } },
                { "Swinub", new() { { "Base", "220.png" } } },
                { "Piloswine", new() { { "Base", "221.png" } } },
                { "Corsola", new() {
                    { "Base", "222.png" },
                    { "Galarian", "10173.png" }
                } },
                { "Remoraid", new() { { "Base", "223.png" } } },
                { "Octillery", new() { { "Base", "224.png" } } },
                { "Delibird", new() { { "Base", "225.png" } } },
                { "Mantine", new() { { "Base", "226.png" } } },
                { "Skarmory", new() { { "Base", "227.png" } } },
                { "Houndour", new() { { "Base", "228.png" } } },
                { "Houndoom", new() {
                    { "Base", "229.png" },
                    { "Mega", "10048.png" }
                } },
                { "Kingdra", new() { { "Base", "230.png" } } },
                { "Phanpy", new() { { "Base", "231.png" } } },
                { "Donphan", new() { { "Base", "232.png" } } },
                { "Porygon2", new() { { "Base", "233.png" } } },
                { "Stantler", new() { { "Base", "234.png" } } },
                { "Smeargle", new() { { "Base", "235.png" } } },
                { "Tyrogue", new() { { "Base", "236.png" } } },
                { "Hitmontop", new() { { "Base", "237.png" } } },
                { "Smoochum", new() { { "Base", "238.png" } } },
                { "Elekid", new() { { "Base", "239.png" } } },
                { "Magby", new() { { "Base", "240.png" } } },
                { "Miltank", new() { { "Base", "241.png" } } },
                { "Blissey", new() { { "Base", "242.png" } } },
                { "Raikou", new() { { "Base", "243.png" } } },
                { "Entei", new() { { "Base", "244.png" } } },
                { "Suicune", new() { { "Base", "245.png" } } },
                { "Larvitar", new() { { "Base", "246.png" } } },
                { "Pupitar", new() { { "Base", "247.png" } } },
                { "Tyranitar", new() {
                    { "Base", "248.png" },
                    { "Mega", "10049.png" }
                } },
                { "Lugia", new() { { "Base", "249.png" } } },
                { "Ho-Oh", new() { { "Base", "250.png" } } },
                { "Celebi", new() { { "Base", "251.png" } } },
                { "Treecko", new() { { "Base", "252.png" } } },
                { "Grovyle", new() { { "Base", "253.png" } } },
                { "Sceptile", new() {
                    { "Base", "254.png" },
                    { "Mega", "10065.png" }
                } },
                { "Torchic", new() { { "Base", "255.png" } } },
                { "Combusken", new() { { "Base", "256.png" } } },
                { "Blaziken", new() {
                    { "Base", "257.png" },
                    { "Mega", "10050.png" }
                } },
                { "Mudkip", new() { { "Base", "258.png" } } },
                { "Marshtomp", new() { { "Base", "259.png" } } },
                { "Swampert", new() {
                    { "Base", "260.png" },
                    { "Mega", "10064.png" }
                } },
                { "Poochyena", new() { { "Base", "261.png" } } },
                { "Mightyena", new() { { "Base", "262.png" } } },
                { "Zigzagoon", new() {
                    { "Base", "263.png" },
                    { "Galarian", "10174.png" }
                } },
                { "Linoone", new() {
                    { "Base", "264.png" },
                    {"Galarian", "10175.png" }
                } },
                { "Wurmple", new() { { "Base", "265.png" } } },
                { "Silcoon", new() { { "Base", "266.png" } } },
                { "Beautifly", new() { { "Base", "267.png" } } },
                { "Cascoon", new() { { "Base", "268.png" } } },
                { "Dustox", new() { { "Base", "269.png" } } },
                { "Lotad", new() { { "Base", "270.png" } } },
                { "Lombre", new() { { "Base", "271.png" } } },
                { "Ludicolo", new() { { "Base", "272.png" } } },
                { "Seedot", new() { { "Base", "273.png" } } },
                { "Nuzleaf", new() { { "Base", "274.png" } } },
                { "Shiftry", new() { { "Base", "275.png" } } },
                { "Taillow", new() { { "Base", "276.png" } } },
                { "Swellow", new() { { "Base", "277.png" } } },
                { "Wingull", new() { { "Base", "278.png" } } },
                { "Pelipper", new() { { "Base", "279.png" } } },
                { "Ralts", new() { { "Base", "280.png" } } },
                { "Kirlia", new() { { "Base", "281.png" } } },
                { "Gardevoir", new() {
                    { "Base", "282.png" },
                    { "Mega", "10051.png" }
                } },
                { "Surskit", new() { { "Base", "283.png" } } },
                { "Masquerain", new() { { "Base", "284.png" } } },
                { "Shroomish", new() { { "Base", "285.png" } } },
                { "Breloom", new() { { "Base", "286.png" } } },
                { "Slakoth", new() { { "Base", "287.png" } } },
                { "Vigoroth", new() { { "Base", "288.png" } } },
                { "Slaking", new() { { "Base", "289.png" } } },
                { "Nincada", new() { { "Base", "290.png" } } },
                { "Ninjask", new() { { "Base", "291.png" } } },
                { "Shedinja", new() { { "Base", "292.png" } } },
                { "Whismur", new() { { "Base", "293.png" } } },
                { "Loudred", new() { { "Base", "294.png" } } },
                { "Exploud", new() { { "Base", "295.png" } } },
                { "Makuhita", new() { { "Base", "296.png" } } },
                { "Hariyama", new() { { "Base", "297.png" } } },
                { "Azurill", new() { { "Base", "298.png" } } },
                { "Nosepass", new() { { "Base", "299.png" } } },
                { "Skitty", new() { { "Base", "300.png" } } },
                { "Delcatty", new() { { "Base", "301.png" } } },
                { "Sableye", new() {
                    { "Base", "302.png" },
                    { "Mega", "10066.png" }
                } },
                { "Mawile", new() {
                    { "Base", "303.png" },
                    { "Mega", "10052.png" }
                } },
                { "Aron", new() { { "Base", "304.png" } } },
                { "Lairon", new() { { "Base", "305.png" } } },
                { "Aggron", new() {
                    { "Base", "306.png" },
                    { "Mega", "10053.png" }
                } },
                { "Meditite", new() { { "Base", "307.png" } } },
                { "Medicham", new() {
                    { "Base", "308.png" },
                    { "Mega", "10054.png" }
                } },
                { "Electrike", new() { { "Base", "309.png" } } },
                { "Manectric", new() { 
                    { "Base", "310.png" },
                    { "Mega", "10055.png" }
                } },
                { "Plusle", new() { { "Base", "311.png" } } },
                { "Minun", new() { { "Base", "312.png" } } },
                { "Volbeat", new() { { "Base", "313.png" } } },
                { "Illumise", new() { { "Base", "314.png" } } },
                { "Roselia", new() { { "Base", "315.png" } } },
                { "Gulpin", new() { { "Base", "316.png" } } },
                { "Swalot", new() { { "Base", "317.png" } } },
                { "Carvanha", new() { { "Base", "318.png" } } },
                { "Sharpedo", new() {
                    { "Base", "319.png" },
                    { "Mega", "10070.png" }
                } },
                { "Wailmer", new() { { "Base", "320.png" } } },
                { "Wailord", new() { { "Base", "321.png" } } },
                { "Numel", new() { { "Base", "322.png" } } },
                { "Camerupt", new() {
                    { "Base", "323.png" },
                    { "Mega", "10087.png" }
                } },
                { "Torkoal", new() { { "Base", "324.png" } } },
                { "Spoink", new() { { "Base", "325.png" } } },
                { "Grumpig", new() { { "Base", "326.png" } } },
                { "Spinda", new() { { "Base", "327.png" } } },
                { "Trapinch", new() { { "Base", "328.png" } } },
                { "Vibrava", new() { { "Base", "329.png" } } },
                { "Flygon", new() { { "Base", "330.png" } } },
                { "Cacnea", new() { { "Base", "331.png" } } },
                { "Cacturne", new() { { "Base", "332.png" } } },
                { "Swablu", new() { { "Base", "333.png" } } },
                { "Altaria", new() { 
                    { "Base", "334.png" },
                    { "Mega", "10067.png" }
                } },
                { "Zangoose", new() { { "Base", "335.png" } } },
                { "Seviper", new() { { "Base", "336.png" } } },
                { "Lunatone", new() { { "Base", "337.png" } } },
                { "Solrock", new() { { "Base", "338.png" } } },
                { "Barboach", new() { { "Base", "339.png" } } },
                { "Whiscash", new() { { "Base", "340.png" } } },
                { "Corphish", new() { { "Base", "341.png" } } },
                { "Crawdaunt", new() { { "Base", "342.png" } } },
                { "Baltoy", new() { { "Base", "343.png" } } },
                { "Claydol", new() { { "Base", "344.png" } } },
                { "Lileep", new() { { "Base", "345.png" } } },
                { "Cradily", new() { { "Base", "346.png" } } },
                { "Anorith", new() { { "Base", "347.png" } } },
                { "Armaldo", new() { { "Base", "348.png" } } },
                { "Feebas", new() { { "Base", "349.png" } } },
                { "Milotic", new() { { "Base", "350.png" } } },
                { "Castform", new() {
                    { "Base", "351.png" },
                    { "Sunny", "10013.png" },
                    { "Rainy", "10014.png" },
                    { "Snowy", "10015.png" }
                } },
                { "Kecleon", new() { { "Base", "352.png" } } },
                { "Shuppet", new() { { "Base", "353.png" } } },
                { "Banette", new() {
                    { "Base", "354.png" },
                    { "Mega", "10056.png" }
                } },
                { "Duskull", new() { { "Base", "355.png" } } },
                { "Dusclops", new() { { "Base", "356.png" } } },
                { "Tropius", new() { { "Base", "357.png" } } },
                { "Chimecho", new() { { "Base", "358.png" } } },
                { "Absol", new() { 
                    { "Base", "359.png" },
                    { "Mega", "10057.png" }
                } },
                { "Wynaut", new() { { "Base", "360.png" } } },
                { "Snorunt", new() { { "Base", "361.png" } } },
                { "Glalie", new() { 
                    { "Base", "362.png" },
                    { "Mega", "10074.png" }
                } },
                { "Spheal", new() { { "Base", "363.png" } } },
                { "Sealeo", new() { { "Base", "364.png" } } },
                { "Walrein", new() { { "Base", "365.png" } } },
                { "Clamperl", new() { { "Base", "366.png" } } },
                { "Huntail", new() { { "Base", "367.png" } } },
                { "Gorebyss", new() { { "Base", "368.png" } } },
                { "Relicanth", new() { { "Base", "369.png" } } },
                { "Luvdisc", new() { { "Base", "370.png" } } },
                { "Bagon", new() { { "Base", "371.png" } } },
                { "Shelgon", new() { { "Base", "372.png" } } },
                { "Salamence", new() { 
                    { "Base", "373.png" },
                    { "Mega", "10089.png" }
                } },
                { "Beldum", new() { { "Base", "374.png" } } },
                { "Metang", new() { { "Base", "375.png" } } },
                { "Metagross", new() { 
                    { "Base", "376.png" },
                    { "Mega", "10076.png" }
                } },
                { "Regirock", new() { { "Base", "377.png" } } },
                { "Regice", new() { { "Base", "378.png" } } },
                { "Registeel", new() { { "Base", "379.png" } } },
                { "Latias", new() { 
                    { "Base", "380.png" },
                    { "Mega", "10062.png" }
                } },
                { "Latios", new() {
                    { "Base", "381.png" },
                    { "Mega", "10063.png" }
                } },
                { "Kyogre", new() {
                    { "Base", "382.png" },
                    { "Primal", "10077.png"}
                } },
                { "Groudon", new() { 
                    { "Base", "383.png" },
                    { "Primal", "10078.png" }
                } },
                { "Rayquaza", new() { 
                    { "Base", "384.png" },
                    { "Mega", "10079.png" }
                } },
                { "Jirachi", new() { { "Base", "385.png" } } },
                { "Deoxys", new() { 
                    { "Base", "386.png" },
                    { "Attack", "10001.png" },
                    { "Defense", "10002.png" },
                    { "Speed", "10003.png" }
                } },
                { "Turtwig", new() { { "Base", "387.png" } } },
                { "Grotle", new() { { "Base", "388.png" } } },
                { "Torterra", new() { { "Base", "389.png" } } },
                { "Chimchar", new() { { "Base", "390.png" } } },
                { "Monferno", new() { { "Base", "391.png" } } },
                { "Infernape", new() { { "Base", "392.png" } } },
                { "Piplup", new() { { "Base", "393.png" } } },
                { "Prinplup", new() { { "Base", "394.png" } } },
                { "Empoleon", new() { { "Base", "395.png" } } },
                { "Starly", new() { { "Base", "396.png" } } },
                { "Staravia", new() { { "Base", "397.png" } } },
                { "Staraptor", new() { { "Base", "398.png" } } },
                { "Bidoof", new() { { "Base", "399.png" } } },
                { "Bibarel", new() { { "Base", "400.png" } } },
                { "Kricketot", new() { { "Base", "401.png" } } },
                { "Kricketune", new() { { "Base", "402.png" } } },
                { "Shinx", new() { { "Base", "403.png" } } },
                { "Luxio", new() { { "Base", "404.png" } } },
                { "Luxray", new() { { "Base", "405.png" } } },
                { "Budew", new() { { "Base", "406.png" } } },
                { "Roserade", new() { { "Base", "407.png" } } },
                { "Cranidos", new() { { "Base", "408.png" } } },
                { "Rampardos", new() { { "Base", "409.png" } } },
                { "Shieldon", new() { { "Base", "410.png" } } },
                { "Bastiodon", new() { { "Base", "411.png" } } },
                { "Burmy", new() { 
                    { "Plant Cloak", "412.png" },
                    { "Sandy Cloak", "412-sandy.png" },
                    { "Trash Cloak", "412-trash.png" }
                } },
                { "Wormadam", new() { 
                    { "Base", "413.png" },
                    { "Sandy Cloak", "10004.png" },
                    { "Trash Cloak", "10005.png" }
                } },
                { "Mothim", new() { { "Base", "414.png" } } },
                { "Combee", new() { { "Base", "415.png" } } },
                { "Vespiquen", new() { { "Base", "416.png" } } },
                { "Pachirisu", new() { { "Base", "417.png" } } },
                { "Buizel", new() { { "Base", "418.png" } } },
                { "Floatzel", new() { { "Base", "419.png" } } },
                { "Cherubi", new() { { "Base", "420.png" } } },
                { "Cherrim", new() { 
                    { "Overcast", "421.png" },
                    { "Sunshine", "421-sunshine.png" }
                } },
                { "Shellos", new() { 
                    { "West Sea", "422.png" },
                    { "East Sea", "422-east.png" }
                } },
                { "Gastrodon", new() { 
                    { "West Sea", "423.png" },
                    { "East Sea", "423-east.png" }
                } },
                { "Ambipom", new() { { "Base", "424.png" } } },
                { "Drifloon", new() { { "Base", "425.png" } } },
                { "Drifblim", new() { { "Base", "426.png" } } },
                { "Buneary", new() { { "Base", "427.png" } } },
                { "Lopunny", new() { 
                    { "Base", "428.png" },
                    { "Mega", "10088.png" }
                } },
                { "Mismagius", new() { { "Base", "429.png" } } },
                { "Honchkrow", new() { { "Base", "430.png" } } },
                { "Glameow", new() { { "Base", "431.png" } } },
                { "Purugly", new() { { "Base", "432.png" } } },
                { "Chingling", new() { { "Base", "433.png" } } },
                { "Stunky", new() { { "Base", "434.png" } } },
                { "Skuntank", new() { { "Base", "435.png" } } },
                { "Bronzor", new() { { "Base", "436.png" } } },
                { "Bronzong", new() { { "Base", "437.png" } } },
                { "Bonsly", new() { { "Base", "438.png" } } },
                { "Mime Jr.", new() { { "Base", "439.png" } } },
                { "Happiny", new() { { "Base", "440.png" } } },
                { "Chatot", new() { { "Base", "441.png" } } },
                { "Spiritomb", new() { { "Base", "442.png" } } },
                { "Gible", new() { { "Base", "443.png" } } },
                { "Gabite", new() { { "Base", "444.png" } } },
                { "Garchomp", new() { 
                    { "Base", "445.png" },
                    { "Mega", "10058.png" }
                } },
                { "Munchlax", new() { { "Base", "446.png" } } },
                { "Riolu", new() { { "Base", "447.png" } } },
                { "Lucario", new() { 
                    { "Base", "448.png" },
                    { "Mega", "10059.png" }
                } },
                { "Hippopotas", new() { { "Base", "449.png" } } },
                { "Hippowdon", new() { { "Base", "450.png" } } },
                { "Skorupi", new() { { "Base", "451.png" } } },
                { "Drapion", new() { { "Base", "452.png" } } },
                { "Croagunk", new() { { "Base", "453.png" } } },
                { "Toxicroak", new() { { "Base", "454.png" } } },
                { "Carnivine", new() { { "Base", "455.png" } } },
                { "Finneon", new() { { "Base", "456.png" } } },
                { "Lumineon", new() { { "Base", "457.png" } } },
                { "Mantyke", new() { { "Base", "458.png" } } },
                { "Snover", new() { { "Base", "459.png" } } },
                { "Abomasnow", new() { 
                    { "Base", "460.png" },
                    { "Mega", "10060.png" }
                } },
                { "Weavile", new() { { "Base", "461.png" } } },
                { "Magnezone", new() { { "Base", "462.png" } } },
                { "Lickilicky", new() { { "Base", "463.png" } } },
                { "Rhyperior", new() { { "Base", "464.png" } } },
                { "Tangrowth", new() { { "Base", "465.png" } } },
                { "Electivire", new() { { "Base", "466.png" } } },
                { "Magmortar", new() { { "Base", "467.png" } } },
                { "Togekiss", new() { { "Base", "468.png" } } },
                { "Yanmega", new() { { "Base", "469.png" } } },
                { "Leafeon", new() { { "Base", "470.png" } } },
                { "Glaceon", new() { { "Base", "471.png" } } },
                { "Gliscor", new() { { "Base", "472.png" } } },
                { "Mamoswine", new() { { "Base", "473.png" } } },
                { "Porygon-Z", new() { { "Base", "474.png" } } },
                { "Gallade", new() { 
                    { "Base", "475.png" },
                    { "Mega", "10068.png" }
                } },
                { "Probopass", new() { { "Base", "476.png" } } },
                { "Dusknoir", new() { { "Base", "477.png" } } },
                { "Froslass", new() { { "Base", "478.png" } } },
                { "Rotom", new() { 
                    { "Base", "479.png" },
                    { "Heat", "10008.png" },
                    { "Wash", "100009.png" },
                    { "Frost", "10010.png" },
                    { "Fan", "10011.png" },
                    { "Mow", "10012.png" }
                } },
                { "Uxie", new() { { "Base", "480.png" } } },
                { "Mesprit", new() { { "Base", "481.png" } } },
                { "Azelf", new() { { "Base", "482.png" } } },
                { "Dialga", new() { 
                    { "Base", "483.png" },
                    { "Origin", "10245.png" }
                } },
                { "Palkia", new() { 
                    { "Base", "484.png" },
                    { "Origin", "10246.png" }
                } },
                { "Heatran", new() { { "Base", "485.png" } } },
                { "Regigigas", new() { { "Base", "486.png" } } },
                { "Giratina", new() { 
                    { "Base", "487.png" },
                    { "Origin", "10007.png" }
                } },
                { "Cresselia", new() { { "Base", "488.png" } } },
                { "Phione", new() { { "Base", "489.png" } } },
                { "Manaphy", new() { { "Base", "490.png" } } },
                { "Darkrai", new() { { "Base", "491.png" } } },
                { "Shaymin", new() { 
                    { "Land Forme", "492.png" },
                    { "Sky Forme", "10006.png" }
                } },
                { "Arceus", new() { 
                    { "Base", "493.png" },
                    { "Fighting", "493-fighting.png" },
                    { "Flying", "493-flying.png" },
                    { "Poison", "493-poison.png" },
                    { "Ground", "493-ground.png" },
                    { "Rock", "493-rock.png" },
                    { "Bug", "493-bug.png" },
                    { "Ghost", "493-ghost.png" },
                    { "Steel", "493-steel.png" },
                    { "Fire", "493-fire.png" },
                    { "Water", "493-water.png" },
                    { "Grass", "493-grass.png" },
                    { "Electric", "493-electric.png" },
                    { "Psychic", "493-psychic.png" },
                    { "Ice", "493-ice.png" },
                    { "Dragon", "493-dragon.png" },
                    { "Dark", "493-dark.png" },
                    { "Fairy", "493-fairy.png" }
                } },
                { "Victini", new() { { "Base", "494.png" } } },
                { "Snivy", new() { { "Base", "495.png" } } },
                { "Servine", new() { { "Base", "496.png" } } },
                { "Serperior", new() { { "Base", "497.png" } } },
                { "Tepig", new() { { "Base", "498.png" } } },
                { "Pignite", new() { { "Base", "499.png" } } },
                { "Emboar", new() { { "Base", "500.png" } } },
                { "Oshawott", new() { { "Base", "501.png" } } },
                { "Dewott", new() { { "Base", "502.png" } } },
                { "Samurott", new() { 
                    { "Unovan", "503.png" },
                    { "Hisuian", "10336.png" }
                } },
                { "Patrat", new() { { "Base", "504.png" } } },
                { "Watchog", new() { { "Base", "505.png" } } },
                { "Lillipup", new() { { "Base", "506.png" } } },
                { "Herdier", new() { { "Base", "507.png" } } },
                { "Stoutland", new() { { "Base", "508.png" } } },
                { "Purrloin", new() { { "Base", "509.png" } } },
                { "Liepard", new() { { "Base", "510.png" } } },
                { "Pansage", new() { { "Base", "511.png" } } },
                { "Simisage", new() { { "Base", "512.png" } } },
                { "Pansear", new() { { "Base", "513.png" } } },
                { "Simisear", new() { { "Base", "514.png" } } },
                { "Panpour", new() { { "Base", "515.png" } } },
                { "Simipour", new() { { "Base", "516.png" } } },
                { "Munna", new() { { "Base", "517.png" } } },
                { "Musharna", new() { { "Base", "518.png" } } },
                { "Pidove", new() { { "Base", "519.png" } } },
                { "Tranquill", new() { { "Base", "520.png" } } },
                { "Unfezant", new() { { "Base", "521.png" } } },
                { "Blitzle", new() { { "Base", "522.png" } } },
                { "Zebstrika", new() { { "Base", "523.png" } } },
                { "Roggenrola", new() { { "Base", "524.png" } } },
                { "Boldore", new() { { "Base", "525.png" } } },
                { "Gigalith", new() { { "Base", "526.png" } } },
                { "Woobat", new() { { "Base", "527.png" } } },
                { "Swoobat", new() { { "Base", "528.png" } } },
                { "Drilbur", new() { { "Base", "529.png" } } },
                { "Excadrill", new() { { "Base", "530.png" } } },
                { "Audino", new() { { "Base", "531.png" } } },
                { "Timburr", new() { { "Base", "532.png" } } },
                { "Gurdurr", new() { { "Base", "533.png" } } },
                { "Conkeldurr", new() { { "Base", "534.png" } } },
                { "Tympole", new() { { "Base", "535.png" } } },
                { "Palpitoad", new() { { "Base", "536.png" } } },
                { "Seismitoad", new() { { "Base", "537.png" } } },
                { "Throh", new() { { "Base", "538.png" } } },
                { "Sawk", new() { { "Base", "539.png" } } },
                { "Sewaddle", new() { { "Base", "540.png" } } },
                { "Swadloon", new() { { "Base", "541.png" } } },
                { "Leavanny", new() { { "Base", "542.png" } } },
                { "Venipede", new() { { "Base", "543.png" } } },
                { "Whirlipede", new() { { "Base", "544.png" } } },
                { "Scolipede", new() { { "Base", "545.png" } } },
                { "Cottonee", new() { { "Base", "546.png" } } },
                { "Whimsicott", new() { { "Base", "547.png" } } },
                { "Petilil", new() { { "Base", "548.png" } } },
                { "Lilligant", new() { 
                    { "Unovan", "549.png" },
                    { "Hisuian", "10237.png" }
                } },
                { "Basculin", new() { 
                    { "Red-Striped", "550.png" },
                    { "Blue-Striped", "10016.png" },
                    { "White-Striped", "10247.png" }
                } },
                { "Sandile", new() { { "Base", "551.png" } } },
                { "Krokorok", new() { { "Base", "552.png" } } },
                { "Krookodile", new() { { "Base", "553.png" } } },
                { "Darumaka", new() { 
                    { "Base", "554.png" },
                    { "Galarian", "10176.png" }
                } },
                { "Darmanitan", new() { 
                    { "Unovan", "555.png" },
                    { "Zen Mode", "10017.png" },
                    { "Galarian", "10177" },
                    { "Galarian Zen Mode", "10178.png" }
                } },
                { "Maractus", new() { { "Base", "556.png" } } },
                { "Dwebble", new() { { "Base", "557.png" } } },
                { "Crustle", new() { { "Base", "558.png" } } },
                { "Scraggy", new() { { "Base", "559.png" } } },
                { "Scrafty", new() { { "Base", "560.png" } } },
                { "Sigilyph", new() { { "Base", "561.png" } } },
                { "Yamask", new() { 
                    { "Base", "562.png" },
                    { "Galarian", "10179.png" }
                } },
                { "Cofagrigus", new() { { "Base", "563.png" } } },
                { "Tirtouga", new() { { "Base", "564.png" } } },
                { "Carracosta", new() { { "Base", "565.png" } } },
                { "Archen", new() { { "Base", "566.png" } } },
                { "Archeops", new() { { "Base", "567.png" } } },
                { "Trubbish", new() { { "Base", "568.png" } } },
                { "Garbodor", new() { { "Base", "569.png" } } },
                { "Zorua", new() { 
                    { "Unovan", "570.png" },
                    { "Hisuian", "10238.png" }
                } },
                { "Zoroark", new() { 
                    { "Unovan", "571.png" },
                    { "Hisuian", "10239.png" }
                } },
                { "Minccino", new() { { "Base", "572.png" } } },
                { "Cinccino", new() { { "Base", "573.png" } } },
                { "Gothita", new() { { "Base", "574.png" } } },
                { "Gothorita", new() { { "Base", "575.png" } } },
                { "Gothitelle", new() { { "Base", "576.png" } } },
                { "Solosis", new() { { "Base", "577.png" } } },
                { "Duosion", new() { { "Base", "578.png" } } },
                { "Reuniclus", new() { { "Base", "579.png" } } },
                { "Ducklett", new() { { "Base", "580.png" } } },
                { "Swanna", new() { { "Base", "581.png" } } },
                { "Vanillite", new() { { "Base", "582.png" } } },
                { "Vanillish", new() { { "Base", "583.png" } } },
                { "Vanilluxe", new() { { "Base", "584.png" } } },
                { "Deerling", new() { 
                    { "Spring", "585.png" },
                    { "Summer", "585-summer.png" },
                    { "Autumn", "585-autumn.png" },
                    { "Winter", "585-winter.png" }
                } },
                { "Sawsbuck", new() { 
                    { "Spring", "586.png" },
                    { "Summer", "586-summer.png" },
                    { "Autumn", "586-autumn.png" },
                    { "Winter", "586-winter.png" }
                } },
                { "Emolga", new() { { "Base", "587.png" } } },
                { "Karrablast", new() { { "Base", "588.png" } } },
                { "Escavalier", new() { { "Base", "589.png" } } },
                { "Foongus", new() { { "Base", "590.png" } } },
                { "Amoonguss", new() { { "Base", "591.png" } } },
                { "Frillish", new() { { "Base", "592.png" } } },
                { "Jellicent", new() { { "Base", "593.png" } } },
                { "Alomomola", new() { { "Base", "594.png" } } },
                { "Joltik", new() { { "Base", "595.png" } } },
                { "Galvantula", new() { { "Base", "596.png" } } },
                { "Ferroseed", new() { { "Base", "597.png" } } },
                { "Ferrothorn", new() { { "Base", "598.png" } } },
                { "Klink", new() { { "Base", "599.png" } } },
                { "Klang", new() { { "Base", "600.png" } } },
                { "Klinklang", new() { { "Base", "601.png" } } },
                { "Tynamo", new() { { "Base", "602.png" } } },
                { "Eelektrik", new() { { "Base", "603.png" } } },
                { "Eelektross", new() { { "Base", "604.png" } } },
                { "Elgyem", new() { { "Base", "605.png" } } },
                { "Beheeyem", new() { { "Base", "606.png" } } },
                { "Litwick", new() { { "Base", "607.png" } } },
                { "Lampent", new() { { "Base", "608.png" } } },
                { "Chandelure", new() { { "Base", "609.png" } } },
                { "Axew", new() { { "Base", "610.png" } } },
                { "Fraxure", new() { { "Base", "611.png" } } },
                { "Haxorus", new() { { "Base", "612.png" } } },
                { "Cubchoo", new() { { "Base", "613.png" } } },
                { "Beartic", new() { { "Base", "614.png" } } },
                { "Cryogonal", new() { { "Base", "615.png" } } },
                { "Shelmet", new() { { "Base", "616.png" } } },
                { "Accelgor", new() { { "Base", "617.png" } } },
                { "Stunfisk", new() { { "Base", "618.png" } } },
                { "Mienfoo", new() { { "Base", "619.png" } } },
                { "Mienshao", new() { { "Base", "620.png" } } },
                { "Druddigon", new() { { "Base", "621.png" } } },
                { "Golett", new() { { "Base", "622.png" } } },
                { "Golurk", new() { { "Base", "623.png" } } },
                { "Pawniard", new() { { "Base", "624.png" } } },
                { "Bisharp", new() { { "Base", "625.png" } } },
                { "Bouffalant", new() { { "Base", "626.png" } } },
                { "Rufflet", new() { { "Base", "627.png" } } },
                { "Braviary", new() { 
                    { "Unovan", "628.png" },
                    { "Hisuian", "10240.png" }
                } },
                { "Vullaby", new() { { "Base", "629.png" } } },
                { "Mandibuzz", new() { { "Base", "630.png" } } },
                { "Heatmor", new() { { "Base", "631.png" } } },
                { "Durant", new() { { "Base", "632.png" } } },
                { "Deino", new() { { "Base", "633.png" } } },
                { "Zweilous", new() { { "Base", "634.png" } } },
                { "Hydreigon", new() { { "Base", "635.png" } } },
                { "Larvesta", new() { { "Base", "636.png" } } },
                { "Volcarona", new() { { "Base", "637.png" } } },
                { "Cobalion", new() { { "Base", "638.png" } } },
                { "Terrakion", new() { { "Base", "639.png" } } },
                { "Virizion", new() { { "Base", "640.png" } } },
                { "Tornadus", new() { 
                    { "Incarnate", "641.png" },
                    { "Therian", "10019.png" }
                } },
                { "Thundurus", new() { 
                    { "Incarnate", "642.png" },
                    { "Therian", "10020.png" }
                } },
                { "Reshiram", new() { { "Base", "643.png" } } },
                { "Zekrom", new() { { "Base", "644.png" } } },
                { "Landorus", new() { 
                    { "Incarnate", "645.png" },
                    { "Therian", "10021.png" }
                } },
                { "Kyurem", new() { 
                    { "Base", "646.png" },
                    { "Black Kyurem", "10022.png" },
                    { "White Kyurem", "10023.png" }
                } },
                { "Keldeo", new() { 
                    { "Ordinary", "647.png" },
                    { "Resolute", "10024.png" }
                } },
                { "Meloetta", new() {
                    { "Aria", "648.png" },
                    { "Pirouette", "10018.png" }
                } },
                { "Genesect", new() { 
                    { "Base", "649.png" },
                    { "Douse Drive", "649-douse.png" },
                    { "Shock Drive", "649-shock.png" },
                    { "Burn Drive", "649-burn.png" },
                    { "Chill Drive", "649-chill.png" }
                } },
                { "Chespin", new() { { "Base", "650.png" } } },
                { "Quilladin", new() { { "Base", "651.png" } } },
                { "Chesnaught", new() { { "Base", "652.png" } } },
                { "Fennekin", new() { { "Base", "653.png" } } },
                { "Braixen", new() { { "Base", "654.png" } } },
                { "Delphox", new() { { "Base", "655.png" } } },
                { "Froakie", new() { { "Base", "656.png" } } },
                { "Frogadier", new() { { "Base", "657.png" } } },
                { "Greninja", new() { { "Base", "658.png" } } },
                { "Bunnelby", new() { { "Base", "659.png" } } },
                { "Diggersby", new() { { "Base", "660.png" } } },
                { "Fletchling", new() { { "Base", "661.png" } } },
                { "Fletchinder", new() { { "Base", "662.png" } } },
                { "Talonflame", new() { { "Base", "663.png" } } },
                { "Scatterbug", new() { { "Base", "664.png" } } },
                { "Spewpa", new() { { "Base", "665.png" } } },
                { "Vivillon", new() { 
                    { "Meadow Pattern", "666.png" },
                    { "Polar Pattern", "666-polar.png" },
                    { "Tundra Pattern", "666-tundra.png" },
                    { "Continental Pattern", "666-continental.png" },
                    { "Garden Pattern", "666-garden.png" },
                    { "Elegant Pattern", "666-elegant.png" },
                    { "Icy Snow Pattern", "666-cy-snow.png" },
                    { "Modern Pattern", "666-modern.png" },
                    { "Marine Pattern", "666-marine.png" },
                    { "Archipelago Pattern", "666-archipelago.png" },
                    { "High Plains Pattern", "666-high-plains.png" },
                    { "Sandstorm Pattern", "666-sandstorm.png" },
                    { "River Pattern", "666-river.png" },
                    { "Monsoon Pattern", "666-monsoon.png" },
                    { "Savanna Pattern", "666-savanna.png" },
                    { "Sun Pattern", "666-sun.png" },
                    { "Ocean Pattern", "666-ocean.png" },
                    { "Jungle Pattern", "666-jungle.png" },
                    { "Fancy Pattern", "666-fancy.png" },
                    { "Poké Ball Pattern", "666-poke-ball.png" },
                } },
                { "Litleo", new() { { "Base", "667.png" } } },
                { "Pyroar", new() { { "Base", "668.png" } } },
                { "Flabébé", new() { 
                    { "Red Flower", "669.png" },
                    { "Yellow Flower", "669-yellow.png" },
                    { "Orange Flower", "669-orange.png" },
                    { "Blue Flower", "669-blue.png" },
                    { "White Flower", "669-white.png" }
                } },
                { "Floette", new() { 
                    { "Red Flower", "670.png" },
                    { "Yellow Flower", "670-yellow.png" },
                    { "Orange Flower", "670-orange.png" },
                    { "Blue Flower", "670-blue.png" },
                    { "White Flower", "670-white.png" }
                } },
                { "Florges", new() { 
                    { "Red Flower", "671.png" },
                    { "Yellow Flower", "671-yellow.png" },
                    { "Orange Flower", "671-orange.png" },
                    { "Blue Flower", "671-blue.png" },
                    { "White Flower", "671-white.png" }
                } },
                { "Skiddo", new() { { "Base", "672.png" } } },
                { "Gogoat", new() { { "Base", "673.png" } } },
                { "Pancham", new() { { "Base", "674.png" } } },
                { "Pangoro", new() { { "Base", "675.png" } } },
                { "Furfrou", new() { 
                    { "Natural Trim", "676.png" },
                    { "Heart Trim", "676-heart.png" },
                    { "Star Trim", "676-star.png" },
                    { "Diamond Trim", "676-diamond.png" },
                    { "Debutante Trim", "676-debutante.png" },
                    { "Matron Trim", "676-matron.png" },
                    { "Dandy Trim", "676-dandy.png" },
                    { "La Reine Trim", "676-la-reine.png" },
                    { "Kabuki Trim", "676-kabuki.png" },
                    { "Pharaoh Trim", "676-pharaoh.png" }
                } },
                { "Espurr", new() { { "Base", "677.png" } } },
                { "Meowstic", new() { { "Base", "678.png" } } },
                { "Honedge", new() { { "Base", "679.png" } } },
                { "Doublade", new() { { "Base", "680.png" } } },
                { "Aegislash", new() { 
                    { "Shield Forme", "681.png" },
                    { "Blade Forme", "10026.png" }
                } },
                { "Spritzee", new() { { "Base", "682.png" } } },
                { "Aromatisse", new() { { "Base", "683.png" } } },
                { "Swirlix", new() { { "Base", "684.png" } } },
                { "Slurpuff", new() { { "Base", "685.png" } } },
                { "Inkay", new() { { "Base", "686.png" } } },
                { "Malamar", new() { { "Base", "687.png" } } },
                { "Binacle", new() { { "Base", "688.png" } } },
                { "Barbaracle", new() { { "Base", "689.png" } } },
                { "Skrelp", new() { { "Base", "690.png" } } },
                { "Dragalge", new() { { "Base", "691.png" } } },
                { "Clauncher", new() { { "Base", "692.png" } } },
                { "Clawitzer", new() { { "Base", "693.png" } } },
                { "Helioptile", new() { { "Base", "694.png" } } },
                { "Heliolisk", new() { { "Base", "695.png" } } },
                { "Tyrunt", new() { { "Base", "696.png" } } },
                { "Tyrantrum", new() { { "Base", "697.png" } } },
                { "Amaura", new() { { "Base", "698.png" } } },
                { "Aurorus", new() { { "Base", "699.png" } } },
                { "Sylveon", new() { { "Base", "700.png" } } },
                { "Hawlucha", new() { { "Base", "701.png" } } },
                { "Dedenne", new() { { "Base", "702.png" } } },
                { "Carbink", new() { { "Base", "703.png" } } },
                { "Goomy", new() { { "Base", "704.png" } } },
                { "Sliggoo", new() { 
                    { "Kalosian", "705.png" },
                    { "Hisuian", "10241.png" }
                } },
                { "Goodra", new() { 
                    { "Kalosian", "706.png" },
                    { "Hisuian", "10242.png" }
                } },
                { "Klefki", new() { { "Base", "707.png" } } },
                { "Phantump", new() { { "Base", "708.png" } } },
                { "Trevenant", new() { { "Base", "709.png" } } },
                { "Pumpkaboo", new() { { "Base", "710.png" } } },
                { "Gourgeist", new() { { "Base", "711.png" } } },
                { "Bergmite", new() { { "Base", "712.png" } } },
                { "Avalugg", new() { 
                    { "Kalosian", "713.png" },
                    { "Hisuian", "10243.png" }
                } },
                { "Noibat", new() { { "Base", "714.png" } } },
                { "Noivern", new() { { "Base", "715.png" } } },
                { "Xerneas", new() { { "Base", "716.png" } } },
                { "Yveltal", new() { { "Base", "717.png" } } },
                { "Zygarde", new() { 
                    { "50% Forme", "718.png" },
                    { "10% Forme", "10118" },
                    { "Complete Forme", "10119.png" }
                } },
                { "Diancie", new() { 
                    { "Base", "719.png" },
                    { "Mega", "10075.png" }
                } },
                { "Hoopa", new() { 
                    { "Hoopa Confined", "720.png" },
                    { "Hoopa Unbound", "10086.png" }
                } },
                { "Volcanion", new() { { "Base", "721.png" } } },
                { "Rowlet", new() { { "Base", "722.png" } } },
                { "Dartrix", new() { { "Base", "723.png" } } },
                { "Decidueye", new() { 
                    { "Alolan", "724.png" },
                    { "Hisuian", "10244.png" }
                } },
                { "Litten", new() { { "Base", "725.png" } } },
                { "Torracat", new() { { "Base", "726.png" } } },
                { "Incineroar", new() { { "Base", "727.png" } } },
                { "Popplio", new() { { "Base", "728.png" } } },
                { "Brionne", new() { { "Base", "729.png" } } },
                { "Primarina", new() { { "Base", "730.png" } } },
                { "Pikipek", new() { { "Base", "731.png" } } },
                { "Trumbeak", new() { { "Base", "732.png" } } },
                { "Toucannon", new() { { "Base", "733.png" } } },
                { "Yungoos", new() { { "Base", "734.png" } } },
                { "Gumshoos", new() { { "Base", "735.png" } } },
                { "Grubbin", new() { { "Base", "736.png" } } },
                { "Charjabug", new() { { "Base", "737.png" } } },
                { "Vikavolt", new() { { "Base", "738.png" } } },
                { "Crabrawler", new() { { "Base", "739.png" } } },
                { "Crabominable", new() { { "Base", "740.png" } } },
                { "Oricorio", new() { 
                    { "Baile Style", "741.png" },
                    { "Pom-Pom Style", "10123.png" },
                    { "Pa'u Style", "10124.png" },
                    { "Sensu Style", "10125.png" }
                } },
                { "Cutiefly", new() { { "Base", "742.png" } } },
                { "Ribombee", new() { { "Base", "743.png" } } },
                { "Rockruff", new() { { "Base", "744.png" } } },
                { "Lycanroc", new() { 
                    { "Midday Form", "745.png" },
                    { "Midnight Form", "10126.png" },
                    { "Dusk Form", "10152.png" }
                } },
                { "Wishiwashi", new() { 
                    { "Solo Form", "746.png" },
                    { "School Form", "10127.png" }
                } },
                { "Mareanie", new() { { "Base", "747.png" } } },
                { "Toxapex", new() { { "Base", "748.png" } } },
                { "Mudbray", new() { { "Base", "749.png" } } },
                { "Mudsdale", new() { { "Base", "750.png" } } },
                { "Dewpider", new() { { "Base", "751.png" } } },
                { "Araquanid", new() { { "Base", "752.png" } } },
                { "Fomantis", new() { { "Base", "753.png" } } },
                { "Lurantis", new() { { "Base", "754.png" } } },
                { "Morelull", new() { { "Base", "755.png" } } },
                { "Shiinotic", new() { { "Base", "756.png" } } },
                { "Salandit", new() { { "Base", "757.png" } } },
                { "Salazzle", new() { { "Base", "758.png" } } },
                { "Stufful", new() { { "Base", "759.png" } } },
                { "Bewear", new() { { "Base", "760.png" } } },
                { "Bounsweet", new() { { "Base", "761.png" } } },
                { "Steenee", new() { { "Base", "762.png" } } },
                { "Tsareena", new() { { "Base", "763.png" } } },
                { "Comfey", new() { { "Base", "764.png" } } },
                { "Oranguru", new() { { "Base", "765.png" } } },
                { "Passimian", new() { { "Base", "766.png" } } },
                { "Wimpod", new() { { "Base", "767.png" } } },
                { "Golisopod", new() { { "Base", "768.png" } } },
                { "Sandygast", new() { { "Base", "769.png" } } },
                { "Palossand", new() { { "Base", "770.png" } } },
                { "Pyukumuku", new() { { "Base", "771.png" } } },
                { "Type: Null", new() { { "Base", "772.png" } } },
                { "Silvally", new() { 
                    { "Type: Normal", "773-normal.png" },
                    { "Type: Fire", "773-fire.png" },
                    { "Type: Water", "773-water.png" },
                    { "Type: Electric", "773-electric.png" },
                    { "Type: Grass", "773-grass.png" },
                    { "Type: Ice", "773-ice.png" },
                    { "Type: Fighting", "773-fighting.png" },
                    { "Type: Poison", "773-poison.png" },
                    { "Type: Ground", "773-ground.png" },
                    { "Type: Flying", "773-flying.png" },
                    { "Type: Psychic", "773-psychic.png" },
                    { "Type: Bug", "773-bug.png" },
                    { "Type: Rock", "773-rock.png" },
                    { "Type: Ghost", "773-ghost.png" },
                    { "Type: Dragon", "773-dragon.png" },
                    { "Type: Dark", "773-dark.png" },
                    { "Type: Steel", "773-steel.png" },
                    { "Type: Fairy", "773-fairy.png" }
                } },
                { "Minior", new() { 
                    { "Meteor Form", "774.png" },
                    { "Core Form", "10136.png" }
                } },
                { "Komala", new() { { "Base", "775.png" } } },
                { "Turtonator", new() { { "Base", "776.png" } } },
                { "Togedemaru", new() { { "Base", "777.png" } } },
                { "Mimikyu", new() { { "Base", "778.png" } } },
                { "Bruxish", new() { { "Base", "779.png" } } },
                { "Drampa", new() { { "Base", "780.png" } } },
                { "Dhelmise", new() { { "Base", "781.png" } } },
                { "Jangmo-o", new() { { "Base", "782.png" } } },
                { "Hakamo-o", new() { { "Base", "783.png" } } },
                { "Kommo-o", new() { { "Base", "784.png" } } },
                { "Tapu Koko", new() { { "Base", "785.png" } } },
                { "Tapu Lele", new() { { "Base", "786.png" } } },
                { "Tapu Bulu", new() { { "Base", "787.png" } } },
                { "Tapu Fini", new() { { "Base", "788.png" } } },
                { "Cosmog", new() { { "Base", "789.png" } } },
                { "Cosmoem", new() { { "Base", "790.png" } } },
                { "Solgaleo", new() { { "Base", "791.png" } } },
                { "Lunala", new() { { "Base", "792.png" } } },
                { "Nihilego", new() { { "Base", "793.png" } } },
                { "Buzzwole", new() { { "Base", "794.png" } } },
                { "Pheromosa", new() { { "Base", "795.png" } } },
                { "Xurkitree", new() { { "Base", "796.png" } } },
                { "Celesteela", new() { { "Base", "797.png" } } },
                { "Kartana", new() { { "Base", "798.png" } } },
                { "Guzzlord", new() { { "Base", "799.png" } } },
                { "Necrozma", new() { 
                    { "Base", "800.png" },
                    { "Dusk Mane", "10155.png" },
                    { "Dawn Wings", "10156.png" },
                    { "Ultra", "10157.png" }
                } },
                { "Magearna", new() { 
                    { "Base", "801.png" },
                    { "Original Color", "10147.png" }
                } },
                { "Marshadow", new() { { "Base", "802.png" } } },
                { "Poipole", new() { { "Base", "803.png" } } },
                { "Naganadel", new() { { "Base", "804.png" } } },
                { "Stakataka", new() { { "Base", "805.png" } } },
                { "Blacephalon", new() { { "Base", "806.png" } } },
                { "Zeraora", new() { { "Base", "807.png" } } },
                { "Meltan", new() { { "Base", "808.png" } } },
                { "Melmetal", new() { 
                    { "Base", "809.png" },
                    { "Gigantamax", "10208.png" }
                } },
                { "Grookey", new() { { "Base", "810.png" } } },
                { "Thwackey", new() { { "Base", "811.png" } } },
                { "Rillaboom", new() { 
                    { "Base", "812.png" },
                    { "Gigantamax", "10209.png" }
                } },
                { "Scorbunny", new() { { "Base", "813.png" } } },
                { "Raboot", new() { { "Base", "814.png" } } },
                { "Cinderace", new() { 
                    { "Base", "815.png" },
                    { "Gigantamax", "10210.png" }
                } },
                { "Sobble", new() { { "Base", "816.png" } } },
                { "Drizzile", new() { { "Base", "817.png" } } },
                { "Inteleon", new() { 
                    { "Base", "818.png" },
                    { "Gigantamax", "10211.png" }
                } },
                { "Skwovet", new() { { "Base", "819.png" } } },
                { "Greedent", new() { { "Base", "820.png" } } },
                { "Rookidee", new() { { "Base", "821.png" } } },
                { "Corvisquire", new() { { "Base", "822.png" } } },
                { "Corviknight", new() { 
                    { "Base", "823.png" },
                    { "Gigantamax", "10212.png" }
                } },
                { "Blipbug", new() { { "Base", "824.png" } } },
                { "Dottler", new() { { "Base", "825.png" } } },
                { "Orbeetle", new() { 
                    { "Base", "826.png" },
                    { "Gigantamax", "10213.png" }
                } },
                { "Nickit", new() { { "Base", "827.png" } } },
                { "Thievul", new() { { "Base", "828.png" } } },
                { "Gossifleur", new() { { "Base", "829.png" } } },
                { "Eldegoss", new() { { "Base", "830.png" } } },
                { "Wooloo", new() { { "Base", "831.png" } } },
                { "Dubwool", new() { { "Base", "832.png" } } },
                { "Chewtle", new() { { "Base", "833.png" } } },
                { "Drednaw", new() { 
                    { "Base", "834.png" },
                    { "Gigantamax", "10214.png" }
                } },
                { "Yamper", new() { { "Base", "835.png" } } },
                { "Boltund", new() { { "Base", "836.png" } } },
                { "Rolycoly", new() { { "Base", "837.png" } } },
                { "Carkol", new() { { "Base", "838.png" } } },
                { "Coalossal", new() { 
                    { "Base", "839.png" },
                    { "Gigantamax", "10215.png" }
                } },
                { "Applin", new() { { "Base", "840.png" } } },
                { "Flapple", new() { 
                    { "Base", "841.png" },
                    { "Gigantamax", "10216.png" }
                } },
                { "Appletun", new() { 
                    { "Base", "842.png" },
                    { "Gigantamax", "10217.png" }
                } },
                { "Silicobra", new() { { "Base", "843.png" } } },
                { "Sandaconda", new() { 
                    { "Base", "844.png" },
                    { "Gigantamax", "10218.png" }
                } },
                { "Cramorant", new() { 
                    { "Base", "845.png" },
                    { "Gulping Form", "10182.png" },
                    { "Gorging Form", "10183.png" }
                } },
                { "Arrokuda", new() { { "Base", "846.png" } } },
                { "Barraskewda", new() { { "Base", "847.png" } } },
                { "Toxel", new() { { "Base", "848.png" } } },
                { "Toxtricity", new() { 
                    { "Amped", "849.png" },
                    { "Low Key", "10184.png" },
                    { "Gigantamax", "10219.png" }
                } },
                { "Sizzlipede", new() { { "Base", "850.png" } } },
                { "Centiskorch", new() { 
                    { "Base", "851.png" },
                    { "Gigantamax", "10220.png" }
                } },
                { "Clobbopus", new() { { "Base", "852.png" } } },
                { "Grapploct", new() { { "Base", "853.png" } } },
                { "Sinistea", new() { { "Base", "854.png" } } },
                { "Polteageist", new() { { "Base", "855.png" } } },
                { "Hatenna", new() { { "Base", "856.png" } } },
                { "Hattrem", new() { { "Base", "857.png" } } },
                { "Hatterene", new() { 
                    { "Base", "858.png" },
                    { "Gigantamax", "10221.png" }
                } },
                { "Impidimp", new() { { "Base", "859.png" } } },
                { "Morgrem", new() { { "Base", "860.png" } } },
                { "Grimmsnarl", new() { 
                    { "Base", "861.png" },
                    {"Gigantamax", "10222.png" }
                } },
                { "Obstagoon", new() { { "Base", "862.png" } } },
                { "Perrserker", new() { { "Base", "863.png" } } },
                { "Cursola", new() { { "Base", "864.png" } } },
                { "Sirfetch’d", new() { { "Base", "865.png" } } },
                { "Mr. Rime", new() { { "Base", "866.png" } } },
                { "Runerigus", new() { { "Base", "867.png" } } },
                { "Milcery", new() { { "Base", "868.png" } } },
                { "Alcremie", new() { 
                    { "Strawberry Sweet", "869.png" },
                    { "Gigantamax", "10223.png" },
                    { "Berry Sweet", "869-caramel-swirl-berry-sweet.png"},
                    { "Love Sweet", "869-caramel-swirl-love-sweet.png"},
                    { "Clover Sweet", "869-caramel-swirl-clover-sweet.png"},
                    { "Flower Sweet", "869-caramel-swirl-flower-sweet.png"},
                    { "Star Sweet", "869-caramel-swirl-star-sweet.png" },
                    { "Ribbon Sweet", "869-caramel-swirl-ribbon-sweet.png" }
                } },
                { "Falinks", new() { { "Base", "870.png" } } },
                { "Pincurchin", new() { { "Base", "871.png" } } },
                { "Snom", new() { { "Base", "872.png" } } },
                { "Frosmoth", new() { { "Base", "873.png" } } },
                { "Stonjourner", new() { { "Base", "874.png" } } },
                { "Eiscue", new() { 
                    { "Ice Face", "875.png" },
                    { "Noice Face", "10185.png" }
                } },
                { "Indeedee", new() { { "Base", "876.png" } } },
                { "Morpeko", new() { 
                    { "Full Belly Mode", "877.png" },
                    { "Hangry Mode", "10187.png" }
                } },
                { "Cufant", new() { { "Base", "878.png" } } },
                { "Copperajah", new() { 
                    { "Base", "879.png" },
                    {"Gigantamax", "10224.png" }
                } },
                { "Dracozolt", new() { { "Base", "880.png" } } },
                { "Arctozolt", new() { { "Base", "881.png" } } },
                { "Dracovish", new() { { "Base", "882.png" } } },
                { "Arctovish", new() { { "Base", "883.png" } } },
                { "Duraludon", new() { 
                    { "Base", "884.png" },
                    {"Gigantamax", "10225.png" }
                } },
                { "Dreepy", new() { { "Base", "885.png" } } },
                { "Drakloak", new() { { "Base", "886.png" } } },
                { "Dragapult", new() { { "Base", "887.png" } } },
                { "Zacian", new() { 
                    { "Hero of Many Battles", "888.png" },
                    { "Crowned Sword", "10188.png" }
                } },
                { "Zamazenta", new() { 
                    { "Hero of Many Battles", "889.png" },
                    { "Crowned Shield", "10189.png" }
                } },
                { "Eternatus", new() { 
                    { "Base", "890.png" },
                    { "Eternamax", "10190.png" }
                } },
                { "Kubfu", new() { { "Base", "891.png" } } },
                { "Urshifu", new() { 
                    { "Single Strike Style", "892.png" },
                    { "Rapid Strike Style", "10191.png" },
                    { "Gigantamax Single Strike Style", "10226.png"},
                    { "Gigantamax Rapid Strike Style", "10227.png" }
                } },
                { "Zarude", new() { 
                    { "Base", "893.png" },
                    {"Dada Form", "10192.png" }
                } },
                { "Regieleki", new() { { "Base", "894.png" } } },
                { "Regidrago", new() { { "Base", "895.png" } } },
                { "Glastrier", new() { { "Base", "896.png" } } },
                { "Spectrier", new() { { "Base", "897.png" } } },
                { "Calyrex", new() { { "Base", "898.png" } } },
                { "Wyrdeer", new() { { "Base", "899.png" } } },
                { "Kleavor", new() { { "Base", "900.png" } } },
                { "Ursaluna", new() { 
                    { "Base", "901.png" },
                    {"Bloodmoon", "10272.png" }
                } },
                { "Basculegion", new() { { "Base", "902.png" } } },
                { "Sneasler", new() { { "Base", "903.png" } } },
                { "Overqwil", new() { { "Base", "904.png" } } },
                { "Enamorus", new() { 
                    { "Incarnate", "905.png" },
                    {"Therian", "10249.png" }
                } },
                { "Sprigatito", new() { { "Base", "906.png" } } },
                { "Floragato", new() { { "Base", "907.png" } } },
                { "Meowscarada", new() { { "Base", "908.png" } } },
                { "Fuecoco", new() { { "Base", "909.png" } } },
                { "Crocalor", new() { { "Base", "910.png" } } },
                { "Skeledirge", new() { { "Base", "911.png" } } },
                { "Quaxly", new() { { "Base", "912.png" } } },
                { "Quaxwell", new() { { "Base", "913.png" } } },
                { "Quaquaval", new() { { "Base", "914.png" } } },
                { "Lechonk", new() { { "Base", "915.png" } } },
                { "Oinkologne", new() { { "Base", "916.png" } } },
                { "Tarountula", new() { { "Base", "917.png" } } },
                { "Spidops", new() { { "Base", "918.png" } } },
                { "Nymble", new() { { "Base", "919.png" } } },
                { "Lokix", new() { { "Base", "920.png" } } },
                { "Pawmi", new() { { "Base", "921.png" } } },
                { "Pawmo", new() { { "Base", "922.png" } } },
                { "Pawmot", new() { { "Base", "923.png" } } },
                { "Tandemaus", new() { { "Base", "924.png" } } },
                { "Maushold", new() { 
                    { "Family of Four", "925.png" },
                    { "Family of Three", "10257.png" }
                } },
                { "Fidough", new() { { "Base", "926.png" } } },
                { "Dachsbun", new() { { "Base", "927.png" } } },
                { "Smoliv", new() { { "Base", "928.png" } } },
                { "Doliv", new() { { "Base", "929.png" } } },
                { "Arboliva", new() { { "Base", "930.png" } } },
                { "Squawkabilly", new() { 
                    { "Green Plumage", "931.png" },
                    { "Blue Plumage", "10260.png" },
                    { "Yellow Plumage", "10261.png" },
                    { "White Plumage", "10262.png" }
                } },
                { "Nacli", new() { { "Base", "932.png" } } },
                { "Naclstack", new() { { "Base", "933.png" } } },
                { "Garganacl", new() { { "Base", "934.png" } } },
                { "Charcadet", new() { { "Base", "935.png" } } },
                { "Armarouge", new() { { "Base", "936.png" } } },
                { "Ceruledge", new() { { "Base", "937.png" } } },
                { "Tadbulb", new() { { "Base", "938.png" } } },
                { "Bellibolt", new() { { "Base", "939.png" } } },
                { "Wattrel", new() { { "Base", "940.png" } } },
                { "Kilowattrel", new() { { "Base", "941.png" } } },
                { "Maschiff", new() { { "Base", "942.png" } } },
                { "Mabosstiff", new() { { "Base", "943.png" } } },
                { "Shroodle", new() { { "Base", "944.png" } } },
                { "Grafaiai", new() { { "Base", "945.png" } } },
                { "Bramblin", new() { { "Base", "946.png" } } },
                { "Brambleghast", new() { { "Base", "947.png" } } },
                { "Toedscool", new() { { "Base", "948.png" } } },
                { "Toedscruel", new() { { "Base", "949.png" } } },
                { "Klawf", new() { { "Base", "950.png" } } },
                { "Capsakid", new() { { "Base", "951.png" } } },
                { "Scovillain", new() { { "Base", "952.png" } } },
                { "Rellor", new() { { "Base", "953.png" } } },
                { "Rabsca", new() { { "Base", "954.png" } } },
                { "Flittle", new() { { "Base", "955.png" } } },
                { "Espathra", new() { { "Base", "956.png" } } },
                { "Tinkatink", new() { { "Base", "957.png" } } },
                { "Tinkatuff", new() { { "Base", "958.png" } } },
                { "Tinkaton", new() { { "Base", "959.png" } } },
                { "Wiglett", new() { { "Base", "960.png" } } },
                { "Wugtrio", new() { { "Base", "961.png" } } },
                { "Bombirdier", new() { { "Base", "962.png" } } },
                { "Finizen", new() { { "Base", "963.png" } } },
                { "Palafin", new() { 
                    { "Zero Form", "964.png" },
                    { "Hero Form", "10256.png" }
                } },
                { "Varoom", new() { { "Base", "965.png" } } },
                { "Revavroom", new() { { "Base", "966.png" } } },
                { "Cyclizar", new() { { "Base", "967.png" } } },
                { "Orthworm", new() { { "Base", "968.png" } } },
                { "Glimmet", new() { { "Base", "969.png" } } },
                { "Glimmora", new() { { "Base", "970.png" } } },
                { "Greavard", new() { { "Base", "971.png" } } },
                { "Houndstone", new() { { "Base", "972.png" } } },
                { "Flamigo", new() { { "Base", "973.png" } } },
                { "Cetoddle", new() { { "Base", "974.png" } } },
                { "Cetitan", new() { { "Base", "975.png" } } },
                { "Veluza", new() { { "Base", "976.png" } } },
                { "Dondozo", new() { { "Base", "977.png" } } },
                { "Tatsugiri", new() { 
                    { "Curly Form", "978.png" },
                    { "Droopy Form", "10258.png" },
                    { "Stretchy Form", "10259.png" }
                } },
                { "Annihilape", new() { { "Base", "979.png" } } },
                { "Clodsire", new() { { "Base", "980.png" } } },
                { "Farigiraf", new() { { "Base", "981.png" } } },
                { "Dudunsparce", new() { 
                    { "Two-Segment Form", "982.png" },
                    { "Three-Segment Form", "10255.png" }
                } },
                { "Kingambit", new() { { "Base", "983.png" } } },
                { "Great Tusk", new() { { "Base", "984.png" } } },
                { "Scream Tail", new() { { "Base", "985.png" } } },
                { "Brute Bonnet", new() { { "Base", "986.png" } } },
                { "Flutter Mane", new() { { "Base", "987.png" } } },
                { "Slither Wing", new() { { "Base", "988.png" } } },
                { "Sandy Shocks", new() { { "Base", "989.png" } } },
                { "Iron Treads", new() { { "Base", "990.png" } } },
                { "Iron Bundle", new() { { "Base", "991.png" } } },
                { "Iron Hands", new() { { "Base", "992.png" } } },
                { "Iron Jugulis", new() { { "Base", "993.png" } } },
                { "Iron Moth", new() { { "Base", "994.png" } } },
                { "Iron Thorns", new() { { "Base", "995.png" } } },
                { "Frigibax", new() { { "Base", "996.png" } } },
                { "Arctibax", new() { { "Base", "997.png" } } },
                { "Baxcalibur", new() { { "Base", "998.png" } } },
                { "Gimmighoul", new() { 
                    { "Chest Form", "999.png" },
                    { "Roaming Form", "10263.png" }
                } },
                { "Gholdengo", new() { { "Base", "1000.png" } } },
                { "Wo-Chien", new() { { "Base", "1001.png" } } },
                { "Chien-Pao", new() { { "Base", "1002.png" } } },
                { "Ting-Lu", new() { { "Base", "1003.png" } } },
                { "Chi-Yu", new() { { "Base", "1004.png" } } },
                { "Roaring Moon", new() { { "Base", "1005.png" } } },
                { "Iron Valiant", new() { { "Base", "1006.png" } } },
                { "Koraidon", new() { { "Base", "1007.png" } } },
                { "Miraidon", new() { { "Base", "1008.png" } } },
                { "Walking Wake", new() { { "Base", "1009.png" } } },
                { "Iron Leaves", new() { { "Base", "1010.png" } } },
                { "Dipplin", new() { { "Base", "1011.png" } } },
                { "Poltchageist", new() { { "Base", "1012.png" } } },
                { "Sinistcha", new() { { "Base", "1013.png" } } },
                { "Okidogi", new() { { "Base", "1014.png" } } },
                { "Munkidori", new() { { "Base", "1015.png" } } },
                { "Fezandipiti", new() { { "Base", "1016.png" } } },
                { "Ogerpon", new() { { "Base", "1017.png" } } },
                { "Archaludon", new() { { "Base", "1018.png" } } },
                { "Hydrapple", new() { { "Base", "1019.png" } } },
                { "Gouging Fire", new() { { "Base", "1020.png" } } },
                { "Raging Bolt", new() { { "Base", "1021.png" } } },
                { "Iron Boulder", new() { { "Base", "1022.png" } } },
                { "Iron Crown", new() { { "Base", "1023.png" } } },
                { "Terapagos", new() { { "Base", "1024.png" } } },
                { "Pecharunt", new() { { "Base", "1025.png" } } },
            };

            var pokemonSprites = new Dictionary<string, Dictionary<string, string>>();

            foreach (var kvp in pokemonFiles)
            {
                var forms = new Dictionary<string, string>();
                foreach (var formKvp in kvp.Value)
                {
                    string form = formKvp.Key;
                    string filename = formKvp.Value;
                    string fullPath = Path.Combine(basePath, filename);

                    forms[form] = File.Exists(fullPath) ? fullPath : null;
                }
                pokemonSprites[kvp.Key] = forms;
            }
            return pokemonSprites;
        }
    }
}
