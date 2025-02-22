public class JournalEntry
{
    public string CollectionName { get; set; }
    public string ChangeType { get; set; }
    public string ChangedData { get; set; }

    public JournalEntry(string collectionName, string changeType, string changedData)
    {
        CollectionName = collectionName;
        ChangeType = changeType;
        ChangedData = changedData;
    }

    public override string ToString()
    {
        return $"Коллекция: {CollectionName}, Тип изменения: {ChangeType}, Данные: {ChangedData}";
    }
}
