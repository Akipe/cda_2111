using System.Linq;

namespace _05_ListBox
{
    public partial class ListBoxMainForm : Form
    {
        public ListBoxMainForm()
        {
            InitializeComponent();

            UpdateCountListShowed();
        }

        #region Logic

        private Boolean AddElementToList(string content)
        {
            if (content.Trim().Equals(String.Empty))
            {
                return false;
            }

            if (LbList.Items.Contains(content))
            {
                return false;
            }

            LbList.Items.Add(content);
            UpdateCountListShowed();

            return true;
        }

        private void ClearList()
        {
            LbList.Items.Clear();
            UpdateCountListShowed();
        }

        private int? IsIndexListExist(string indexFromTextBox)
        {
            int index;

            if (!int.TryParse(indexFromTextBox, out index))
            {
                return null;
            }

            if (index < 0 || index >= LbList.Items.Count)
            {
                return null;
            }

            return index;
        }

        private void UpdateShowedInfoElement(int? indexElement = null)
        {
            if (indexElement is not null)
            {
                TbSelectedIndex.Text = indexElement.ToString();
                TbSelectedElement.Text = LbList.Items[(int)indexElement].ToString();
            } else
            {
                TbSelectedIndex.Clear();
                TbSelectedElement.Clear();
            }
        }

        private void UpdateCountListShowed()
        {
            ListCount.Text = LbList.Items.Count.ToString();
        }

        #endregion

        #region Events

        private void BAddElement_Click(object sender, EventArgs e)
        {
            if (AddElementToList(TbElementToAdd.Text))
            {
                TbElementToAdd.Clear();
            }

            TbElementToAdd.Focus();
        }

        private void BShowIndex_Click(object sender, EventArgs e)
        {
            int? maybeIndex = IsIndexListExist(TbIndexElement.Text);

            if (maybeIndex is int index)
            {
                LbList.SelectedIndex = index;
            }
        }

        private void BEmptyingList_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private void LbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateShowedInfoElement(LbList.SelectedIndex);
        }

        #endregion
    }
}