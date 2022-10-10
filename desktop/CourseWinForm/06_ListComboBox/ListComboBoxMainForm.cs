namespace _06_ListComboBox
{
    public partial class ListComboBoxMainForm : Form
    {
        public ListComboBoxMainForm()
        {
            InitializeComponent();
            InitCbSourceDataList();
            InitMoveElementListButtons();
        }

        #region Init

        // Ajout des données par défaut à la liste
        private void InitCbSourceDataList()
        {
            string[] defaultList = new string[]
            {
                "France",
                "Belgique",
                "Allemagnie",
                "Japon",
                "Portugale",
                "Grece"
            };

            CbSource.Items.AddRange(defaultList);
        }

        private void InitMoveElementListButtons()
        {
            BAddOneToTarget.Tag = ButtonMoveAction.OneSourceToTarget;
            BAddOneToSource.Tag = ButtonMoveAction.OneTargetToSource;
            BAddAllToTarget.Tag = ButtonMoveAction.AllSourceToTarget;
            BAddAllToSource.Tag = ButtonMoveAction.AllTargetToSource;
            BSourceMoveTop.Tag      = ButtonMoveAction.Top;
            BSourceMoveBottom.Tag   = ButtonMoveAction.Bottom;
        }

        #endregion

        #region Logic

        // Déplacer une donnée d'une liste à une autre
        private Boolean MoveDataFromTwoList(
            ComboBox origineList,
            ListBox destinationList
        )
        {
            AddDataToListIfNotExist(
                destinationList,
                origineList.Text
            );

            RemoveFromListIfExist(origineList, origineList.Text);
            origineList.Text = String.Empty;

            return true;
        }
        private Boolean MoveDataFromTwoList(
            ListBox origineList,
            ComboBox destinationList
        )
        {
            AddDataToListIfNotExist(
                destinationList,
                origineList.Text
            );

            RemoveFromListIfExist(origineList, origineList.Text);
            origineList.Text = String.Empty;

            return true;
        }

        // Remove data from list if exist
        private void RemoveFromListIfExist(ListBox listBox, string data)
        {
            if (listBox.Items.Contains(data))
            {
                listBox.Items.Remove(data);
            }
        }
        private void RemoveFromListIfExist(ComboBox comboBox, string data)
        {
            if (comboBox.Items.Contains(data))
            {
                comboBox.Items.Remove(data);
            }
        }

        // Ajouter tous les éléments à une liste
        private Boolean MoveAllDataFromTwoList(
            ComboBox origineList,
            ListBox destinationList
        )
        {
            if (origineList.Items.Count == 0)
            {
                return false;
            }

            foreach (string data in origineList.Items)
            {
                AddDataToListIfNotExist(destinationList, data);
            }
            origineList.Items.Clear();

            MoveDataFromTwoList(origineList, destinationList);

            return true;
        }
        private Boolean MoveAllDataFromTwoList(
            ListBox origineList,
            ComboBox destinationList
        )
        {
            if (origineList.Items.Count == 0)
            {
                return false;
            }

            foreach (string data in origineList.Items)
            {
                AddDataToListIfNotExist(destinationList, data);
            }
            origineList.Items.Clear();

            MoveDataFromTwoList(origineList, destinationList);

            return true;
        }

        // Ajouter une donnée non existante dans une liste
        private Boolean AddDataToListIfNotExist(ListBox listBox, string data)
        {
            if (data.Trim().Equals(String.Empty))
            {
                return false;
            }

            if (listBox.Items.Contains(data))
            {
                return false;
            }

            listBox.Items.Add(data);
            return true;
        }
        private Boolean AddDataToListIfNotExist(ComboBox comboBox, string data)
        {
            if (data.Trim().Equals(String.Empty))
            {
                return false;
            }

            if (comboBox.Items.Contains(data))
            {
                return false;
            }

            comboBox.Items.Add(data);
            return true;
        }

        // Déplacer vers le haut un élément
        // de la liste cible
        // Déplacer vers le bas un élément
        // de la liste cible
        private void MoveElementSelectedFromLbTarget(Button moveButton)
        {
            if (LbTarget.Items.Contains(LbTarget.Text))
            {
                object tempStorage;
                int currentIndex = LbTarget.Items.IndexOf(LbTarget.Text);
                int newIndex;

                if ((
                    ButtonMoveAction)moveButton.Tag == ButtonMoveAction.Top
                    && currentIndex > 0
                    )
                {
                    newIndex = currentIndex - 1;
                }
                else if ((
                    ButtonMoveAction)moveButton.Tag == ButtonMoveAction.Bottom
                    && currentIndex < LbTarget.Items.Count - 1
                    )
                {
                    newIndex = currentIndex + 1;
                }
                else
                {
                    throw new Exception("Error");
                }

                tempStorage = LbTarget.Items[currentIndex];
                LbTarget.Items[currentIndex] = LbTarget.Items[newIndex];
                LbTarget.Items[newIndex] = tempStorage;

                LbTarget.SelectedItem = LbTarget.Items[newIndex];
            }
        }

        // Activer ou désactiver le bouton
        // pour monter si aucune selection
        // ou premier élément selectionner
        private void TriggerEnabledButtonMoveTopBottom()
        {
            TriggerEnabledButtonMove(BSourceMoveTop, false);
            TriggerEnabledButtonMove(BSourceMoveBottom, true);
        }

        private void TriggerEnabledButtonMove(Button button, Boolean isMoveBottom)
        {
            int indexToDisable;

            indexToDisable = isMoveBottom ? LbTarget.Items.Count - 1 : 0;

            if (
                LbTarget.Items.Contains(LbTarget.Text.Trim())
                && LbTarget.Text.Trim() != (string)LbTarget.Items[indexToDisable]
            )
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        #endregion

        #region Events

        private void CbSource_DropDown(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                AddDataToListIfNotExist(CbSource, comboBox.Text);
            }
        }

        private void BMoveToList_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch((ButtonMoveAction)button.Tag)
                {
                    case ButtonMoveAction.OneSourceToTarget:
                        MoveDataFromTwoList(CbSource, LbTarget);
                        break;
                    case ButtonMoveAction.OneTargetToSource:
                        MoveDataFromTwoList(LbTarget, CbSource);
                        break;
                    case ButtonMoveAction.AllSourceToTarget:
                        MoveAllDataFromTwoList(CbSource, LbTarget);
                        break;
                    case ButtonMoveAction.AllTargetToSource:
                        MoveAllDataFromTwoList(LbTarget, CbSource);
                        break;
                }
            }

            TriggerEnabledButtonMoveTopBottom();
        }

        #endregion

        private void BSourceMoveItems_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                MoveElementSelectedFromLbTarget(button);
            }
        }

        private void LbTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            TriggerEnabledButtonMoveTopBottom();
        }
    }
}