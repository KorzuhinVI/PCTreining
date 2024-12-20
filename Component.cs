namespace PCBuilderTrainer.Model
{
    public class Component
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public bool IsCompatibleWithMotherboard { get; set; }

        // Другие свойства, такие как тип сокета для процессора, интерфейс для видеокарты и т.д.
    }
}
