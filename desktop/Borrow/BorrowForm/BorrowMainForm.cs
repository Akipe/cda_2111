using BorrowCore;
using BorrowCore.Convertion;
using BorrowCore.Validation;
using System.Text;

namespace BorrowForm
{
    public partial class BorrowMainForm : Form
    {
        private const int DEFAULT_DURATION_MONTHS_REPAYMENT = 1;
        private RadioButton DEFAULT_INTEREST_RATE;
        private BorrowCalculation calculator;

        public BorrowMainForm()
        {
            InitializeComponent();
        }

        #region Init

        private void BorrowMainForm_Load(object sender, EventArgs e)
        {
            DEFAULT_INTEREST_RATE = RbInterestRate7Percent;

            calculator = new BorrowCalculation();

            InitFocusToName();
            InitRepaymentFrequencyValues();
            InitDefaultBorrowValue();
            InitDurationMonthsRepaymentRange();
        }

        // Initialise les valeurs par d�faut de l'emprunt
        // - taux d'int�ret � 7%
        // - dur�e en mois de remboursement �gale � 1
        // - p�riodicit� de remboursement en mensuelle
        private void InitDefaultBorrowValue()
        {
            DEFAULT_INTEREST_RATE.Checked = true;
            SetDurationMonthsRepaymentValue(DEFAULT_DURATION_MONTHS_REPAYMENT);
        }

        // Initialise le focus sur le champ du nom
        private void InitFocusToName()
        {
            TbName.Focus();
        }

        // On initialise la liste de choix pour la p�riodicit� des remboursements
        private void InitRepaymentFrequencyValues()
        {
            foreach (Tuple<TimeFrequency, string> frequency in TimeFrequencyConversion.CORRESPONDENCE)
            {
                LbRepaymentFrequency.Items.Add(frequency.Item2);
            }
        }

        private void InitDurationMonthsRepaymentRange()
        {
            HsbDurationMonthsRepayment.Minimum = NumberMonthRefundValidation.MIN;
            HsbDurationMonthsRepayment.Maximum = NumberMonthRefundValidation.MAX;
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
            else
            {
                ResetResultShowed(); // todo : remplacer par ShowInvalidInputUser();
            }
        }

        private void ResetResultShowed()
        {
            calculator.Reset();

            LAmountRefund.Text = "0";
            LRefundTotal.Text = "0,00 �";
        }

        // R�initialiser l'ensemble des valeurs des entr�es de l'utilisateur
        private void ResetBorrowForm()
        {
            TbName.Text = String.Empty;
            TbBorrowedCapital.Text = String.Empty;
            SetDurationMonthsRepaymentValue(DEFAULT_DURATION_MONTHS_REPAYMENT);
            LbRepaymentFrequency.SelectedIndex = -1;
            DEFAULT_INTEREST_RATE.Checked = true;

            ResetResultShowed();
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
            return UserNameValidation.IsValid(TbName.Text);
        }

        // Est ce que le champ capital emprunt� respecte les contraintes
        // - que des chiffres
        // - maximum 10 chiffres
        // - pas de decimal
        // - obligatoire
        private Boolean IsBorrowedCapitalIsValid()
        {
            return CapitalBorrowValidation.IsValid(TbBorrowedCapital.Text);
        }

        // Est ce que la dur�e en mois du remboursement est valide
        private Boolean IsDurationInMonthIsValid()
        {
            return NumberMonthRefundValidation.IsValid(
                HsbDurationMonthsRepayment.Value.ToString()
            );
        }

        // Est ce que la p�riodicit� du remboursement est valide
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

        // Est ce que le taux d'int�r�t est valide
        private Boolean IsInterestRateIsValid()
        {
            return InterestRateValidation.IsValid(
                GetInterestRateSelectedByUser()
            );
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
            try
            {
                calculator.CapitalBorrow = int.Parse(TbBorrowedCapital.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Veuillez entrer un capital emprunt� respectant les crit�res."
                );
            }
        }

        // On d�fini la dur�e en mois du remboursement depuis l'entr�e de l'utilisateur
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

        // On d�fini la p�riodicit� du remboursement
        private void SetRepaymentFrequencyFromForm()
        {
            TimeFrequency repaymentFrequencySelected = TimeFrequencyConversion.Convert(
                LbRepaymentFrequency.SelectedItem.ToString() ?? String.Empty
            );

            calculator.RepaymentFrequency = repaymentFrequencySelected;
        }

        // On d�fini le taux d'int�r�t annuel
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

        // On r�cup�re le taux d'int�ret selectionn� par l'utilisateur
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

        // D�finir la dur�e de remboursement en mois
        private void SetDurationMonthsRepaymentValue(int howManyMonths)
        {
            HsbDurationMonthsRepayment.Value = howManyMonths;
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
            StringBuilder builder = new StringBuilder();

            builder.Append(calculator.GetRefundAmount().ToString("0.00"));
            builder.Append(" �");
            LRefundTotal.Text = builder.ToString();
        }

        // On met � jour le nombre de remboursement � effectuer
        private void UpdateNumberRefundToDo()
        {
            LAmountRefund.Text = calculator.GetNumberRefund().ToString();
        }

        // On met � jour l'affichage de la dur�e en mois choisi par l'utilisateur
        private void UpdateDurationInMonthsShowed()
        {
            LHowManyMonthsRepayment.Text = HsbDurationMonthsRepayment.Value.ToString();
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