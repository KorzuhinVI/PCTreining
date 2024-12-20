namespace PCBuilderTrainer.Model
{
    public class GraphicsCard : Component
    {
        public int VRAM { get; set; } // Видеопамять
        public string Interface { get; set; } // Тип интерфейса, например PCIe
    }
}
