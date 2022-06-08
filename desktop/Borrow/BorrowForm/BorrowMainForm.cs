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

        // Initialise les valeurs par d�faut de l'emprunt
        // - taux d'int�ret � 7%
        // - dur�e en mois de remboursement �gale � 1
        // - p�riodicit� de remboursement en mensuelle
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

        // On initialise la liste de choix pour la p�riodicit� des remboursements
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

        // D�finition et affichage de notre emprunt par rapport � notre formulaire
        private void UpdateBorrowFromForm()
        {
            if (IsAllUserInputsAreValid())
            {
                SetBorrowSettingsFromForm();
                UpdateBorrowResultShowed();
            }
        }

        // R�initialiser l'ensemble des valeurs des entr�es de l'utilisateur
        private void ResetBorrowForm()
        {

        }

        #region Logic form test

        // Est ce que l'ensemble des entr�es de l'utilisateurs sont valides
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
        // - uniquement des caract�res alphab�tiques.
        private Boolean IsNameIsValid()
        {
            return true;
        }

        // Est ce que le champ capital emprunt� respecte les contraintes
        // - que des chiffres
        // - maximum 10 chiffres
        // - pas de decimal
        // - obligatoire
        private Boolean IsBorrowedCapitalIsValid()
        {
            return true;
        }

        // Est ce que la dur�e en mois du remboursement est valide
        private Boolean IsDurationInMonthIsValid()
        {
            return true;
        }

        // Est ce que la p�riodicit� du remboursement est valide
        private Boolean IsRepaymentFrequencyIsValid()
        {
            return true;
        }

        // Est ce que le taux d'int�r�t est valide
        private Boolean IsInterestRateIsValid()
        {
            return true;
        }

        #endregion Logic form test

        #region Logic data pick

        // On mets � jour l'emprunt par rapport � l'ensemble des entr�es de l'utilisateur
        private void SetBorrowSettingsFromForm()
        {
            SetAmountBorrowedFromForm();
            SetDurationInMonthsFromForm();
            SetRepaymentFrequencyFromForm();
            SetInterestRateFromForm();
        }

        // On d�fini le capital emprunt� depuis l'entr�e de l'utilisateur
        private void SetAmountBorrowedFromForm()
        {

        }

        // On d�fini la dur�e en mois du remboursement depuis l'entr�e de l'utilisateur
        private void SetDurationInMonthsFromForm()
        {
            // ...
            UpdateDurationInMonthsShowed();
        }

        // On d�fini la p�riodicit� du remboursement
        private void SetRepaymentFrequencyFromForm()
        {

        }

        // On d�fini le taux d'int�r�t annuel
        private void SetInterestRateFromForm()
        {

        }

        #endregion Logic data pick

        #region Logic form control set

        // D�finir la dur�e de remboursement en mois
        private void SetDurationMonthsRepaymentValue(int howManyMonths)
        {
            // ...
            UpdateDurationInMonthsShowed();
        }

        #endregion Logic form set

        #region Logic update result

        // On met � jour l'ensemble des r�sultats
        private void UpdateBorrowResultShowed()
        {
            UpdateAmountRefundShowed();
            UpdateNumberRefundToDo();
        }

        // On met � jour la somme total � rembourser
        private void UpdateAmountRefundShowed()
        {

        }

        // On met � jour le nombre de remboursement � effectuer
        private void UpdateNumberRefundToDo()
        {

        }

        // On met � jour l'affichage de la dur�e en mois choisi par l'utilisateur
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
