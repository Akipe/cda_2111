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

        // Initialise les valeurs par d�faut de l'emprunt
        // - taux d'int�ret � 7%
        // - dur�e en mois de remboursement �gale � 1
        // - p�riodicit� de remboursement en mensuelle
        private void InitDefaultBorrowValue()
        {

        }

        // Initialise le focus sur le champ du nom
        private void InitFocusToName()
        {

        }

        // On initialise la liste de choix pour la p�riodicit� des remboursements
        private void InitRepaymentFrequencyValues()
        {

        }

        #endregion

        #region Logic

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

        #endregion

        #region Logic data pick

        // On met � jour l'emprunt par rapport � toutes les entr�es de l'utilisateur
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

        // On d�fini le capital emprunt� depuis l'entr�e de l'utilisateur
        private void SetAmountBorrowedFromForm()
        {

        }

        // On d�fini la dur�e en mois du remboursement depuis l'entr�e de l'utilisateur
        private void SetDurationInMonthsFromForm()
        {

        }

        // On d�fini la p�riodicit� du remboursement
        private void SetRepaymentFrequencyFromForm()
        {

        }

        // On d�fini le taux d'int�r�t annuel
        private void SetInterestRateFromForm()
        {

        }

        #endregion

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