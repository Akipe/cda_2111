namespace _07_ScrollColorChoose
{
    public partial class ScrollColorChooseMainForm : Form
    {
        private const int DEFAULT_PRIMARY_COLOR_LEVEL = 255;

        public ScrollColorChooseMainForm()
        {
            InitializeComponent();
            InitMinMaxColorLevel();
            InitTagsColorButtons();
            UserColor = new ColorChooser();
            InitPrimariesColors();
            InitColorShow();
        }

        public ColorChooser UserColor { get; set;}

        #region Init

        // Initialisation des valeurs pour les différents controls
        private void InitMinMaxColorLevel()
        {
            foreach(Control control in PColorChoose.Controls)
            {
                if (control is ScrollBar scrollBar)
                {
                    scrollBar.Minimum = ColorChooser.MIN_COLOR_LEVEL;
                    scrollBar.Maximum = ColorChooser.MAX_COLOR_LEVEL;
                }
                if (control is NumericUpDown numericInput)
                {
                    numericInput.Minimum = ColorChooser.MIN_COLOR_LEVEL;
                    numericInput.Maximum = ColorChooser.MAX_COLOR_LEVEL;
                }
            }
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


        private void InitPrimariesColors()
        {
            UpdateColor(PrimaryColor.Red, DEFAULT_PRIMARY_COLOR_LEVEL);
            UpdateColor(PrimaryColor.Green, DEFAULT_PRIMARY_COLOR_LEVEL);
            UpdateColor(PrimaryColor.Blue, DEFAULT_PRIMARY_COLOR_LEVEL);
        }

        // Initialisation de l'affichage de la couleur
        private void InitColorShow()
        {
            UpdateColor(PrimaryColor.Red, UserColor.Red);
            UpdateColor(PrimaryColor.Green, UserColor.Green);
            UpdateColor(PrimaryColor.Blue, UserColor.Blue);
            UpdateFinalColorPreview();
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
                    UserColor.Red = (byte)colorValue;
                    UpdateValuePrimaryColorButtons(PColorChooseRed, colorValue);
                    break;
                case PrimaryColor.Green:
                    UserColor.Green = (byte)colorValue;
                    UpdateValuePrimaryColorButtons(PColorChooseGreen, colorValue);
                    break;
                case PrimaryColor.Blue:
                    UserColor.Blue = (byte)colorValue;
                    UpdateValuePrimaryColorButtons(PColorChooseBlue, colorValue);
                    break;
            }

            UpdateColorPreview(targetColor);
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
        private void UpdateColorPreview(PrimaryColor targetColor)
        {
            switch (targetColor)
            {
                case PrimaryColor.Red:
                    LColorPreviewRed.BackColor = Color.FromArgb(UserColor.Red, 0, 0);
                    break;
                case PrimaryColor.Green:
                    LColorPreviewGreen.BackColor = Color.FromArgb(0, UserColor.Green, 0);
                    break;
                case PrimaryColor.Blue:
                    LColorPreviewBlue.BackColor = Color.FromArgb(0, 0, UserColor.Blue);
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