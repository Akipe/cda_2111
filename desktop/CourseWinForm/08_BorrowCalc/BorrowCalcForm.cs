namespace _08_BorrowCalc
{
    public partial class BorrowCalcForm : Form
    {
        private BorrowCalculation borrowCalculation { get; set; }

        public BorrowCalcForm()
        {
            InitializeComponent();

            InitDefaultBorrowValue();
            InitFocusToName();
            InitRepaymentFrequencyValues();
        }

        #region Init

        // Initialise les valeurs par défaut de l'emprunt
        // - taux d'intéret à 7%
        // - durée en mois de remboursement égale à 1
        // - périodicité de remboursement en mensuelle
        private void InitDefaultBorrowValue()
        {

        }

        // Initialise le focus sur le champ du nom
        private void InitFocusToName()
        {

        }

        // On initialise la liste de choix pour la périodicité des remboursements
        private void InitRepaymentFrequencyValues()
        {

        }

        #endregion

        #region Logic

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

        #endregion

        #region Logic data pick

        // On met à jour l'emprunt par rapport à toutes les entrées de l'utilisateur
        private void UpdateBorrowFromForm()
        {
            if (IsAllUserInputsAreValid())
            {
                SetAmountBorrowedFromForm();
                SetDurationInMonthsFromForm();
                SetRepaymentFrequencyFromForm();
                SetInterestRateFromForm();

                UpdateBorrowResultShowed();
            }
        }

        // On défini le capital emprunté depuis l'entrée de l'utilisateur
        private void SetAmountBorrowedFromForm()
        {

        }

        // On défini la durée en mois du remboursement depuis l'entrée de l'utilisateur
        private void SetDurationInMonthsFromForm()
        {

        }

        // On défini la périodicité du remboursement
        private void SetRepaymentFrequencyFromForm()
        {

        }

        // On défini le taux d'intérêt annuel
        private void SetInterestRateFromForm()
        {

        }

        #endregion

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

        #endregion

        #endregion

        #region Events

        private void GeneralControls_DataChanged(object sender, EventArgs e)
        {
            UpdateBorrowFromForm();
        }

        private void ScrollBarControls_DataChanged(object sender, ScrollEventArgs e)
        {
            UpdateBorrowFromForm();
        }

        #endregion
    }
}