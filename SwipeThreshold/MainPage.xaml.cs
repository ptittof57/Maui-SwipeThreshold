namespace SwipeThreshold
{
    public partial class MainPage : ContentPage
    {
        private int threshold = 100;
        public MainPage()
        {
            InitializeComponent();
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            Console.WriteLine("Swiped");
        }

        private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            if (e.TotalY > threshold)
            {
                this.scrollPosition.Text = $"Over threshold";
            }
            else
            {
                this.scrollPosition.Text = string.Empty;
            }
        }
    }
}
