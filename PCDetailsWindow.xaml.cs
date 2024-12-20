using System.Windows;

namespace PCBuilderTrainer
{
    public partial class PCDetailsWindow : Window
    {
        private string v1;
        private string v2;
        private string compatibilityMessage;

        public PCDetailsWindow(string v1, string v2, string compatibilityMessage)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.compatibilityMessage = compatibilityMessage;
        }

        public PCDetailsWindow(
            string processorName, string processorSocket,
            string motherboardName, string motherboardSocket,
            string graphicsCardName,
            string ramModuleName,
            string coolerName,
            string powerSupplyName,
            string compatibilityMessage)
        {
            InitializeComponent();

            // Устанавливаем текст для каждого компонента
            ProcessorTextBlock.Text = processorName;
            ProcessorSocketTextBlock.Text = $"Сокет: {processorSocket}";

            MotherboardTextBlock.Text = motherboardName;
            MotherboardSocketTextBlock.Text = $"Сокет: {motherboardSocket}";

            GraphicsCardTextBlock.Text = graphicsCardName;
            RamTextBlock.Text = ramModuleName;
            CoolerTextBlock.Text = coolerName;
            PowerSupplyTextBlock.Text = powerSupplyName;
            CompatibilityTextBlock.Text = compatibilityMessage;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
