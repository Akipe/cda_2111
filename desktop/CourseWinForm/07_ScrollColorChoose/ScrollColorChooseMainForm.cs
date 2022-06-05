namespace _07_ScrollColorChoose
{
    public partial class ScrollColorChooseMainForm : Form
    {
        public ScrollColorChooseMainForm()
        {
            InitializeComponent();
            InitHsbColorLevel();
            InitNupColorLevel();
            InitTagsColorButtons();
            UserColor = new ColorChooser();
        }

        public ColorChooser UserColor { get; set;}

        #region Init

        // Initialisation des valeurs pour les barres de défilement
        private void InitHsbColorLevel()
        {
            SetMinMaxColorValueForScollBar(HsbColorLevelRed);
            SetMinMaxColorValueForScollBar(HsbColorLevelGreen);
            SetMinMaxColorValueForScollBar(HsbColorLevelRed);
        }

        private void SetMinMaxColorValueForScollBar(ScrollBar scrollBar)
        {
            scrollBar.Minimum = ColorChooser.MIN_COLOR_LEVEL;
            scrollBar.Maximum = ColorChooser.MAX_COLOR_LEVEL;
        }
        
        // Initialisation des valeurs pour les champs numériques
        private void InitNupColorLevel()
        {
            SetMinMaxColorValueForNumericInput(NudColorLevelRed);
            SetMinMaxColorValueForNumericInput(NudColorLevelGreen);
            SetMinMaxColorValueForNumericInput(NudColorLevelBlue);
        }
        private void SetMinMaxColorValueForNumericInput(NumericUpDown input)
        {
            input.Minimum = ColorChooser.MIN_COLOR_LEVEL;
            input.Maximum = ColorChooser.MAX_COLOR_LEVEL;
        }

        // Initialisation des tags couleurs des différents boutons
        private void InitTagsColorButtons()
        {
            SetTagsForAllPanelControl(
                PColorChooseRed,
                PrimaryColor.Red
            );
            SetTagsForAllPanelControl(
                PColorChooseGreen,
                PrimaryColor.Green
            );
            SetTagsForAllPanelControl(
                PColorChooseBlue,
                PrimaryColor.Blue
            );
        }

        private void SetTagsForAllPanelControl(Panel panel, PrimaryColor primaryColor)
        {
            foreach (Control control in panel.Controls)
            {
                control.Tag = primaryColor;
            }
        }

        #endregion

        #region Logic

        // Mise à jour d'une couleur
        private void UpdateColor(PrimaryColor targetColor, int colorValue)
        {
            if (IsColorOverflow(colorValue))
            {
                throw new Exception("La couleur doit être entre ..");
            }

            switch(targetColor)
            {
                case PrimaryColor.Red:
                    UpdateValuePrimaryColorButtons(PColorChooseRed, colorValue);
                    UserColor.Red = (byte)colorValue;
                    break;
                case PrimaryColor.Green:
                    UpdateValuePrimaryColorButtons(PColorChooseGreen, colorValue);
                    UserColor.Green = (byte)colorValue;
                    break;
                case PrimaryColor.Blue:
                    UpdateValuePrimaryColorButtons(PColorChooseBlue, colorValue);
                    UserColor.Blue = (byte)colorValue;
                    break;
            }

            UpdateColorPreview(targetColor, colorValue);
            UpdateFinalColorPreview();
        }

        // Vérification que la valeur de la couleur ne dépasse pas les limites
        private bool IsColorOverflow(int colorValue)
        {
            return colorValue < ColorChooser.MIN_COLOR_LEVEL
                || colorValue > ColorChooser.MAX_COLOR_LEVEL;
        }

        // Mise à jour des valeurs de tous les boutons d'une couleur primaire
        private void UpdateValuePrimaryColorButtons(Panel colorPanel, int colorValue)
        {
            foreach (Control button in colorPanel.Controls)
            {
                if (button is ScrollBar scrollbar)
                    scrollbar.Value = colorValue;
                if (button is NumericUpDown numericInput)
                    numericInput.Value = colorValue;
            }
        }

        // Mise à jour de l'affichage des couleurs
        private void UpdateColorPreview(PrimaryColor targetColor, int colorValue)
        {
            switch (targetColor)
            {
                case PrimaryColor.Red:
                    LColorPreviewRed.BackColor = Color.FromArgb(colorValue, 0, 0);
                    break;
                case PrimaryColor.Green:
                    LColorPreviewGreen.BackColor = Color.FromArgb(0, colorValue, 0);
                    break;
                case PrimaryColor.Blue:
                    LColorPreviewBlue.BackColor = Color.FromArgb(0, 0, colorValue);
                    break;
            }
        }

        private void UpdateFinalColorPreview()
        {
            LColorPreview.BackColor = UserColor.GetFinalColor();
        }

        #endregion

        #region Event

        // Maj de la couleur au défilement de la barre horizontal
        private void ControlChangePrimaryColorValue(object sender, ScrollEventArgs e)
        {
            if (sender is ScrollBar scrollbar)
                UpdateColor(
                    (PrimaryColor)scrollbar.Tag,
                    scrollbar.Value
                );
        }

        // Maj de la couleur au changement de la valeur de la barre horizontal

        // Maj de la couleur lors du changement du nombre représentant la couleur
        #endregion

        private void ControlChangePrimaryColorValue(object sender, EventArgs e)
        {
            if (sender is NumericUpDown numericInput)
                UpdateColor(
                    (PrimaryColor)numericInput.Tag,
                    Decimal.ToInt32(numericInput.Value)
                );
        }
    }
}