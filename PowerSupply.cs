namespace PCBuilderTrainer.Model
{
    public class PowerSupply : Component
    {
        public int Wattage { get; set; } // Мощность в ваттах
        public string Certification { get; set; } // Сертификация эффективности, например 80 Plus Gold
    }
}
