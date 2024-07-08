namespace BMI_Calculator
{
    public partial class MainPage : ContentPage
    {
        const double UnderweightThreshold = 18.5;
        const double NormalWeightThreshold = 24.9;
        const double OverweightThreshold = 29.9;

        const string UnderweightMessage = "You have low weight";
        const string NormalWeightMessage = "You are normal weight";
        const string OverweightMessage = "You are overweight";


        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            var weight = double.Parse(Weight.Text);
            var height = double.Parse(Height.Text) / 100;
            var bodyMassIndex = weight / (height * height);

            BMI.Text = GetBMIMessage(bodyMassIndex) + "(" + bodyMassIndex.ToString("F2") + ")";
            //DisplayAlert("Result", BMI.Text, "OK");
        }

        private string GetBMIMessage(double bmi)
        {
            if (bmi < UnderweightThreshold)
                return UnderweightMessage;
            else if (bmi > OverweightThreshold)
                return OverweightMessage;
            else
            {
                return NormalWeightMessage;
            }
        }
    }

}
