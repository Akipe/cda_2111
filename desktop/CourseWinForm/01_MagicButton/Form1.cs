namespace _01_MagicButton
{
    public partial class MagicForm : Form
    {
        public static int TIME_UPDATE_BUTTON = 10;
        public static int PIXEL_INCREMENT = 10;
        public static int WIN10_INHERENT_TOP_PIXEL = 35;
        public static int WIN10_INHERENT_RIGHT_PIXEL = 10;

        private int magicButtonOriginalTop = 0;
        private int magicButtonOriginalLeft = 0;
        private int counterPosition = 0;

        private int positionMoveHorizontal = 0;

        public MagicForm()
        {
            InitializeComponent();
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            this.DoMagic();
        }

        private void DoMagic()
        {
            magicButtonOriginalTop = this.magicButton.Top;
            magicButtonOriginalLeft = this.magicButton.Left;
            positionMoveHorizontal = this.GetFinalDistanceToLeft();
            positionMoveHorizontal = this.GetFinalDistanceToRight();

            MoveButtonToRight();
            MoveButtonToBottom();
            MoveButtonToLeft();
            MoveButtonToTop();
        }

        private void MoveButtonToRight()
        {
            while(magicButton.Right < GetFinalDistanceToRight())
            {
                magicButton.Left += PIXEL_INCREMENT;
                System.Threading.Thread.Sleep(TIME_UPDATE_BUTTON);
            }
        }

        private void MoveButtonToLeft()
        {
            while (magicButton.Left > GetFinalDistanceToLeft())
            {
                magicButton.Left -= PIXEL_INCREMENT;
                System.Threading.Thread.Sleep(TIME_UPDATE_BUTTON);
            }
        }

        private void MoveButtonToBottom()
        {
            while (magicButton.Bottom < GetFinalDistanceToBottom())
            {
                magicButton.Top += PIXEL_INCREMENT;
                System.Threading.Thread.Sleep(TIME_UPDATE_BUTTON);
            }
        }

        private void MoveButtonToTop()
        {
            while (magicButton.Top > GetFinalDistanceToTop())
            {
                magicButton.Top -= PIXEL_INCREMENT;
                System.Threading.Thread.Sleep(TIME_UPDATE_BUTTON);
            }
        }

        private int GetFinalDistanceToRight()
        {
            return 
                this.Width -
                this.magicButtonOriginalTop -
                magicButton.Margin.Left -
                magicButton.Margin.Right -
                WIN10_INHERENT_RIGHT_PIXEL
                ;
        }

        private int GetFinalDistanceToLeft()
        {
            return GetFinalDistanceToTop();
        }

        private int GetFinalDistanceToBottom()
        {
            return this.Height -
                this.magicButtonOriginalLeft -
                magicButton.Margin.Top -
                magicButton.Margin.Bottom -
                WIN10_INHERENT_TOP_PIXEL
                ;
        }

        private int GetFinalDistanceToTop()
        {
            return 0;
        }
    }
}