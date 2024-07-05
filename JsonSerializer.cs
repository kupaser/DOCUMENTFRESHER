using System;
using System.IO;
using DOCUMENTFRESHER;
using Newtonsoft.Json;

public class DogConfigs
{
    private readonly string _configFilePath;
    public DogConfigs()
    {
        _configFilePath = @"C:\DOGCONFIGS\configdoc.json";
    }
    #region methods
    public void Serialize(object data)
    {
        try
        {
            // Проверка и создание каталога, если он не существует
            string directoryPath = Path.GetDirectoryName(_configFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(_configFilePath, jsonData);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка в сериализации: {ex.Message}");
        }
    }
    private void DefaultCreate()
    {
        try
        {
            List<Folder> defaultFolders = new List<Folder>
        {
            new Folder("Внутренний документ"),
            new Folder("Входящий документ"),
            new Folder("Исходящий документ"),
            new Folder("ИТ заявка"),
            new Folder("Маршрут договора"),
            new Folder("Служебная записка")
        };

            Serialize(defaultFolders);
            Console.WriteLine("Default configuration file created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred during default configuration file creation: {ex.Message}");
        }
    }
    public T Deserialize<T>()
    {
        try
        {
            // Проверка существования файла
            if (File.Exists(_configFilePath))
            {
                string jsonData = File.ReadAllText(_configFilePath);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
            else
            {
                // Проверка и создание каталога, если он не существует
                string directoryPath = Path.GetDirectoryName(_configFilePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                DefaultCreate();
                return Deserialize<T>();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка десериализации: {ex.Message}");
            return default(T);
        }
    }
    #endregion
}
