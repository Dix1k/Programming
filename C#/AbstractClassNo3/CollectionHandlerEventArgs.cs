using System;

public class CollectionHandlerEventArgs : EventArgs
{
    public string CollectionName { get; set; }
    public string ChangeType { get; set; }
    public object ChangedObject { get; set; }

    public CollectionHandlerEventArgs(string collectionName, string changeType, object changedObject)
    {
        CollectionName = collectionName;
        ChangeType = changeType;
        ChangedObject = changedObject;
    }

    public override string ToString()
    {
        return $"Коллекция: {CollectionName}, Тип изменения: {ChangeType}, Объект: {ChangedObject}";
    }
}
