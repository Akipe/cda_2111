namespace BorrowForm
{
    public partial class BorrowMainForm : Form
    {
        private const string FREQUENCY_MONTHLY = "Mensuelle";
        private const string FREQUENCY_BIMONTHLY = "Bimestrielle";
        private const string FREQUENCY_QUARTERLY = "Trimestrielle";
        private const string FREQUENCY_SEMIANNUAL = "Semestrielle";
        private const string FREQUENCY_ANNUAL = "Annuelle";

        private BorrowCalculation borrowCalculation { get; set; }

        public BorrowMainForm()
        {
            InitializeComponent();
            InitFocusToName();
            InitRepaymentFrequencyValues();
            InitDefaultBorrowValue();
        }

        #region Init

        // Initialise les valeurs par défaut de l'emprunt
        // - taux d'intéret à 7%
        // - durée en mois de remboursement égale à 1
        // - périodicité de remboursement en mensuelle
        private void InitDefaultBorrowValue()
        {
            RbInterestRate7Percent.Checked = true;
            SetDurationMonthsRepaymentValue(1);

        }

        // Initialise le focus sur le champ du nom
        private void InitFocusToName()
        {
            TbName.Focus();
        }

        // On initialise la liste de choix pour la périodicité des remboursements
        private void InitRepaymentFrequencyValues()
        {
            string[] listFrequencies = new string[]
            {
                FREQUENCY_MONTHLY,
                FREQUENCY_BIMONTHLY,
                FREQUENCY_QUARTERLY,
                FREQUENCY_SEMIANNUAL,
                FREQUENCY_ANNUAL
            };

            foreach (string frequency in listFrequencies)
            {
                LbRepaymentFrequency.Items.Add(frequency);
            }
        }

        #endregion Init

        #region Logic

        // Définition et affichage de notre emprunt par rapport à notre formulaire
        private void UpdateBorrowFromForm()
        {
            if (IsAllUserInputsAreValid())
            {
                SetBorrowSettingsFromForm();
                UpdateBorrowResultShowed();
            }
        }

        // Réinitialiser l'ensemble des valeurs des entrées de l'utilisateur
        private void ResetBorrowForm()
        {

        }

        #region Logic form test

        // Est ce que l'ensemble des entrées de l'utilisateurs sont valides
        private Boolean IsAllUserInputsAreValid()
        {
            return IsNameIsValid() &&
                IsBorrowedCapitalIsValid() &&
                IsDurationInMonthIsValid() &&
                IsRepaymentFrequencyIsValid() &&
                IsInterestRateIsValid();
        }

        // Est ce que le champ nom respecte les contraintes
        // - il est optionnel
        // - uniquement des caractères alphabétiques.
        private Boolean IsNameIsValid()
        {
            return true;
        }

        // Est ce que le champ capital emprunté respecte les contraintes
        // - que des chiffres
        // - maximum 10 chiffres
        // - pas de decimal
        // - obligatoire
        private Boolean IsBorrowedCapitalIsValid()
        {
            return true;
        }

        // Est ce que la durée en mois du remboursement est valide
        private Boolean IsDurationInMonthIsValid()
        {
            return true;
        }

        // Est ce que la périodicité du remboursement est valide
        private Boolean IsRepaymentFrequencyIsValid()
        {
            return true;
        }

        // Est ce que le taux d'intérêt est valide
        private Boolean IsInterestRateIsValid()
        {
            return true;
        }

        #endregion Logic form test

        #region Logic data pick

        // On mets à jour l'emprunt par rapport à l'ensemble des entrées de l'utilisateur
        private void SetBorrowSettingsFromForm()
        {
            SetAmountBorrowedFromForm();
            SetDurationInMonthsFromForm();
            SetRepaymentFrequencyFromForm();
            SetInterestRateFromForm();
        }

        // On défini le capital emprunté depuis l'entrée de l'utilisateur
        private void SetAmountBorrowedFromForm()
        {

        }

        // On défini la durée en mois du remboursement depuis l'entrée de l'utilisateur
        private void SetDurationInMonthsFromForm()
        {
            // ...
            UpdateDurationInMonthsShowed();
        }

        // On défini la périodicité du remboursement
        private void SetRepaymentFrequencyFromForm()
        {

        }

        // On défini le taux d'intérêt annuel
        private void SetInterestRateFromForm()
        {

        }

        #endregion Logic data pick

        #region Logic form control set

        // Définir la durée de remboursement en mois
        private void SetDurationMonthsRepaymentValue(int howManyMonths)
        {
            // ...
            UpdateDurationInMonthsShowed();
        }

        #endregion Logic form set

        #region Logic update result

        // On met à jour l'ensemble des résultats
        private void UpdateBorrowResultShowed()
        {
            UpdateAmountRefundShowed();
            UpdateNumberRefundToDo();
        }

        // On met à jour la somme total à rembourser
        private void UpdateAmountRefundShowed()
        {

        }

        // On met à jour le nombre de remboursement à effectuer
        private void UpdateNumberRefundToDo()
        {

        }

        // On met à jour l'affichage de la durée en mois choisi par l'utilisateur
        private void UpdateDurationInMonthsShowed()
        {

        }

        #endregion Logic update result

        #endregion Logic

        #region Events

        private void GeneralControls_DataChanged(object sender, EventArgs e)
        {
            UpdateBorrowFromForm();
        }

        private void ScrollBarControls_DataChanged(object sender, ScrollEventArgs e)
        {
            UpdateBorrowFromForm();
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            ResetBorrowForm();
        }

        #endregion Events
    }
