using BorrowCore;
using BorrowCore.Convertion;
using BorrowCore.Validation;
using BorrowForm.Properties;
using System.Text;

namespace BorrowForm
{
    public partial class BorrowMainForm : Form
    {
        private const TimeFrequency DEFAULT_TIME_FREQUENCY = TimeFrequency.Monthly;
        private const string DEFAULT_MESSAGE_ = "Données manquantes";

        private BorrowCalculation calculator;
        private ErrorProvider errorProvider;

        public BorrowMainForm()
        {
            InitializeComponent();

            InitErrorProvider();
        }

        #region Init

        private void BorrowMainForm_Load(object sender, EventArgs e)
        {
            calculator = new BorrowCalculation();

            InitFocusToName();
            InitRepaymentFrequencyValues();
            InitDefaultBorrowValue();
            InitDurationMonthsRepayment();
            InitLabelRefundTotal();

            LAmountRefund.Text = Settings.Default.NumberRefund.ToString();
        }

        // Initialiser l'error provider
        private void InitErrorProvider()
        {
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        // Initialise les valeurs par défaut de l'emprunt
        // - taux d'intéret à 7%
        // - durée en mois de remboursement égale à 1
        // - périodicité de remboursement en mensuelle
        private void InitDefaultBorrowValue()
        {
            RbInterestRate7Percent.Checked = true;
            SetDurationMonthsRepaymentValue(Settings.Default.DurationMonthRepayment);
        }

        // Initialise le focus sur le champ du nom
        private void InitFocusToName()
        {
            TbName.Focus();
        }

        // On initialise la liste de choix pour la périodicité des remboursements
        private void InitRepaymentFrequencyValues()
        {
            foreach (Tuple<TimeFrequency, string> frequency in TimeFrequencyConversion.CORRESPONDENCE)
            {
                LbRepaymentFrequency.Items.Add(frequency.Item2);

                if (frequency.Item1 == DEFAULT_TIME_FREQUENCY)
                {
                    int lastIndex = LbRepaymentFrequency.Items.Count - 1;
                    LbRepaymentFrequency.SelectedIndex = lastIndex;
                }
            }
        }

        // On initialise les propriétés de la barre de défillement
        private void InitDurationMonthsRepayment()
        {
            SetDurationMonthsRepaymentValue();
        }

        private void InitLabelRefundTotal()
        {
            LRefundTotal.Text = Resources.NoValidsData;
        }

        #endregion Init

        #region Logic

        // Définition et affichage de notre emprunt par rapport à notre formulaire
        private void UpdateBorrowFromForm()
        {
            if (IsAllUserInputsAreValid())
            {
                ResetAllErrors();
                SetBorrowSettingsFromForm();
                UpdateBorrowResultShowed();
            }
            else
            {
                ShowErrorsOnInputForm();
                ResetResultShowed();
            }
        }

        private void ShowErrorsOnInputForm()
        {
            ShowErrorsForName();
            ShowErrorsOnBorrowAmout();
        }

        private void ResetResultShowed()
        {
            calculator.Reset();

            LAmountRefund.Text = Settings.Default.NumberRefund.ToString();
            LRefundTotal.Text = Resources.NoValidsData;
        }

        // Réinitialiser l'ensemble des valeurs des entrées de l'utilisateur
        private void ResetBorrowForm()
        {
            TbName.Text = String.Empty;
            TbBorrowedCapital.Text = String.Empty;
            LbRepaymentFrequency.SelectedIndex = 0;

            SetDurationMonthsRepaymentValue(Settings.Default.DurationMonthRepayment);

            ResetResultShowed();
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
            return UserNameValidation.IsValid(TbName.Text);
        }

        // Est ce que le champ capital emprunté respecte les contraintes
        // - que des chiffres
        // - maximum 10 chiffres
        // - pas de decimal
        // - obligatoire
        private Boolean IsBorrowedCapitalIsValid()
        {
            return CapitalBorrowValidation.IsValid(TbBorrowedCapital.Text);
        }

        // Est ce que la durée en mois du remboursement est valide
        private Boolean IsDurationInMonthIsValid()
        {
            return NumberMonthRefundValidation.IsValid(
                HsbDurationMonthsRepayment.Value.ToString()
            );
        }

        // Est ce que la périodicité du remboursement est valide
        private Boolean IsRepaymentFrequencyIsValid()
        {
            if (LbRepaymentFrequency.SelectedIndex == -1)
                return false;

            if (String.IsNullOrEmpty(LbRepaymentFrequency.SelectedItem.ToString()))
                return false;

            return TimeFrequencyValidation.IsValid(
                LbRepaymentFrequency.SelectedItem.ToString() ?? String.Empty
            );
        }

        // Est ce que le taux d'intérêt est valide
        private Boolean IsInterestRateIsValid()
        {
            return InterestRateValidation.IsValid(
                GetInterestRateSelectedByUser()
            );
        }

        #endregion Logic form test

        #region Logic form error provider

        private void ShowErrorsForName()
        {
            string errorMessage = IsNameIsValid() ? String.Empty : Resources.ErrorName;

            errorProvider.SetError(TbName, errorMessage);
        }

        private void ResetAllErrors()
        {
            errorProvider.Clear();
        }

        private void ShowErrorsOnBorrowAmout()
        {
            string errorMessage = String.Empty;

            if (
                !IsBorrowedCapitalIsValid() &&
                !String.IsNullOrEmpty(TbBorrowedCapital.Text)
            ) {
                errorMessage = Resources.ErrorBorrowAmount;
            }

            errorProvider.SetError(TbBorrowedCapital, errorMessage);
        }

        #endregion Logic form error provider

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
            try
            {
                calculator.CapitalBorrow = long.Parse(TbBorrowedCapital.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Veuillez entrer un capital emprunté respectant les critéres."
                );
            }
        }

        // On défini la durée en mois du remboursement depuis l'entrée de l'utilisateur
        private void SetDurationInMonthsFromForm()
        {
            try
            {
                calculator.DurationInMonths = HsbDurationMonthsRepayment.Value;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Erreur"
                  ); // todo
            }
        }

        private TimeFrequency GetRefundFrequency()
        {
            if (!TimeFrequencyValidation.IsValid(
                LbRepaymentFrequency.SelectedItem.ToString() ?? String.Empty
            )) {
                throw new Exception("La valeur de la frequence de remboursement n'est pas valide");
            }

            return TimeFrequencyConversion.Convert(
                LbRepaymentFrequency.SelectedItem.ToString()
            );
        }

        // On défini la périodicité du remboursement
        private void SetRepaymentFrequencyFromForm()
        {
            TimeFrequency repaymentFrequencySelected = TimeFrequencyConversion.Convert(
                LbRepaymentFrequency.SelectedItem.ToString() ?? String.Empty
            );

            calculator.RepaymentFrequency = repaymentFrequencySelected;
        }

        // On défini le taux d'intérêt annuel
        private void SetInterestRateFromForm()
        {
            try
            {
                int annualRate = int.Parse(GetInterestRateSelectedByUser());
                calculator.AnnualRatePercent = annualRate;
            }
            catch(Exception)
            {
                MessageBox.Show(
                    "Erreur"
                  ); // todo
            }
        }

        // On récupére le taux d'intéret selectionné par l'utilisateur
        private string GetInterestRateSelectedByUser()
        {
            foreach (Control control in GbInterestRate.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    if (radioButton.Checked)
                        return radioButton.Tag.ToString() ?? String.Empty;
                }
            }

            return String.Empty;
        }

        #endregion Logic data pick

        #region Logic form control set

        // Définir la durée de remboursement en mois
        private void SetDurationMonthsRepaymentValue(int? howManyMonths = null)
        {
            if (howManyMonths is not null)
                HsbDurationMonthsRepayment.Value = (int)howManyMonths;

            TimeFrequency refundFrequency = GetRefundFrequency();

            HsbDurationMonthsRepayment.Minimum = (int)refundFrequency;
            HsbDurationMonthsRepayment.LargeChange = 10 * (int)refundFrequency;
            HsbDurationMonthsRepayment.SmallChange = 1 * (int)refundFrequency;
            // Pour avoir accès au nombre maximum, on doit utiliser une petite astuce
            // MAX + LargeChange - 1
            HsbDurationMonthsRepayment.Maximum =
                NumberMonthRefundValidation.MAX + HsbDurationMonthsRepayment.LargeChange - 1;

            UpdateCurrentDurationMonthRespectMultiple();

            if (HsbDurationMonthsRepayment.Value < (int)refundFrequency)
                HsbDurationMonthsRepayment.Value = (int)refundFrequency;

            UpdateDurationInMonthsShowed();
            UpdateNumberRefundToDo();
            SetDurationInMonthsFromForm();
        }

        // On change le nombre de mois selectionnés en respectant le multiple des fréquences
        // mensuelle : de 1 en 1 en partant de 1
        // bimensuelle : de 2 en 2 en partant de 2
        // trimestrielle : de 3 en 3 en partant de 3
        private void UpdateCurrentDurationMonthRespectMultiple()
        {
            TimeFrequency refundFrequency = GetRefundFrequency();

            if ((double)HsbDurationMonthsRepayment.Value % (double)refundFrequency != 0.0)
            {
                int result = 
                    HsbDurationMonthsRepayment.Value / (int)refundFrequency * (int)refundFrequency + (int)refundFrequency;

                HsbDurationMonthsRepayment.Value = result;
            }
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
            StringBuilder builder = new StringBuilder();

            builder.Append(calculator.GetRefundAmount().ToString("0.00"));
            builder.Append(" €");
            LRefundTotal.Text = builder.ToString();
        }

        // On met à jour le nombre de remboursement à effectuer
        private void UpdateNumberRefundToDo()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Remboursement");
            if (calculator.GetNumberRefund() > 1)
                builder.Append('s');

            LPresentRefund.Text = builder.ToString();
            LAmountRefund.Text = calculator.GetNumberRefund().ToString();
        }

        // On met à jour l'affichage de la durée en mois choisi par l'utilisateur
        private void UpdateDurationInMonthsShowed()
        {
            LHowManyMonthsRepayment.Text = HsbDurationMonthsRepayment.Value.ToString();
        }

        #endregion Logic update result

        #endregion Logic

        #region Events

        private void GeneralControls_DataChanged(object sender, EventArgs e)
        {
            if (sender is ListBox)
            {
                SetDurationMonthsRepaymentValue();
            }

            UpdateBorrowFromForm();
        }

        private void ScrollBarControls_DataChanged(object sender, ScrollEventArgs e)
        {
            UpdateDurationInMonthsShowed();
            UpdateBorrowFromForm();
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            ResetBorrowForm();
        }

        #endregion Events
    }
}