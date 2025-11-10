using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static PokemonCounter.PokemonSpriteMapper;

namespace PokemonCounter
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, string>> _pokemonSpritePaths;
        private int _encounterCount = 0;
        private Label _encountersValueLabel;
        private Label _oddsValueLabel;
        private Label _generationValueLabel;
        private Label _huntingMethodValueLabel;

        private Keys addKey = Keys.Space;
        private Keys subtractKey = Keys.Space | Keys.Shift;

        private bool _suppressMethodCBEvent = false;
        private bool _suppressGenerationCBEvent = false;

        private readonly List<string> _allMethods = new List<string>
        {
            "Random Encounter",
            "Soft Reset",
            "Breeding",
            "Masuda Method",
            "Radar Chaining",
            "Chain Fishing",
            "Dex Nav",
            "Horde Encounter",
            "SOS Battle"
        };
        public Form1()
        {
            InitializeComponent();
            LoadPokemonSprites();

            generationCB.Items.AddRange(new string[] {
                "Gen 2",
                "Gen 3",
                "Gen 4",
                "Gen 5",
                "Gen 6",
                "Gen 7",
                "Gen 8",
                "Gen 9"
                });

            methodCB.Items.AddRange(new string[] {
                "Random Encounter",
                "Soft Reset",
                "Breeding",
                "Masuda Method",
                "Radar Chaining",
                "Chain Fishing",
                "Dex Nav",
                "Horde Encounter",
                "SOS Battle"
                });

            this.Load += Form1_Load;

            shinyCharmYesRadioButton.CheckedChanged += shinyCharmRadioButton_CheckedChanged;
            shinyCharmNoRadioButton.CheckedChanged += shinyCharmRadioButton_CheckedChanged;
            methodCB.SelectedIndexChanged += methodCB_SelectedIndexChanged;
            topmostBox.CheckedChanged += topmostBox_CheckedChanged;

            pokemonCB.SelectedIndexChanged += pokemonCB_SelectedIndexChanged;
            formesCB.SelectedIndexChanged += formsCB_SelectedIndexChanged;

            addKeybind.KeyDown += addKeybind_KeyDown;
            subtractKeybind.KeyDown += subtractKeybind_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _pokemonSpritePaths = PokemonSpriteMapper.LoadPokemonSprites();
            pokemonCB.Items.Clear();
            pokemonCB.DataSource = _pokemonSpritePaths.Keys.ToList();
            pokemonCB.DropDownStyle = ComboBoxStyle.DropDown;
            pokemonCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pokemonCB.AutoCompleteSource = AutoCompleteSource.ListItems;

            generationCB.SelectedIndexChanged -= generationCB_SelectedIndexChanged;
            generationCB.SelectedIndexChanged += generationCB_SelectedIndexChanged;

            generationCB.SelectedIndex = 0;
            methodCB.SelectedIndex = 0;

            _encounterCount = 0;
            InitializeStatsTable("");

            generationCB_SelectedIndexChanged(generationCB, EventArgs.Empty);
            methodCB_SelectedIndexChanged(methodCB, EventArgs.Empty);

            addKey = Keys.Space;
            subtractKey = Keys.Shift | Keys.Space;
            addKeybind.Text = KeyToString(addKey);
            subtractKeybind.Text = KeyToString(subtractKey);

            keybindLabelA.Text = $"{KeyToString(addKey)}";
            keybindLabelA.Left = addButton.Left + (addButton.Width - keybindLabelA.Width) / 2;
            keybindLabelA.Top = addButton.Bottom + 5;

            keybindLabelS.Text = $"{KeyToString(subtractKey)}";
            keybindLabelS.Left = subtractButton.Left + (subtractButton.Width - keybindLabelS.Width) / 2;
            keybindLabelS.Top = subtractButton.Bottom + 5;
        }

        private void InitializeStatsTable(string selectedGen)
        {
            string[] statNames = { "Generation", "Hunting Method", "Odds", "Encounters" };
            string[] statValues = { "", "", "", _encounterCount.ToString() };

            statsTable.Controls.Clear();
            statsTable.RowCount = statNames.Length;

            for (int i = 0; i < statNames.Length; i++)
            {
                var nameLabel = new Label
                {
                    Text = statNames[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };
                statsTable.Controls.Add(nameLabel, 0, i);

                var valueLabel = new Label
                {
                    Text = statValues[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };
                statsTable.Controls.Add(valueLabel, 1, i);

                switch (statNames[i])
                {
                    case "Encounters":
                        _encountersValueLabel = valueLabel;
                        break;
                    case "Odds":
                        _oddsValueLabel = valueLabel;
                        break;
                    case "Generation":
                        _generationValueLabel = valueLabel;
                        break;
                    case "Hunting Method":
                        _huntingMethodValueLabel = valueLabel;
                        break;
                }
            }
        }

        private void pokemonCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPokemon = pokemonCB.SelectedItem as string;
            if (selectedPokemon != null && _pokemonSpritePaths.TryGetValue(selectedPokemon, out var formsDict))
            {
                formesCB.DataSource = formsDict.Keys.ToList();
                formesCB.SelectedIndex = 0;

                formesCB.Enabled = formsDict.Count > 1;

            }
        }

        private void formsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPokemon = pokemonCB.SelectedItem as string;
            string selectedForm = formesCB.SelectedItem as string;

            pokemonLabel.Text = selectedPokemon ?? string.Empty;
            pokemonLabel.Left = (HuntTab.ClientSize.Width - pokemonLabel.Width) / 2;

            if (selectedPokemon != null && selectedForm != null &&
                _pokemonSpritePaths.TryGetValue(selectedPokemon, out var formsDict) &&
                formsDict.TryGetValue(selectedForm, out var spritePath) &&
                !string.IsNullOrEmpty(spritePath))
            {
                pictureBox1.Image = Image.FromFile(spritePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _encounterCount++;
            UpdateEncountersLabel();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            _encounterCount = Math.Max(0, _encounterCount - 1);
            UpdateEncountersLabel();
        }

        private void UpdateEncountersLabel()
        {
            if (_encountersValueLabel != null)
                _encountersValueLabel.Text = _encounterCount.ToString();
        }

        private void generationCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_suppressGenerationCBEvent) return;

            string selectedGen = generationCB.SelectedItem as string;
            if (_generationValueLabel == null)
                return;

            _generationValueLabel.Text = selectedGen ?? string.Empty;

            int genNumber = 0;
            if (selectedGen != null && selectedGen.StartsWith("Gen ") && int.TryParse(selectedGen.Substring(4), out genNumber))
            {
                UpdateMethodCBItems(genNumber);

                bool enableShinyCharm = genNumber >= 5;
                shinyCharmYesRadioButton.Enabled = enableShinyCharm;
                shinyCharmNoRadioButton.Enabled = enableShinyCharm;
                if (!enableShinyCharm)
                {
                    shinyCharmNoRadioButton.Checked = true;
                }
            }
            UpdateOddsLabel();
        }

        private void UpdateOddsLabel()
        {
            string selectedGen = generationCB.SelectedItem as string;
            if (_oddsValueLabel == null || string.IsNullOrEmpty(selectedGen))
                return;

            int genNumber = 0;
            if (selectedGen.StartsWith("Gen ") && int.TryParse(selectedGen.Substring(4), out genNumber))
            {
                bool shinyCharm = shinyCharmYesRadioButton.Enabled && shinyCharmYesRadioButton.Checked;
                if (genNumber >= 1 && genNumber <= 5)
                {
                    _oddsValueLabel.Text = shinyCharm ? "1/2730.6" : "1/8192";
                }
                else
                {
                    _oddsValueLabel.Text = shinyCharm ? "1/1365.3" : "1/4096";
                }
            }
        }

        private void shinyCharmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOddsLabel();
        }

        private void methodCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMethod = methodCB.SelectedItem as string;
            if (_huntingMethodValueLabel != null)
                _huntingMethodValueLabel.Text = selectedMethod ?? string.Empty;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            generationCB.SelectedItem = null;
            methodCB.SelectedItem = null;
            pokemonCB.SelectedItem = null;

            shinyCharmYesRadioButton.Checked = false;
            shinyCharmNoRadioButton.Checked = false;
            shinyCharmYesRadioButton.Enabled = false;
            shinyCharmNoRadioButton.Enabled = false;

            _encounterCount = 0;

            if (_generationValueLabel != null) _generationValueLabel.Text = "";
            if (_huntingMethodValueLabel != null) _huntingMethodValueLabel.Text = "";
            if (_oddsValueLabel != null) _oddsValueLabel.Text = "";
            if (_encountersValueLabel != null) _encountersValueLabel.Text = "";

            pokemonLabel.Text = "";
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void topmostBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostBox.Checked;
        }

        private void addKeybind_KeyDown(object sender, KeyEventArgs e)
        {
            addKey = e.KeyData;
            addKeybind.Text = KeyToString(addKey);
            e.SuppressKeyPress = true;
            keybindLabelA.Text = $"{KeyToString(addKey)}";
            keybindLabelA.Left = addButton.Left + (addButton.Width - keybindLabelA.Width) / 2;
            keybindLabelA.Top = addButton.Bottom + 5;
        }

        private void subtractKeybind_KeyDown(object sender, KeyEventArgs e)
        {
            subtractKey = e.KeyData;
            subtractKeybind.Text = KeyToString(subtractKey);
            e.SuppressKeyPress = true;
            keybindLabelS.Text = $"{KeyToString(subtractKey)}";
            keybindLabelS.Left = subtractButton.Left + (subtractButton.Width - keybindLabelS.Width) / 2;
            keybindLabelS.Top = subtractButton.Bottom + 5;
        }

        private string KeyToString(Keys key)
        {
            return key.ToString().Replace(", ", " + ");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == addKey)
            {
                addButton.PerformClick();
                return true;
            }
            if (keyData == subtractKey)
            {
                subtractButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateMethodCBItems(int genNumber)
        {
            string prevSelection = methodCB.SelectedItem as string;
            methodCB.SelectedIndexChanged -= methodCB_SelectedIndexChanged;

            methodCB.Items.Clear();

            foreach (var method in _allMethods)
            {
                if (method == "Masuda Method" && genNumber < 5)
                    continue; 
                if(method == "Radar Chaining" && (genNumber != 4 || genNumber !=6))
                    continue;
                if ((method == "Dex Nav" || method == "Horde Encounter" || method == "Chain Fishing") && genNumber != 6)
                    continue;
                if (method == "SOS Battle" && genNumber != 7)
                    continue;
                methodCB.Items.Add(method);
            }

            if (prevSelection != null && methodCB.Items.Contains(prevSelection))
                methodCB.SelectedItem = prevSelection;
            else
                methodCB.SelectedIndex = 0;

            methodCB.SelectedIndexChanged += methodCB_SelectedIndexChanged;
        }

        private class ComboBoxItem
        {
            public string Text { get; }
            public bool Enabled { get; }

            public ComboBoxItem(string text, bool enabled)
            {
                Text = text;
                Enabled = enabled;
            }

            public override string ToString() => Text;
        }
    }
}
