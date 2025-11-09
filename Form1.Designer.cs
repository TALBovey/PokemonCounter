namespace PokemonCounter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SettingsTab = new TabPage();
            subtractKBLabel = new Label();
            addKBLabel = new Label();
            subtractKeybind = new TextBox();
            addKeybind = new TextBox();
            topmostBox = new CheckBox();
            methodCB = new ComboBox();
            label1 = new Label();
            resetButton = new Button();
            pokemonCB = new ComboBox();
            targetLabel = new Label();
            shinyCharmYN = new GroupBox();
            shinyCharmNoRadioButton = new RadioButton();
            shinyCharmYesRadioButton = new RadioButton();
            shinycharmLabel = new Label();
            generationCB = new ComboBox();
            generationLabel = new Label();
            HuntTab = new TabPage();
            keybindLabelA = new Label();
            keybindLabelS = new Label();
            statsTable = new TableLayoutPanel();
            pokemonLabel = new Label();
            pictureBox1 = new PictureBox();
            subtractButton = new Button();
            addButton = new Button();
            tabControl1 = new TabControl();
            SettingsTab.SuspendLayout();
            shinyCharmYN.SuspendLayout();
            HuntTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsTab
            // 
            SettingsTab.Controls.Add(subtractKBLabel);
            SettingsTab.Controls.Add(addKBLabel);
            SettingsTab.Controls.Add(subtractKeybind);
            SettingsTab.Controls.Add(addKeybind);
            SettingsTab.Controls.Add(topmostBox);
            SettingsTab.Controls.Add(methodCB);
            SettingsTab.Controls.Add(label1);
            SettingsTab.Controls.Add(resetButton);
            SettingsTab.Controls.Add(pokemonCB);
            SettingsTab.Controls.Add(targetLabel);
            SettingsTab.Controls.Add(shinyCharmYN);
            SettingsTab.Controls.Add(shinycharmLabel);
            SettingsTab.Controls.Add(generationCB);
            SettingsTab.Controls.Add(generationLabel);
            SettingsTab.Location = new Point(4, 24);
            SettingsTab.Name = "SettingsTab";
            SettingsTab.Padding = new Padding(3);
            SettingsTab.Size = new Size(354, 459);
            SettingsTab.TabIndex = 1;
            SettingsTab.Text = "Settings";
            SettingsTab.UseVisualStyleBackColor = true;
            // 
            // subtractKBLabel
            // 
            subtractKBLabel.AutoSize = true;
            subtractKBLabel.Location = new Point(108, 335);
            subtractKBLabel.Name = "subtractKBLabel";
            subtractKBLabel.Size = new Size(139, 15);
            subtractKBLabel.TabIndex = 18;
            subtractKBLabel.Text = "Subtract Button Keybind:";
            // 
            // addKBLabel
            // 
            addKBLabel.AutoSize = true;
            addKBLabel.Location = new Point(119, 286);
            addKBLabel.Name = "addKBLabel";
            addKBLabel.Size = new Size(117, 15);
            addKBLabel.TabIndex = 17;
            addKBLabel.Text = "Add Button Keybind:";
            // 
            // subtractKeybind
            // 
            subtractKeybind.Location = new Point(127, 353);
            subtractKeybind.Name = "subtractKeybind";
            subtractKeybind.ReadOnly = true;
            subtractKeybind.Size = new Size(100, 23);
            subtractKeybind.TabIndex = 16;
            // 
            // addKeybind
            // 
            addKeybind.Location = new Point(127, 307);
            addKeybind.Name = "addKeybind";
            addKeybind.ReadOnly = true;
            addKeybind.Size = new Size(100, 23);
            addKeybind.TabIndex = 15;
            // 
            // topmostBox
            // 
            topmostBox.AutoSize = true;
            topmostBox.Location = new Point(118, 394);
            topmostBox.Name = "topmostBox";
            topmostBox.Size = new Size(118, 19);
            topmostBox.TabIndex = 14;
            topmostBox.Text = "Keep this on Top?";
            topmostBox.UseVisualStyleBackColor = true;
            topmostBox.CheckedChanged += topmostBox_CheckedChanged;
            // 
            // methodCB
            // 
            methodCB.FormattingEnabled = true;
            methodCB.Location = new Point(117, 218);
            methodCB.Name = "methodCB";
            methodCB.Size = new Size(121, 23);
            methodCB.TabIndex = 13;
            methodCB.SelectedIndexChanged += methodCB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 200);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 11;
            label1.Text = "Hunting Method:";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(140, 255);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 10;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // pokemonCB
            // 
            pokemonCB.FormattingEnabled = true;
            pokemonCB.Location = new Point(117, 78);
            pokemonCB.Name = "pokemonCB";
            pokemonCB.Size = new Size(121, 23);
            pokemonCB.TabIndex = 8;
            pokemonCB.SelectedIndexChanged += pokemonCB_SelectedIndexChanged;
            // 
            // targetLabel
            // 
            targetLabel.AutoSize = true;
            targetLabel.Location = new Point(128, 60);
            targetLabel.Name = "targetLabel";
            targetLabel.Size = new Size(96, 15);
            targetLabel.TabIndex = 7;
            targetLabel.Text = "Target Pokemon:";
            // 
            // shinyCharmYN
            // 
            shinyCharmYN.Controls.Add(shinyCharmNoRadioButton);
            shinyCharmYN.Controls.Add(shinyCharmYesRadioButton);
            shinyCharmYN.Location = new Point(73, 126);
            shinyCharmYN.Name = "shinyCharmYN";
            shinyCharmYN.Size = new Size(209, 58);
            shinyCharmYN.TabIndex = 6;
            shinyCharmYN.TabStop = false;
            // 
            // shinyCharmNoRadioButton
            // 
            shinyCharmNoRadioButton.AutoSize = true;
            shinyCharmNoRadioButton.Location = new Point(134, 22);
            shinyCharmNoRadioButton.Name = "shinyCharmNoRadioButton";
            shinyCharmNoRadioButton.Size = new Size(41, 19);
            shinyCharmNoRadioButton.TabIndex = 5;
            shinyCharmNoRadioButton.TabStop = true;
            shinyCharmNoRadioButton.Text = "No";
            shinyCharmNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // shinyCharmYesRadioButton
            // 
            shinyCharmYesRadioButton.AutoSize = true;
            shinyCharmYesRadioButton.Location = new Point(34, 22);
            shinyCharmYesRadioButton.Name = "shinyCharmYesRadioButton";
            shinyCharmYesRadioButton.Size = new Size(42, 19);
            shinyCharmYesRadioButton.TabIndex = 4;
            shinyCharmYesRadioButton.TabStop = true;
            shinyCharmYesRadioButton.Text = "Yes";
            shinyCharmYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // shinycharmLabel
            // 
            shinycharmLabel.AutoSize = true;
            shinycharmLabel.Location = new Point(138, 108);
            shinycharmLabel.Name = "shinycharmLabel";
            shinycharmLabel.Size = new Size(78, 15);
            shinycharmLabel.TabIndex = 3;
            shinycharmLabel.Text = "Shiny Charm:";
            // 
            // generationCB
            // 
            generationCB.FormattingEnabled = true;
            generationCB.Location = new Point(117, 32);
            generationCB.Name = "generationCB";
            generationCB.Size = new Size(121, 23);
            generationCB.TabIndex = 2;
            generationCB.SelectedIndexChanged += generationCB_SelectedIndexChanged;
            // 
            // generationLabel
            // 
            generationLabel.AutoSize = true;
            generationLabel.Location = new Point(143, 14);
            generationLabel.Name = "generationLabel";
            generationLabel.Size = new Size(68, 15);
            generationLabel.TabIndex = 1;
            generationLabel.Text = "Generation:";
            // 
            // HuntTab
            // 
            HuntTab.Controls.Add(keybindLabelA);
            HuntTab.Controls.Add(keybindLabelS);
            HuntTab.Controls.Add(statsTable);
            HuntTab.Controls.Add(pokemonLabel);
            HuntTab.Controls.Add(pictureBox1);
            HuntTab.Controls.Add(subtractButton);
            HuntTab.Controls.Add(addButton);
            HuntTab.Location = new Point(4, 24);
            HuntTab.Name = "HuntTab";
            HuntTab.Padding = new Padding(3);
            HuntTab.Size = new Size(354, 459);
            HuntTab.TabIndex = 0;
            HuntTab.Text = "Hunt";
            HuntTab.UseVisualStyleBackColor = true;
            // 
            // keybindLabelA
            // 
            keybindLabelA.AutoSize = true;
            keybindLabelA.Location = new Point(292, 418);
            keybindLabelA.Name = "keybindLabelA";
            keybindLabelA.Size = new Size(0, 15);
            keybindLabelA.TabIndex = 8;
            // 
            // keybindLabelS
            // 
            keybindLabelS.AutoSize = true;
            keybindLabelS.Location = new Point(62, 418);
            keybindLabelS.Name = "keybindLabelS";
            keybindLabelS.Size = new Size(0, 15);
            keybindLabelS.TabIndex = 7;
            // 
            // statsTable
            // 
            statsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            statsTable.ColumnCount = 2;
            statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            statsTable.Location = new Point(32, 273);
            statsTable.Name = "statsTable";
            statsTable.RowCount = 4;
            statsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            statsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            statsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            statsTable.Size = new Size(290, 100);
            statsTable.TabIndex = 6;
            // 
            // pokemonLabel
            // 
            pokemonLabel.Anchor = AnchorStyles.None;
            pokemonLabel.AutoSize = true;
            pokemonLabel.Location = new Point(177, 9);
            pokemonLabel.Name = "pokemonLabel";
            pokemonLabel.Size = new Size(0, 15);
            pokemonLabel.TabIndex = 5;
            pokemonLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(32, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 219);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(32, 392);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(75, 23);
            subtractButton.TabIndex = 1;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(247, 392);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 0;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(HuntTab);
            tabControl1.Controls.Add(SettingsTab);
            tabControl1.Location = new Point(-2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(362, 487);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 486);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Bovey's Pokemon Counter";
            SettingsTab.ResumeLayout(false);
            SettingsTab.PerformLayout();
            shinyCharmYN.ResumeLayout(false);
            shinyCharmYN.PerformLayout();
            HuntTab.ResumeLayout(false);
            HuntTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage SettingsTab;
        private ComboBox methodCB;
        private Label label1;
        private Button resetButton;
        private ComboBox pokemonCB;
        private Label targetLabel;
        private GroupBox shinyCharmYN;
        private RadioButton shinyCharmNoRadioButton;
        private RadioButton shinyCharmYesRadioButton;
        private Label shinycharmLabel;
        private ComboBox generationCB;
        private Label generationLabel;
        private TabPage HuntTab;
        private TableLayoutPanel statsTable;
        private Label pokemonLabel;
        private PictureBox pictureBox1;
        private Button subtractButton;
        private Button addButton;
        private TabControl tabControl1;
        private CheckBox topmostBox;
        private Label subtractKBLabel;
        private Label addKBLabel;
        private TextBox subtractKeybind;
        private TextBox addKeybind;
        private Label keybindLabelA;
        private Label keybindLabelS;
    }
}
